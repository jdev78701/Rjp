import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { AccountService } from '../Service/account.service';
import { ReactiveFormsModule } from '@angular/forms';
import { CustomerService } from '../Service/customer.service';


@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.css']
})
export class AccountComponent implements OnInit {
  customers: any;
  accountForm:any;
  accountCreated:boolean=false;
  accountNotCreated:boolean = false;
  constructor(
    private fb: FormBuilder,
    private accountService: AccountService,
    private customerService: CustomerService
  ) { }
  ngOnInit(): void {
    console.log("trans");
    this.customerService.GetCustomers().subscribe(customers => {
      console.log(customers);
      this.customers = customers;
      console.log(this.customers);
    });

    this.accountForm = this.fb.group({
      CustomerId: ['', Validators.required],
      Balance: ['', [Validators.required, Validators.pattern(/^\d+(\.\d{1,2})?$/)]]
    });
  }
    onSubmit() {
      console.log(this.accountForm.controls['CustomerId'].invalid)
      if (this.accountForm.invalid) {
        return;
      } 
      console.log("TESTTTT")
      const accountModel = {...this.accountForm.value};
      console.log(accountModel);
      this.accountService.AddAccount(accountModel).subscribe(
        result => {
          console.log(result);
          if(result!=null){
            this.accountCreated=true;
            this.accountNotCreated=false;
          }
          else{
            this.accountCreated=false;
            this.accountNotCreated=true;
          }
          // handle success result
        },
        error => {
          // handle error
          this.accountCreated=false;
            this.accountNotCreated=true;
        }
      );
    }
  }
  

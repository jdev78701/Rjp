
import { Component,OnInit } from '@angular/core';
import { CustomerService } from '../Service/customer.service';
@Component({
  selector: 'app-customer',
  templateUrl: './customer.component.html',
  styleUrls: ['./customer.component.css']
})
export class CustomerComponent implements OnInit{
  customers: any;
  customer:any;
  dataLoaded:boolean = true;
  constructor(
    private customerService: CustomerService
  ) { }
  ngOnInit(): void {
    this.customerService.GetCustomers().subscribe(customers => {
      console.log(customers);
      this.customers = customers;
      console.log(this.customers);
    });
  }
  onCustomerSelected(param:any):void{
    this.dataLoaded=false;
    this.customerService.GetCustomer(param.target.value).subscribe(customer=>{
      this.dataLoaded=true;
      console.log(customer);

      this.customer=customer;
    })
  }
}

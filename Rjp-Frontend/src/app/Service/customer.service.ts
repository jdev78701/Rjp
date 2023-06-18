import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, Subject,tap } from 'rxjs';
import {Account} from '../Model/Account';
import { Customer } from '../Model/Customer';
import {envirement} from './../../env';
@Injectable({
  providedIn: 'root'
})
export class CustomerService {
    apiurl = 'http://localhost:53590/Customer';
    constructor(private http: HttpClient) {

    }
    GetCustomers(): Observable<Customer> {
        return this.http.get<Customer>(`${envirement.apiUrl}api/Customer`);
    }
    GetCustomer(id:string):Observable<any>{
      return this.http.get<any>(`${envirement.apiUrl}api/Customer`+"/"+id);
    }
}

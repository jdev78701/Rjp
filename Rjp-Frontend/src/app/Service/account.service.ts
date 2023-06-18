import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, Subject,tap } from 'rxjs';
import {Account} from '../Model/Account';
import {envirement} from './../../env';
@Injectable({
  providedIn: 'root'
})
export class AccountService {

    constructor(private http: HttpClient) {

    }
    AddAccount(accountModel: Account): Observable<Account> {
        return this.http.post<Account>(`${envirement.apiUrl}api/Account`, accountModel);
    }
}

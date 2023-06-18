import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { RouterModule, Routes } from '@angular/router';
import { HTTP_INTERCEPTORS,HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';
import { AccountComponent } from './account/account.component';
import { ReactiveFormsModule } from '@angular/forms';
import { CustomerComponent } from './customer/customer.component';
import {CacheInterceptor}from'./interceptor/interceptor';
const routes : Routes=[
  {path:'customer',component:CustomerComponent},
  {path:'add-account',component:AccountComponent}
]

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    AccountComponent,
    CustomerComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(routes),
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [{
    provide:HTTP_INTERCEPTORS,
    useClass:CacheInterceptor,
    multi:true
  }],
  exports: [RouterModule],
  bootstrap: [AppComponent]
})
export class AppModule { }

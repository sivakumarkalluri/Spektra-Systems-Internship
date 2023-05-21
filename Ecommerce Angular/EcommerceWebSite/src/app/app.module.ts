
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './home-page/home-page.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { AdminPageComponent } from './admin-page/admin-page.component';
import { CartPageComponent } from './cart-page/cart-page.component';
import { HttpClient } from '@angular/common/http';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CrudPageComponent } from './adminDashboard/crud-page/crud-page.component';
import { EditPageComponent } from './adminDashboard/edit-page/edit-page.component';
import { AddPageComponent } from './adminDashboard/add-page/add-page.component';
import { ProductsPageComponent } from './products-page/products-page.component';


@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    LoginPageComponent,
    AdminPageComponent,
    ProductDetailsComponent,
    CartPageComponent,
    CrudPageComponent,
    EditPageComponent,
    AddPageComponent,
    ProductsPageComponent
   
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

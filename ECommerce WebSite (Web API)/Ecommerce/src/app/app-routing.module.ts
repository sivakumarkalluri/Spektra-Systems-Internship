import { AddPageComponent } from './adminDashboard/add-page/add-page.component';
import { CrudPageComponent } from './adminDashboard/crud-page/crud-page.component';
import { EditPageComponent } from './adminDashboard/edit-page/edit-page.component';
import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePageComponent } from './home-page/home-page.component';
import { LoginPageComponent } from './login-page/login-page.component';
import { CartPageComponent } from './cart-page/cart-page.component';
import { ProductDetailsComponent } from './product-details/product-details.component';
import { AdminPageComponent } from './admin-page/admin-page.component';
import { ProductsPageComponent } from './products-page/products-page.component';


const routes: Routes = [
  {path:"",redirectTo:"home",pathMatch:'full'},
  {path:"home",component:HomePageComponent},
  {path:"login",component:LoginPageComponent},
  
  {path:"cartPage",component:CartPageComponent},
  {path:"adminPage",component:AdminPageComponent},
  {path:"admin",component:AdminPageComponent},
 
  {path:"products",component:ProductsPageComponent},
  {path:"productDetails/:id",component:ProductDetailsComponent},
  {path:"crudPage",component:CrudPageComponent},
  {path:'addPage',component:AddPageComponent},
  {path:"editPage/:id",component:EditPageComponent}
 

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

import { ProductDetailsComponent } from './product-details/product-details.component';
import { NgModule, Component } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ProductsComponent } from './products/products.component';

const routes: Routes = [
  {path:'',component:ProductsComponent},
  {path:'products',component:ProductsComponent},
  {path:'products/:id',component:ProductDetailsComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

export const routingComponents =[ProductsComponent,ProductDetailsComponent]


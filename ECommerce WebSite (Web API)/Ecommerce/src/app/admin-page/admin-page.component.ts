import { Component, OnInit } from '@angular/core';
import { PurchasedService } from '../services/purchased/purchased.service';
import { CartService } from '../services/cart.service';

@Component({
  selector: 'app-admin-page',
  templateUrl: './admin-page.component.html',
  styleUrls: ['./admin-page.component.css']
})
export class AdminPageComponent implements OnInit{
  constructor(private purchaseServe:PurchasedService,private cartService:CartService){
   
  }
  productDetails:any;
  ngOnInit(): void {
      this.purchaseServe.getData().subscribe((data:any)=>{
        this.productDetails=data;
        this.calculateTotal();
        
      })
  }

  totalQuantity=0;
  totalPrice=0;


  calculateTotal(): void {
    this.totalQuantity = this.productDetails[0].reduce((total: number, product: any) => total + product.quantity, 0);
  
    this.totalPrice = this.productDetails[0].reduce((total: number, product: any) => total + (product.quantity * product.price), 0);
  
  }
}

import { UserService } from './../services/user/user.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CartService } from '../services/cart.service';
import { PurchasedService } from '../services/purchased/purchased.service';

@Component({
  selector: 'app-cart-page',
  templateUrl: './cart-page.component.html',
  styleUrls: ['./cart-page.component.css']
})
export class CartPageComponent implements OnInit{

  constructor(private route:Router,private userApiService:UserService,private cartService:CartService,private purchaseServe:PurchasedService){}

  cartData:any;
  ngOnInit(): void {
   
      this.userApiService.getData().subscribe((data:any)=>{
        this.cartData=data;
        this.calculateTotal();
        this.userApiService.cartQuantity=this.totalQuantity;
      });
      
      
  }
  


deleted=false;
  delete(id:number){
    this.userApiService.deleteData(id).subscribe((data:any)=>{

    }, (err: any) => console.error(err),
    () => console.log('Error Occured'));this.userApiService.getData().subscribe((data:any)=>{
      this.cartData=data}); 
      this.calculateTotal();
      this.deleted = true
      setTimeout(() => {
        this.deleted = false
      }, 2000);;
    
  

  }


  decreaseQuantity(product:any){
    if (product.quantity > 1) {
      product.quantity--;
      this.updateCartData(product);
      
    }

  }

  increaseQuantity(product:any){
    product.quantity++;
    this.updateCartData(product);
  }

  updateCartData(product: any) {
    this.userApiService.editData(product.id, product).subscribe(
      (response: any) => {
        console.log('Cart data updated:', response);
        this.userApiService.getData().subscribe((data: any) => {
          this.cartData = data;
          this.calculateTotal();
          this.cartService.updateCartTotal(this.totalQuantity); // Call the service method to update the cart total

        });
      },
      (error: any) => {
        console.error('Error updating cart data:', error);
      }
    );
  }

  totalQuantity: number = 0;
totalPrice: number = 0;

calculateTotal(): void {
  this.totalQuantity = this.cartData.reduce((total: number, product: any) => total + product.quantity, 0);
  this.userApiService.cartQuantity = this.totalQuantity;

  this.totalPrice = this.cartData.reduce((total: number, product: any) => total + (product.quantity * product.price), 0);
  this.cartService.cartSum=this.totalPrice;
  this.cartService.updateCartTotal(this.totalQuantity); // Call the service method to update the cart total

}

purchase(){
  this.purchaseServe.addData(this.cartData).subscribe((response: any) => {
    console.log('Purchase successful:', response);
    // Make a DELETE request to remove cart data
    this.deleteAllData()});
    alert("purchased Successfully");
  }
  
  deleteAllData(): void {
    // Iterate over each item in the cartData array
    for (const product of this.cartData) {
      this.userApiService.deleteData(product.id).subscribe(
        (response: any) => {
          console.log('Deleted product with ID:', product.id);
        },
        (error: any) => {
          console.error('Error deleting product with ID:', product.id, error);
        }
      );
    }
  
    // Clear the cartData array
    this.cartData = [];
    // Recalculate the total
    this.calculateTotal();
    // Update the cart total in the shared service
    this.cartService.updateCartTotal(0);
  }
  
  

}

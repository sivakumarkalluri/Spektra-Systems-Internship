import { UserService } from './../services/user/user.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CartService } from '../services/cart.service';

@Component({
  selector: 'app-cart-page',
  templateUrl: './cart-page.component.html',
  styleUrls: ['./cart-page.component.css']
})
export class CartPageComponent implements OnInit{

  constructor(private route:Router,private userApiService:UserService,private cartService:CartService){}

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
  this.cartService.updateCartTotal(this.totalQuantity); // Call the service method to update the cart total

}
  

}

import { UserService } from './services/user/user.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { CartService } from './services/cart.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  adminCheck:any;
  title = 'EcommerceWebSite';
  constructor(private route:Router,private userApiService:UserService,private cartService:CartService){}

  cartTotal!:number;
  ngOnInit(): void {
    this.adminCheck=localStorage.getItem("role");
    this.cartService.cartTotal$.subscribe(total => {
      this.cartTotal = total;
      this.calculateTotal(total);
    });
    

  }
  logout(){
    localStorage.removeItem('role');
    this.route.navigate(['home']).then(() => {
      window.location.reload();
    });;
    alert("Logged Out Successfully");
  }
  calculateTotal(total:number){
    this.cartTotal=total;

  }
  
  
}

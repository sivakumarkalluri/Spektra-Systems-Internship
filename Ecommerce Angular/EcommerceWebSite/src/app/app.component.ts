import { UserService } from './services/user/user.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  adminCheck:any;
  title = 'EcommerceWebSite';
  constructor(private route:Router,private userApiService:UserService){}

  cartTotal!:number;
  ngOnInit(): void {
    this.adminCheck=localStorage.getItem("role");
    this.cartTotal=this.userApiService.cartQuantity;

  }
  logout(){
    localStorage.removeItem('role');
    this.route.navigate(['home']).then(() => {
      window.location.reload();
    });;
    alert("Logged Out Successfully");
  }
  
}

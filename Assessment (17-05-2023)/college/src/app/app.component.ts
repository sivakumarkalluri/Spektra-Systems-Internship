import { student } from './student';
import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  title = 'college';
  constructor(private route:Router){}
  adminCheck:any;
  ngOnInit(): void {
    this.adminCheck=localStorage.getItem("role");

    console.log(localStorage.getItem("role"));
      
  }
  login(){
    if(localStorage.getItem("role")=="admin"){
      this.route.navigate(['Display']);
    }
    else if(localStorage.getItem("role")=="student"){
      this.route.navigate(['student']);
    }
    else{
      this.route.navigate(['login']);
    }
  }
  logout(){
    localStorage.removeItem('role');
    this.route.navigate(['mainPage']).then(() => {
      window.location.reload();
    });;
    alert("Logged Out Successfully");
  }
  adminLogin(){
    this.route.navigate(['Display']).then(() => {
      window.location.reload();
    });;
  }
  studentLogin(){
    this.route.navigate(['student']).then(() => {
      window.location.reload();
    });
  }


}

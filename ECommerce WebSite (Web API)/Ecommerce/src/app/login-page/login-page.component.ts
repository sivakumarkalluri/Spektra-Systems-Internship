import { AdminService } from './../services/admin/admin.service';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { LoginService } from '../services/login/login.service';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent implements OnInit{

  constructor(private route:Router,private loginServe:LoginService){}
  ngOnInit(): void {
    if(this.loginServe.loginCheck==true){
      this.route.navigate(['home'])
    }
      
  }

  userName:any;
  password:any;
  wrongUserDetails=false;
  loginBtn(){
    
  if(this.userName=="admin" && this.password=="pass"){
    localStorage.setItem('role','admin');
    this.loginServe.loginCheck=true;
    this.goToHome();
    
  }
  else if(this.userName=="student" && this.password=="pass"){
    localStorage.setItem('role','user');
    this.loginServe.loginCheck=true;
    this.goToHome();
    
  }
  else{
    this.wrongUserDetails=true;
  }
  }
  goToHome(){
    this.route.navigate(['/home']).then(() => {
      window.location.reload();
    });
  }

}

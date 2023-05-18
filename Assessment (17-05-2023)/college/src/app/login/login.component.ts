import { Router } from '@angular/router';
import { Component, OnInit } from '@angular/core';
import { CollegeServiceService } from '../services/college-service.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit{
  constructor(private route:Router,private apiService:CollegeServiceService){}
  ngOnInit(): void {
    if(this.apiService.loginCheck==true){
      this.route.navigate(['Display'])
    }
      
  }

  userName:any;
  password:any;
  wrongUserDetails=false;
  loginBtn(){
    
  if(this.userName=="admin" && this.password=="pass"){
    localStorage.setItem('role','admin');
    this.goToCrud();
    this.apiService.loginCheck=true;
  }
  else if(this.userName=="student" && this.password=="pass"){
    localStorage.setItem('role','student');
    this.goToStudent();
    this.apiService.loginCheck=true;
  }
  else{
    this.wrongUserDetails=true;
  }
  }
  goToCrud(){
    this.route.navigate(['Display']).then(() => {
      window.location.reload();
    });;
  }
  goToStudent(){
    this.route.navigate(['student']).then(() => {
      window.location.reload();
    });;
  }



}

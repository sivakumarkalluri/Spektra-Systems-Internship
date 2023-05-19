import { student } from './../student';
import { Component, OnInit } from '@angular/core';
import { CollegeServiceService } from '../services/college-service.service';

@Component({
  selector: 'app-student-page',
  templateUrl: './student-page.component.html',
  styleUrls: ['./student-page.component.css']
})
export class StudentPageComponent implements OnInit{
  constructor(private apiService:CollegeServiceService){}
  studentsDetails:any;
  ngOnInit(): void {
    this.apiService.getData().subscribe((data:any)=>{
      this.studentsDetails=data;
      
    })
  }
  ID:any;
  findData:any;
  idNotFound=false;
  errorApi=false;
  errorMessage:any;
   findID(): void {
    console.log(this.ID);
    this.apiService.getDataByID(this.ID).subscribe(
      (data: any) => {
        this.findData = data;
        this.errorMessage = null;
      },
      (error: any) => {
        console.error(error);
        this.errorMessage = 'ID not found in the database.';
        this.findData = null;
      }
    );
  }
  
  }
  
  
    
  

  



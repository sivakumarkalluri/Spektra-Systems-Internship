import { Component, OnInit } from '@angular/core';
import { CollegeServiceService } from '../services/college-service.service';
import { Router } from '@angular/router';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-display',
  templateUrl: './display.component.html',
  styleUrls: ['./display.component.css']
})
export class DisplayComponent implements OnInit{


  constructor(private apiService:CollegeServiceService,private route:Router,private formBuilder:FormBuilder){}
  studentsDetails:any;

  ngOnInit(): void {
      this.apiService.getData().subscribe((data:any)=>{
        this.studentsDetails=data;
        
      })

  }

  deleted=false;
  delete(id:number){
    this.apiService.deleteData(id).subscribe((data:any)=>{

    }, (err: any) => console.error(err),
    () => console.log('Error Occured'));this.apiService.getData().subscribe((data:any)=>{
      this.studentsDetails=data}); this.deleted = true
      setTimeout(() => {
        this.deleted = false
      }, 2000);;
    
  

  }

  ID:any;
  findData:any;
  findID():void{
    console.log(this.ID);
    this.apiService.getDataByID(this.ID).subscribe((data:any)=>{
      this.findData=data;
    })
  }
  

}



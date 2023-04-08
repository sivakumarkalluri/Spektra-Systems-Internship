import { Component, Input, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit{
  
  ngOnInit(): void {
      
  }
 
  

  userForm: FormGroup;
  studentsData:any;
  constructor(private fb:FormBuilder){
    this.studentsData=[];
    this.userForm=this.fb.group({
      Id: ['',Validators.required],
      Name: ['',Validators.required],
      class:['',Validators.required],
      gender:['',Validators.required],
      Dob:['',Validators.required],
      fees:['',Validators.required]

    })

  }
  public addStudent():void{
    this.studentsData.push(this.userForm.value)
    this.userForm.reset();
    
  }
  

  
}

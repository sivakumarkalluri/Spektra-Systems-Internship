import { CollegeServiceService } from './../services/college-service.service';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.css']
})
export class AddComponent implements OnInit{
  constructor(private route:Router,private apiService:CollegeServiceService,private formBuilder:FormBuilder){}
  ngOnInit(): void {
      
  }
  studentsForm=this.formBuilder.group({
    id:this.formBuilder.control({value:'',disabled:true}),
    name:this.formBuilder.control('',Validators.required),
    age:this.formBuilder.control('',Validators.required),
    course:this.formBuilder.control('',Validators.required),
    semester:this.formBuilder.control('',Validators.required),
    feesDue:this.formBuilder.control('',Validators.required),
    examsCompleted:this.formBuilder.control('',Validators.required),
  })

  saveForm():void{
    if(this.studentsForm.valid){
     
      this.apiService.addData(this.studentsForm.value).subscribe((response:any)=>{
        if(confirm("Student Added Successfully....")==true){
          this.getHome();
        }

      });
    }
  }
  getHome():void{
    this.route.navigate(['Display']);
  }

}

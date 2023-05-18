import { FormBuilder, Validators } from '@angular/forms';
import { student } from './../student';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { CollegeServiceService } from '../services/college-service.service';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.css']
})
export class EditComponent implements OnInit{
  
  constructor(private route:Router,private apiService:CollegeServiceService,private activeRoutes:ActivatedRoute,private formBuilder:FormBuilder){}
  editedID!:number;
  editingData:any;
  ngOnInit(): void {
      this.editedID=this.activeRoutes.snapshot.params['id'];
      this.apiService.getDataByID(this.editedID).subscribe((data:any)=>{
        this.editingData=data;
        this.initialiseForm()
      })
      

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

  initialiseForm():void{
    if(this.editingData){
      this.studentsForm.patchValue({
        id:this.editingData.id,
        name:this.editingData.name,
        age:this.editingData.age,
        course:this.editingData.course,
        semester:this.editingData.semester,
        feesDue:this.editingData.feesDue,
        examsCompleted:this.editingData.examsCompleted
      })
    }

  }
  saveForm():void{
    if(this.studentsForm.valid){
      this.apiService.editData(this.editedID,this.studentsForm.value).subscribe((response:any)=>{
        if(confirm("Edited Successfully...")==true){
          this.getHome();
        }
      })
    }
  }
  getHome():void{
    this.route.navigate(['Display']);
  }


}

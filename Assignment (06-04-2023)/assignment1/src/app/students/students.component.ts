import { Component, OnInit,Input } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styleUrls: ['./students.component.css']
})
export class StudentsComponent implements OnInit {

 
  ngOnInit(): void {
      
  }
  studentsDetails=[
    {'id':'1','image':'assets/student1.jpeg'},
    {'id':'2','image':'assets/student2.jpeg'},
    {'id':'3','image':'assets/student3.jpeg'},
    {'id':'4','image':'assets/student4.jpeg'},
    {'id':'5','image':'assets/student5.jpeg'},
    {'id':'6','image':'assets/student6.jpeg'}

  ]

  userForm: FormGroup;
  studentsData:any[]=[];
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
    this.calculateData(this.studentsData);
  }
  totalStudents:any=0;
  sum:number=0;
  malesCount:number=0;
  femalesCount:number=0;
  public calculateData(data:any){
    this.totalStudents=data.length;
  this.sum= data.map((a: { fees: string; }) => parseInt(a.fees)).reduce(function(a: any, b: any)
  {
    return a + b;
  });
  
  
   this.malesCount =data.filter((student: { gender: string; }) => student.gender === 'male').length;
  this.femalesCount = data.filter((student: { gender: string; }) => student.gender === 'female').length;
    
  }
  // 

}

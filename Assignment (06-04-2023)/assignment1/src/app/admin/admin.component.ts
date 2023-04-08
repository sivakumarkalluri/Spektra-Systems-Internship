import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.css']
})
export class AdminComponent implements OnInit{
  

  @Input() studentsDetails:any;
  @Input() TotalFees:any;
  @Input() maleCount:any;
  @Input() femaleCount:any;
  @Input() studentCount:any;



constructor() {

 }

ngOnInit(): void {

  
}
 

}

import { Component } from '@angular/core';
import { details } from '../details';
import { DetailsService } from '../details.service';
@Component({
  selector: 'app-employees',
  templateUrl: './employees.component.html',
  styleUrls: ['./employees.component.css'],
  providers:[DetailsService]
})
export class EmployeesComponent {

  infoReceived!: details[];
  heading:string="";
 
  
  constructor(private empservice:DetailsService){

    
  }
 visible:boolean=false;
  getInfo(){
    this.infoReceived=this.empservice.getInfo();
    this.visible=!this.visible;
  }
 

}

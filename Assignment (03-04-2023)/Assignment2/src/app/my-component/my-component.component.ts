import { Component, OnInit } from '@angular/core';
import { first } from 'rxjs';

@Component({
  selector: 'app-my-component',
  templateUrl: './my-component.component.html',
  styleUrls: ['./my-component.component.css']
})
export class MyComponentComponent implements OnInit{
  constructor(){

  }
  ngOnInit(): void {
      
  }
  FirstName:string="Siva Kumar";
  Email:string="siva@gmail.com"
  show():void{
    
    alert(this.FirstName+" You have successfully Submitted")

  }

}

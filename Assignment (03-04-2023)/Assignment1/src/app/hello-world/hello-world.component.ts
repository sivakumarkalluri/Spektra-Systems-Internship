import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-hello-world',
  templateUrl: './hello-world.component.html',
  styleUrls: ['./hello-world.component.css']
})
export class HelloWorldComponent implements OnInit{
  constructor(){

  }
  ngOnInit(): void {
   
  }
  ngOnIt():void{
    
  }
  FirstName:string="Siva Kumar"
  show():void{
    alert("Hi I am "+this.FirstName);
  }

}

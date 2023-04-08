import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-persons',
  templateUrl: './persons.component.html',
  styleUrls: ['./persons.component.css']
})
export class PersonsComponent implements OnInit{
  constructor(private router: Router){

  }
  ngOnInit(): void {
      
  }
  personsList=[
    {"id":"1","Name":"John","company":"Amazon","technology":"Front End","image":"portfolio\src\assets\person_1.jpeg"},
    {"id":"2","Name":"Tom Cruise","company":"Facebook","technology":"Back End","image":"portfolio\src\assets\person_2.jpeg"},
    {"id":"3","Name":"Robert Jr","company":"Google","technology":"Cyber Security","image":"portfolio\src\assets\person_3.jpeg"},
    {"id":"4","Name":"Chris Hemsworth","company":"Netflix","technology":"UI/UX Designer","image":"portfolio\src\assets\person_4.jpeg"}
  ]
  onSelect(person:any){
    console.log(person.id);
   
    this.router.navigate(['/persons',person])

  }

}

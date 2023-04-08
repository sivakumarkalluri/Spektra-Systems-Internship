import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit{
 
  personDetails:any;
  constructor(private route: ActivatedRoute){

  }
  ngOnInit(): void {
    let id: any = this.route.snapshot.paramMap.get('id');
    this.personDetails = id;

     
  }
  personsList=[
    {"id":"1","Name":"John","company":"Amazon","technology":"Front End Developer","image":"assets/person_1.jpg","logo":"assets/amazon.png","review":"John is an exceptional employee who consistently delivers quality work. He is proactive in identifying issues and is always willing to go above and beyond to ensure that tasks are completed on time and to a high standard."},
    {"id":"2","Name":"Tom Cruise","company":"Facebook","technology":"Back End Developer","image":"assets/person_2.jpg","logo":"assets/facebook.png","review":"Tom is a hardworking employee who is always willing to lend a helping hand, she could benefit from improving her attention to detail. Her work is generally satisfactory, but there have been a few instances where errors have been missed."},
    {"id":"3","Name":"Robert Jr","company":"Google","technology":"Cyber Security Engineer","image":"assets/person_3.jpg","logo":"assets/google.png","review":"Robert is a pleasure to work with and has a positive attitude that is infectious. He is always willing to take on new challenges and is quick to offer suggestions for improving processes. His contributions have been invaluable to our team."},
    {"id":"4","Name":"Chris Hemsworth","company":"Netflix","technology":"UI/UX Designer","image":"assets/person_4.jpg","logo":"assets/netflix.png","review":"Chris is a highly skilled employee who is always willing to share her expertise with others. She has a strong work ethic and consistently produces excellent work. However, at times she can be overly critical of others and may need to work on her communication skills."}
  ]
  

}

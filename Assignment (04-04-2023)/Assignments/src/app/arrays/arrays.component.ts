
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-arrays',
  templateUrl: './arrays.component.html',
  styleUrls: ['./arrays.component.css']
})

export class ArraysComponent implements OnInit {
  constructor() {

  }
  ngOnInit(): void {

  }
  
  arr = [{ id: 1, first: "John", last: 'Abraham', country: 'England' },
  { id: 2, first: 'Tom', last: 'Cruise', country: 'America' },
  { id: 3, first: 'Albert', last: 'Einstein', country: 'Australia' }]


}




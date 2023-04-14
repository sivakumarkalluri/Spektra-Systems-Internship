import { Router } from '@angular/router';
import { users } from './../users';
import { Component, OnInit } from '@angular/core';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-details',
  templateUrl: './details.component.html',
  styleUrls: ['./details.component.css']
})
export class DetailsComponent implements OnInit{
  constructor(private apidata:ApiService){}
  ngOnInit(): void {
      
  }
  usersData!:users[];
  
  fetchData(){
    this.apidata.getData().subscribe((data:any) =>{
      this.usersData=data;
    })
  }



}

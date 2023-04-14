import { Injectable, OnInit } from '@angular/core';
import {HttpClient} from '@angular/common/http';
import { users } from './users';

@Injectable({
  providedIn: 'root'
})
export class ApiService implements OnInit{
  constructor(private http:HttpClient){}

  apiUrl="http://localhost:3000/users";

  

  ngOnInit(): void {
      
  }

  getData():any{
     return this.http.get<users[]>(this.apiUrl);
  }

  
}

import { student } from './../student';
import { Injectable, OnInit } from '@angular/core';
import {HttpClientModule} from '@angular/common/http'
import {HttpClient} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class CollegeServiceService implements OnInit{

  constructor(private http:HttpClient) { }
  ngOnInit(): void {
  }

  loginCheck=false;

  Api="https://localhost:7155/api/API";

  getData():any{
    return this.http.get<student[]>(this.Api);
  }
  getDataByID(id:number):any{
    return this.http.get<student>(`${this.Api}/${id}`);
  }
  addData(data:any):any{
    return this.http.post<student>(this.Api,data);
  }

  editData(id:number,data:any):any{
    return this.http.put<student>(`${this.Api}/${id}`,data);
  }

  deleteData(id:number):any{
    return this.http.delete<student>(`${this.Api}/${id}`);
  }


}

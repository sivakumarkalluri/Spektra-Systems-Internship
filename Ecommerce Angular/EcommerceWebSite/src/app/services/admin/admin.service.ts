import { adminI } from './../../interfaces/adminI';

import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'

@Injectable({
  providedIn: 'root'
})
export class AdminService {
  constructor(private http:HttpClient) { }
  ngOnInit(): void {
  }

  loginCheck=false;

  adminApi="http://localhost:3000/products";

  getData():any{
    return this.http.get<adminI[]>(this.adminApi);
  }
  getDataByID(id:number):any{
    return this.http.get<adminI>(`${this.adminApi}/${id}`);
  }
  addData(data:any):any{
    return this.http.post<adminI>(this.adminApi,data);
  }

  editData(id:number,data:any):any{
    return this.http.put<adminI>(`${this.adminApi}/${id}`,data);
  }

  deleteData(id:number):any{
    return this.http.delete<adminI>(`${this.adminApi}/${id}`);
  }


}

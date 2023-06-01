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

  adminApi="https://localhost:7022/api";

  getData():any{
    return this.http.get<adminI[]>(this.adminApi+'/Products');
  }
  getDataByID(id:number):any{
    return this.http.get<adminI>(`${this.adminApi}/Products/${id}`);
  }
  addData(data:any):any{
    return this.http.post<adminI>(this.adminApi+'/Products',data);
  }

  getImages():any{
    return this.http.get<any>(this.adminApi+'/Images');
  }

  editData(id:number,data:any):any{
    return this.http.put<adminI>(`${this.adminApi}/Products//${id}`,data);
  }

  deleteData(id:number):any{
    return this.http.delete<adminI>(`${this.adminApi}/Products/${id}`);
  }


}

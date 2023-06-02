import { adminI } from './../../interfaces/adminI';

import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AdminService {
  constructor(private http:HttpClient) { }
  ngOnInit(): void {
  }

  loginCheck=false;

  adminApi="https://localhost:7022/api";

  getData(genderFilter:any,sortByFilter:any,sortBy:boolean,pageNumber:any):any{
    const genderFilterParam = genderFilter ? `&genderFilter=${genderFilter}` : '';
const sortByParam = sortByFilter ? `&sortBy=${sortByFilter}&isAscending=${sortBy}` : '';
    return this.http.get(`${this.adminApi}/Products?pageNumber=${pageNumber}&pageSize=6${genderFilterParam}${sortByParam}`);
    //return this.http.get<adminI[]>(this.adminApi+'/Products?genderFilter='+genderFilter+'&sortBy='+sortByFilter+'&isAscending='+sortBy+'&pageNumber='+pageNumber+'&pageSize=6');
  }
  getDataByID(id:number):any{
    return this.http.get<adminI>(`${this.adminApi}/Products/${id}`);
  }
  addData(data:any):any{
    return this.http.post<adminI>(this.adminApi+'/Products',data);
  }

  getAllProducts():any{
    return this.http.get<adminI[]>('https://localhost:7022/api/Products?pageNumber=1&pageSize=1000');
  }

  uploadImage(id:Int16Array,file:File):Observable<any>{
    const formData=new FormData();
    formData.append("productImage",file);
   return this.http.post(`${this.adminApi}/Products/Products/${id}/upload-image`,formData,{
      responseType:'text'
    });
  }

  editData(id:number,data:any):any{
    return this.http.put<adminI>(`${this.adminApi}/Products/${id}`,data);
  }

  deleteData(id:number):any{
    return this.http.delete<adminI>(`${this.adminApi}/Products/${id}`);
  }


}

import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { cartI } from 'src/app/interfaces/cartI';

@Injectable({
  providedIn: 'root'
})
export class UserService {
  constructor(private http:HttpClient) { }
  

  loginCheck=false;
  cartQuantity=0;

  userApi="http://localhost:7000/cart";

  getData():any{
    return this.http.get<cartI[]>(this.userApi);
  }
  getDataByID(id:number):any{
    return this.http.get<cartI>(`${this.userApi}/${id}`);
  }
  addData(data:any):any{
    return this.http.post<cartI>(this.userApi,data);
  }

  editData(id:number,data:any):any{
    return this.http.put<cartI>(`${this.userApi}/${id}`,data);
  }

  deleteData(id:number):any{
    return this.http.delete<cartI>(`${this.userApi}/${id}`);
  }
}

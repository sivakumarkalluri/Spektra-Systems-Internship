import { HttpClient } from '@angular/common/http';
import { Injectable, OnInit } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class PurchasedService implements OnInit{
  constructor(private http:HttpClient) { }
  

  
  ngOnInit(): void {
      
  }

  purchaseApi="http://localhost:9000/purchased";

  getData():any{
    return this.http.get<any[]>(this.purchaseApi);
  }
  addData(data:any):any{
    return this.http.post<any>(this.purchaseApi,data);
  }
  editData(id:number,data:any):any{
    return this.http.put<any>(`${this.purchaseApi}/${id}`,data);
  }
  
  deleteData(id:number):any{
    return this.http.delete<any>(`${this.purchaseApi}/${id}`);
  }
}

import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { companyModel } from '../companymodel';
import { catchError, retry, throwError } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }
  apiurl = ' http://localhost:3000';


  editId!: companyModel;

  // Get Method
  getCompanyDetails() {
    return this.http.get<companyModel[]>(this.apiurl + '/company/');
  }


  // Post Method

  createCompany(companyData: any) {
    return this.http.post(this.apiurl + '/company/', companyData);

  }

  // Update Method
  editCompanyData(data: any) {
    return this.http.put<companyModel[]>(`${this.apiurl}/company/${this.editId.id}`, data)
  }

  // Delete
  deleteData(data: any) {
    return this.http.delete<companyModel[]>(`${this.apiurl}/company/${data}`);
  }


}

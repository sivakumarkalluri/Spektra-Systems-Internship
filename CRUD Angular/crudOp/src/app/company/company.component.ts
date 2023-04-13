import { Route, Router } from '@angular/router';
import { ApiService } from '../shared/api.service';
import { companyModel } from './../companymodel';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-company',
  templateUrl: './company.component.html',
  styleUrls: ['./company.component.css']
})
export class CompanyComponent implements OnInit {
  constructor(private companyData: ApiService, private router: Router) { }

  companyDetails!: companyModel[];

  // Fetching Data
  ngOnInit(): void {
    this.companyData.getCompanyDetails().subscribe(data => {
      this.companyDetails = data;
    })

  }

  // Editing the Data

  editEmployee(employeeId: companyModel) {
    this.companyData.editId = employeeId;
    this.router.navigate(['editForm']);

  }

  // Deleting the Data
  deleteRow(id: any) {
    const idArray = [id];
    this.companyData.deleteData(idArray).subscribe((data) => {

    }, err => console.error(err),
      () => console.log('Error Occured'));
    this.companyData.getCompanyDetails().subscribe(data => {
      this.companyDetails = data;
    })
  }


  getHome() {
    this.router.navigate(['Home']);
  }

  // For Creating Data
  openForm() {
    this.router.navigate(['/addUserLink']);
    // window.open('/addUserLink', '_blank');

  }





}

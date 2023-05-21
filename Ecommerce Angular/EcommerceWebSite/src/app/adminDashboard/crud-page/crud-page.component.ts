import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AdminService } from 'src/app/services/admin/admin.service';

@Component({
  selector: 'app-crud-page',
  templateUrl: './crud-page.component.html',
  styleUrls: ['./crud-page.component.css']
})
export class CrudPageComponent implements OnInit{

  constructor(private adminApiService:AdminService,private route:Router){}
  productDetails:any;

  ngOnInit(): void {
      this.adminApiService.getData().subscribe((data:any)=>{
        this.productDetails=data;
        
      })

  }

  deleted=false;
  delete(id:number){
    this.adminApiService.deleteData(id).subscribe((data:any)=>{

    }, (err: any) => console.error(err),
    () => console.log('Error Occured'));this.adminApiService.getData().subscribe((data:any)=>{
      this.productDetails=data}); this.deleted = true
      setTimeout(() => {
        this.deleted = false
      }, 2000);;
    
  

  }

  ID:any;
  errorMessage:any;
  findData:any;
  findID(): void {
    console.log(this.ID);
    this.adminApiService.getDataByID(this.ID).subscribe(
      (data: any) => {
        this.findData = data;
        this.errorMessage = null;
      },
      (error: any) => {
        console.error(error);
        this.errorMessage = 'ID not found in the database.';
        this.findData = null;
      }
    );
  }
  

}

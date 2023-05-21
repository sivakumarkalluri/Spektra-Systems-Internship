import { AdminService } from './../services/admin/admin.service';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css']
})
export class ProductDetailsComponent  implements OnInit{
  productID:any;
  productData:any;
  constructor(private activeRoute: ActivatedRoute,private apiService:AdminService){

  }
  ngOnInit(): void {
    let id: any = this.activeRoute.snapshot.params['id'];
    console.log(this.productID);
    this.productID = id;
    this.apiService.getDataByID(this.productID).subscribe((data:any)=>{
      this.productData=data;
      console.log(this.productData);
    })
  }



}

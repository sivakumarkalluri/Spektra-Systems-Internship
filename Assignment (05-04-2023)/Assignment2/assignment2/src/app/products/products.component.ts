import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit{
  constructor(private router: Router){

  }
  ngOnInit(): void {
      
  }
  productsList=[
    {"id":"1","Name":"ROVER PACK CLASSIC","price":"$99.99","image":"assets/product_1.jpg"},
    {"id":"2","Name":"ROVER PACK MINI","price":"$35","image":"assets/product_2.jpg"},
    {"id":"3","Name":"H & M GREY SHIRT","price":"$40.99","image":"assets/product_3.jpg"},
    {"id":"4","Name":"ZARA SWEAT JACKET","price":"$33.99","image":"assets/product_4.jpg"}
  ]
  onSelect(product:any){
    console.log(product.id);
   
    this.router.navigate(['/products',product])

  }


}

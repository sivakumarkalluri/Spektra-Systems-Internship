import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-product-details',
  templateUrl: './product-details.component.html',
  styleUrls: ['./product-details.component.css']
})
export class ProductDetailsComponent implements OnInit {
  productDetails:any;
  constructor(private route: ActivatedRoute){

  }
  ngOnInit(): void {
    let id: any = this.route.snapshot.paramMap.get('id');
    this.productDetails = id;

     
  }

  productsList=[
    {"id":"1","Name":"ROVER PACK CLASSIC","desc":"Rover Pack Anti Theft Backpack with 15.6 inch Laptop Compartment, Patented Design, Water Resistant Fabric, Quick Access Pockets & 8 Years Warranty for Men and Women (Capacity-25 Litre)","price":"$99.99","mrp":"$120","discount":"-25","rating_num":4,"rating_dec":1,"image":"assets/product_1.jpg"},
    {"id":"2","Name":"ROVER PACK MINI","desc":"Rover Pack Mini 21 ltrs 16 Inch Classic Laptop Backpack with YKK Zippers, New","price":"$35","mrp":"50","discount":"-30","rating_num":3,"rating_dec":1,"image":"assets/product_2.jpg"},
    {"id":"3","Name":"H & M GREY SHIRT","price":"$40.99","desc":"H & M Plain Casual Shirt for Men | Premium Cotton Solid Shirt | Full Sleeves Slim Fit | Buy Stylish Plain Shirt Online Long Lasting Fabric","mrp":"60.99","discount":"-20","rating_num":3,"rating_dec":1,"image":"assets/product_3.jpg"},
    {"id":"4","Name":"ZARA SWEAT JACKET","desc":"Zara Women's Regular Fit Stylish And Fashionable Jacket For Winter (Color-Rust02)","price":"$33.99","mrp":"70.99","discount":"-40","rating_num":5,"rating_dec":0,"image":"assets/product_4.jpg"}
  ]
}

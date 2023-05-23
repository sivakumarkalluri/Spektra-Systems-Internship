import { Router } from '@angular/router';
import { AdminService } from './../services/admin/admin.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.css']
})
export class HomePageComponent implements OnInit{
  constructor(private apiService:AdminService,private route:Router){}
  newArrivals:any;
  ngOnInit(): void {
      this.apiService.getData().subscribe((data:any)=>{
        this.newArrivals=data.slice(-4);
      })
  }

  onSelect(product:any){
    console.log(product.id);
   
    this.route.navigate(['/productDetails',product])

  }
  isAddedToCart: boolean = false;

  initializeProductFlags() {
    this.newArrivals.forEach((product:any) => {
      product.isAddedToCart = false;
    });
  }
  addToCart(id:number){
    const selectedProduct = this.newArrivals.find((product: any) => product.id === id);
    if (selectedProduct) {
      const cartItem = {
        id: selectedProduct.id,
        name: selectedProduct.name,
        price: selectedProduct.price,
        quantity: 1,
        discount: selectedProduct.discount,
        description: selectedProduct.description,
        image: selectedProduct.image
      };
    }
  }

}

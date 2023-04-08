import { Component, OnInit } from '@angular/core';

interface Product {
  id: string;
  name: string;
  price: number;
  image: string;
}
interface CartItem {
  product: Product;
  quantity: number;
  Totalprice:number;
  
}

@Component({
  selector: 'app-products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  productsList: Product[] = [
    {"id":"1","name":"Rover Pack Classic","price":99.99,"image":"assets/product_1.jpg"},
    {"id":"2","name":"Rover Pack Mini","price":35,"image":"assets/product_2.jpg"},
    {"id":"3","name":"H & M Grey Shirt","price":40.99,"image":"assets/product_3.jpg"},
    {"id":"4","name":"Zara sweat jacket","price":33.99,"image":"assets/product_4.jpg"}
  ];

  cartDisplay: CartItem[] = [];

  constructor() {}

  ngOnInit(): void {}
  totalQuantity = 0;
  totalPrice = 0;

  addToCart(product: Product): void {
    const itemIndex = this.cartDisplay.findIndex(item => item.product.id === product.id);
    if (itemIndex >= 0) {
      this.cartDisplay[itemIndex].quantity++;
      this.cartDisplay[itemIndex].Totalprice += product.price;
    } else {
      this.cartDisplay.push({
        product: product,
        quantity: 1,
        Totalprice: product.price
      });
    }
  
    this.calculateTotal();
  }
  calculateTotal(): void {
    let totalQty = 0;
    let totalPrice = 0;
    for (const item of this.cartDisplay) {
      totalQty += item.quantity;
      totalPrice += item.Totalprice;
    }
    this.totalQuantity = totalQty;
    this.totalPrice = totalPrice;
  }

}
 

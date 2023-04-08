import { Component, Input } from '@angular/core';

@Component({
  selector: 'app-products-details',
  templateUrl: './products-details.component.html',
  styleUrls: ['./products-details.component.css']
})
export class ProductsDetailsComponent {
  @Input() totalQuantity = 0;
  @Input() totalPrice = 0;
  
}

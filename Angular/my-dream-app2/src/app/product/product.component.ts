import { Component, OnInit } from '@angular/core';
import { IProduct } from './IProduct';
@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  products : IProduct[] = [];
  constructor() { }

  ngOnInit(): void {
    this.products = this.getProducts();
    console.log(this.products);
  }

  getProducts() : IProduct[] {
    return[
      {
        Id : 1,
        Title : "Pringles",
        Price : 150,
        ExpiryDate : "10-20-2020",
        isInStock : true,
        Quantity : 389
      },
      {
        Id : 2,
        Title : "Kurkure",
        Price : 40,
        ExpiryDate : "12-05-2020",
        isInStock : false,
        Quantity : 0
      },
      {
        Id : 3,
        Title : "Doritos",
        Price : 260,
        ExpiryDate : "02-12-2020",
        isInStock : true,
        Quantity : 72
      },
      {
        Id : 4,
        Title : "Lays",
        Price : 60,
        ExpiryDate : "08-31-2020",
        isInStock : true,
        Quantity : 478
      },
      {
        Id : 5,
        Title : "Bingo",
        Price : 100,
        ExpiryDate : "06-10-2020",
        isInStock : false,
        Quantity : 28
      },
     ]
  }

}

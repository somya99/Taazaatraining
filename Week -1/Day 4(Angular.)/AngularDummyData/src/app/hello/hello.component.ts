import { Component, OnInit } from '@angular/core';
import { product } from '../products';

@Component({
  selector: 'app-hello',
  templateUrl: './hello.component.html',
  styleUrls: ['./hello.component.css']
})

export class HelloComponent implements OnInit {
  
  products: product[]=[];

  constructor() { }

  ngOnInit(): void {
    this.products=this.getproducts();
  }
  getproducts(): product[]{
    return[
      {
        Bleach :1,
        Facepack:"Strawberry",
        Eyecream :"Garnier",
        ExpiryDate : "1-1-2050",
        Price : 4999,
      },
      {
        Bleach :2,
        Facepack:"Chocolate",
        Eyecream :"Mama earth",
        ExpiryDate : "1-1-2025",
        Price : 1200
      },
      {
        Bleach :3,
        Facepack:"Fruit",
        Eyecream :"Nivea",
        ExpiryDate : "1-1-2030",
        Price : 3600
      },
      {
        Bleach :4,
        Facepack:"Papaya",
        Eyecream :"Loreal",
        ExpiryDate : "1-1-2050",
        Price : 12000
      },
      {
        Bleach :5,
        Facepack:"Gold",
        Eyecream :"Colorbar",
        ExpiryDate : "1-1-2035",
        Price : 2200
      },
      {
        Bleach :6,
        Facepack:"Diamond",
        Eyecream :"Faceshop",
        ExpiryDate : "1-1-2040",
        Price : 3000
      },
    ]
  }
}

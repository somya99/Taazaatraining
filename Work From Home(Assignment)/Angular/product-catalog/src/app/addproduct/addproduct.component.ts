import { Component, OnInit } from '@angular/core';
import { ProductserviceService } from '../productservice.service';

@Component({
  selector: 'app-addproduct',
  templateUrl: './addproduct.component.html',
  styleUrls: ['./addproduct.component.css']
})
export class AddproductComponent implements OnInit {
  id : number;
  prodid : number = 5;
  name : string;
  manu : string;
  shortcode : string;
  category : string;
  description : string;
  price : number;
  message : string;
  constructor(private productservice : ProductserviceService) { }

  ngOnInit(): void {
  }

  submit(){
    this.productservice.id = this.prodid;
    this.productservice.name = this.name;
    this.productservice.manu = this.manu;
    this.productservice.shortcode = this.shortcode;
    this.productservice.category = this.category;
    this.productservice.description = this.description;
    this.productservice.price= this.price;
    this.productservice.addProduct();
    this.message = "Product added successfully";
  }
}

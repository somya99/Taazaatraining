import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
import { IProduct } from '../product/IProduct';
@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
  products : IProduct[] = [];
  constructor(private dataservice : DataService) { }

  ngOnInit(): void {
    this.products = this.dataservice.getProducts();
    // console.log(this.products);
  }

  

}

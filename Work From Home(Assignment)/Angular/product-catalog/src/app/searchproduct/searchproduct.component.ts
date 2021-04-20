import { Component, OnInit } from '@angular/core';
import { IProduct } from '../product/IProduct';
import { ProductserviceService } from '../productservice.service';

@Component({
  selector: 'app-searchproduct',
  templateUrl: './searchproduct.component.html',
  styleUrls: ['./searchproduct.component.css']
})
export class SearchproductComponent implements OnInit {
  product : IProduct[] = [];
  constructor(private productservice : ProductserviceService) { }
  searchId : number;
  searchName : string;
  searchShortCode : string;
  searchPrice : number;
  ngOnInit(): void {
    this.product = this.productservice.getProduct();
  }

}

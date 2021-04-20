import { Component, OnInit } from '@angular/core';
import { IProduct } from '../product/IProduct';
import { ProductserviceService } from '../productservice.service';

@Component({
  selector: 'app-listproduct',
  templateUrl: './listproduct.component.html',
  styleUrls: ['./listproduct.component.css']
})
export class ListproductComponent implements OnInit {
  product : IProduct[] = [];
  constructor(private productservice : ProductserviceService) { }

  ngOnInit(): void {
    this.product = this.productservice.getProduct();
  }

}

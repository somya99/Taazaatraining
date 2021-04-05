import { Component, OnInit } from '@angular/core';
import { DataService } from '../data.service';
import { IPurchaseItem } from '../purchase/IPurchaseItem';

@Component({
  selector: 'app-purchase',
  templateUrl: './purchase.component.html',
  styleUrls: ['./purchase.component.css']
})
export class PurchaseComponent implements OnInit {
  purchases : IPurchaseItem[] = [];
  constructor(private dataservice : DataService) { }
  
  ngOnInit(): void {
    this.purchases = this.dataservice.getPurchase();
    
  }
  
}

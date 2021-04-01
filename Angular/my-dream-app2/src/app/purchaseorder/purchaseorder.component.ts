import { Component, OnInit, Input } from '@angular/core';
import { IPurchaseItem } from '../purchase/IPurchaseItem';
@Component({
  selector: 'app-purchaseorder',
  templateUrl: './purchaseorder.component.html',
  styleUrls: ['./purchaseorder.component.css']
})
export class PurchaseorderComponent implements OnInit {
  @Input() PurchaseItem : IPurchaseItem;
  Price = 0;
  constructor() { }
  
  ngOnInit(): void {
  }

  ngOnChanges() : void{
    console.log(this.PurchaseItem);
    this.PurchaseItem.Items.forEach(i => {
      this.Price = this.Price + i.Price;
    })
  }
}

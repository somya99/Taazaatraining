import { Injectable } from '@angular/core';
import { IProduct } from '../app/product/IProduct';
import { IPurchaseItem } from '../app/purchase/IPurchaseItem';
@Injectable({
  providedIn: 'root'
})
export class DataService {
  products : IProduct[] = [];
  purchases : IPurchaseItem[] = [];
  constructor() { }

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

  getPurchase() : IPurchaseItem[] {
    return[
      {
        PurchaseName : "Relience Smart",
        PurchaseID : 1,
        PurchaseDate : "09-12-2019",
        VendorName : "Alice",
        Items : [{
          Id : 1,
          Title : "Pringles",
          Price : 150,
          ExpiryDate : "10-20-2020",
          isInStock : true,
          Quantity : 389
        },
        {
          Id : 4,
          Title : "Lays",
          Price : 60,
          ExpiryDate : "08-31-2020",
          isInStock : true,
          Quantity : 478
        }        
       ]
      },
      {
        PurchaseName : "Easy Day",
        PurchaseID : 2,
        PurchaseDate : "07-31-2019",
        VendorName : "Bob",
        Items : [{
          Id : 5,
          Title : "Bingo",
          Price : 100,
          ExpiryDate : "06-10-2020",
          isInStock : false,
          Quantity : 28
        },
        {
          Id : 2,
          Title : "Kurkure",
          Price : 40,
          ExpiryDate : "12-05-2020",
          isInStock : false,
          Quantity : 0
        }        
       ]
      },
      {
        PurchaseName : "Spencers",
        PurchaseID : 3,
        PurchaseDate : "11-16-2019",
        VendorName : "Robert",
        Items : [{
          Id : 3,
          Title : "Doritos",
          Price : 260,
          ExpiryDate : "02-12-2020",
          isInStock : true,
          Quantity : 72
        },
        {
          Id : 1,
          Title : "Pringles",
          Price : 150,
          ExpiryDate : "10-20-2020",
          isInStock : true,
          Quantity : 389
        },
        {
          Id : 4,
          Title : "Lays",
          Price : 60,
          ExpiryDate : "08-31-2020",
          isInStock : true,
          Quantity : 478
        }        
       ]
      },
      {
        PurchaseName : "Big Bazaar",
        PurchaseID : 4,
        PurchaseDate : "02-12-2019",
        VendorName : "George",
        Items : [{
          Id : 3,
          Title : "Doritos",
          Price : 260,
          ExpiryDate : "02-12-2020",
          isInStock : true,
          Quantity : 72
        },
        {
          Id : 5,
          Title : "Bingo",
          Price : 100,
          ExpiryDate : "06-10-2020",
          isInStock : false,
          Quantity : 28
        }        
       ]
      },
      {
        PurchaseName : "D-Mart",
        PurchaseID : 5,
        PurchaseDate : "01-29-2019",
        VendorName : "Steve",
        Items : [{
          Id : 2,
          Title : "Kurkure",
          Price : 40,
          ExpiryDate : "12-05-2020",
          isInStock : false,
          Quantity : 0
        },
        {
          Id : 1,
          Title : "Pringles",
          Price : 150,
          ExpiryDate : "10-20-2020",
          isInStock : true,
          Quantity : 389
        },
        {
          Id : 5,
          Title : "Bingo",
          Price : 100,
          ExpiryDate : "06-10-2020",
          isInStock : false,
          Quantity : 28
        }         
       ]
      }
    ]
  }
}

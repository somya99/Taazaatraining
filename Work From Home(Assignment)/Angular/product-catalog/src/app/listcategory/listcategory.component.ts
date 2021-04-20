import { Component, OnInit } from '@angular/core';
import { ICategory } from '../category/ICategory';
import { CategoryserviceService } from '../categoryservice.service';

@Component({
  selector: 'app-listcategory',
  templateUrl: './listcategory.component.html',
  styleUrls: ['./listcategory.component.css']
})
export class ListcategoryComponent implements OnInit {
  category : ICategory[] = [];

  constructor(private categoryservice : CategoryserviceService) { }

  ngOnInit(): void {
    this.category = this.categoryservice.getCategory();
  }

}

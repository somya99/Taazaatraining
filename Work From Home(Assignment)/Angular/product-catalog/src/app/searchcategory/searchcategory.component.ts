import { Component, OnInit } from '@angular/core';
import { ICategory } from '../category/ICategory';
import { CategoryserviceService } from '../categoryservice.service';

@Component({
  selector: 'app-searchcategory',
  templateUrl: './searchcategory.component.html',
  styleUrls: ['./searchcategory.component.css']
})
export class SearchcategoryComponent implements OnInit {
  category : ICategory[] = [];

  constructor(private categoryservice : CategoryserviceService) { }
  searchId: number;
  searchName: string;
  searchShortCode: string;
  ngOnInit(): void {
    this.category = this.categoryservice.getCategory();
  }

}

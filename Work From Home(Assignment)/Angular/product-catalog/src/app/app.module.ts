import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductComponent } from './product/product.component';
import { CategoryComponent } from './category/category.component';
import { MainPageComponent } from './main-page/main-page.component';
import { AddcategoryComponent } from './addcategory/addcategory.component';
import { ListcategoryComponent } from './listcategory/listcategory.component';
import { DeletecategoryComponent } from './deletecategory/deletecategory.component';
import { SearchcategoryComponent } from './searchcategory/searchcategory.component';
import { AddproductComponent } from './addproduct/addproduct.component';
import { ListproductComponent } from './listproduct/listproduct.component';
import { DeleteproductComponent } from './deleteproduct/deleteproduct.component';
import { SearchproductComponent } from './searchproduct/searchproduct.component';
import { CategoryidPipe } from './categoryid.pipe';
import { CategorynamePipe } from './categoryname.pipe';
import { CategoryshortcodePipe } from './categoryshortcode.pipe';
import { FormsModule } from '@angular/forms';
import { ProductidPipe } from './productid.pipe';
import { ProductnamePipe } from './productname.pipe';
import { ProductshortcodePipe } from './productshortcode.pipe';
import { ProductpricePipe } from './productprice.pipe';
import { ExitappComponent } from './exitapp/exitapp.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductComponent,
    CategoryComponent,
    MainPageComponent,
    AddcategoryComponent,
    ListcategoryComponent,
    DeletecategoryComponent,
    SearchcategoryComponent,
    AddproductComponent,
    ListproductComponent,
    DeleteproductComponent,
    SearchproductComponent,
    CategoryidPipe,
    CategorynamePipe,
    CategoryshortcodePipe,
    ProductidPipe,
    ProductnamePipe,
    ProductshortcodePipe,
    ProductpricePipe,
    ExitappComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    AppRoutingModule,
    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

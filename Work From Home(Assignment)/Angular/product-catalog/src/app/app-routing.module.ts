import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CategoryComponent } from './category/category.component';
import { AddcategoryComponent } from './addcategory/addcategory.component';
import { ListcategoryComponent } from './listcategory/listcategory.component';
import { DeletecategoryComponent } from './deletecategory/deletecategory.component';
import { SearchcategoryComponent } from './searchcategory/searchcategory.component';
import { ProductComponent } from './product/product.component';
import { AddproductComponent } from './addproduct/addproduct.component';
import { ListproductComponent } from './listproduct/listproduct.component';
import { DeleteproductComponent } from './deleteproduct/deleteproduct.component';
import { SearchproductComponent } from './searchproduct/searchproduct.component';
import { MainPageComponent } from './main-page/main-page.component';
import { ExitappComponent } from './exitapp/exitapp.component';
const routes: Routes = [
  {path: 'mainpage', component: MainPageComponent},
  {path: 'category', component: CategoryComponent,
  children: [
    {
      path: 'addcategory', 
      component: AddcategoryComponent,
    },
    {
      path: 'listcategory',
      component:ListcategoryComponent, 
    },
    {
        path: 'deletecategory',
        component: DeletecategoryComponent, 
      },
      {
        path: 'searchcategory',
        component: SearchcategoryComponent, 
      }
  ],},
  {path: 'product', component: ProductComponent,
  children: [
    {
      path: 'addproduct', 
      component: AddproductComponent,
    },
    {
      path: 'listproduct',
      component:ListproductComponent, 
    },
    {
        path: 'deleteproduct',
        component: DeleteproductComponent, 
      },
      {
        path: 'searchproduct',
        component: SearchproductComponent, 
      }
  ],},
  {path: 'exitapp', component: ExitappComponent},
  {path: '', redirectTo:'mainpage', pathMatch:"full"}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

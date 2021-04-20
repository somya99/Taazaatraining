import { Pipe, PipeTransform } from '@angular/core';
import { ICategory } from './category/ICategory';

@Pipe({
  name: 'categoryname'
})
export class CategorynamePipe implements PipeTransform {

  transform(value: ICategory[], args: string): ICategory[] {
    if(!args){
      return value;
    }
    return value.filter(
      item => item.CategoryName.toLowerCase().indexOf(args.toLowerCase()) > -1)
  }

}

import { Pipe, PipeTransform } from '@angular/core';
import { ICategory } from './category/ICategory';

@Pipe({
  name: 'categoryshortcode'
})
export class CategoryshortcodePipe implements PipeTransform {

  transform(value: ICategory[], args: string): ICategory[] {
    if(!args){
      return value;
    }
    return value.filter(
      item => item.CategoryShortCode.toLowerCase().indexOf(args.toLowerCase()) > -1)
  }

}

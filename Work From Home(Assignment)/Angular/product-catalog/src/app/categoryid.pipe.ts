import { Pipe, PipeTransform } from '@angular/core';
import { ICategory } from './category/ICategory';

@Pipe({
  name: 'categoryid'
})
export class CategoryidPipe implements PipeTransform {

  transform(value: ICategory[], args: number): ICategory[] {
    if(!args){
      return value;
    }
    return value.filter(
      item => item.CategoryId == args
    )
  }

}


import { Pipe, PipeTransform } from '@angular/core';
import { IProduct } from './product/IProduct';

@Pipe({
  name: 'productname'
})
export class ProductnamePipe implements PipeTransform {

  transform(value: IProduct[], args: string): IProduct[] {
    if(!args){
      return value;
    }
    return value.filter(
      item => item.ProductName.toLowerCase().indexOf(args.toLowerCase()) > -1)
  }

}

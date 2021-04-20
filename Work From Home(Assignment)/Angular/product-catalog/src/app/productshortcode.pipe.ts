import { Pipe, PipeTransform } from '@angular/core';
import { IProduct } from './product/IProduct';

@Pipe({
  name: 'productshortcode'
})
export class ProductshortcodePipe implements PipeTransform {

  transform(value: IProduct[], args: string): IProduct[] {
    if(!args){
      return value;
    }
    return value.filter(
      item => item.ProductShortCode.toLowerCase().indexOf(args.toLowerCase()) > -1)
  }

}

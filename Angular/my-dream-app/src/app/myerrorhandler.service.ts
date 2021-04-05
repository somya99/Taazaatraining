import { ErrorHandler, Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class MyerrorhandlerService implements ErrorHandler{

  constructor() { }
  
  handleError(error : any){

    console.log("Error will be logged using API later");

    
  }
}

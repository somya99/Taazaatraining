import { Injectable } from '@angular/core';
import { AsyncSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AsyncsubjectserviceService {

  counter = 0;
  count$: Observable<any>;
  private count: AsyncSubject<number>;
   

  constructor() {
    
    this.count = new AsyncSubject();
    this.count$ = this.count.asObservable();

    setInterval(() => {
      this.counter = this.counter + 1;
      if (this.counter > 20) {
        this.count.complete();
      }
      this.count.next(this.counter);
    }, 1000)

  }
}

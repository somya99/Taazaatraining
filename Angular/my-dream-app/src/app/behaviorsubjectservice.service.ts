import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class BehaviorsubjectserviceService {

  counter = 0;
  count$: Observable<any>;
  private count: BehaviorSubject<number>;
   

  constructor() {
    
    this.count = new BehaviorSubject(100);
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

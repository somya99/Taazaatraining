import { ComponentFixture, TestBed } from '@angular/core/testing';

import { RxJSsubjectComponent } from './rx-jssubject.component';

describe('RxJSsubjectComponent', () => {
  let component: RxJSsubjectComponent;
  let fixture: ComponentFixture<RxJSsubjectComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ RxJSsubjectComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(RxJSsubjectComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

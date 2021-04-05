import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NcomponentComponent } from './ncomponent.component';

describe('NcomponentComponent', () => {
  let component: NcomponentComponent;
  let fixture: ComponentFixture<NcomponentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ NcomponentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(NcomponentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

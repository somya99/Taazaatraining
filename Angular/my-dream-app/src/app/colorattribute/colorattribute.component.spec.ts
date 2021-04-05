import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ColorattributeComponent } from './colorattribute.component';

describe('ColorattributeComponent', () => {
  let component: ColorattributeComponent;
  let fixture: ComponentFixture<ColorattributeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ColorattributeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ColorattributeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

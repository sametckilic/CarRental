import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SingleCarComponent } from './single-car.component';

describe('SingleCarComponent', () => {
  let component: SingleCarComponent;
  let fixture: ComponentFixture<SingleCarComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [SingleCarComponent]
    });
    fixture = TestBed.createComponent(SingleCarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

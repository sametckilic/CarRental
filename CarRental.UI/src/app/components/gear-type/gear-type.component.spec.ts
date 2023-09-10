import { ComponentFixture, TestBed } from '@angular/core/testing';

import { GearTypeComponent } from './gear-type.component';

describe('GearTypeComponent', () => {
  let component: GearTypeComponent;
  let fixture: ComponentFixture<GearTypeComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [GearTypeComponent]
    });
    fixture = TestBed.createComponent(GearTypeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

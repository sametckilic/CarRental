import { ComponentFixture, TestBed } from '@angular/core/testing';

import { YenicompComponent } from './yenicomp.component';

describe('YenicompComponent', () => {
  let component: YenicompComponent;
  let fixture: ComponentFixture<YenicompComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [YenicompComponent]
    });
    fixture = TestBed.createComponent(YenicompComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

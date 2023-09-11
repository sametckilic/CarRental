import { TestBed } from '@angular/core/testing';

import { GearTypeService } from './gear-type.service';

describe('GearTypeService', () => {
  let service: GearTypeService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(GearTypeService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

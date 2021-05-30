import { TestBed } from '@angular/core/testing';

import { DebitSecurityAPIServiceService } from './debit-security-apiservice.service';

describe('DebitSecurityAPIServiceService', () => {
  let service: DebitSecurityAPIServiceService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DebitSecurityAPIServiceService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

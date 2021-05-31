import { TestBed } from '@angular/core/testing';

import { DebitSecurityAPIService } from './debit-security-api.service';

describe('DebitSecurityAPIServiceService', () => {
  let service: DebitSecurityAPIService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(DebitSecurityAPIService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});

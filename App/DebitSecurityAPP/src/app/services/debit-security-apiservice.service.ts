import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../../environments/environment';
import { DebitSecurity } from '../models/document';

@Injectable({
  providedIn: 'root'
})
export class DebitSecurityAPIServiceService {

  DebitSecurityApi: string = `${environment.debitSecurityAPI}/Debits`;

  constructor(
    private http: HttpClient
  ) { }

  getDebits() {
    return this.http.get(this.DebitSecurityApi);
  }

  getDebitByDocument(idDebitSecurity: string) {
    return this.http.get(`${this.DebitSecurityApi}/${idDebitSecurity}`);
  }

  getByFilter(filter: any) {
    return this.http.get(this.DebitSecurityApi, { params: { idDebitSecurity: filter.idDebitSecurity, CPF: filter.CPF } });
  }

  create(model: DebitSecurity) {
    return this.http.post(this.DebitSecurityApi, model);
  }

  Alter(idDebitSecurity: number, model: DebitSecurity) {
    return this.http.put(`${this.DebitSecurityApi}/${idDebitSecurity}`, model);
  }
}

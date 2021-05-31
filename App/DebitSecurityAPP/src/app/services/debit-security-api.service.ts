import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { DebitSecurity } from '../models/document';

@Injectable({
  providedIn: 'root'
})
export class DebitSecurityAPIService {

  DebitSecurityApi: string = `${environment.debitSecurityAPI}/DebitSecurity`;

  constructor(
    private http: HttpClient
  ) { }

  getDebits(): Observable<DebitSecurity[]> {
    return this.http.get<DebitSecurity[]>(this.DebitSecurityApi);
  }

  /*getDebitByDocument(idDebitSecurity: string) {
    return this.http.get(`${this.DebitSecurityApi}/${idDebitSecurity}`);
  }

  getByFilter(filter: any) {
    return this.http.get(this.DebitSecurityApi, { params: { idDebitSecurity: filter.idDebitSecurity, CPF: filter.CPF } });
  }*/

  create(model: DebitSecurity) {
    return this.http.post(this.DebitSecurityApi, model);
  }

  Alter(idDebitSecurity: number, model: DebitSecurity) {
    return this.http.put(`${this.DebitSecurityApi}/${idDebitSecurity}`, model);
  }
}

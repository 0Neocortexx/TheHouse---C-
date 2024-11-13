import { inject, Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { AuthServiceService } from './auth-service.service';
import { Observable } from 'rxjs';

const authservice = new AuthServiceService();

const httpOptions = {
  headers : new HttpHeaders({
    'Content-Type': 'application/json',
    'Authorization': `bearer ${authservice.getToken()}`
  })
}

@Injectable({
  providedIn: 'root'
})
export class ComprasService {

  private apiUrl = 'http://localhost:5043/api';

  http = inject(HttpClient);

  getAllListaCompra(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl+'/listacompra', httpOptions);
  }

  
}

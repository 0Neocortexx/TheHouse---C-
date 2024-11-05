import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, throwError } from 'rxjs';
import { HttpHeaders } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ThehouseService {
  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type': 'application/json',
    })
  };
  loginUrl: string = 'http://localhost:5043/api/login';

  constructor(private http: HttpClient) { }

  realizaLogin(email: string, senha: string): Observable<any> {
    const loginData = { email, senha };
    return this.http.post(this.loginUrl, loginData, this.httpOptions)
      .pipe(
        catchError(this.handleError)
      );
  }

  realizaCadastro(nome: string, email: string, senha: string): Observable<any> {
    const cadastroData = { nome, email, senha };
    return this.http.post(this.loginUrl, cadastroData, this.httpOptions)
      .pipe(
        catchError(this.handleError)
      );
  }

  private handleError(error: any): Observable<any> {
    console.error('Erro ao realizar login:', error);
    return throwError(() => new Error('Erro ao realizar login. Verifique as credenciais e tente novamente.'));
  }
}

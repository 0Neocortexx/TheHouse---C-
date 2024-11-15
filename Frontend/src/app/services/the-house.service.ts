import { inject, Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { HttpHeaders } from '@angular/common/http';
import { throwError } from 'rxjs';
import { catchError } from 'rxjs';
import { Router } from '@angular/router';
import Swal from 'sweetalert2';

const httpOptions = {
  headers : new HttpHeaders({
    'Content-Type': 'application/json',
  })
}

@Injectable({
  providedIn: 'root'
})
export class TheHouseService {

  http = inject(HttpClient);
  router = inject(Router);
  
  private apiUrl = 'http://localhost:5043/api';

  //nome: string, email: string, senha: string
  getListaDeCompras() {
    return this.http.get(this.apiUrl+'/listacompra');
  }
  getListaDeComprasById(id:number) {
    return this.http.get(this.apiUrl+'/listacompra/'+id);
  }

  login(email: string, senha: string ) {

    const data = {email, senha};

    this.http.post(this.apiUrl+'/login', data, httpOptions) 
      
    .pipe(
        catchError(this.handleError)
      )
      .subscribe({
        next: (response: any) => {

          localStorage.setItem("email", response.email);
          localStorage.setItem("token", response.token);
          localStorage.setItem("nome", response.nome);
          localStorage.setItem("userIdentify", response.id);

          console.log(response);
            
          Swal.fire({
              position: "center",
              icon: "success",
              title: "Login realizado com sucesso!",
              showConfirmButton: false,
              timer: 1500,
          });

        },
        error: (error) => {
          console.error("Erro ao realizar login!", error);
          Swal.fire({
            icon: "error",
            title: "Oops...",
            text: "Email ou senha inválidos"
          });
        },
        complete: () => {
          this.router.navigate(['/dashboard']);
        }
    })
  }

  validaEmail(email: string) {
    const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/; // Cria o regex para validar o email
    var test = emailRegex.test(email);
    return !test ? false : true;
  }

  cadastro(nome: string, email: string, senha: string) {

    email.toLowerCase;
    
    const data = { nome, email, senha };

    this.http.post(this.apiUrl+'/cadastro', data, httpOptions)
    .pipe(
        catchError(this.handleError)
      )
      .subscribe({
        next: (response) => {
          Swal.fire({
            position: "center",
            icon: "success",
            title: "Cadastro realizado com sucesso!",
            showConfirmButton: false,
            timer: 1500,
        });

        },
        error: (error) => {
          console.error('Erro ao realizar cadastro:', error);
        },
        complete: () => {
          console.log('Requisição de cadastro completa.');
          this.router.navigate(['login']);
        }
      });
    }

  updatePost(data: any) {
    return this.http.put(this.apiUrl, data);
  }

  private handleError(error: any) {
    console.log(error);
    return throwError(() => new Error('Erro ao realizar login. Verifique as credenciais e tente novamente.'));
  }
}

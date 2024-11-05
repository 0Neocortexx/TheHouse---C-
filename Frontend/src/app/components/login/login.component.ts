import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { ThehouseService } from '../../services/thehouse.service';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [ MatProgressSpinnerModule, FormsModule ],
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent {
  constructor(private thehouseService: ThehouseService) {}

  formEmail: string = '';
  formSenha: string = '';

  clicked(): void {
    this.thehouseService.realizaLogin(this.formEmail, this.formSenha)
      .subscribe({
        next: (response) => {
          window.alert('Login realizado com sucesso!');
          console.log('Resposta do servidor:', response);
        },
        error: (error) => {
          window.alert('Erro ao realizar login. Verifique suas credenciais.');
          console.error('Erro:', error);
        },
        complete: () => {
          console.log('Requisição de login completa.');
        }
      });
  }
}

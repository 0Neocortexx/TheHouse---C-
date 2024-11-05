import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { ThehouseService } from '../../services/thehouse.service';

@Component({
  selector: 'app-cadastro',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './cadastro.component.html',
  styleUrl: './cadastro.component.css'
})
export class CadastroComponent {

  formNome: string = '';
  formEmail: string = '';
  formSenha: string = '';

  constructor(private theHouseService: ThehouseService){}
  
  clicked(): void {
    this.theHouseService.realizaLogin(this.formEmail, this.formSenha)
      .subscribe({
        next: (response) => {
          window.alert('Cadastro realizado com sucesso!');
          console.log('Resposta do servidor:', response);
        },
        error: (error) => {
          window.alert('Erro ao realizar cadastro. Verifique suas credenciais.');
          console.error('Erro:', error);
        },
        complete: () => {
          console.log('Requisição de login completa.');
        }
      });
  }
}

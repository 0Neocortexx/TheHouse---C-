import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule],
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'] // Corrigido de 'styleUrl' para 'styleUrls'
})
export class LoginComponent {
  formEmail: string = '';
  formSenha: string = '';

  async login(): Promise<void> {
    try {
      const response = await fetch('http://localhost:5043/api/login', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({
          email: this.formEmail,
          senha: this.formSenha
        })
      });

      console.log("Dados: "+ this.formEmail, this.formSenha);

      if (response.ok) {
        const result = await response.json();
        window.alert('Login realizado com sucesso!');
        console.log('Resposta do servidor:', result);
      }
      else if (response.status == 401) {
        window.alert("Dados incoerentes!");
        this.formSenha = '';
      }
      else {
        const errorText = await response.text(); // Use text() em vez de json() se a resposta não for JSON
        window.alert('Erro ao realizar login: ' + errorText);
      }
    } catch (error) {
      console.error('Erro na requisição:', error);
      window.alert('Erro ao realizar login. Verifique sua conexão e tente novamente.');
    }
  }

  clicked(): void {
    this.login();
  }
}

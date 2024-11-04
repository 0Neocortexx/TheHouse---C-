import { Component } from '@angular/core';
import { FormsModule } from '@angular/forms';

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

  async register(): Promise<void> {
    try {
      const response = await fetch('http://localhost:5043/api/cadastro', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json'
        },
        body: JSON.stringify({
          nome: this.formNome,
          email: this.formEmail,
          senha: this.formSenha
        })
      });

      console.log("Cadastro: " +this.formEmail, this.formSenha);

      if (response.ok) {
        const result = await response.json();
        window.alert('Login realizado com sucesso!');
        console.log('Resposta do servidor:', result);
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
    this.register();
  }
}

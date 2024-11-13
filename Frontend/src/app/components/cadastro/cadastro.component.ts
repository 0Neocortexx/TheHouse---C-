import { Component, inject } from '@angular/core';
import { TheHouseService } from '../../services/the-house.service';
import { FormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-cadastro',
  standalone: true,
  imports: [FormsModule, RouterLink],
  templateUrl: './cadastro.component.html',
  styleUrl: './cadastro.component.css'
})
export class CadastroComponent {

  service = inject(TheHouseService);

  nome: string = '';
  email: string = '';
  senha: string = '';

  cadastro() {
    return this.service.cadastro(this.nome, this.email, this.senha);
  }
}

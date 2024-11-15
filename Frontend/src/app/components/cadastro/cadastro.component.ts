import { Component, inject } from '@angular/core';
import { TheHouseService } from '../../services/the-house.service';
import { FormsModule } from '@angular/forms';
import { RouterLink } from '@angular/router';
import Swal from 'sweetalert2';

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
    if(this.service.validaEmail(this.email)) {
        this.service.cadastro(this.nome, this.email, this.senha);
    } else {
      Swal.fire({
        icon: "error",
        title: "Oops...",
        text: "Digite um email válido!"
      });
    }
  }
}

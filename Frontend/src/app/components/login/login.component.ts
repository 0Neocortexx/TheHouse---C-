import { Component, inject } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { TheHouseService } from '../../services/the-house.service';
import { RouterLink } from '@angular/router';
import { LoadingComponent } from "../loading/loading.component";

@Component({
  selector: 'app-login',
  standalone: true,
  imports: [FormsModule, RouterLink, LoadingComponent],
  templateUrl: './login.component.html',
  styleUrl: './login.component.css'
})
export class LoginComponent {

  service = inject(TheHouseService);

  email: string = '';
  senha: string = '';

  login() {
    this.service.login(this.email, this.senha); 
  }
}

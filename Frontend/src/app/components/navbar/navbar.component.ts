import { Component, inject } from '@angular/core';
import { AuthService } from '../../services/auth.service';
import { CommonModule } from '@angular/common';
import { RouterLink } from '@angular/router';

@Component({
  selector: 'app-navbar',
  standalone: true,
  imports: [CommonModule, RouterLink],
  templateUrl: './navbar.component.html',
  styleUrl: './navbar.component.css'
})
export class NavbarComponent {

  authservice = inject(AuthService);

  userName: string | null = null;

  ngOnInit() {
    this.userName = this.authservice.getUserName();  
  }

  isLoggedIn(): boolean { 
    return this.authservice.IsLoggedIn(); 
  }

  logout() { 
    this.authservice.logout(); 
    this.userName = null; 
  }
}

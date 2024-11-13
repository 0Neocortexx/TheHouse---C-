import { Component } from '@angular/core';
import { RouterLink, RouterLinkActive, RouterOutlet } from '@angular/router';
import { IndexComponent } from './components/index/index.component';
import { SweetAlert2Module } from '@sweetalert2/ngx-sweetalert2';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, SweetAlert2Module],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
  // template: `
  // <h1> hello world </h1>
  // `
})
export class AppComponent {
  title = 'Frontend';
}

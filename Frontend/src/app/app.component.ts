import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { FormsModule } from '@angular/forms';
import { CadastroComponent } from "./components/cadastro/cadastro.component";
import { LoaderComponent } from './components/loader/loader.component';
import { LoginComponent } from "./components/login/login.component";


@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, CadastroComponent, LoginComponent, FormsModule, LoaderComponent],
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
}
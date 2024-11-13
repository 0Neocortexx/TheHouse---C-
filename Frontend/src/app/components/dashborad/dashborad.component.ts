import { Component } from '@angular/core';
import { NavbarComponent } from "../navbar/navbar.component";

@Component({
  selector: 'app-dashborad',
  standalone: true,
  imports: [NavbarComponent],
  templateUrl: './dashborad.component.html',
  styleUrl: './dashborad.component.css'
})
export class DashboradComponent {

}

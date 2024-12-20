import { Component } from '@angular/core';
import { ChartType, GoogleChartsModule } from 'angular-google-charts';

@Component({
  selector: 'app-entretenimentos',
  standalone: true,
  imports: [GoogleChartsModule],
  templateUrl: './entretenimentos.component.html',
  styleUrl: './entretenimentos.component.css'
})
export class EntretenimentosComponent {
  title = 'Entretenimentos realizados no mês ${Mês}';
  type: ChartType = ChartType.BarChart; 
  data: any[] = [
    ['Locais Visitados', 3],
    ['Filmes Assistidos', 7],
    ['Series Assistidas', 12.8],
    ['Itens Comprados', 8.5],
  ];
  columnNames = ['Browser', 'Percentage'];
}

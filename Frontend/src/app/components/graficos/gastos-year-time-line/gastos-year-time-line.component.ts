import { Component } from '@angular/core';
import { ChartType, GoogleChartsModule } from 'angular-google-charts';

@Component({
  selector: 'app-gastos-year-time-line',
  standalone: true,
  imports: [GoogleChartsModule],
  templateUrl: './gastos-year-time-line.component.html',
  styleUrl: './gastos-year-time-line.component.css'
})
export class GastosYearTimeLineComponent {
  title = 'Linha do tempo de gastos no Ano de ${ano}';
  type: ChartType = ChartType.ComboChart; 
  data: any[] = [
    ['Janeiro', 230.50],
    ['Fevereiro', 310.34],
    ['Março', 300],
    ['Abril', 253.23],
    ['Maio', 89.90],
    ['Junho', 439.23],
    ['Julho', 300.23],
    ['Agosto', 1020.23],
    ['Setembro', 200.23],
    ['Outubro', 670.23],
    ['Novembro', 412.23],
    ['Dezembro', 510.23]
  ];
  columnNames = ['Browser', 'Percentage'];
  options = {    
  };
}

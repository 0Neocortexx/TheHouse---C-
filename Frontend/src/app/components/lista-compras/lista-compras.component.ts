import { Component, inject } from '@angular/core';
import { ComprasService } from '../../services/compras.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-lista-compras',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './lista-compras.component.html',
  styleUrl: './lista-compras.component.css'
})
export class ListaComprasComponent {
  
  service = inject(ComprasService);

  listaCompras: any[] = [];

  ngOnInit() {
    this.getListaCompras();
  }

  getListaCompras() { 
    this.service.getAllListaCompra()
      .subscribe( (data: any[]) => { 
      this.listaCompras = data; 
    }, (error) => { 
      console.error('Erro ao carregar lista de compras:', error); 
    } 
  ); 
}
}

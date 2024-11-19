import { Component, inject } from '@angular/core';
import { ComprasService } from '../../services/compras.service';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';
import { NavbarComponent } from "../navbar/navbar.component";

@Component({
  selector: 'app-lista-compras',
  standalone: true,
  imports: [CommonModule, NavbarComponent],
  templateUrl: './lista-compras.component.html',
  styleUrl: './lista-compras.component.css'
})
export class ListaComprasComponent {
  
  router = inject(Router);
  service = inject(ComprasService);

  listaCompras: any[] = [];

  userIdentify:string | null = localStorage.getItem('userIdentify');

  ngOnInit() {
    if(this.userIdentify == null) {
      this.router.navigate(['/login']);
    } else {
      this.getListaCompras(this.userIdentify);
    }
  }

  getListaCompras(email:string) { 
    this.service.getAllListaCompra(email)
      .subscribe( (data: any[]) => { 
      this.listaCompras = data; 
      console.log(this.listaCompras);
    }, (error) => { 
      console.error('Erro ao carregar lista de compras:', error); 
    } 
  ); 
}

  deleteListaCompra(idLista:number) {
    this.service.deleteListaCompra(idLista);
  }
}

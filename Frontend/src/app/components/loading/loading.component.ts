import { Component, effect, inject, signal } from '@angular/core';
import { LoaderService } from '../../services/loader.service';

@Component({
  selector: 'app-loading',
  standalone: true,
  imports: [],
  templateUrl: './loading.component.html',
  styleUrl: './loading.component.css'
})
export class LoadingComponent {
  isLoading: boolean = false; 
  
  constructor(private loaderService: LoaderService) { } ngOnInit(): void { 
    this.loaderService.loaderState.subscribe((state: boolean) => { 
      this.isLoading = state; 
    }); 
  }
}

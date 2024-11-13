import { Routes } from '@angular/router';
import { CadastroComponent } from './components/cadastro/cadastro.component';
import { LoginComponent } from './components/login/login.component';
import { IndexComponent } from './components/index/index.component';
import { DashboradComponent } from './components/dashborad/dashborad.component';

export const routes: Routes = [
    {path: 'login' , component: LoginComponent},
    {path: 'cadastro', component: CadastroComponent},
    {path: '', component: IndexComponent},
    {path: 'dashboard', component: DashboradComponent}
];



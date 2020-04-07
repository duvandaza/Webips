import { NgModule, Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PersonaRegistroComponent } from './ips/persona-registro/persona-registro.component';
import { PersonaConsultaComponent } from './ips/persona-consulta/persona-consulta.component';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [
  {
    path: 'personaConsulta',
    component: PersonaConsultaComponent
  },
  {
    path: 'personaRegistro',
    component: PersonaRegistroComponent
  }
];

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }

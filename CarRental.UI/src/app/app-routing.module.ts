import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CarComponent } from './components/car/car.component';
import { IndexComponent } from './components/index/index.component';
import { SingleCarComponent } from './components/single-car/single-car.component';
import { ErrorComponent } from './components/error/error.component';
import { YenicompComponent } from './components/yenicomp/yenicomp.component';

const routes: Routes = [
  { path: '', pathMatch: 'full', component: IndexComponent },
  {
    path: 'cars',
    component: CarComponent,
    children: [{ path: 'hasan', component: SingleCarComponent }],
  },
  { path: '**', component: ErrorComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { DetailComponent } from './page/debits/detail/detail.component';
import { ListComponent } from './page/debits/list/list.component';

const routes: Routes = [
  { path: '', redirectTo: 'debits/list', pathMatch: 'full' },
  { path: 'debits', redirectTo: 'debits/list', pathMatch: 'full' },
  { path: 'debits/list', component: ListComponent },
  { path: 'debits/detail', component: DetailComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})

export class AppRoutingModule { }

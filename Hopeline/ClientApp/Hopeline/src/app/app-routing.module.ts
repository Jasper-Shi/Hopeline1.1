import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { ResourcesComponent } from './resources/resources.component';
import { CommunitiesComponent } from './communities/communities.component';
import { PageNotFoundComponent } from './page-not-found.component';
import { ResourceCategoryManageComponent } from './admin/resource-category-manage.component';
import { ResourcesManageComponent } from './admin/resources-manage.component';
import { ResourceListManageComponent } from './admin/resource-list-manage.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'resources', component: ResourcesComponent },
  { path: 'communities', component: CommunitiesComponent },
  { path: 'mrc', component: ResourceCategoryManageComponent },
  { path: 'mr', component: ResourceListManageComponent },
  { path: 'resourcemanage/:m/:i', component:ResourcesManageComponent },
  { path: '', redirectTo: '/home', pathMatch: 'full' },
  { path: '**', component: PageNotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

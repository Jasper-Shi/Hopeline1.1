import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { ResourcesComponent } from './resources/resources.component';
import { CommunitiesComponent } from './communities/communities.component';
import { PageNotFoundComponent } from './page-not-found.component';
import { ResCommServiceService } from './resCommService/res-comm-service.service';
import { AdminResCommService } from './adminService/admin-res-comm.service';
import { ResourcesManageComponent } from './admin/resources-manage.component';
import { ResourceCategoryManageComponent } from './admin/resource-category-manage.component';
import { NgForm, FormsModule } from '@angular/forms';
import { ResourceListManageComponent } from './admin/resource-list-manage.component';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    ResourcesComponent,
    CommunitiesComponent,
    PageNotFoundComponent,
    ResourcesManageComponent,
    ResourceCategoryManageComponent,
    ResourceListManageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [ResCommServiceService, AdminResCommService],
  bootstrap: [AppComponent]
})
export class AppModule { }

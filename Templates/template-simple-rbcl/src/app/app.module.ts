import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { RouterModule, Routes } from "@angular/router";

import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';

// Bootstrap stuff
import { CollapseModule } from 'ngx-bootstrap';
import { TitledCardComponent } from './titled-card/titled-card.component';
import { HomeComponent } from './home/home.component';
import { FooterComponent } from './footer/footer.component';
import { AboutComponent } from './about/about.component';

const appRoutes : Routes = [
  { path: 'About', component: AboutComponent },
  { path: 'Home', component: HomeComponent },

  // Default
  { path: '', redirectTo: '/Home', pathMatch: 'full' }
]

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    TitledCardComponent,
    HomeComponent,
    FooterComponent,
    AboutComponent
  ],
  imports: [
    BrowserModule,
    CollapseModule.forRoot(),
    RouterModule.forRoot(appRoutes, {enableTracing: true })
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

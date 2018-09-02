import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppComponent } from './app.component';
import { NavbarComponent } from './navbar/navbar.component';

// Bootstrap stuff
import { CollapseModule } from 'ngx-bootstrap';
import { TitledCardComponent } from './titled-card/titled-card.component';

@NgModule({
  declarations: [
    AppComponent,
    NavbarComponent,
    TitledCardComponent
  ],
  imports: [
    BrowserModule,
    CollapseModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }

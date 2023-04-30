import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppComponent } from './app.component';
import { MainComponent } from "./pages/main.component";
import { Client } from "./services/Client";
import { RouterLink, RouterLinkActive, RouterModule, RouterOutlet, Routes } from "@angular/router";
import { CityComponent } from "./pages/City/city.component";
import { DoctorsComponent } from "./pages/Doctors/doctors.component";
import { SpecializationsComponent } from "./pages/Specializations/specializations.component";
import { PolyclinicsComponent } from "./pages/Polyclinics/polyclinics.component";
import { WeatherForecastComponent } from "./pages/Weather/weather.component";

const routes: Routes = [{ path: 'main', component: MainComponent },
{ path: 'city', component: CityComponent },

{ path: 'weather-root', component: WeatherForecastComponent },
{ path: 'doc', component: DoctorsComponent },
{ path: 'spec', component: SpecializationsComponent },
{ path: 'hospital', component: PolyclinicsComponent },
{ path: '**', redirectTo: '/' }];

@NgModule({
  declarations: [
    WeatherForecastComponent,
    MainComponent,
    CityComponent,
    DoctorsComponent,
    SpecializationsComponent,
    PolyclinicsComponent,
    AppComponent
  ],
  imports: [
    BrowserModule, HttpClientModule, RouterOutlet, RouterLink, RouterLinkActive,
    RouterModule.forRoot(routes),
  ],
  providers: [Client],
  bootstrap: [AppComponent]
})
export class AppModule { }

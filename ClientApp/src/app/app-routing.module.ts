import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import {MainComponent} from "./pages/main.component";
import {CityComponent} from "./pages/City/city.component";
import { DoctorsComponent } from "./pages/Doctors/doctors.component";
import { SpecializationsComponent } from "./pages/Specializations/specializations.component";
import { PolyclinicsComponent } from "./pages/Polyclinics/polyclinics.component";
import { WeatherForecastComponent } from "./pages/Weather/weather.component";

const routes: Routes = [
  { path: 'main',component: MainComponent},
  { path: 'city', component: CityComponent},
  { path: 'doc', component: DoctorsComponent},
  { path: 'spec', component: SpecializationsComponent},
  { path: 'hospital', component: PolyclinicsComponent},
  { path: '**', redirectTo: '/'},
  { path: 'weather-root', component: WeatherForecastComponent}
];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }



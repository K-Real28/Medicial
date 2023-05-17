import { HttpClient } from '@angular/common/http';
import { Component, NgModule } from '@angular/core';
import { Client } from '../../services/Client';

@Component({

  selector: 'city',
  templateUrl: './city.component.html',
  styleUrls: ['./city.component.css'],
})
export class CityComponent {
  public cities: Array<City> = new Array<City>();

  constructor(http: HttpClient) {
    http.get<City[]>('api/cities/GetCity').subscribe(result => {
      this.cities = result;
    }, error => console.error(error));
  }

  title = 'angularapp';
}

interface City {
  id: Int32Array;
  name: string;
}

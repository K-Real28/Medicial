import { HttpClient } from '@angular/common/http';
import { Component, NgModule } from '@angular/core';
import { City, Client } from '../../services/Client';

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

interface CityPage {
  id: Int32Array;
  name: string;
}
//export class CityComponent {

//  cities: Array<City> = new Array<City>();
//  constructor(
//    private client: Client
//  ) { }
//  ngOnInit(): void {
//    this.getCities();
//  }

//  getCities() {
//    this.client.citiesApiAll().subscribe(response => {
//      this.cities = response;
//    })
//  }
//  title = 'rout';
//}


//import { Component, OnInit } from '@angular/core';
//import { HttpClient } from '@angular/common/http';
//import { City } from '../../../Models/city.models';

//@Component({
//  selector: 'app-city-list',
//  templateUrl: 'city-list.component.html',
//  styleUrls: ['./city-list.component.css']
//})
//export class CityListComponent implements OnInit {

//  cities: City[] = [
//    {
//      Id: 1,
//      Name: 'Tokyo'
//    },
//    {
//      Id: 2,
//      Name: 'Moscow'
//    },
//    {
//      Id: 3,
//      Name: 'Tiraspol'
//    }
//  ];

//  constructor() { }

//  ngOnInit(): void {
//    this.City.push()
//  }

//}

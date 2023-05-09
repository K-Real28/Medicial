import { HttpClient } from '@angular/common/http';
import {Component, NgModule} from '@angular/core';


@Component({

  selector: 'hospital',
  templateUrl: './polyclinics.component.html',
  styleUrls: ['./polyclinics.component.css'],
})
export class PolyclinicsComponent {
  public polyclinics: Array<Polyclinic> = new Array<Polyclinic>();

  constructor(http: HttpClient) {
    http.get<Polyclinic[]>('api/polyclinics/GetPolyclinic').subscribe(result => {
      this.polyclinics = result;
    }, error => console.error(error));
  }

  title = 'angularapp';
}

interface Polyclinic {
  id: Int32Array;
  address: string;
  phoneNumber: Int32Array;
  name: string;
  photo: string;
}

import { HttpClient } from '@angular/common/http';
import {Component, NgModule} from '@angular/core';

@Component({

  selector: 'page-spec',
  templateUrl: './specializations.component.html',
  styleUrls: ['./specializations.component.css'],
})
export class SpecializationsComponent {
  public specializations: Array<Specialization> = new Array<Specialization>();

  constructor(http: HttpClient) {
    http.get<Specialization[]>('api/specializations/GetSpecialization').subscribe(result => {
      this.specializations = result;
    }, error => console.error(error));
  }

  title = 'angularapp';
}

interface Specialization {
  id: Int32Array;
  name: string;
}

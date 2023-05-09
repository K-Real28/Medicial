import {Component, NgModule} from '@angular/core';
import { Client } from '../../services/Client';
import { HttpClient } from '@angular/common/http';

@Component({

  selector: 'doc',
  templateUrl: './doctors.component.html',
  styleUrls: ['./doctors.component.css'],
})
export class DoctorsComponent {
  public doctors: Array<Doctor> = new Array<Doctor>();

  constructor(http: HttpClient) {
    http.get<Doctor[]>('api/doctors/GetDoctor').subscribe(result => {
      this.doctors = result;
    }, error => console.error(error));
  }

  title = 'angularapp';
}

interface Doctor {
  id: Int32Array;
  fullName: string;
  shortInfo: string;
  costOfVisit: Int32Array;
  phoneNumber: Int32Array;
  expOfSpec: Int32Array;
}

//export class DoctorsComponent {

//  doctors: Array<Doctor> = new Array<Doctor>();
//  constructor(
//    private client: Client
//  ) { }
//  ngOnInit(): void {
//    this.getDoctors();
//  }

//  getDoctors() {
//    this.client.getDoctor().subscribe(Response => {
//      this.doctors = Response;
//    })
//  }

//  title = 'rout';
//}

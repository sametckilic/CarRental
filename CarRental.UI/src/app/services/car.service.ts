import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Car } from '../models/car';
import { ListResponseModel } from '../models/ListResponseModel';

@Injectable({
  providedIn: 'root',
})
export class CarService {
  apiUrl = 'https:/localhost:44327/api/';
  constructor(private httpClient: HttpClient) {}

  getCars(): Observable<ListResponseModel<Car>> {
    let path = this.apiUrl + 'Car/GetAll';
    return this.httpClient.get<ListResponseModel<Car>>(path);
  }
  getCarsByBrandId(brandId: number) {
    let path = this.apiUrl + 'Car/GetByBrandId?brandId=' + brandId;
    return this.httpClient.get<ListResponseModel<Car>>(path);
  }
}

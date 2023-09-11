import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Car } from '../models/car';
import { ListResponseModel } from '../models/listResponseModel';
import { CarDto } from '../models/carDto';

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
  getCarsByBrandId(brandId: number): Observable<ListResponseModel<Car>> {
    let path = this.apiUrl + 'Car/GetByBrandId?brandId=' + brandId;
    return this.httpClient.get<ListResponseModel<Car>>(path);
  }

  getCarsByGearTypeId(gearTypeId: number): Observable<ListResponseModel<Car>> {
    let path = this.apiUrl + 'Car/GetByGearTypeId?gearTypeId=' + gearTypeId;
    return this.httpClient.get<ListResponseModel<Car>>(path);
  }

  getCarsByFuelTypeId(fuelTypeId: number): Observable<ListResponseModel<Car>> {
    let path = this.apiUrl + 'Car/GetByFuelTypeId?fuelTypeId=' + fuelTypeId;
    return this.httpClient.get<ListResponseModel<Car>>(path);
  }
  getCarsByColorId(colorId: number): Observable<ListResponseModel<Car>> {
    let path = this.apiUrl + 'Car/GetByColorId?colorId=' + colorId;
    return this.httpClient.get<ListResponseModel<Car>>(path);
  }
  getCarsDto(): Observable<ListResponseModel<CarDto>> {
    let path = this.apiUrl + 'Car/GetAllDetails';
    return this.httpClient.get<ListResponseModel<CarDto>>(path);
  }

  getCarDtoById(id: number): Observable<ListResponseModel<CarDto>> {
    let path = this.apiUrl + 'Car/GetAllDetailsById?id=' + id;
    return this.httpClient.get<ListResponseModel<CarDto>>(path);
  }
}

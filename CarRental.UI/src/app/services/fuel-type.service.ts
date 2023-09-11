import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { ListResponseModel } from '../models/listResponseModel';
import { Observable } from 'rxjs';
import { Color } from '../models/color';
import { FuelType } from '../models/fuelType';

@Injectable({
  providedIn: 'root',
})
export class FuelTypeService {
  apiUrl = 'https:/localhost:44327/api/';
  constructor(private httpClient: HttpClient) {}

  getFuelTypes(): Observable<ListResponseModel<FuelType>> {
    let path = this.apiUrl + 'FuelType/GetAll';
    return this.httpClient.get<ListResponseModel<FuelType>>(path);
  }
}

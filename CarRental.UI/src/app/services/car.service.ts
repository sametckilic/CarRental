import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { CarResponseModel } from '../models/carResponseModel';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class CarService {
  constructor(private httpClient: HttpClient) {}

  getCars(): Observable<CarResponseModel> {
    return this.httpClient.get<CarResponseModel>(
      'https:/localhost:44327/api/Car/GetAll'
    );
  }
}

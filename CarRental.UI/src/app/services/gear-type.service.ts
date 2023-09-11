import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ListResponseModel } from '../models/listResponseModel';
import { GearType } from '../models/gearType';

@Injectable({
  providedIn: 'root',
})
export class GearTypeService {
  apiUrl = 'https:/localhost:44327/api/';
  constructor(private httpClient: HttpClient) {}

  getGearTypes(): Observable<ListResponseModel<GearType>> {
    let path = this.apiUrl + 'GearType/GetAll';
    return this.httpClient.get<ListResponseModel<GearType>>(path);
  }
}

import { Component } from '@angular/core';
import { Brand } from 'src/app/models/brand';
import { Color } from 'src/app/models/color';
import { FuelType } from 'src/app/models/fuelType';
import { GearType } from 'src/app/models/gearType';
import { BrandService } from 'src/app/services/brand.service';
import { ColorService } from 'src/app/services/color.service';
import { FuelTypeService } from 'src/app/services/fuel-type.service';
import { GearTypeService } from 'src/app/services/gear-type.service';

@Component({
  selector: 'app-navi',
  templateUrl: './navi.component.html',
  styleUrls: ['./navi.component.css'],
})
export class NaviComponent {
  brands: Brand[] = [];
  colors: Color[] = [];
  fuelTypes: FuelType[] = [];
  gearTypes: GearType[] = [];

  constructor(
    private brandService: BrandService,
    private colorService: ColorService,
    private fuelTypeService: FuelTypeService,
    private gearTypeService: GearTypeService
  ) {
    this.getBrands();
    this.getColors();
    this.getFuelTypes();
    this.getGearTypes();
  }

  getBrands() {
    this.brandService.getBrands().subscribe((response) => {
      this.brands = response.data;
    });
  }
  getColors() {
    this.colorService.getColors().subscribe((response) => {
      this.colors = response.data;
    });
  }
  getFuelTypes() {
    this.fuelTypeService.getFuelTypes().subscribe((response) => {
      this.fuelTypes = response.data;
    });
  }
  getGearTypes() {
    this.gearTypeService.getGearTypes().subscribe((response) => {
      this.gearTypes = response.data;
    });
  }
}

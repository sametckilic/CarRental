import { Car } from './car';

export interface CarDto extends Car {
  brandName: string;
  colorName: string;
  gearTypeName: string;
  fuelTypeName: string;
}

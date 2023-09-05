using CarRental.Core.DataAccess.EntityFramework;
using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;
using CarRental.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;

namespace CarRental.DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailsDto> GetAllCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var query = from cars in context.Cars
                            join brands in context.Brands
                            on cars.BrandId equals brands.Id
                            join color in context.Colors
                            on cars.ColorId equals color.Id
                            join geartype in context.GearTypes
                            on cars.GearTypeId equals geartype.Id
                            join fueltype in context.FuelTypes
                            on cars.FuelTypeId equals fueltype.Id
                            select new CarDetailsDto
                            {
                                Id = cars.Id,
                                BrandName = brands.BrandName,
                                ModelName = cars.ModelName,
                                ColorName = color.ColorName,
                                GearTypeName = geartype.GearTypeName,
                                FuelTypeName = fueltype.FuelTypeName,
                                ModelYear = cars.ModelYear,
                                DailyPrice = cars.DailyPrice,
                                MonthlyPrice = cars.MonthlyPrice,
                                Status = cars.Status,
                                ImageBase = cars.ImageBase,
                                Description = cars.Description
                            };

                return query.ToList();
            }
        }

        public CarDetailsDto GetAllCarDetailsById(int id)
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var query = from cars in context.Cars
                            join brands in context.Brands
                            on cars.BrandId equals brands.Id
                            join color in context.Colors
                            on cars.ColorId equals color.Id
                            join geartype in context.GearTypes
                            on cars.GearTypeId equals geartype.Id
                            join fueltype in context.FuelTypes
                            on cars.FuelTypeId equals fueltype.Id
                            where cars.Id == id
                            select new CarDetailsDto
                            {
                                Id = cars.Id,
                                BrandName = brands.BrandName,
                                ColorName = color.ColorName,
                                GearTypeName = geartype.GearTypeName,
                                FuelTypeName = fueltype.FuelTypeName,
                                ModelYear = cars.ModelYear,
                                DailyPrice = cars.DailyPrice,
                                MonthlyPrice = cars.MonthlyPrice,
                                Status = cars.Status,
                                ImageBase = cars.ImageBase,
                                Description = cars.Description
                            };

                return query.FirstOrDefault();
            }
        }
    }

}

using CarRental.Entities.Concrete;
using CarRental.Entities.DTOs;
using Core.DataAccess;
using System.Collections.Generic;

namespace CarRental.DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        public List<CarDetailsDto> GetAllCarDetails();

        public List<CarDetailsDto> GetAllCarDetailsByBrandId(int brandId);
        public List<CarDetailsDto> GetAllCarDetailsByFuelTypeId(int fuelTypeId);
        public List<CarDetailsDto> GetAllCarDetailsByGearTypeId(int gearTypeId);
        public List<CarDetailsDto> GetAllCarDetailsByColorId(int colorId);


        public CarDetailsDto GetAllCarDetailsById(int id);

    }

}

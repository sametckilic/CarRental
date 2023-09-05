using CarRental.Entities.Concrete;
using CarRental.Entities.DTOs;
using Core.DataAccess;
using System.Collections.Generic;

namespace CarRental.DataAccess.Abstract
{
    public interface ICarDal : IEntityRepository<Car>
    {
        public List<CarDetailsDto> GetAllCarDetails();

        public CarDetailsDto GetAllCarDetailsById(int id);

    }

}

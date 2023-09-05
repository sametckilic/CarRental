using CarRental.Business.Abstract;
using CarRental.Core.Utilities.Results;
using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;
using CarRental.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllByColorId(int colorId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllByFuelTypeId(int fuelTypeId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarDetailsDto>> GetAllDetails()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetAllGearTypeId(int gearTypeId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Car> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Car>> GetByUnitPrice(int unitPrice)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}

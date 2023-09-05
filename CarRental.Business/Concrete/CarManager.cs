using CarRental.Business.Abstract;
using CarRental.Business.Constants;
using CarRental.Core.Utilities.Results;
using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;
using CarRental.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            _carDal.Add(car);

            return new SuccessResult(Messages.CarAdded);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.AllCarsListed);
        }

        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == brandId), Messages.AllCarsListedByBrandId);
        }

        public IDataResult<List<Car>> GetAllByColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == colorId), Messages.AllCarsListedByColorId);

        }

        public IDataResult<List<Car>> GetAllByFuelTypeId(int fuelTypeId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.FuelTypeId == fuelTypeId), Messages.AllCarsListedByFuelTypeId);

        }

        public IDataResult<List<CarDetailsDto>> GetAllDetails()
        {
            return new SuccessDataResult<List<CarDetailsDto>>(_carDal.GetAllCarDetails(), Messages.AllCarsDetailsListed);
        }

        public IDataResult<CarDetailsDto> GetAllDetailsById(int id)
        {
            return new SuccessDataResult<CarDetailsDto>(_carDal.GetAllCarDetailsById(id), Messages.GetCarDetails);

        }

        public IDataResult<List<Car>> GetAllGearTypeId(int gearTypeId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.GearTypeId == gearTypeId), Messages.AllCarsListedByGearTypeId);
        }

        public IDataResult<Car> GetById(int id)
        {
            return new SuccessDataResult<Car>(_carDal.Get(c => c.Id == id), Messages.CarListed);
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.DailyPrice < max && c.DailyPrice > min));
        }
        public IDataResult<List<Car>> GetByMonthlyPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.MonthlyPrice < max && c.MonthlyPrice > min));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);

            return new SuccessResult(Messages.CarUpdated);
        }
    }
}

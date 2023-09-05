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
            var result = _carDal.GetAll();

            if (!result.Any())
            {
                return new ErrorDataResult<List<Car>>(Messages.CarNotFoundError);
            }
            return new SuccessDataResult<List<Car>>(result, Messages.AllCarsListed);
        }

        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            var result = _carDal.GetAll(c => c.BrandId == brandId);

            if (result == null)
            {
                return new ErrorDataResult<List<Car>>(Messages.CarNotFoundError);
            }
            return new SuccessDataResult<List<Car>>(result, Messages.AllCarsListedByBrandId);
        }

        public IDataResult<List<Car>> GetAllByColorId(int colorId)
        {
            var result = _carDal.GetAll(c => c.ColorId == colorId);

            if (result == null)
            {
                return new ErrorDataResult<List<Car>>(Messages.CarNotFoundError);
            }
            return new SuccessDataResult<List<Car>>(result, Messages.AllCarsListedByColorId);

        }

        public IDataResult<List<Car>> GetAllByFuelTypeId(int fuelTypeId)
        {
            var result = _carDal.GetAll(c => c.FuelTypeId == fuelTypeId);
            if (!result.Any())
            {
                return new ErrorDataResult<List<Car>>(Messages.CarNotFoundError);

            }
            return new SuccessDataResult<List<Car>>(result, Messages.AllCarsListedByFuelTypeId);

        }

        public IDataResult<List<CarDetailsDto>> GetAllDetails()
        {
            var result = _carDal.GetAllCarDetails();
            if (!result.Any())
            {
                return new ErrorDataResult<List<CarDetailsDto>>(Messages.CarNotFoundError);

            }
            return new SuccessDataResult<List<CarDetailsDto>>(result, Messages.AllCarsDetailsListed);
        }

        public IDataResult<CarDetailsDto> GetAllDetailsById(int id)
        {
            var result = _carDal.GetAllCarDetailsById(id);

            if (result == null)
            {
                return new ErrorDataResult<CarDetailsDto>(Messages.CarNotFoundError);

            }
            return new SuccessDataResult<CarDetailsDto>(result, Messages.GetCarDetails);

        }

        public IDataResult<List<Car>> GetAllGearTypeId(int gearTypeId)
        {
            var result = _carDal.GetAll(c => c.GearTypeId == gearTypeId);
            if (!result.Any())
            {
                return new ErrorDataResult<List<Car>>(Messages.CarNotFoundError);

            }
            return new SuccessDataResult<List<Car>>(result, Messages.AllCarsListedByGearTypeId);
        }

        public IDataResult<Car> GetById(int id)
        {
            var result = _carDal.Get(c => c.Id == id);
            if (result == null)
            {
                return new ErrorDataResult<Car>(Messages.CarNotFoundError);
            }
            return new SuccessDataResult<Car>(result, Messages.CarListed);
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            var result = _carDal.GetAll(c => c.DailyPrice < max && c.DailyPrice > min);

            if (!result.Any())
            {
                return new ErrorDataResult<List<Car>>(Messages.CarNotFoundError);
            }
            return new SuccessDataResult<List<Car>>(result, Messages.CarsListedByDailyPrice);
        }
        public IDataResult<List<Car>> GetByMonthlyPrice(decimal min, decimal max)
        {
            var result = _carDal.GetAll(c => c.MonthlyPrice < max && c.MonthlyPrice > min);
            if (!result.Any())
            {
                return new ErrorDataResult<List<Car>>(Messages.CarNotFoundError);
            }
            return new SuccessDataResult<List<Car>>(result, Messages.CarsListedByMonthlyPrice);
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);

            return new SuccessResult(Messages.CarUpdated);
        }
    }
}

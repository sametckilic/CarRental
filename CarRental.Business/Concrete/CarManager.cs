using CarRental.Business.Abstract;
using CarRental.Business.BusinessAspect.Autofac;
using CarRental.Business.Constants;
using CarRental.Business.ValidationRules.FluentValidation;
using CarRental.Core.Aspects.Autofac.Caching;
using CarRental.Core.Aspects.Autofac.Validation;
using CarRental.Core.Utilities.Results;
using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;
using CarRental.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static CarRental.Business.Constants.Messages;

namespace CarRental.Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [SecuredOperation("car.add , admin")]
        [ValidationAspect(typeof(CarValidator))]
        [CacheRemoveAspect("ICarService.Get")]
        public IResult Add(Car car)
        {
            _carDal.Add(car);

            return new SuccessResult(Messages.CarMessages.CarAdded);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            var result = _carDal.GetAll();

            if (!result.Any())
            {
                return new ErrorDataResult<List<Car>>(Messages.CarMessages.CarNotFoundError);
            }
            return new SuccessDataResult<List<Car>>(result, Messages.CarMessages.AllCarsListed);
        }

        [CacheAspect]
        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            var result = _carDal.GetAll(c => c.BrandId == brandId);

            if (result == null)
            {
                return new ErrorDataResult<List<Car>>(Messages.CarMessages.CarNotFoundError);
            }
            return new SuccessDataResult<List<Car>>(result, Messages.CarMessages.AllCarsListedByBrandId);
        }

        public IDataResult<List<Car>> GetAllByColorId(int colorId)
        {
            var result = _carDal.GetAll(c => c.ColorId == colorId);

            if (result == null)
            {
                return new ErrorDataResult<List<Car>>(Messages.CarMessages.CarNotFoundError);
            }
            return new SuccessDataResult<List<Car>>(result, Messages.CarMessages.AllCarsListedByColorId);

        }

        public IDataResult<List<Car>> GetAllByFuelTypeId(int fuelTypeId)
        {
            var result = _carDal.GetAll(c => c.FuelTypeId == fuelTypeId);
            if (!result.Any())
            {
                return new ErrorDataResult<List<Car>>(Messages.CarMessages.CarNotFoundError);

            }
            return new SuccessDataResult<List<Car>>(result, Messages.CarMessages.AllCarsListedByFuelTypeId);

        }

        public IDataResult<List<CarDetailsDto>> GetAllDetails()
        {
            var result = _carDal.GetAllCarDetails();
            if (!result.Any())
            {
                return new ErrorDataResult<List<CarDetailsDto>>(Messages.CarMessages.CarNotFoundError);

            }
            return new SuccessDataResult<List<CarDetailsDto>>(result, Messages.CarMessages.AllCarsDetailsListed);
        }

        public IDataResult<CarDetailsDto> GetAllDetailsById(int id)
        {
            var result = _carDal.GetAllCarDetailsById(id);

            if (result == null)
            {
                return new ErrorDataResult<CarDetailsDto>(Messages.CarMessages.CarNotFoundError);

            }
            return new SuccessDataResult<CarDetailsDto>(result, Messages.CarMessages.GetCarDetails);

        }

        public IDataResult<List<Car>> GetAllGearTypeId(int gearTypeId)
        {
            var result = _carDal.GetAll(c => c.GearTypeId == gearTypeId);
            if (!result.Any())
            {
                return new ErrorDataResult<List<Car>>(Messages.CarMessages.CarNotFoundError);

            }
            return new SuccessDataResult<List<Car>>(result, Messages.CarMessages.AllCarsListedByGearTypeId);
        }

        [CacheAspect]
        public IDataResult<Car> GetById(int id)
        {
            var result = _carDal.Get(c => c.Id == id);
            if (result == null)
            {
                return new ErrorDataResult<Car>(Messages.CarMessages.CarNotFoundError);
            }
            return new SuccessDataResult<Car>(result, Messages.CarMessages.CarListed);
        }

        public IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max)
        {
            var result = _carDal.GetAll(c => c.DailyPrice < max && c.DailyPrice > min);

            if (!result.Any())
            {
                return new ErrorDataResult<List<Car>>(Messages.CarMessages.CarNotFoundError);
            }
            return new SuccessDataResult<List<Car>>(result, Messages.CarMessages.CarsListedByDailyPrice);
        }
        public IDataResult<List<CarDetailsDto>> GetAllDetailsByBrandId(int brandId)
        {
            var result = _carDal.GetAllCarDetailsByBrandId(brandId);

            if (!result.Any())
            {
                return new ErrorDataResult<List<CarDetailsDto>>(Messages.CarMessages.CarNotFoundError);
            }
            return new SuccessDataResult<List<CarDetailsDto>>(result, Messages.CarMessages.AllCarsListedByBrandId);

        }

        public IDataResult<List<CarDetailsDto>> GetAllDetailsByColorId(int colorId)
        {
            var result = _carDal.GetAllCarDetailsByColorId(colorId);
            if (!result.Any())
            {
                return new ErrorDataResult<List<CarDetailsDto>>(Messages.CarMessages.CarNotFoundError);
            }
            return new SuccessDataResult<List<CarDetailsDto>>(result, Messages.CarMessages.AllCarsListedByColorId);
        }

        public IDataResult<List<CarDetailsDto>> GetAllDetailsByGearTypeId(int gearTypeId)
        {
            var result = _carDal.GetAllCarDetailsByGearTypeId(gearTypeId);

            if (!result.Any())
            {
                return new ErrorDataResult<List<CarDetailsDto>>(Messages.CarMessages.CarNotFoundError);
            }
            return new SuccessDataResult<List<CarDetailsDto>>(result, Messages.CarMessages.AllCarsListedByBrandId);
        }

        public IDataResult<List<CarDetailsDto>> GetAllDetailsByFuelTypeId(int fuelTypeId)
        {
            var result = _carDal.GetAllCarDetailsByFuelTypeId(fuelTypeId);

            if (!result.Any())
            {
                return new ErrorDataResult<List<CarDetailsDto>>(Messages.CarMessages.CarNotFoundError);
            }
            return new SuccessDataResult<List<CarDetailsDto>>(result, Messages.CarMessages.AllCarsListedByBrandId);
        }

        public IDataResult<List<Car>> GetByMonthlyPrice(decimal min, decimal max)
        {
            var result = _carDal.GetAll(c => c.MonthlyPrice < max && c.MonthlyPrice > min);
            if (!result.Any())
            {
                return new ErrorDataResult<List<Car>>(Messages.CarMessages.CarNotFoundError);
            }
            return new SuccessDataResult<List<Car>>(result, Messages.CarMessages.CarsListedByMonthlyPrice);
        }

        [CacheRemoveAspect("ICarService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);

            return new SuccessResult(Messages.CarMessages.CarUpdated);
        }

        [CacheRemoveAspect("ICarService.Get")]
        public IResult Delete(Car car)
        {
            _carDal.Delete(car);

            return new SuccessResult(Messages.CarMessages.CarDeleted);
        }


    }
}

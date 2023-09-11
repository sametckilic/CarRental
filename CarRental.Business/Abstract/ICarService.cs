using CarRental.Core.Utilities.Results;
using CarRental.Entities.Concrete;
using CarRental.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();

        IDataResult<List<CarDetailsDto>> GetAllDetails();
        IDataResult<CarDetailsDto> GetAllDetailsById(int id);
        IDataResult<List<CarDetailsDto>> GetAllDetailsByBrandId(int brandId);
        IDataResult<List<CarDetailsDto>> GetAllDetailsByColorId(int colorId);
        IDataResult<List<CarDetailsDto>> GetAllDetailsByGearTypeId(int gearTypeId);
        IDataResult<List<CarDetailsDto>> GetAllDetailsByFuelTypeId(int fuelTypeId);



        IDataResult<List<Car>> GetAllByBrandId(int brandId);
        IDataResult<List<Car>> GetAllByColorId(int colorId);
        IDataResult<List<Car>> GetAllGearTypeId(int gearTypeId);
        IDataResult<List<Car>> GetAllByFuelTypeId(int fuelTypeId);

        IDataResult<List<Car>> GetByDailyPrice(decimal min, decimal max);
        IDataResult<List<Car>> GetByMonthlyPrice(decimal min, decimal max);

        IDataResult<Car> GetById(int id);

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);



    }
}

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

        IDataResult<List<Car>> GetAllByBrandId(int brandId);
        IDataResult<List<Car>> GetAllByColorId(int colorId);
        IDataResult<List<Car>> GetAllGearTypeId(int gearTypeId);
        IDataResult<List<Car>> GetAllByFuelTypeId(int fuelTypeId);

        IDataResult<List<Car>> GetByUnitPrice(int unitPrice);
        IDataResult<Car> GetById(int id);

        IResult Add(Car car);
        IResult Update(Car car);



    }
}

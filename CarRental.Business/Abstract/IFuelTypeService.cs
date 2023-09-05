using CarRental.Core.Utilities.Results;
using CarRental.Entities.Concrete;
using System.Collections.Generic;
using System.Threading.Channels;

namespace CarRental.Business.Abstract
{
    public interface IFuelTypeService
    {
        IDataResult<List<FuelType>> GetAll();
        IDataResult<FuelType> GetById(int fuelTypeId);


    }
}

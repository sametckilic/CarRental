using CarRental.Business.Abstract;
using CarRental.Business.Constants;
using CarRental.Core.Utilities.Results;
using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Concrete
{
    public class FuelTypeManager : IFuelTypeService
    {
        IFuelTypeDal _fuelTypeDal;

        public FuelTypeManager(IFuelTypeDal fuelTypeDal)
        {
            _fuelTypeDal = fuelTypeDal;
        }

        public IDataResult<List<FuelType>> GetAll()
        {
            var result = _fuelTypeDal.GetAll();

            if (!result.Any())
            {
                return new ErrorDataResult<List<FuelType>>(Messages.FuelType.FuelTypeNotFound);
            }

            return new SuccessDataResult<List<FuelType>>(result, Messages.FuelType.FuelTypesListed);
        }

        public IDataResult<FuelType> GetById(int fuelTypeId)
        {
            var result = _fuelTypeDal.Get(b => b.Id == fuelTypeId);
            if (result == null)
            {
                return new ErrorDataResult<FuelType>(Messages.FuelType.FuelTypeNotFound);
            }

            return new SuccessDataResult<FuelType>(result, Messages.FuelType.FuelTypeListed);

        }

    }
}

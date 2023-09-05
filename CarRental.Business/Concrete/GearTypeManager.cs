using CarRental.Business.Abstract;
using CarRental.Business.Constants;
using CarRental.Core.Utilities.Results;
using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Concrete
{
    public class GearTypeManager : IGearTypeService
    {
        IGearTypeDal _GearTypeDal;

        public GearTypeManager(IGearTypeDal GearTypeDal)
        {
            _GearTypeDal = GearTypeDal;
        }


        public IDataResult<List<GearType>> GetAll()
        {
            var result = _GearTypeDal.GetAll();

            if (!result.Any())
            {
                return new ErrorDataResult<List<GearType>>(Messages.GearType.GearTypeNotFound);
            }

            return new SuccessDataResult<List<GearType>>(result, Messages.GearType.GearTypesListed);
        }

        public IDataResult<GearType> GetById(int GearTypeId)
        {
            var result = _GearTypeDal.Get(b => b.Id == GearTypeId);
            if (result == null)
            {
                return new ErrorDataResult<GearType>(Messages.GearType.GearTypeNotFound);
            }

            return new SuccessDataResult<GearType>(result, Messages.GearType.GearTypeListed);

        }

    }
}

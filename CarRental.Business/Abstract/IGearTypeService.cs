using CarRental.Core.Utilities.Results;
using CarRental.Entities.Concrete;
using System.Collections.Generic;

namespace CarRental.Business.Abstract
{
    public interface IGearTypeService
    {
        IDataResult<List<GearType>> GetAll();
        IDataResult<GearType> GetById(int gearTypeId);

    }
}

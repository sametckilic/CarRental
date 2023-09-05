using CarRental.Core.Utilities.Results;
using CarRental.Entities.Concrete;
using System.Collections.Generic;

namespace CarRental.Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int colorId);

    }
}

using CarRental.Core.Utilities.Results;
using CarRental.DataAccess.Abstract;
using CarRental.Business.Abstract;
using CarRental.Business.Constants;
using CarRental.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.Business.BusinessAspect.Autofac;

namespace ColorRental.Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        [SecuredOperation("admin")]
        public IResult Add(Color color)
        {
            _colorDal.Add(color);

            return new SuccessResult(Messages.Color.ColorAdded);
        }

        [SecuredOperation("admin")]
        public IResult Delete(Color color)
        {
            _colorDal.Delete(color);

            return new SuccessResult(Messages.Color.ColorDeleted);
        }

        [SecuredOperation("admin")]
        public IDataResult<List<Color>> GetAll()
        {
            var result = _colorDal.GetAll();

            if (!result.Any())
            {
                return new ErrorDataResult<List<Color>>(Messages.Color.ColorNotFound);
            }

            return new SuccessDataResult<List<Color>>(result, Messages.Color.ColorsListed);
        }

        [SecuredOperation("admin")]
        public IDataResult<Color> GetById(int colorId)
        {
            var result = _colorDal.Get(b => b.Id == colorId);
            if (result == null)
            {
                return new ErrorDataResult<Color>(Messages.Color.ColorNotFound);
            }

            return new SuccessDataResult<Color>(result, Messages.Color.ColorListed);

        }

        [SecuredOperation("admin")]
        public IResult Update(Color color)
        {
            _colorDal.Update(color);

            return new SuccessResult(Messages.Color.ColorUpdated);
        }
    }
}

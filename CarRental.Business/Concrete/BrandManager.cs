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
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);

            return new SuccessResult(Messages.Brand.BrandAdded);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);

            return new SuccessResult(Messages.Brand.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            var result = _brandDal.GetAll();

            if (!result.Any())
            {
                return new ErrorDataResult<List<Brand>>(Messages.Brand.BrandNotFound);
            }

            return new SuccessDataResult<List<Brand>>(result, Messages.Brand.BrandsListed);
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            var result = _brandDal.Get(b => b.Id == brandId);
            if (result == null)
            {
                return new ErrorDataResult<Brand>(Messages.Brand.BrandNotFound);
            }

            return new SuccessDataResult<Brand>(result, Messages.Brand.BrandListed);

        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);

            return new SuccessResult(Messages.Brand.BrandUpdated);
        }
    }
}

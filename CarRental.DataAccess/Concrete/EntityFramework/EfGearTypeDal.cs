using CarRental.Core.DataAccess.EntityFramework;
using CarRental.DataAccess.Abstract;
using CarRental.Entities.Concrete;

namespace CarRental.DataAccess.Concrete.EntityFramework
{
    public class EfGearTypeDal : EfEntityRepositoryBase<GearType, CarRentalContext>, IGearType
    {

    }

}

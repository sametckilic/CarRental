using Autofac;
using CarRental.Business.Abstract;
using CarRental.Business.Concrete;
using CarRental.DataAccess.Abstract;
using CarRental.DataAccess.Concrete.EntityFramework;
using Castle.DynamicProxy;
using ColorRental.Business.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CarManager>().As<ICarService>();
            builder.RegisterType<EfCarDal>().As<ICarDal>();

            builder.RegisterType<BrandManager>().As<IBrandService>();
            builder.RegisterType<EfBrandDal>().As<IBrandDal>();

            builder.RegisterType<ColorManager>().As<IColorService>();
            builder.RegisterType<EfColorDal>().As<IColorDal>();

            builder.RegisterType<FuelTypeManager>().As<IFuelTypeService>();
            builder.RegisterType<EfFuelTypeDal>().As<IFuelTypeDal>();

            builder.RegisterType<GearTypeManager>().As<IGearTypeService>();
            builder.RegisterType<EfGearTypeDal>().As<IGearTypeDal>();


        }
    }

}
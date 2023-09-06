using CarRental.Business.Constants;
using CarRental.Entities.Concrete;
using Castle.Components.DictionaryAdapter.Xml;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.ModelYear).ExclusiveBetween(new DateTime(2100, 1, 1), new DateTime(1900, 1, 1)).NotNull().WithMessage(Messages.Validation.ChooseCorrectYear);
            RuleFor(c => c.ModelName).Length(1, 25).WithMessage(Messages.Validation.NameTooLong);
            RuleFor(c => c.DailyPrice).GreaterThanOrEqualTo(0).LessThanOrEqualTo(99999).WithMessage(Messages.Validation.DailyPriceBetweenError);
            RuleFor(c => c.DailyPrice).NotNull().WithMessage(Messages.Validation.NotNull);
            RuleFor(c => c.MonthlyPrice).GreaterThanOrEqualTo(0).LessThanOrEqualTo(99999).WithMessage(Messages.Validation.MonthlyPriceBetweenError);
            RuleFor(c => c.MonthlyPrice).NotNull().WithMessage(Messages.Validation.NotNull);
        }
    }
}

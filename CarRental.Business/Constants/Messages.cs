using Autofac;
using CarRental.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Business.Constants
{
    public class Messages
    {

        public static class Car
        {
            public static string CarAdded = "Car added successfully.";
            public static string AllCarsListed = "All cars listed successfully.";
            public static string AllCarsListedByColorId = "All cars listed by Colors";
            public static string AllCarsListedByFuelTypeId = "All cars listed by FuelTypes";
            public static string AllCarsListedByBrandId = "All cars listed by Brands";
            public static string AllCarsListedByGearTypeId = "All cars listed by GearType";
            public static string GetCarDetails = "All cars details listed successfully.";
            public static string AllCarsDetailsListed = "Car details listed succesfully.";
            public static string CarListed = "Car listed successfully.";
            public static string CarUpdated = "Car updated successfully";
            public static string CarsListedByDailyPrice = "Cars listed by daily price successfully";
            public static string CarsListedByMonthlyPrice = "Cars listed by monthly price successfully";
            public static string CarNotFoundError = "Car did not found.";
            public static string CarDeleted = "Car deleted successfully.";
        }

        public static class Brand
        {
            public static string BrandAdded = "Brand added successfully";
            public static string BrandUpdated = "Brand updated successfully";
            public static string BrandDeleted = "Brand deleted successfully";
            public static string BrandNotFound = "Brand not found";
            public static string BrandsListed = "All Brands listed succesfully";
            public static string BrandListed = "Brand listed succesfully";

        }

        public static class Color
        {
            public static string ColorListed = "Color listed succesfully";
            public static string ColorAdded = "Color added successfully";
            public static string ColorUpdated = "Color updated successfully";
            public static string ColorDeleted = "Color deleted successfully";
            public static string ColorNotFound = "Color not found";
            public static string ColorsListed = "All Colors listed succesfully";
        }

        public static class FuelType
        {
            public static string FuelTypeListed = "FuelType listed succesfully";
            public static string FuelTypeAdded = "FuelType added successfully";
            public static string FuelTypeUpdated = "FuelType updated successfully";
            public static string FuelTypeDeleted = "FuelType deleted successfully";
            public static string FuelTypeNotFound = "FuelType not found";
            public static string FuelTypesListed = "All FuelTypes listed succesfully";
        }

        public static class GearType
        {
            public static string GearTypeListed = "GearType listed succesfully";
            public static string GearTypeAdded = "GearType added successfully";
            public static string GearTypeUpdated = "GearType updated successfully";
            public static string GearTypeDeleted = "GearType deleted successfully";
            public static string GearTypeNotFound = "GearType not found";
            public static string GearTypesListed = "All GearTypes listed succesfully";
        }

        public static class Validation
        {
            public static string ChooseCorrectYear = "Please choose correct year";
            public static string NameTooLong = "Name is too long!";
            public static string DailyPriceBetweenError = "Daily price have to beetween 1 - 99999";
            public static string NotNull = "This section can not be empty!";
            public static string MonthlyPriceBetweenError = "Daily price have to beetween 1 - 99999";

        }

        public static class User
        {
            public static string AuthorizationDenied = "Authorization is denied.";
            public static string UserRegistered = "User registered successfuly.";
            public static string UserNotFound = "User did not found.";
            public static string WrongPassword = "Wrong Password";
            public static string SuccessLogin = "Logined succesfully.";
            public static string UserExist = "The user is exist";
            public static string TokenCreated = "Token created succesfully";
        }
    }
}

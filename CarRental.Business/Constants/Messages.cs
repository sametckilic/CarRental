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
    }
}

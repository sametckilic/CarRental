﻿using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.DTOs
{
    public class CarDetailsDto : IDto
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public int BrandId { get; set; }
        public string ModelName { get; set; }
        public string ColorName { get; set; }
        public int ColorId { get; set; }
        public string GearTypeName { get; set; }
        public int GearTypeId { get; set; }
        public string FuelTypeName { get; set; }
        public int FuelTypeId { get; set; }
        public DateTime ModelYear { get; set; }
        public decimal DailyPrice { get; set; }
        public decimal MonthlyPrice { get; set; }
        public bool Status { get; set; }
        public string ImageBase { get; set; }
        public string Description { get; set; }
    }
}

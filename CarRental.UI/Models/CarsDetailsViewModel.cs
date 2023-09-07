using CarRental.Entities.DTOs;
using System.Collections;
using System.Collections.Generic;

namespace CarRental.UI.Models
{
    public class CarsDetailsViewModel
    {
        public List<CarDetailsDto> Cars { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}

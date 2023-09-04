using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Concrete
{
    public class FuelType : IEntity
    {
        public int Id { get; set; }
        public string FuelTypeName { get; set; }
    }
}

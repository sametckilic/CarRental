using CarRental.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities.Concrete
{
    public class Brand : IEntity
    {
        public int? Id { get; set; }

        public string BrandName { get; set; }

        public string BrandLogoBase { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ShippingRate
    {
        public string Id { get; set; }
        public string Country { get; set; }
        public double Rate { get; set; }

    }

    public class Initializare2
    {
        ShippingRate RO = new ShippingRate()
        {
            Id = "01",
            Country = "RO",
            Rate= 1
        };

        ShippingRate UK = new ShippingRate()
        {
            Id = "02",
            Country = "UK",
            Rate = 2
        };

        ShippingRate US = new ShippingRate()
        {
            Id = "03",
            Country = "US",
            Rate = 3
        };
    }
}

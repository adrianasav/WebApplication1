﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Item
    {
        public Product Product { get; set; }
        public ShippingRate ShippingRate { get; set;  }

        public int Quantity { get; set; }
    }
}

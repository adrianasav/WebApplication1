using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {
        
        public string Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Country {get; set; }

    }
    public class Initializare
    {
         Product Mouse = new Product()
         {
                Id="01",
                 Name= "Mouse",
                Price = 10.99,
                Country = "RO"
         };

            

            Product Keyboard = new Product()
            {
                Id = "02",
                Name = "Keyboard",
                Price = 40.99,
                Country = "UK"
            };

            

            Product Monitor = new Product()
            {
                Id = "03",
                Name = "Monitor",
                Price = 164.99,
                Country = "US"
            };

           

            Product Webcam = new Product()
            {
                Id = "04",
                Name = "Webcam",
                Price = 84.99,
                Country = "RO"
            };


            Product Headphones = new Product()
            {
                Id = "05",
                Name = "Headphones",
                Price = 59.99,
                Country = "US"
            };

            

            Product DeskLamp = new Product()
            {
                Id = "06",
                Name = "Desk Lamp",
                Price = 89.99,
                Country = "UK"
            };

        
    }
}

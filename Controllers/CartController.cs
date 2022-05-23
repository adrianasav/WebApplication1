using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace WebApplication1.Controllers
{

    
    
        [Route("cart")]
        public class CartController : Controller
        {
        
        [Route("index")]
            public IActionResult Index()
            {
            
                
                return View();
            }

            

        }
    
}

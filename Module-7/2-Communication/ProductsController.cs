using Microsoft.AspNetCore.Mvc;
using Module7.Models;
using System.Collections.Generic;

namespace Module7.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "Laptop",
                    Price = 50000
                },
                new Product
                {
                    Id = 2,
                    Name = "Keyboard",
                    Price = 1500
                }
            };

            return Ok(products);
        }
    }
}
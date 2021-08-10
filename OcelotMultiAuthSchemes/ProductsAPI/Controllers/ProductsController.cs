using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProductsAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductsAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            int size = 10;
            var products = new List<Product>(size);

            for (int index = 1; index <= size; index++)
            {
                products.Add(new()
                {
                    Id = index,
                    Description = $"Product {index}",
                    CategoryId = index
                });
            }

            return products;
        }
    }
}

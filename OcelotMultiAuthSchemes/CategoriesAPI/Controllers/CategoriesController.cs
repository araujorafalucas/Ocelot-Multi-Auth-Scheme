using CategoriesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CategoriesAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Category>> GetCategories()
        {
            int size = 10;
            var categories = new List<Category>(size);
            
            for (int index = 1; index <= size; index++)
            {
                categories.Add(new()
                {
                    Id = index,
                    Description = $"Category {index}"
                });
            }

            return categories;
        }
    }
}

using APIGateway.Models;
using APIGateway.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace APIGateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        [Route("categories")]
        [AllowAnonymous]
        public ActionResult<AuthToken> GetCategoriesAuthentication([FromBody] AuthUser user)
        {
            if (user.Username != "categories_user" || user.Password != "456")
            {
                return BadRequest(new { message = "Username or Password is invalid" });
            }

            return new CategoriesApiTokenService().GenerateToken(user);
        }

        [HttpPost]
        [Route("products")]
        [AllowAnonymous]
        public ActionResult<AuthToken> GetProductsAuthentication([FromBody] AuthUser user)
        {
            if (user.Username != "products_user" || user.Password != "123")
            {
                return BadRequest(new { message = "Username or Password is invalid" });
            }

            return new ProductsApiTokenService().GenerateToken(user);
        }
    }
}

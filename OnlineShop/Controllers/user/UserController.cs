using Microsoft.AspNetCore.Mvc;
using OnlineShop.Models.Vo;

namespace OnlineShop.Admin.Controllers.user
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class UserController: ControllerBase
    {


        [HttpGet]
        public async Task<IActionResult> GetHello()
        { 

            return Ok("Hello");
        }

    }
}

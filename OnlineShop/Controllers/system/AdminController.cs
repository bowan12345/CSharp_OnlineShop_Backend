using Microsoft.AspNetCore.Mvc;
using OnlineShop.IRepository;
using OnlineShop.Models.ViewModels;

namespace OnlineShop.Admin.Controllers.user
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AdminController: ControllerBase
    {

        private  readonly IAdminRepository adminRepository;

        public AdminController(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetHello()
        {
            var admin = await adminRepository.GetAdminByUsername("admin");
            Console.WriteLine(admin);
            return Ok(admin);
        }

    }
}

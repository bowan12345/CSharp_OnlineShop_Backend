using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Common;
using OnlineShop.IServices;
using OnlineShop.Models.Dto;
using OnlineShop.Models.ViewModels;

namespace OnlineShop.Admin.Controllers.user
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class AdminController: ControllerBase
    {

        private readonly IAdminService adminService;

        public AdminController(IAdminService adminService)
        {
            this.adminService = adminService;
        }

        [Authorize]
        [HttpPost]
        public async Task<ApiResult<AdminVM>> AdminLogin([FromBody]AdminLoginDto adminLoginDto)
        {
            var admin = await adminService.AdminLogin(adminLoginDto);
            if (admin == null)
            {
                return ApiResult<AdminVM>.Failed(null, "Username or Password Incorrect!");
            }
            return new ApiResult<AdminVM>{ Data = admin };
        }

    }
}

using Microsoft.AspNetCore.Identity.Data;
using Microsoft.AspNetCore.Mvc;
using OnlineShop.Common;
using OnlineShop.Configuration;
using OnlineShop.IServices;
using OnlineShop.Models.Dto;
using OnlineShop.Models.Entities;
using OnlineShop.Models.ViewModels;

namespace OnlineShop.Admin.Controllers.System
{
    [ApiController]
    [Route("api/[controller]")] 
    public class AuthController : Controller
    {
        private readonly JWTHelper jwtHelper;
        private readonly IAdminService adminService;

        public AuthController(JWTHelper jwtHelper, IAdminService adminService)
        {
            this.jwtHelper = jwtHelper;
            this.adminService = adminService;
        }

        [HttpPost("login")] 
        public async Task<ApiResult<string>> Login([FromBody] LoginUserDto request)
        {
            var adminLoginDto = new AdminLoginDto();
            adminLoginDto.Username = request.Username;
            adminLoginDto.Password = request.Password;

            var admin = await adminService.AdminLogin(adminLoginDto);
            if (admin == null) 
            {
                return ApiResult<string>.Unauthorized(null);
            }
            var token = jwtHelper.GetToken(request.Username);
            return ApiResult<string>.Success(token);
        }
    }
}

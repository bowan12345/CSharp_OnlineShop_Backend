
using OnlineShop.Models.Dto;
using OnlineShop.Models.ViewModels;

namespace OnlineShop.IServices
{
    public interface IAdminService
    {
        Task<AdminVM> AdminLogin(AdminLoginDto adminLoginDto);
    }
}

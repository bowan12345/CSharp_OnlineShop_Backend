using OnlineShop.Models.Entities;
using OnlineShop.Models.ViewModels;

namespace OnlineShop.IRepository
{
    public interface IAdminRepository
    {
        Task<Admin> GetAdminByUsername(string username);
    }
}

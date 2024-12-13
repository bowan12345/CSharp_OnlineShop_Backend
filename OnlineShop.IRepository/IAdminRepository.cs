using OnlineShop.Models.Entities;
using OnlineShop.Models.Vo;

namespace OnlineShop.IRepository
{
    public interface IAdminRepository
    {
        Task<Admin> GetAdminByUsername(string username);
    }
}

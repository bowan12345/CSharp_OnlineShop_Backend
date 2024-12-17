using Microsoft.EntityFrameworkCore;
using OnlineShop.IRepository;
using OnlineShop.Models.Entities;
using OnlineShop.Models.ViewModels;
using SqlSugar;

namespace OnlineShop.Repository
{
    public class AdminRepository : BaseRepository<Admin>, IAdminRepository
    {
        

        public AdminRepository(SqlSugarScope db):base(db)
        {
           
        }

        public async Task<Admin?> GetAdminByUsername(string username)
        {
            //var admin = await context.FindAsync<AdminVM>(username);
            //var admin = new AdminVM() { Username = "admin", Password = "password" };
            var admin = DbClient.Queryable<Admin>().Where(x => x.Username == username).Single();
            return admin;
        }

        public async Task<Admin?> GetAdminByUsernameAndPassword(string username, string password)
        {
            var admin = await DbClient.Queryable<Admin>().Where(x => x.Username == username && x.Password == password).SingleAsync();
            return admin;
        }
    }
}

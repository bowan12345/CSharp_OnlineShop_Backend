using OnlineShop.IRepository;
using OnlineShop.IServices;
using OnlineShop.Models.Dto;
using OnlineShop.Models.Entities;
using OnlineShop.Models.ViewModels;
using AutoMapper;


namespace OnlineShop.Services
{
    public class AdminService:IAdminService
    {
        private readonly IAdminRepository adminRepository;

        private readonly IMapper mapper;

        public AdminService(IAdminRepository adminRepository, IMapper mapper)
        {
            this.adminRepository = adminRepository;
            this.mapper = mapper;
        }

        public async Task<AdminVM> AdminLogin(AdminLoginDto adminLoginDto)
        {
            var admin =  await adminRepository.GetAdminByUsernameAndPassword(adminLoginDto.Username, adminLoginDto.Password);
            return mapper.Map<AdminVM>(admin);
        }
    }
}

using AutoMapper;
using OnlineShop.Models.Entities;
using OnlineShop.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Configuration
{
    public class AutoMapperConfiguration: Profile
    {
        public AutoMapperConfiguration()
        {
            //CreateMap<SourceType, DestinationType>(); 

            // custom something using AfterMap method
            /*CreateMap<Admin, AdminVM>().AfterMap((from, to, context) => 
            {
                to.Username = from.Username + "we can custom something here";
            });*/


            CreateMap<Admin, AdminVM>();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models.Vo
{
    public record AdminVM
    {
        // username
        public string Username { get; set; }

        // password
        public string Password { get; set; }
    }
}

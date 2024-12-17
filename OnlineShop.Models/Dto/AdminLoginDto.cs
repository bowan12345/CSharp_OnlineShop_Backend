using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models.Dto
{
    public record AdminLoginDto
    {
        public string? Username { get; init; }
        public string? Password { get; init; }
    }
}

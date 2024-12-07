using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models.Entities
{
    public record User
    {
        // user id
        public string Id { get; init; }

        // username
        public string Username { get; init; }

        // password
        public string Password { get; init; }

        // email
        public string Email { get; init; }

        // phone number
        public string Phone { get; init; }

        // question for get password back
        public string? Question { get; init; }

        // answer for get password back
        public string? Answer { get; init; }

        // role: 1 = buyer, 2 = seller
        public int Role { get; init; }
    }
}

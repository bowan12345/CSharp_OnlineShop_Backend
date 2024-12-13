using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models.Entities
{
    public record Address
    {

        // user id
        public string UserId { get; init; }

        // receiver/sender name
        public string Name { get; init; }

        // phone number
        public string Phone { get; init; }

        // role: 1 = buyer, 2 = seller
        public int? Role { get; init; }

        // city
        public string City { get; init; }

        // district
        public string District { get; init; }

        // street
        public string Street { get; init; }

        // postcode
        public string Postcode { get; init; }

    }

}

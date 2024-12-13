using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models.Entities
{
    public record Store
    {

        // seller id
        public string SellerId { get; init; }

        // category id
        public int CategoryId { get; init; }

        // store name
        public string? StoreName { get; init; }

        // store status: 0 = close, 1 = open
        public int? StoreStatus { get; init; }

        // store details
        public string? Detail { get; init; }

    }

}

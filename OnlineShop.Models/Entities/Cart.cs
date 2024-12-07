using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models.Entities
{
    public record Cart
    {
        // cart id
        public string Id { get; init; }

        // product id
        public string ProductId { get; init; }

        // buyer id
        public string? BuyerId { get; init; }

        // store id
        public string? StoreId { get; init; }

        // price
        public decimal? Price { get; init; }

        // quantity of product
        public int? Quantity { get; init; }

        // checked status: 0 = unchecked, 1 = checked
        public int? CheckStatus { get; init; }

    }

}

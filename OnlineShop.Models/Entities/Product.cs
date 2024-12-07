using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models.Entities
{
    public record Product
    {
        // product id
        public string Id { get; init; }

        // category id
        public int CategoryId { get; init; }

        // store id
        public string StoreId { get; init; }

        // product name
        public string Name { get; init; }

        // subtitle name
        public string? Subtitle { get; init; }

        // product details
        public string? Detail { get; init; }

        // product main pic url address
        public string? MainImageUrl { get; init; }

        // product sub pics url address
        public string? SubImagesUrl { get; init; }

        // price
        public decimal Price { get; init; }

        // product storage
        public int Stock { get; init; }

        // product status: 0 = off shelf, 1 = on shelf
        public int ProductStatus { get; init; }

    }

}

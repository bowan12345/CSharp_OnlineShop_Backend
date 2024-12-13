using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models.Entities
{
    public record Category
    {

        // parent id, 0: root
        public int? ParentId { get; init; }

        // category name
        public string? Name { get; init; }

        // category details
        public string? Detail { get; init; }

        // order by number (Reserved Fields)
        public int? OrderBy { get; init; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models.Entities
{
    public record BaseEntity
    {
        // status of availability: 0 = unavailable, 1 = available
        public int Status { get; init; }

        // create time
        public DateTime? CreateTime { get; init; }

        // update time
        public DateTime? UpdateTime { get; init; }
    }
}

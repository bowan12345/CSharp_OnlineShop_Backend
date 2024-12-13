using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models.Entities
{
    public record Order
    {

        // order number
        public long OrderNo { get; init; }

        // buyer id
        public string BuyerId { get; init; }

        // address id
        public string AddressId { get; init; }

        // payment price
        public decimal Payment { get; init; }

        // payment type
        public int? PayType { get; init; }

        // postage
        public int? Postage { get; init; }

        // order status: 
        // 0: cancelled, 
        // 1: unpaid, 
        // 2: paid, 
        // 3: shipped but not received, 
        // 4: received successfully, 
        // 5: transaction closed
        public int? OrderStatus { get; init; }

        // payment time
        public DateTime? PayTime { get; init; }

        // send time
        public DateTime? SendTime { get; init; }

        // received time
        public DateTime? EndTime { get; init; }

        // transaction closed time
        public DateTime? CloseTime { get; init; }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models.Entities
{
    public record TradeInfo
    {
        // trade info id
        public string Id { get; init; }

        // order number
        public long OrderNo { get; init; }

        // buyer id
        public string BuyerId { get; init; }

        // seller id
        public string SellerId { get; init; }

        // payment platform: 1 = AliPay, 2 = Wechatpay, 3 = CreditCard
        public int? TradePlatform { get; init; }

        // transaction serial number
        public string TradeNumber { get; init; }

        // trade status: 0 = failed, 1 = success
        public int TradeStatus { get; init; }

    }

}

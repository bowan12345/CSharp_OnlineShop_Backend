using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Models.Entities
{
    public record BaseEntity
    {

        // id
        public string Id { get; init; }

        // status of availability: 0 = unavailable, 1 = available
        public int Status { get; init; }

        // create time
        [SugarColumn(ColumnName ="Create_Time")]
        public DateTime? CreateTime { get; init; }

        // update time
        [SugarColumn(ColumnName = "Update_Time")]
        public DateTime? UpdateTime { get; init; }
    }
}

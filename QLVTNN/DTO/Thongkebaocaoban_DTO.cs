using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SaleStatisticsDTO
    {
        public string ProductName { get; set; }
        public int QuantitySold { get; set; }
        public int TotalRevenue { get; set; }
        public decimal ProductPrice { get; set; }
        // Các thuộc tính khác nếu cần
    }

}

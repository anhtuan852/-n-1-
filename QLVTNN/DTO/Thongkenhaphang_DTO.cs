using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ImportStatisticsDTO
    {
        public string ProductName { get; set; }
        public int QuantityImported { get; set; }
        public int TotalAmount { get; set; }
        // Các thuộc tính khác nếu cần
    }
}

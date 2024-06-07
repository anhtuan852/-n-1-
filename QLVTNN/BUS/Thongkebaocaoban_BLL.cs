using System;
using System.Collections.Generic;
using DAO;
using DTO;

namespace BLL
{
    public class SaleBLL
    {
        private SaleDAL saleDAL;

        public SaleBLL(string connectionString)
        {
            this.saleDAL = new SaleDAL(connectionString);
        }

        public List<SaleStatisticsDTO> GetSalesStatistics(DateTime startDate, DateTime endDate)
        {
            return saleDAL.GetSalesStatistics(startDate, endDate);
        }
    }
}

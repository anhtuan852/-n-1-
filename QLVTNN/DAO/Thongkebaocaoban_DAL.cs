using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAO
{
    public class SaleDAL
    {
        private string connectionString;

        public SaleDAL(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public List<SaleStatisticsDTO> GetSalesStatistics(DateTime startDate, DateTime endDate)
        {
            List<SaleStatisticsDTO> statistics = new List<SaleStatisticsDTO>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT sp.tensp, SUM(tthd.soluong) AS QuantitySold, SUM(tthd.thanhtien) AS TotalRevenue
                             FROM Sanpham sp
                             JOIN thongtinhoadon tthd ON sp.masp = tthd.masp
                             JOIN Hoadon hd ON tthd.idhd = hd.mahd
                             WHERE hd.ngaygd BETWEEN @StartDate AND @EndDate
                             GROUP BY sp.tensp";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    SaleStatisticsDTO statistic = new SaleStatisticsDTO();
                    statistic.ProductName = reader["tensp"].ToString();
                    statistic.QuantitySold = Convert.ToInt32(reader["QuantitySold"]);
                    statistic.TotalRevenue = Convert.ToInt32(reader["TotalRevenue"]);
                    statistics.Add(statistic);
                }
                reader.Close();
            }

            return statistics;
        }
    }
}
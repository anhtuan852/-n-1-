using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;

public class ImportDAL
{
    private string connectionString;

    public ImportDAL(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public List<ImportStatisticsDTO> GetImportStatistics(DateTime startDate, DateTime endDate)
    {
        List<ImportStatisticsDTO> statistics = new List<ImportStatisticsDTO>();

        try
        {
            using (SqlConnection connection = DataProvider.MoKetNoi()) // Sử dụng phương thức MoKetNoi từ lớp DataProvider
            {
                string query = @"SELECT sp.tensp, SUM(nh.soluong) AS QuantityImported, SUM(nh.tong) AS TotalAmount
                                 FROM Sanpham sp
                                 JOIN Nhaphang nh ON sp.masp = nh.masp
                                 WHERE nh.ngaynhap BETWEEN @StartDate AND @EndDate
                                 GROUP BY sp.tensp";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ImportStatisticsDTO statistic = new ImportStatisticsDTO();
                    statistic.ProductName = reader["tensp"].ToString();
                    statistic.QuantityImported = Convert.ToInt32(reader["QuantityImported"]);
                    statistic.TotalAmount = Convert.ToInt32(reader["TotalAmount"]);
                    statistics.Add(statistic);
                }
                reader.Close();
            }
        }
        catch (Exception ex)
        {
            // Xử lý lỗi nếu cần thiết
            Console.WriteLine("Error: " + ex.Message);
        }

        return statistics;
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class DataProvider
    {
        public static SqlConnection MoKetNoi()
        {
            //desktop-5ol6p9r\sqlexpress2019
            //(local)\SQLEXPRESS
            SqlConnection KetNoi = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLVLXD;Integrated Security=True");
            KetNoi.Open();
            return KetNoi;
        }
        public static SqlConnection DongKetNoi()
        {
            SqlConnection KetNoi = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=QLVLXD;Integrated Security=True");
            KetNoi.Close();
            return KetNoi;
        }
        public static DataTable LayDuLieu(string truyvan, SqlConnection KetNoi)
        {
            SqlDataAdapter da = new SqlDataAdapter(truyvan, KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public static bool KLayDuLieu(string truyvan, SqlConnection Ketoi)
        {
            try
            {
                SqlCommand cm = new SqlCommand(truyvan, Ketoi);
                cm.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static int TruyVanLayGiaTriINT(string truyvan, SqlConnection Ketnoi)
        {
            try
            {
                SqlCommand cm = new SqlCommand(truyvan, Ketnoi);
                int GiaTri = Convert.ToInt32(cm.ExecuteScalar());
                return GiaTri;
            }
            catch (Exception)
            {
                return -1;
            }
        }
    }
}

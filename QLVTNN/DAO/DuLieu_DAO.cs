using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class DuLieu_DAO
    {
        static SqlConnection con;
        public static bool SaoLuuDuLieu(string duongdan)
        {
            string ten = "\\QLVLXD(" + DateTime.Now.Day.ToString() + "_" +
            DateTime.Now.Month.ToString() + "_" +
            DateTime.Now.Year.ToString() + "_" +
            DateTime.Now.Hour.ToString() + "_" +
            DateTime.Now.Minute.ToString() + ").bak";
            string sql = "BACKUP DATABASE QLVLXD TO DISK = N'" + duongdan + ten + "'";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(sql, con);
            con = DataProvider.DongKetNoi();
            return kq;

        }
        public static bool PhuHoi(string duongdan)
        {
            try 
            {
                con = DataProvider.MoKetNoi();
                SqlCommand cmd1 = new SqlCommand("ALTER DATABASE QLVLXD SET SINGLE_USER WITH ROLLBACK IMMEDIATE ", con);
                cmd1.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("USE MASTER RESTORE DATABASE QLVLXD FROM DISK='" + duongdan + "' WITH REPLACE", con);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand("ALTER DATABASE QLVLXD SET MULTI_USER", con);
                cmd3.ExecuteNonQuery();
                con.Close();
                return true;
                /*
                con = DataProvider.DongKetNoi();
                string sql = "USE master ALTER DATABASE QLVLXD SET SINGLE_USER WITH ROLLBACK IMMEDIATE Restore database QLVLXD from disk = N'"+duongdan+"'";
                SqlConnection ketnoi = new SqlConnection(@"Data Source =.\sqlexpress; Initial Catalog = master; Integrated Security = True");
                SqlCommand cm = new SqlCommand(sql, ketnoi);
                cm.ExecuteNonQuery();
                return true;
                */
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

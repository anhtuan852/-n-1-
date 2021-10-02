using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAO
{
    public class Loai_DAO
    {
        static SqlConnection con;
        public static List<Loai_DTO> LayLoai()
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from Loai", con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<Loai_DTO> lstLoai = new List<Loai_DTO>();
            for(int i=0; i < dt.Rows.Count; i++)
            {
                Loai_DTO loai = new Loai_DTO();
                loai.Maloai = dt.Rows[i]["maloai"].ToString();
                loai.Tenloai = dt.Rows[i]["tenloai"].ToString();
                lstLoai.Add(loai);
            }
            con = DataProvider.DongKetNoi();
            return lstLoai;
        }
        public static bool Them(string ma, string ten)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"insert into Loai values(N'"+ma+"', N'"+ten+"')", con); 
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool Sua(string ma, string maedit, string ten)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update Loai set maloai = N'"+maedit+"', tenloai = N'"+ten+"' where maloai = '"+ma+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool Xoa(string ma)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"delete Loai where maloai = '"+ma+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static List<Loai_DTO> Tim(string ma)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from Loai where maloai = N'"+ma+"'", con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<Loai_DTO> lstLoai = new List<Loai_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Loai_DTO loai = new Loai_DTO();
                loai.Maloai = dt.Rows[i]["maloai"].ToString();
                loai.Tenloai = dt.Rows[i]["tenloai"].ToString();
                lstLoai.Add(loai);
            }
            con = DataProvider.DongKetNoi();
            return lstLoai;
        }
    }
}

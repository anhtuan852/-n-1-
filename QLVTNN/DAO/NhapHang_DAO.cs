using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class NhapHang_DAO
    {
        static SqlConnection con;
        public static List<NhapHang_DTO> GetNhapHang()
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from NhapHang", con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhapHang_DTO> lstNhapHang = new List<NhapHang_DTO>();
            for(int i=0; i < dt.Rows.Count; i++)
            {
                NhapHang_DTO nh = new NhapHang_DTO();
                nh.Id =Convert.ToInt32(dt.Rows[i]["id"].ToString());
                nh.Masp = dt.Rows[i]["masp"].ToString();
                nh.Tensp = dt.Rows[i]["tensp"].ToString();
                nh.Soluong = Convert.ToInt32(dt.Rows[i]["soluong"].ToString());
                nh.Ngaynhap = Convert.ToDateTime(dt.Rows[i]["ngaynhap"].ToString());
                nh.Manv = dt.Rows[i]["manv"].ToString();
                nh.Dvtinh = dt.Rows[i]["dvtinh"].ToString();
                nh.Gia =Convert.ToInt32(dt.Rows[i]["giaban"].ToString());
                nh.Tong = Convert.ToInt32(dt.Rows[i]["tong"].ToString());
                lstNhapHang.Add(nh);
            }
            con = DataProvider.DongKetNoi();
            return lstNhapHang;
        }
        public static bool Them(NhapHang_DTO nh)
        {
            string truyvan = string.Format(@"insert into Nhaphang values(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}')", nh.Masp, nh.Tensp, nh.Soluong,  nh.Ngaynhap, nh.Manv, nh.Dvtinh, nh.Gia, nh.Tong);
            try
            {
                con = DataProvider.MoKetNoi();
                SqlCommand cm = new SqlCommand(truyvan, con);
                cm.ExecuteReader();
                DataProvider.DongKetNoi();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static int GetID()
        {
            con = DataProvider.MoKetNoi();
            int kq = DataProvider.TruyVanLayGiaTriINT(@"select id from NhapHang where id = (select max(id) from NhapHang)", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static List<NhapHang_DTO> Xem(string start, string end)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from nhaphang where ngaynhap >= '" + start + "' and ngaynhap <= '" + end + "'", con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhapHang_DTO> lstNhapHang = new List<NhapHang_DTO>();
            for(int i=0; i<dt.Rows.Count; i++)
            {
                NhapHang_DTO n = new NhapHang_DTO();
                n.Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                n.Masp = dt.Rows[i]["masp"].ToString();
                n.Tensp = dt.Rows[i]["tensp"].ToString();
                n.Soluong = Convert.ToInt32(dt.Rows[i]["soluong"].ToString());
                n.Ngaynhap = Convert.ToDateTime(dt.Rows[i]["ngaynhap"].ToString());
                n.Manv = dt.Rows[i]["manv"].ToString();
                n.Dvtinh = dt.Rows[i]["dvtinh"].ToString();
                n.Gia = Convert.ToInt32(dt.Rows[i]["giaban"].ToString());
                n.Tong = Convert.ToInt32(dt.Rows[i]["tong"].ToString());
                lstNhapHang.Add(n);
            }
            con = DataProvider.DongKetNoi();
            return lstNhapHang;
        }
        public static bool Delete()
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"delete nhaphang", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
    }
}

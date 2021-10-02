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
    public class KhachHang_DAO
    {
        static SqlConnection con;
        public static List<KhachHang_DTO> GetKhachHangAll()
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu("select * from Khachhang", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> lstKhachHang = new List<KhachHang_DTO>();
            for(int i=0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.Makh = dt.Rows[i]["makh"].ToString();
                kh.Tenkh = dt.Rows[i]["tenkh"].ToString();
                kh.Sdt = dt.Rows[i]["sdt"].ToString();
                kh.Ngaysinh =Convert.ToDateTime(dt.Rows[i]["ngaysinh"].ToString());
                kh.Diachi = dt.Rows[i]["diachi"].ToString();
                kh.Tthai = dt.Rows[i]["tthai"].ToString();
                kh.Congno = Convert.ToInt32(dt.Rows[i]["congno"].ToString());
                kh.Tongmua = Convert.ToInt32(dt.Rows[i]["tongmua"].ToString());
                lstKhachHang.Add(kh);
            }
            con = DataProvider.DongKetNoi();
            return lstKhachHang;
        }
        public static List<KhachHang_DTO> GetKhachHang()
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu("select * from Khachhang where tthai = N'Bật'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> lstKhachHang = new List<KhachHang_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.Makh = dt.Rows[i]["makh"].ToString();
                kh.Tenkh = dt.Rows[i]["tenkh"].ToString();
                kh.Sdt = dt.Rows[i]["sdt"].ToString();
                kh.Ngaysinh = Convert.ToDateTime(dt.Rows[i]["ngaysinh"].ToString());
                kh.Diachi = dt.Rows[i]["diachi"].ToString();
                kh.Tthai = dt.Rows[i]["tthai"].ToString();
                kh.Congno = Convert.ToInt32(dt.Rows[i]["congno"].ToString());
                kh.Tongmua = Convert.ToInt32(dt.Rows[i]["tongmua"].ToString());
                lstKhachHang.Add(kh);
            }
            con = DataProvider.DongKetNoi();
            return lstKhachHang;
        }
        public static bool UpdateNoGiam(string makd, float No)
        {
            string truyvan = string.Format(@"update Khachhang set congno -= '" + No + "' where makh = '" + makd + "'");
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(truyvan, con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool UpdateNoTang(string makh, float No)
        {
            string truyvan = string.Format(@"update Khachhang set congno += '" + No + "' where makh = '" + makh + "'");
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(truyvan, con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool CapNhatTong(string makh, int tong)
        {
            string truyvan = string.Format(@"update Khachhang set tongmua += '" + tong + "' where makh = '" + makh + "'");
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(truyvan, con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static string GetSDTbyIDKH(string makh)
        {
            string truyvan = @"select k.sdt from Khachhang k where makh = '" + makh + "'";
            con = DataProvider.MoKetNoi();
            SqlCommand cm = new SqlCommand(truyvan, con);
            string kq = (cm.ExecuteScalar()).ToString();
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static string GetAddressbyIDKH(string makh)
        {
            string truyvan = @"select k.diachi from Khachhang k where makh = '" + makh + "'";
            con = DataProvider.MoKetNoi();
            SqlCommand cm = new SqlCommand(truyvan, con);
            string kq = (cm.ExecuteScalar()).ToString();
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static int GetCongNo(string makh)
        {
            con = DataProvider.MoKetNoi();
            SqlCommand cm = new SqlCommand(@"select k.congno from khachhang k where makh = '" + makh + "'", con);
            int kq =Convert.ToInt32(cm.ExecuteScalar());
            con = DataProvider.DongKetNoi();
            return kq;
        }

        public static List<KhachHang_DTO> TimKhachHangTheoMa(string makh)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu("select * from Khachhang where makh = '"+makh+"'", con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> listKh = new List<KhachHang_DTO>();
            for(int i=0; i< dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.Makh = dt.Rows[i]["makh"].ToString();
                kh.Tenkh = dt.Rows[i]["tenkh"].ToString();
                kh.Sdt = dt.Rows[i]["sdt"].ToString();
                kh.Ngaysinh =Convert.ToDateTime(dt.Rows[i]["ngaysinh"].ToString());
                kh.Diachi = dt.Rows[i]["diachi"].ToString();
                kh.Congno =Convert.ToInt32(dt.Rows[i]["congno"].ToString());
                listKh.Add(kh);
            }
            con = DataProvider.DongKetNoi();
            return listKh;
        }
        public static List<KhachHang_DTO> TimKhachHang(string text)
        {
            //select * from khachhang where makh like N'%bùi%' or tenkh like N'%bùi%'
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from Khachhang where makh like N'%" + text + "%' or tenkh like N'%"+text+"%'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<KhachHang_DTO> listkhachhang = new List<KhachHang_DTO>();
            for(int i=0;i<dt.Rows.Count; i++)
            {
                KhachHang_DTO kh = new KhachHang_DTO();
                kh.Makh = dt.Rows[i]["makh"].ToString();
                kh.Tenkh = dt.Rows[i]["tenkh"].ToString();
                kh.Sdt = dt.Rows[i]["sdt"].ToString();
                kh.Ngaysinh =Convert.ToDateTime(dt.Rows[i]["ngaysinh"].ToString());
                kh.Diachi = dt.Rows[i]["diachi"].ToString();
                kh.Congno =Convert.ToInt32(dt.Rows[i]["congno"].ToString());
                listkhachhang.Add(kh);
            }
            con = DataProvider.DongKetNoi();
            return listkhachhang;
        }

        public static bool AddKhachHang(string makh, string tenkh, string sdt, DateTime ngaysinh, string diachi)
        {
            string truyvan = @"insert into Khachhang values ('"+makh+"', N'"+tenkh+"','"+sdt+"', '"+ngaysinh+"', N'"+diachi+"', N'Bật', 0, 0)";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(truyvan, con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool Edit(string makh, string ten, string sdt, DateTime ngaysinh, string diachi)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update khachhang set tenkh = N'"+ten+"', sdt = '"+sdt+"', ngaysinh = '"+ngaysinh+"', diachi = N'"+diachi+"' where makh = '"+makh+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool Tat(string makh)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update Khachhang set tthai = N'Tắt' where makh = '"+makh+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool Bat(string makh)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update Khachhang set tthai = N'Bật' where makh = '" + makh + "'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool Delete(string makh)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"delete from khachhang where makh = '"+makh+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static int SLKH()
        {
            con = DataProvider.MoKetNoi();
            int kq = DataProvider.TruyVanLayGiaTriINT(@"select count(makh) from khachhang", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static string GetName(string makh)
        {
            con = DataProvider.MoKetNoi();
            SqlCommand cm = new SqlCommand(@"select tenkh from khachhang where makh = '"+makh+"'", con);
            string kq = cm.ExecuteScalar().ToString();
            con = DataProvider.DongKetNoi();
            return kq;
        }

    }
}

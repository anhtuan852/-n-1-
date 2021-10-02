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
    public class HoaDon_DAO
    {
        static SqlConnection con;
        public static List<HoaDon_DTO> GetHoaDon()
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu("select * from Hoadon", con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lst = new List<HoaDon_DTO>();
            for(int i=0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.Mahd = Convert.ToInt32(dt.Rows[i]["mahd"].ToString());
                hd.Manv = dt.Rows[i]["manv"].ToString();
                hd.Makh = dt.Rows[i]["makh"].ToString();
                hd.Ngaygd = DateTime.Parse(dt.Rows[i]["ngaygd"].ToString());
                hd.Tonghd =Convert.ToInt32(dt.Rows[i]["tonghd"].ToString());
                hd.Tra = Convert.ToInt32(dt.Rows[i]["tra"].ToString());
                hd.Conlai = Convert.ToInt32(dt.Rows[i]["conlai"].ToString());
                hd.Tthai = dt.Rows[i]["tthai"].ToString();
                lst.Add(hd);
            }
            con = DataProvider.DongKetNoi();
            return lst;
        }
        public static int GetSLHD()
        {
            try
            {
                con = DataProvider.MoKetNoi();
                SqlCommand cm = new SqlCommand(@"select mahd from Hoadon where mahd = (select max(mahd) from Hoadon)", con);
                int id = Convert.ToInt32(cm.ExecuteScalar());
                con = DataProvider.DongKetNoi();
                return id;
            }
            catch (Exception)
            {
                return -1;
            }
            
        }
        public static bool ThemHD(int mahd, string manv, string makh, DateTime ngaygd, int tonghd, int tra, int conlai, string tthai)
        {
            string struyvan =@"insert into Hoadon values (N'"+mahd+@"', N'"+manv+@"', N'"+makh+@"', N'"+ngaygd+@"', N'"+tonghd+@"', '"+tra+"', '"+conlai+"', N'"+tthai+"')";
            try
            {
                con = DataProvider.MoKetNoi();
                SqlCommand cm = new SqlCommand(struyvan, con);
                cm.ExecuteReader();
                con = DataProvider.DongKetNoi();
                return true;
            }
            catch(Exception)
            {
                return false;
            } 
        }
        public static List<HoaDon_DTO> GetHDByIDKH(string makh)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select h.* from Hoadon h, khachhang kh where h.makh = kh.makh and kh.makh = '"+makh+"'", con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lsthd = new List<HoaDon_DTO>();
            for(int i=0; i< dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.Mahd = Convert.ToInt32(dt.Rows[i]["mahd"].ToString());
                hd.Manv = dt.Rows[i]["manv"].ToString();
                hd.Makh = dt.Rows[i]["makh"].ToString();
                hd.Ngaygd = Convert.ToDateTime(dt.Rows[i]["ngaygd"].ToString());
                hd.Tonghd =Convert.ToInt32(dt.Rows[i]["tonghd"].ToString());
                hd.Tra = Convert.ToInt32(dt.Rows[i]["tra"].ToString());
                hd.Conlai = Convert.ToInt32(dt.Rows[i]["conlai"].ToString());
                hd.Tthai = dt.Rows[i]["tthai"].ToString();
                lsthd.Add(hd);
            }
            con = DataProvider.DongKetNoi();
            return lsthd;
        }
        public static List<HoaDon_DTO> GetHDByIDKHChuaTT(string makh)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select h.* from Hoadon h, khachhang kh where h.makh = kh.makh and h.tthai= N'Chưa thanh toán' and kh.makh = '" + makh + "'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lsthd = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.Mahd = Convert.ToInt32(dt.Rows[i]["mahd"].ToString());
                hd.Manv = dt.Rows[i]["manv"].ToString();
                hd.Makh = dt.Rows[i]["makh"].ToString();
                hd.Ngaygd = Convert.ToDateTime(dt.Rows[i]["ngaygd"].ToString());
                hd.Tonghd = Convert.ToInt32(dt.Rows[i]["tonghd"].ToString());
                hd.Tra = Convert.ToInt32(dt.Rows[i]["tra"].ToString());
                hd.Conlai = Convert.ToInt32(dt.Rows[i]["conlai"].ToString());
                hd.Tthai = dt.Rows[i]["tthai"].ToString();
                lsthd.Add(hd);
            }
            con = DataProvider.DongKetNoi();
            return lsthd;
        }
        public static List<HoaDon_DTO> GetHDChuathanhtoanbtKH(string makh)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select h.* from Hoadon h, khachhang kh where h.makh = kh.makh and kh.makh = '" + makh + "' and h.tthai= 'Chưa thanh toán'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lsthd = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.Mahd = Convert.ToInt32(dt.Rows[i]["mahd"].ToString());
                hd.Manv = dt.Rows[i]["manv"].ToString();
                hd.Makh = dt.Rows[i]["makh"].ToString();
                hd.Ngaygd = Convert.ToDateTime(dt.Rows[i]["ngaygd"].ToString());
                hd.Tonghd = Convert.ToInt32(dt.Rows[i]["tonghd"].ToString());
                hd.Tra = Convert.ToInt32(dt.Rows[i]["tra"].ToString());
                hd.Conlai = Convert.ToInt32(dt.Rows[i]["conlai"].ToString());
                hd.Tthai = dt.Rows[i]["tthai"].ToString();
                lsthd.Add(hd);
            }
            con = DataProvider.DongKetNoi();
            return lsthd;
        }
        public static List<HoaDon_DTO> GetIDHDByIDKH(string makh)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select h.mahd from Hoadon h where makh = '"+makh+"'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> listhd = new List<HoaDon_DTO>();
            for(int i=0; i<dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.Mahd = Convert.ToInt32(dt.Rows[i]["mahd"].ToString());
                listhd.Add(hd);
            }
            con = DataProvider.DongKetNoi();
            return listhd;
        }

        public static List<HoaDon_DTO> GetHDByIDNhanVien(string manv)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select h.* from Hoadon h, nhanvien nv where h.manv = nv.manv and nv.manv = '" + manv + "'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lsthdnv = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.Mahd = Convert.ToInt32(dt.Rows[i]["mahd"].ToString());
                hd.Manv = dt.Rows[i]["manv"].ToString();
                hd.Makh = dt.Rows[i]["makh"].ToString();
                hd.Ngaygd = Convert.ToDateTime(dt.Rows[i]["ngaygd"].ToString());
                hd.Tonghd = Convert.ToInt32(dt.Rows[i]["tonghd"].ToString());
                hd.Tra = Convert.ToInt32(dt.Rows[i]["tra"].ToString());
                hd.Conlai = Convert.ToInt32(dt.Rows[i]["conlai"].ToString());
                hd.Tthai = dt.Rows[i]["tthai"].ToString();
                lsthdnv.Add(hd);
            }
            con = DataProvider.DongKetNoi();
            return lsthdnv;
        }
        public static List<HoaDon_DTO> GetHDByIDHoaDon(int mahd)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from Hoadon where mahd = '" + mahd + "'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lsthd = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.Mahd = Convert.ToInt32(dt.Rows[i]["mahd"].ToString());
                hd.Manv = dt.Rows[i]["manv"].ToString();
                hd.Makh = dt.Rows[i]["makh"].ToString();
                hd.Ngaygd = Convert.ToDateTime(dt.Rows[i]["ngaygd"].ToString());
                hd.Tonghd = Convert.ToInt32(dt.Rows[i]["tonghd"].ToString());
                hd.Tra = Convert.ToInt32(dt.Rows[i]["tra"].ToString());
                hd.Conlai = Convert.ToInt32(dt.Rows[i]["conlai"].ToString());
                hd.Tthai = dt.Rows[i]["tthai"].ToString();
                lsthd.Add(hd);
            }
            con = DataProvider.DongKetNoi();
            return lsthd;
        }
        
        public static List<HoaDon_DTO> XemHoaDon(string checkin, string checkout)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select *from Hoadon where ngaygd >= '"+checkin+"' and ngaygd <= '"+checkout+"'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> lstHoaDon = new List<HoaDon_DTO>();
            for(int i=0;i<dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.Mahd = Convert.ToInt32(dt.Rows[i]["mahd"].ToString());
                hd.Manv = dt.Rows[i]["manv"].ToString();
                hd.Makh = dt.Rows[i]["makh"].ToString();
                hd.Ngaygd = DateTime.Parse(dt.Rows[i]["ngaygd"].ToString());
                hd.Tonghd = Convert.ToInt32(dt.Rows[i]["tonghd"].ToString());
                hd.Tra = Convert.ToInt32(dt.Rows[i]["tra"].ToString());
                hd.Conlai = Convert.ToInt32(dt.Rows[i]["conlai"].ToString());
                hd.Tthai = dt.Rows[i]["tthai"].ToString();
                lstHoaDon.Add(hd);
            }
            con = DataProvider.DongKetNoi();
            return lstHoaDon;
        }
        public static bool EditTthai(string mahd, int conlai, string tthai)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update Hoadon set tra += '"+conlai+"', conlai = 0, tthai = N'" + tthai + "' where mahd = '" + mahd + "'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool EditThanhToan(string mahd, int tra, int conlai, string tthai)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update Hoadon set tra += '" + tra + "', conlai = '"+conlai+"', tthai = N'" + tthai + "' where mahd = '" + mahd + "'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
    }
}

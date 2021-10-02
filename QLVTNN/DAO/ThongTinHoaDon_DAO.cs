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
    public class ThongTinHoaDon_DAO
    {
        static SqlConnection con;
        public static int GetIDThongTinHoaDon()
        {
            con = DataProvider.MoKetNoi();
            int id = Convert.ToInt32(DataProvider.TruyVanLayGiaTriINT("select count(tt.id) from thongtinhoadon tt", con));
            return id;
        }
        public static bool ThemTTHoaDon(ThongTinHoaDon_DTO tt)
        {
            string truyvan = string.Format(@"insert into Thongtinhoadon values(N'{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', N'{7}')", tt.Loaisp, tt.Masp, tt.Tensp, tt.Dvtinh, tt.Gia, tt.Soluong, tt.Thanhtien, tt.Idhd);
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
        public static bool ThemTTHoaDon2(int id, string lsp, string masp, string tensp, string dvt, int gia, int sl, int thanhtien, int idhd)
        {
            string truyvan = @"insert into Thongtinhoadon values('"+id+"', N'"+lsp+"', N'"+masp+"', N'"+tensp+"', N'"+dvt+"', N'"+ gia + "', N'"+sl+"', N'"+thanhtien+"', N'"+idhd+"')";
            try
            {
                con = DataProvider.MoKetNoi();
                SqlCommand cm = new SqlCommand(truyvan, con);
                cm.ExecuteReader();
                con = DataProvider.DongKetNoi();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static List<ThongTinHoaDon_DTO> GetThongTinHDByIDHD(int mahd)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select tt.* from hoadon h, thongtinhoadon tt where h.mahd = tt.idhd and h.mahd = '"+mahd+"'", con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<ThongTinHoaDon_DTO> lsttthd = new List<ThongTinHoaDon_DTO>();
            for(int i=0; i < dt.Rows.Count; i++)
            {
                ThongTinHoaDon_DTO tt = new ThongTinHoaDon_DTO();
                tt.Id =Convert.ToInt32(dt.Rows[i]["id"].ToString());
                tt.Loaisp = dt.Rows[i]["loaisp"].ToString();
                tt.Masp = dt.Rows[i]["masp"].ToString();
                tt.Tensp = dt.Rows[i]["tensp"].ToString();
                tt.Dvtinh = dt.Rows[i]["dvtinh"].ToString();
                tt.Gia =Convert.ToInt32(dt.Rows[i]["giaban"].ToString());
                tt.Soluong =Convert.ToInt32(dt.Rows[i]["soluong"].ToString());
                tt.Thanhtien =Convert.ToInt32(dt.Rows[i]["thanhtien"].ToString());
                tt.Idhd = Convert.ToInt32(dt.Rows[i]["idhd"].ToString());
                lsttthd.Add(tt);
            }
            return lsttthd;
        }
        public static List<ThongTinHoaDon_DTO> GetThongTinHDByIDNhanVien(string manv)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select tt.* from hoadon h, thongtinhoadon tt where h.mahd = tt.idhd and h.mahd = '" + manv + "'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ThongTinHoaDon_DTO> lsttthdnv = new List<ThongTinHoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ThongTinHoaDon_DTO tt = new ThongTinHoaDon_DTO();
                tt.Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                tt.Loaisp = dt.Rows[i]["loaisp"].ToString();
                tt.Masp = dt.Rows[i]["masp"].ToString();
                tt.Tensp = dt.Rows[i]["tensp"].ToString();
                tt.Dvtinh = dt.Rows[i]["dvtinh"].ToString();
                tt.Gia = Convert.ToInt32(dt.Rows[i]["giaban"].ToString());
                tt.Soluong = Convert.ToInt32(dt.Rows[i]["soluong"].ToString());
                tt.Thanhtien = Convert.ToInt32(dt.Rows[i]["thanhtien"].ToString());
                tt.Idhd = Convert.ToInt32(dt.Rows[i]["idhd"].ToString());
                lsttthdnv.Add(tt);
            }
            return lsttthdnv;
        }
        public static bool Delete(int idhd)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"delete thongtinhoadon where idhd = '"+idhd+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool DleteByIDHD(int idhd)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"delete thongtinhoadon where idhd = '"+idhd+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
    }
}

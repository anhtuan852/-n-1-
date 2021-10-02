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
    public class HangHoa_DAO
    {
        static SqlConnection con;
        public static List<HangHoa_DTO> GetHangHoa()
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu("select * from Sanpham", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HangHoa_DTO> lstHangHoa = new List<HangHoa_DTO>();
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.Masp = dt.Rows[i]["masp"].ToString();
                hh.Tensp = dt.Rows[i]["tensp"].ToString();
                hh.Soluong =Convert.ToInt32(dt.Rows[i]["soluong"].ToString());
                hh.Idloai = dt.Rows[i]["idloai"].ToString();
                hh.Dvtinh = dt.Rows[i]["dvtinh"].ToString();
                hh.Giamua = Convert.ToInt32(dt.Rows[i]["giamua"].ToString());
                hh.Giaban = Convert.ToInt32(dt.Rows[i]["giaban"].ToString());
                hh.Ttrang = dt.Rows[i]["ttrang"].ToString();
                lstHangHoa.Add(hh);
            }
            con = DataProvider.DongKetNoi();
            return lstHangHoa;
        }
        public static List<HangHoa_TMP> GetHangHoa_TMP()
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu("select masp, tensp, idloai, soluong, dvtinh, giaban from Sanpham", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HangHoa_TMP> lstHangHoa = new List<HangHoa_TMP>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HangHoa_TMP hh = new HangHoa_TMP();
                hh.Masp = dt.Rows[i]["masp"].ToString();
                hh.Tensp = dt.Rows[i]["tensp"].ToString();
                hh.Soluong = Convert.ToInt32(dt.Rows[i]["soluong"].ToString());
                hh.Idloai = dt.Rows[i]["idloai"].ToString();
                hh.Dvtinh = dt.Rows[i]["dvtinh"].ToString();
                hh.Giaban = Convert.ToInt32(dt.Rows[i]["giaban"].ToString());
                lstHangHoa.Add(hh);
            }
            con = DataProvider.DongKetNoi();
            return lstHangHoa;
        }

        public static List<HangHoa_DTO> GetHangHoaByID(string id)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu("select * from Sanpham where idloai = '" + id + "'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HangHoa_DTO> lstHangHoa = new List<HangHoa_DTO>();
            for(int i=0; i < dt.Rows.Count; i++)
            {
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.Masp = dt.Rows[i]["masp"].ToString();
                hh.Tensp = dt.Rows[i]["tensp"].ToString();
                hh.Giaban =Convert.ToInt32(dt.Rows[i]["giaban"].ToString());
                hh.Dvtinh = dt.Rows[i]["dvtinh"].ToString();
                lstHangHoa.Add(hh);
            }
            con = DataProvider.DongKetNoi();
            return lstHangHoa;
        }
        public static int GetSLHangHoaByIDSP(string masp)
        {
            con = DataProvider.MoKetNoi();
            int giatri = DataProvider.TruyVanLayGiaTriINT("select s.soluong from Sanpham s where masp = '" + masp + "'", con);
            con = DataProvider.DongKetNoi();
            return giatri;
        }
        public static bool CapNhatSLGiam(string masp, int sl)
        {
            string truyvan = @"Update sanpham set soluong -= '" + sl + "' where masp = '" + masp + "'";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(truyvan, con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool CapNhatSLTang(string masp, int sl)
        {
            string truyvan = @"update sanpham set soluong += '" + sl + "' where masp = '" + masp + "'";
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(truyvan, con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static List<HangHoa_TMP> GetHangHoaHet()
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select masp, tensp, idloai, soluong, dvtinh, giaban from sanpham where soluong <= '5'", con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<HangHoa_TMP> lstHangHoa = new List<HangHoa_TMP>();
            for(int i=0; i<dt.Rows.Count;i++)
            {
                HangHoa_TMP hh = new HangHoa_TMP();
                hh.Masp = dt.Rows[i]["masp"].ToString();
                hh.Tensp = dt.Rows[i]["tensp"].ToString();
                hh.Idloai = dt.Rows[i]["idloai"].ToString();
                hh.Soluong =Convert.ToInt32(dt.Rows[i]["soluong"].ToString());
                hh.Dvtinh = dt.Rows[i]["dvtinh"].ToString();
                hh.Giaban = Convert.ToInt32(dt.Rows[i]["giaban"].ToString());
                lstHangHoa.Add(hh);
            }
            con = DataProvider.DongKetNoi();
            return lstHangHoa;
        }
        public static List<HangHoa_TMP> Tim_TMP(string text)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from sanpham where masp like N'%"+text+"%' or tensp like N'%"+text+"%'", con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<HangHoa_TMP> lstHangHoa = new List<HangHoa_TMP>();
            for(int i=0; i<dt.Rows.Count; i++)
            {
                HangHoa_TMP hh = new HangHoa_TMP();
                hh.Masp = dt.Rows[i]["masp"].ToString();
                hh.Tensp = dt.Rows[i]["tensp"].ToString();
                hh.Soluong = Convert.ToInt32(dt.Rows[i]["soluong"].ToString());
                hh.Idloai = dt.Rows[i]["idloai"].ToString();
                hh.Dvtinh = dt.Rows[i]["dvtinh"].ToString();
                hh.Giaban = Convert.ToInt32(dt.Rows[i]["giaban"].ToString());
                lstHangHoa.Add(hh);
            }
            con = DataProvider.DongKetNoi();
            return lstHangHoa;
        }
        public static List<HangHoa_DTO> Tim(string text)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from sanpham where masp like N'%" + text + "%' or tensp like N'%" + text + "%'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HangHoa_DTO> lstHangHoa = new List<HangHoa_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.Masp = dt.Rows[i]["masp"].ToString();
                hh.Tensp = dt.Rows[i]["tensp"].ToString();
                hh.Soluong = Convert.ToInt32(dt.Rows[i]["soluong"].ToString());
                hh.Idloai = dt.Rows[i]["idloai"].ToString();
                hh.Dvtinh = dt.Rows[i]["dvtinh"].ToString();
                hh.Giamua = Convert.ToInt32(dt.Rows[i]["giamua"].ToString());
                hh.Giaban = Convert.ToInt32(dt.Rows[i]["giaban"].ToString());
                hh.Ttrang = dt.Rows[i]["ttrang"].ToString();
                lstHangHoa.Add(hh);
            }
            con = DataProvider.DongKetNoi();
            return lstHangHoa;
        }
        public static List<HangHoa_DTO> TimbyID(string masp)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from sanpham where masp = '"+masp+"'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HangHoa_DTO> lstHangHoa = new List<HangHoa_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HangHoa_DTO hh = new HangHoa_DTO();
                hh.Masp = dt.Rows[i]["masp"].ToString();
                hh.Tensp = dt.Rows[i]["tensp"].ToString();
                hh.Soluong = Convert.ToInt32(dt.Rows[i]["soluong"].ToString());
                hh.Idloai = dt.Rows[i]["idloai"].ToString();
                hh.Giaban = Convert.ToInt32(dt.Rows[i]["giaban"].ToString());
                lstHangHoa.Add(hh);
            }
            con = DataProvider.DongKetNoi();
            return lstHangHoa;
        }
        public static bool Them(string ma, string ten, int sl, string idloai, string dvt, int giamua, int giaban)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"insert into Sanpham values ('"+ma+"', N'"+ten+"', '"+sl+"', '"+idloai+"', '"+dvt+"', '"+giamua+"', '"+giaban+"', 0)", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool SuaKhongCoMa(string ma, string ten, int sl, string idloai, string dvt, int giamua, int giaban, string tt)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update Sanpham set tensp = N'" + ten + "', soluong = '" + sl + "', idloai = '" + idloai + "', dvtinh = N'" + dvt + "', giamua = '" + giamua + "', giaban = '" + giaban + "', ttrang = N'"+tt+"' where masp = '"+ma+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool SuaCoMa(string ma, string maedit, string ten, int sl, string idloai, string dvt, int giamua, int giaban, string tt)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update Sanpham set masp = '" + maedit + "', tensp = N'" + ten + "', soluong = '" + sl + "', idloai = '" + idloai + "', dvtinh = N'" + dvt + "', giamua = '" + giamua + "', giaban = '" + giaban + "', ttrang = N'"+tt+"' where masp = '"+ma+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool Xoa(string ma)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"delete sanpham where masp = '"+ma+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
    }
}

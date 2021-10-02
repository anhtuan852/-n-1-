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
    public class NhanVien_DAO
    {
        static SqlConnection con;
        public static List<NhanVien_DTO> GetNhanVienAll()
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from Nhanvien", con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lst = new List<NhanVien_DTO>();
            for(int i=0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Manv = dt.Rows[i]["manv"].ToString();
                nv.Tennv = dt.Rows[i]["tennv"].ToString();
                nv.Macv = dt.Rows[i]["macv"].ToString();
                nv.Sdt = dt.Rows[i]["sdt"].ToString();
                nv.Ngaysinh =Convert.ToDateTime(dt.Rows[i]["ngaysinh"].ToString());
                nv.Diachi = dt.Rows[i]["diachi"].ToString();
                nv.Tthai = dt.Rows[i]["tthai"].ToString();
                lst.Add(nv);
            }
            DataProvider.DongKetNoi();
            return lst;
        }
        public static List<NhanVien_DTO> GetNhanVien()
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from Nhanvien where tthai = N'Bật'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lst = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Manv = dt.Rows[i]["manv"].ToString();
                nv.Tennv = dt.Rows[i]["tennv"].ToString();
                nv.Macv = dt.Rows[i]["macv"].ToString();
                nv.Sdt = dt.Rows[i]["sdt"].ToString();
                nv.Ngaysinh = Convert.ToDateTime(dt.Rows[i]["ngaysinh"].ToString());
                nv.Diachi = dt.Rows[i]["diachi"].ToString();
                nv.Tthai = dt.Rows[i]["tthai"].ToString();
                lst.Add(nv);
            }
            DataProvider.DongKetNoi();
            return lst;
        }
        public static string GetNamebyID(string manv)
        {

            string truyvan = @"select n.tennv from Nhanvien n where manv = '" + manv + "'";
            con = DataProvider.MoKetNoi();
            SqlCommand cm = new SqlCommand(truyvan, con);
            string kq = cm.ExecuteScalar().ToString();
            con = DataProvider.DongKetNoi();
            return kq;

            
        }
        public static List<ChucVu_DTO> GetChucVu()
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from Chucvu", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChucVu_DTO> lstChucVu = new List<ChucVu_DTO>();
            for(int i=0; i < dt.Rows.Count; i++)
            {
                ChucVu_DTO cv = new ChucVu_DTO();
                cv.Macv = dt.Rows[i]["macv"].ToString();
                cv.Tencv = dt.Rows[i]["tencv"].ToString();
                lstChucVu.Add(cv);
            }
            con = DataProvider.DongKetNoi();
            return lstChucVu;
        }
        public static bool Them(string manv, string tennv, string macv, string sdt, string ngaysinh, string diachi)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"insert into nhanvien values ('"+manv+"', N'"+tennv+"', '"+macv+"', '"+sdt+"', '"+ngaysinh+"', '"+diachi+"', N'Bật')", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool SuaCoManv(string manv, string manvedit, string tennv, string macv, string sdt, DateTime ngaysinh, string diachi)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update Nhanvien set manv = '" + manvedit + "', tennv = N'" + tennv + "', macv = '" + macv + "', sdt = '" + sdt + "', ngaysinh = '" + ngaysinh + "', diachi = N'" + diachi + "' where manv = '" + manv + "'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool SuaKhongCoManv(string manv, string tennv, string macv, string sdt, DateTime ngaysinh, string diachi)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update Nhanvien set tennv = N'" + tennv + "', macv = '" + macv + "', sdt = '" + sdt + "', ngaysinh = '" + ngaysinh + "', diachi = N'" + diachi + "' where manv = '" + manv + "'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }

        public static bool Xoa(string manv)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"delete Nhanvien where manv = '"+manv+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static List<NhanVien_DTO> TimByID(string manv)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from Nhanvien where manv = '" + manv + "'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for(int i=0; i<dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Manv = dt.Rows[i]["manv"].ToString();
                nv.Tennv = dt.Rows[i]["tennv"].ToString();
                nv.Macv = dt.Rows[i]["macv"].ToString();
                nv.Sdt = dt.Rows[i]["sdt"].ToString();
                nv.Ngaysinh = Convert.ToDateTime(dt.Rows[i]["ngaysinh"].ToString());
                nv.Diachi = dt.Rows[i]["diachi"].ToString();
                nv.Tthai = dt.Rows[i]["tthai"].ToString();
                lstNhanVien.Add(nv);
            }
            con = DataProvider.DongKetNoi();
            return lstNhanVien;
        }
        public static List<NhanVien_DTO> Tim(string text)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from Nhanvien where manv like N'%" + text + "%' or tennv like N'%"+text+"%'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.Manv = dt.Rows[i]["manv"].ToString();
                nv.Tennv = dt.Rows[i]["tennv"].ToString();
                nv.Macv = dt.Rows[i]["macv"].ToString();
                nv.Sdt = dt.Rows[i]["sdt"].ToString();
                nv.Ngaysinh = Convert.ToDateTime(dt.Rows[i]["ngaysinh"].ToString());
                nv.Diachi = dt.Rows[i]["diachi"].ToString();
                nv.Tthai = dt.Rows[i]["tthai"].ToString();
                lstNhanVien.Add(nv);
            }
            con = DataProvider.DongKetNoi();
            return lstNhanVien;
        }
        public static bool Bat(string manv)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update Nhanvien set tthai = N'Bật' where manv = '" + manv + "'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool Tat(string manv)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update Nhanvien set tthai = N'Tắt' where manv = '" + manv + "'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static int SLNV()
        {
            con = DataProvider.MoKetNoi();
            int kq = DataProvider.TruyVanLayGiaTriINT(@"select count(manv) from nhanvien", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
    }
}

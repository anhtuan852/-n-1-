using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class ThongTinHoaDon_BUS
    {
        public static int GetIDThongTinHoaDon()
        {
            return ThongTinHoaDon_DAO.GetIDThongTinHoaDon();
        }
        public static bool ThemTTHoaDon(ThongTinHoaDon_DTO tt)
        {
            return ThongTinHoaDon_DAO.ThemTTHoaDon(tt);
        }
        public static bool ThemTTHoaDon2(int id, string lsp, string masp, string tensp, string dvt, int gia, int sl, int thanhtien, int idhd)
        {
            return ThongTinHoaDon_DAO.ThemTTHoaDon2(id, lsp, masp, tensp, dvt, gia, sl, thanhtien, idhd);
        }
        public static List<ThongTinHoaDon_DTO> GetThongTinHDByIDHD(int mahd)
        {
            return ThongTinHoaDon_DAO.GetThongTinHDByIDHD(mahd);
        }
        public static List<ThongTinHoaDon_DTO> GetThongTinHDByIDNhanVien(string manv)
        {
            return ThongTinHoaDon_DAO.GetThongTinHDByIDNhanVien(manv);
        }
        public static bool DeleteTTHDByIDHD(int idhd)
        {
            return ThongTinHoaDon_DAO.Delete(idhd);
        }
    }
}

using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDon_BUS
    {
        public static int GetSLHD()
        {
            return HoaDon_DAO.GetSLHD();
        }
        public static bool ThemHD(int mahd, string manv, string makh, DateTime ngaygd, int tonghd, int tra, int conlai, string tthai)
        {
            return HoaDon_DAO.ThemHD(mahd, manv, makh, ngaygd, tonghd, tra, conlai, tthai);
        }
        public static List<HoaDon_DTO> GetHoaDonByIDKH(string makh)
        {
            return HoaDon_DAO.GetHDByIDKH(makh);
        }
        public static List<HoaDon_DTO> GetHoaDonByIDKHChuaTT(string makh)
        {
            return HoaDon_DAO.GetHDByIDKHChuaTT(makh);
        }
        public static List<HoaDon_DTO> GetHoaDonChuathanhtoanByIDKH(string makh)
        {
            return HoaDon_DAO.GetHDChuathanhtoanbtKH(makh);
        }
        public static List<HoaDon_DTO> GetIDHoaDonByIDKH(string makh)
        {
            return HoaDon_DAO.GetIDHDByIDKH(makh);
        }
        public static List<HoaDon_DTO> GetHoaDonByIDNhanVien(string manv)
        {
            return HoaDon_DAO.GetHDByIDNhanVien(manv);
        }
        public static List<HoaDon_DTO> GetHoaDon()
        {
            return HoaDon_DAO.GetHoaDon();
        }
        public static List<HoaDon_DTO> GetHoaDonByID(int mahd)
        {
            return HoaDon_DAO.GetHDByIDHoaDon(mahd);
        }
        public static List<HoaDon_DTO> XemTheoNgay(string checkin, string checkout)
        {
            return HoaDon_DAO.XemHoaDon(checkin, checkout);
        }
        public static bool EditTthai(string mahd, int conlai, string tthai)
        {
            return HoaDon_DAO.EditTthai(mahd, conlai, tthai);
        }
        public static bool EditThanhToan(string mahd, int tra, int conlai, string tthai)
        {
            return HoaDon_DAO.EditThanhToan(mahd, tra, conlai, tthai);
        }
    }
}

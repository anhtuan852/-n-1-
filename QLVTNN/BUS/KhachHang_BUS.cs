using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class KhachHang_BUS
    {
        public static List<KhachHang_DTO> GetKhachHangAll()
        {
            return KhachHang_DAO.GetKhachHangAll();
        }
        public static List<KhachHang_DTO> GetKhachHang()
        {
            return KhachHang_DAO.GetKhachHang();
        }
        public static bool UpdateNoGiam(string makh, int no)
        {
            return KhachHang_DAO.UpdateNoGiam(makh, no);
        }
        public static bool UpdateNoTang(string makh, int no)
        {
            return KhachHang_DAO.UpdateNoTang(makh, no);
        }
        public static bool CapNhatTong(string makh, int tong)
        {
            return KhachHang_DAO.CapNhatTong(makh, tong);
        }
        public static string GetSDTbtIDKH(string makh)
        {
            return KhachHang_DAO.GetSDTbyIDKH(makh);
        }
        public static string GetName(string makh)
        {
            return KhachHang_DAO.GetName(makh);
        }
        public static string GetAddressbtIDKH(string makh)
        {
            return KhachHang_DAO.GetAddressbyIDKH(makh);
        }
        public static int GetCongNo(string makh)
        {
            return KhachHang_DAO.GetCongNo(makh);
        }
        public static bool AddKhachHang(string makh, string tenkh, string sdt, DateTime ngaysinh, string diachi)
        {
            return KhachHang_DAO.AddKhachHang(makh, tenkh, sdt, ngaysinh, diachi);
        }
        public static List<KhachHang_DTO> TimKhacHangByID(string makh)
        {
            return KhachHang_DAO.TimKhachHangTheoMa(makh);
        }
        public static List<KhachHang_DTO> TimKhachHang(string text)
        {
            return KhachHang_DAO.TimKhachHang(text);
        }
        public static bool Edit(string makh, string ten, string sdt, DateTime ngaysinh, string diachi)
        {
            return KhachHang_DAO.Edit(makh, ten, sdt, ngaysinh, diachi);
        }
        public static bool Delete(string makh)
        {
            return KhachHang_DAO.Delete(makh);
        }
        public static bool Tat(string makh)
        {
            return KhachHang_DAO.Tat(makh);
        }
        public static bool Bat(string makh)
        {
            return KhachHang_DAO.Bat(makh);
        }
        public static int SLKH()
        {
            return KhachHang_DAO.SLKH();
        }
    }
}

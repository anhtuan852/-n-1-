using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class NhanVien_BUS
    {
        public static List<NhanVien_DTO> GetNhanVienAll()
        {
            return NhanVien_DAO.GetNhanVienAll();
        }
        public static List<NhanVien_DTO> GetNhanVien()
        {
            return NhanVien_DAO.GetNhanVien();
        }
        public static string GetNamebyID(string manv)
        {
            return NhanVien_DAO.GetNamebyID(manv);
        }
        public static List<ChucVu_DTO> GetChucVu()
        {
            return NhanVien_DAO.GetChucVu();
        }
        public static bool Them(string manv, string tennv, string macv, string sdt, string ngaysinh, string diachi)
        {
            return NhanVien_DAO.Them(manv, tennv, macv, sdt, ngaysinh, diachi);
        }
        public static bool SuacCoManv(string manv, string manvedit, string tennv, string macv, string sdt, DateTime ngaysinh, string diachi)
        {
            return NhanVien_DAO.SuaCoManv(manv, manvedit, tennv, macv, sdt, ngaysinh, diachi);
        }
        public static bool SuacKhongCoManv(string manv, string tennv, string macv, string sdt, DateTime ngaysinh, string diachi)
        {
            return NhanVien_DAO.SuaKhongCoManv(manv, tennv, macv, sdt, ngaysinh, diachi);
        }
        public static bool Xoa(string manv)
        {
            return NhanVien_DAO.Xoa(manv);
        }
        public static List<NhanVien_DTO> TimByID(string manv)
        {
            return NhanVien_DAO.TimByID(manv);
        }
        public static List<NhanVien_DTO> Tim(string text)
        {
            return NhanVien_DAO.Tim(text);
        }
        public static bool Bat(string manv)
        {
            return NhanVien_DAO.Bat(manv);
        }
        public static bool Tat(string manv)
        {
            return NhanVien_DAO.Tat(manv);
        }
        public static int SLNV()
        {
            return NhanVien_DAO.SLNV();
        }
    }
}

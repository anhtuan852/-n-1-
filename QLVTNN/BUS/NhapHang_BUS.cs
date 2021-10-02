using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class NhapHang_BUS
    {
        public static List<NhapHang_DTO> GetNhapHang()
        {
            return NhapHang_DAO.GetNhapHang();
        }
        public static bool Them(NhapHang_DTO nh)
        {
            return NhapHang_DAO.Them(nh);
        }
        public  static int GetID()
        {
            return NhapHang_DAO.GetID();
        }
        public static List<NhapHang_DTO> Xem(string start, string end)
        {
            return NhapHang_DAO.Xem(start, end);
        }
        public static bool Delete()
        {
            return NhapHang_DAO.Delete();
        }
    }
}

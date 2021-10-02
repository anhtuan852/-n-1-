using System;
using DAO;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace BUS
{
    public class LichSu_BUS
    {
        public static List<LichSu_DTO> GetLichSu()
        {
            return LichSu_DAO.GetLichSu();
        }
        public static bool Add(string manv, DateTime ngay, string tt)
        {
            return LichSu_DAO.Add(manv, ngay, tt);
        }
        public static bool Edit(int id, string manv, DateTime ngay, string tt)
        {
            return LichSu_DAO.Edit(id, manv, ngay, tt);
        }
        public static List<LichSu_DTO> Xem(string start, string end)
        {
            return LichSu_DAO.Xem(start, end);
        }
    }
}

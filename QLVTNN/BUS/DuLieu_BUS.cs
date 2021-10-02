using System;
using DAO;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DuLieu_BUS
    {
        public static bool SaoLuu(string DuongDan)
        {
            return DuLieu_DAO.SaoLuuDuLieu(DuongDan);
        }
        public static bool PhucHoi(string DuongDan)
        {
            return DuLieu_DAO.PhuHoi(DuongDan);
        }
    }
}

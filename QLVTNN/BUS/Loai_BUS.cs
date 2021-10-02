using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;

namespace BUS
{
    public class Loai_BUS
    {
        public static List<Loai_DTO> LayLoai()
        {
            return Loai_DAO.LayLoai();
        }
        public static bool Them(string ma, string ten)
        {
            return Loai_DAO.Them(ma, ten);
        }
        public static bool Sua(string ma, string maedit, string ten)
        {
            return Loai_DAO.Sua(ma, maedit, ten);
        }
        public static bool Xoa(string ma)
        {
            return Loai_DAO.Xoa(ma);
        }
        public static List<Loai_DTO> Tim(string ma)
        {
            return Loai_DAO.Tim(ma);
        }
    }
}

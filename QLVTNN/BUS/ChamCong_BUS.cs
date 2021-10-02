using System;
using DAO;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChamCong_BUS
    {
        public static List<ChamCong_DTO> GetChamCong()
        {
            return ChamCong_DAO.GetChamCong();
        }
        public static bool Add(string manv, DateTime ngay, string ghichu)
        {
            return ChamCong_DAO.Add(manv, ngay, ghichu);
        }
        public static bool Edit(string id, string manv, DateTime ngay, string ghichu)
        {
            return ChamCong_DAO.Edit(id, manv, ngay, ghichu);
        }
    }
}

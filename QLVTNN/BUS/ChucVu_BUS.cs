using System;
using DTO;
using DAO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ChucVu_BUS
    {
        public static List<ChucVu_DTO> GetChucVu()
        {
            return ChucVu_DAO.GetChucVu();
        }
    }
}

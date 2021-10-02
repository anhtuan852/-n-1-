using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DAO
{
    public class ChucVu_DAO
    {
        static SqlConnection con;
        public static List<ChucVu_DTO> GetChucVu()
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from Chucvu", con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChucVu_DTO> lst = new List<ChucVu_DTO>();
            for(int i=0;i<dt.Rows.Count; i++)
            {
                ChucVu_DTO cv = new ChucVu_DTO();
                cv.Macv = dt.Rows[i]["macv"].ToString();
                cv.Tencv = dt.Rows[i]["tencv"].ToString();
                lst.Add(cv);
            }
            con = DataProvider.DongKetNoi();
            return lst;
        }
    }
}

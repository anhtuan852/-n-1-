using System;
using DTO;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class ChamCong_DAO
    {
        static SqlConnection con;
        public static List<ChamCong_DTO> GetChamCong()
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from chamcong", con);
            if(dt.Rows.Count == 0)
            {
                return null;
            }
            List<ChamCong_DTO> lst = new List<ChamCong_DTO>();
            for(int i=0; i<dt.Rows.Count; i++)
            {
                ChamCong_DTO cc = new ChamCong_DTO();
                cc.Id =Convert.ToInt32(dt.Rows[i]["id"].ToString());
                cc.Manv = dt.Rows[i]["manv"].ToString();
                cc.Ngay = Convert.ToDateTime(dt.Rows[i]["ngay"].ToString());
                cc.Ghichu = dt.Rows[i]["ghichu"].ToString();
                lst.Add(cc);
            }
            con = DataProvider.DongKetNoi();
            return lst;
        }
        public static bool Add(string manv, DateTime ngay, string ghichu)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"insert into chamcong values ('"+manv+"', '"+ngay+"', '"+ghichu+"')", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool Edit(string id, string manv, DateTime ngay, string ghichu)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update chamcong set manv = '"+manv+"', ngay = '"+ngay+"', ghichu = '"+ghichu+"' where id = '"+id+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
    }
}

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
    public class LichSu_DAO
    {
        static SqlConnection con;
        public static List<LichSu_DTO> GetLichSu()
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from lichsu", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LichSu_DTO> lst = new List<LichSu_DTO>();
            for(int i=0; i<dt.Rows.Count;i++)
            {
                LichSu_DTO l = new LichSu_DTO();
                l.Id =Convert.ToInt32(dt.Rows[i]["id"].ToString());
                l.Manv = dt.Rows[i]["manv"].ToString();
                l.Ngay = Convert.ToDateTime(dt.Rows[i]["ngay"].ToString());
                l.Chitiet = dt.Rows[i]["chitiet"].ToString();
                lst.Add(l);
            }
            con = DataProvider.DongKetNoi();
            return lst;
        }
        public static bool Add(string manv, DateTime ngay, string tt)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"insert into lichsu values ('" + manv + "', '" + ngay + "', N'" + tt + "')", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }
        public static bool Edit(int id, string manv, DateTime ngay, string tt)
        {
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.KLayDuLieu(@"update lichsu set manv = '"+manv+"', ngay = '"+ngay+"', chitiet = '"+tt+"' where id = '"+id+"'", con);
            con = DataProvider.DongKetNoi();
            return kq;
        }public static List<LichSu_DTO> Xem(string start, string end)
        {
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.LayDuLieu(@"select * from lichsu where ngay = '"+start+"' and ngay '"+end+"'", con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<LichSu_DTO> lst = new List<LichSu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                LichSu_DTO l = new LichSu_DTO();
                l.Id = Convert.ToInt32(dt.Rows[i]["id"].ToString());
                l.Manv = dt.Rows[i]["manv"].ToString();
                l.Ngay = Convert.ToDateTime(dt.Rows[i]["ngay"].ToString());
                l.Chitiet = dt.Rows[i]["chitiet"].ToString();
                lst.Add(l);
            }
            con = DataProvider.DongKetNoi();
            return lst;
        }
    }
}

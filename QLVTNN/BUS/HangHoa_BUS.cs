using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HangHoa_BUS
    {
        public static List<HangHoa_DTO> GetHangHoa()
        {
            return HangHoa_DAO.GetHangHoa();
        }
        public static List<HangHoa_TMP> GetHangHoa_TMP()
        {
            return HangHoa_DAO.GetHangHoa_TMP();
        }
        public static List<HangHoa_DTO> GetHangHoaByID(string id)
        {
            return HangHoa_DAO.GetHangHoaByID(id);
        }
        public static int GetSLByIDSP(string masp)
        {
            return HangHoa_DAO.GetSLHangHoaByIDSP(masp);
        }
        public static bool UpdateSLSP(string masp, int sl)
        {
            return HangHoa_DAO.CapNhatSLGiam(masp, sl);
        }
        public static bool CapNhatTang(string masp, int sl)
        {
            return HangHoa_DAO.CapNhatSLTang(masp, sl);
        }
        public static List<HangHoa_TMP> GetHangHoaHet()
        {
            return HangHoa_DAO.GetHangHoaHet();
        }
        public static List<HangHoa_TMP> Tim_TMP(string text)
        {
            return HangHoa_DAO.Tim_TMP(text);
        }
        public static List<HangHoa_DTO> Tim(string text)
        {
            return HangHoa_DAO.Tim(text);
        }
        public static List<HangHoa_DTO> TimByID(string masp)
        {
            return HangHoa_DAO.TimbyID(masp);
        }
        public static bool Them(string ma, string ten, int sl, string idloai, string dvt, int giamua, int giaban)
        {
            return HangHoa_DAO.Them(ma, ten, sl, idloai, dvt, giamua, giaban);
        }
        public static bool SuaCoMa(string ma, string maedit, string ten, int sl, string idloai, string dvt, int giamua, int giaban, string tt)
        {
            return HangHoa_DAO.SuaCoMa(ma, maedit, ten, sl, idloai, dvt, giamua, giaban, tt);
        }
        public static bool SuaKhongCoMa(string ma, string ten, int sl, string idloai, string dvt, int giamua, int giaban, string tt)
        {
            return HangHoa_DAO.SuaKhongCoMa(ma, ten, sl, idloai, dvt, giamua, giaban, tt);
        }
        public static bool Xoa(string ma)
        {
            return HangHoa_DAO.Xoa(ma);
        }

    }
}

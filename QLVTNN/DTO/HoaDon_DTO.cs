using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDon_DTO
    {
        private int mahd;
        private string manv;
        private string makh;
        private DateTime ngaygd;
        private int tonghd;
        private int tra;
        private int conlai;
        private string tthai;

        [DisplayName("Mã hóa đơn")]
        public int Mahd { get => mahd; set => mahd = value; }

        [DisplayName("Mã nhân viên")]
        public string Manv { get => manv; set => manv = value; }

        [DisplayName("Mã khách hàng")]
        public string Makh { get => makh; set => makh = value; }

        [DisplayName("Ngày giao dịch")]
        public DateTime Ngaygd { get => ngaygd; set => ngaygd = value; }

        [DisplayName("Tổng hóa đơn")]
        public int Tonghd { get => tonghd; set => tonghd = value; }

        [DisplayName("Trả")]
        public int Tra { get => tra; set => tra = value; }

        [DisplayName("Còn Lại")]
        public int Conlai { get => conlai; set => conlai = value; }

        [DisplayName("Trạng Thái")]
        public string Tthai { get => tthai; set => tthai = value; }
    }
}

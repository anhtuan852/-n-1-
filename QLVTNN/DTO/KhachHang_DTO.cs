using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private string makh;
        private string tenkh;
        private string sdt;
        private DateTime ngaysinh;
        private string diachi;
        private string tthai;
        private int congno;
        private int tongmua;

        [DisplayName("Mã KH")]
        public string Makh { get => makh; set => makh = value; }

        [DisplayName("Tên Khách Hàng")]
        public string Tenkh { get => tenkh; set => tenkh = value; }

        [DisplayName("Số Điện Thoại")]
        public string Sdt { get => sdt; set => sdt = value; }

        [DisplayName("Ngày Sinh")]
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }

        [DisplayName("Địa Chỉ")]
        public string Diachi { get => diachi; set => diachi = value; }

        [DisplayName("Trạng Thái")]
        public string Tthai { get => tthai; set => tthai = value; }

        [DisplayName("Nợ")]
        public int Congno { get => congno; set => congno = value; }

        [DisplayName("Tổng Mua")]
        public int Tongmua { get => tongmua; set => tongmua = value; }
    }
}

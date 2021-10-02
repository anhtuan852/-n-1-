using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien_DTO
    {
        private string manv;
        private string tennv;
        private string macv;
        private string sdt;
        private DateTime ngaysinh;
        private string diachi;
        private string tthai;

        [DisplayName("Mã Nhân Viên")]
        public string Manv { get => manv; set => manv = value; }

        [DisplayName("Tên Nhân Viên")]
        public string Tennv { get => tennv; set => tennv = value; }

        [DisplayName("Mã Chức Vụ")]
        public string Macv { get => macv; set => macv = value; }

        [DisplayName("Số Điện Thoại")]
        public string Sdt { get => sdt; set => sdt = value; }

        [DisplayName("Ngày Sinh")]
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }

        [DisplayName("Địa Chỉ")]
        public string Diachi { get => diachi; set => diachi = value; }

        [DisplayName("Trại thái")]
        public string Tthai { get => tthai; set => tthai = value; }
    }
}

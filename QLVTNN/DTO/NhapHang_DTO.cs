using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhapHang_DTO
    {
        private int id;
        private string masp;
        private string tensp;
        private int soluong;
        private DateTime ngaynhap;
        private string manv;
        private string dvtinh;
        private int gia;
        private int tong;

        [DisplayName("ID")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Mã SP")]
        public string Masp { get => masp; set => masp = value; }

        [DisplayName("Tên SP")]
        public string Tensp { get => tensp; set => tensp = value; }

        [DisplayName("Số lượng")]
        public int Soluong { get => soluong; set => soluong = value; }

        [DisplayName("Ngày nhập")]
        public DateTime Ngaynhap { get => ngaynhap; set => ngaynhap = value; }

        [DisplayName("NV nhập")]
        public string Manv { get => manv; set => manv = value; }

        [DisplayName("ĐVT")]
        public string Dvtinh { get => dvtinh; set => dvtinh = value; }

        [DisplayName("Giá")]
        public int Gia { get => gia; set => gia = value; }

        [DisplayName("Tổng")]
        public int Tong { get => tong; set => tong = value; }
    }
}

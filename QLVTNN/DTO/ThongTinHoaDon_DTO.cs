using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinHoaDon_DTO
    {
        private int id;
        private string loaisp;
        private string masp;
        private string tensp;
        private string dvtinh;
        private int giaban;
        private int soluong;
        private int thanhtien;
        private int idhd;

        [DisplayName("ID")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Loại")]
        public string Loaisp { get => loaisp; set => loaisp = value; }

        [DisplayName("Mã hàng hóa")]
        public string Masp { get => masp; set => masp = value; }

        [DisplayName("Tên hàng hóa")]
        public string Tensp { get => tensp; set => tensp = value; }

        [DisplayName("Đơn vị tính")]
        public string Dvtinh { get => dvtinh; set => dvtinh = value; }

        [DisplayName("Giá")]
        public int Gia { get => giaban; set => giaban = value; }

        [DisplayName("Số lượng")]
        public int Soluong { get => soluong; set => soluong = value; }

        [DisplayName("Thành tiền")]
        public int Thanhtien { get => thanhtien; set => thanhtien = value; }

        [DisplayName("Mã hóa đơn")]
        public int Idhd { get => idhd; set => idhd = value; }
        
    }
}

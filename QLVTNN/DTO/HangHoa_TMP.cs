using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HangHoa_TMP
    {
        private string masp;
        private string tensp;
        private int soluong;
        private string idloai;
        private string dvtinh;
        private float giaban;

        [DisplayName("Mã hàng hóa")]
        public string Masp { get => masp; set => masp = value; }

        [DisplayName("Tên hàng hóa")]
        public string Tensp { get => tensp; set => tensp = value; }

        [DisplayName("Số lượng")]
        public int Soluong { get => soluong; set => soluong = value; }

        [DisplayName("Mã loại")]
        public string Idloai { get => idloai; set => idloai = value; }

        [DisplayName("Đơn vị tính")]
        public string Dvtinh { get => dvtinh; set => dvtinh = value; }

        [DisplayName("Giá bán")]
        public float Giaban { get => giaban; set => giaban = value; }
    }
}

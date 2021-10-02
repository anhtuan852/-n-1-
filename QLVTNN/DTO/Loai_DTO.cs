using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Loai_DTO
    {
        private string maloai;
        private string tenloai;

        [DisplayName("Mã Loại")]
        public string Maloai { get => maloai; set => maloai = value; }

        [DisplayName("Tên Loại")]
        public string Tenloai { get => tenloai; set => tenloai = value; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ChamCong_DTO
    {
        private int id;
        private string manv;
        private DateTime ngay;
        private string ghichu;

        [DisplayName("ID")]
        public int Id { get => id; set => id = value; }

        [DisplayName("Mã Nhân Viên")]
        public string Manv { get => manv; set => manv = value; }

        [DisplayName("Ngày")]
        public DateTime Ngay { get => ngay; set => ngay = value; }

        [DisplayName("Ghi Chú")]
        public string Ghichu { get => ghichu; set => ghichu = value; }
    }
}

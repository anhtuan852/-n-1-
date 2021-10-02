using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVTNN
{
    public partial class frmThanhToan : Form
    {
        public frmThanhToan()
        {
            InitializeComponent();
        }
        public string makh;
        public string tenkh;
        public int tongHD;
        public int slsp;
        public int IDHD;
        public string user;
        public int conlai;
        string tthai;
        public int tra;

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            lbID_HD_TT.Text = IDHD.ToString();
            //txtTong_HD_TT.Text = tongHD.ToString();
            lbTongHD_TT.Text = tongHD.ToString();
            lbTongSLSP_TT.Text = slsp.ToString();
            txtConLai_HD_TT.Text = tongHD.ToString();

            txtNv.Text = NhanVien_BUS.GetNamebyID(user);
            lbID_KH_TT.Text = tenkh;

        }

        private void txtTra_HD_TT_TextChanged(object sender, EventArgs e)
        {
            if (txtTra_HD_TT.Text == "")
            {
                txtConLai_HD_TT.Text = tongHD.ToString();
            }
            else
                txtConLai_HD_TT.Text = (tongHD - Convert.ToInt32(txtTra_HD_TT.Text)).ToString();
        }


        private void txtTra_HD_TT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) // kiem tra kí tự không cho nhap kí tự chỉ cho nhạp số
            {
                e.Handled = true;
                MessageBox.Show("Số tiền trả phải là kiểu SỐ", "Thông báo");
                txtTra_HD_TT.Focus();
            }
        }

        private void btnThanhToan_TT_Click(object sender, EventArgs e)
        {
            conlai = Convert.ToInt32(txtConLai_HD_TT.Text);
            
            if(makh == "KH00" && conlai > 0)
            {
                MessageBox.Show("Khách lẻ, phải thanh toán toàn bộ hóa đơn khi thanh toán", "Tông báo");
            }
            else
            {
                if (conlai == 0)
                {
                    tthai = "Đã thanh toán";
                }
                else
                    tthai = "Chưa thanh toán";
                if (txtTra_HD_TT.Text == "")
                {
                    tra = 0;
                }
                else
                    tra = Convert.ToInt32(txtTra_HD_TT.Text);
                //HoaDon_BUS.ThemHD(IDHD, cbbID_NV_TT.SelectedValue.ToString(), makh, dtNgay_GD_TT.Value, tongHD);
                if (HoaDon_BUS.ThemHD(IDHD, user, makh, DateTime.Now, tongHD, tra, conlai, tthai) && KhachHang_BUS.UpdateNoTang(makh, conlai) && KhachHang_BUS.CapNhatTong(makh, tongHD))
                {
                    MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LichSu_BUS.Add(user, DateTime.Now, "Bán hàng, hóa đơn " + IDHD);

                }
                else
                {
                    MessageBox.Show("Thanh toán thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            txtTra_HD_TT.Text = tongHD.ToString();
        }
    }
}

using BUS;
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
    public partial class frmAddKH : Form
    {
        public frmAddKH()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("Mã khách hàng không được bỏ trống!", "Thông báo");
            }else if(txtName.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được bỏ trống!", "Thông báo");
            }
            else if(txtSĐT.Text == "")
            {
                MessageBox.Show("Số điện thoại khách hàng không được bỏ trống!", "Thông báo");
            }
            else if(txtAddress.Text == "")
            {
                MessageBox.Show("Địa chỉ khách hàng không được bỏ trống!", "Thông báo");
            }
            else
            {
                if(KhachHang_BUS.TimKhacHangByID(txtID.Text) == null)
                {
                    if (KhachHang_BUS.AddKhachHang(txtID.Text, txtName.Text, txtSĐT.Text, Convert.ToDateTime(dtNgaySinh.Value.ToShortDateString()), txtAddress.Text))
                    {
                        MessageBox.Show("Thêm khách hàng " + txtName.Text + " thành công!", "Thông báo");
                        txtID.Clear();
                        txtName.Clear();
                        txtSĐT.Clear();
                        txtAddress.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm khách hàng thất bại!", "Thông báo");
                    }
                }else
                {
                    MessageBox.Show("Mã khách hàng đã tồn tại, vui lòng chọn mã khác và thực hiện lại!", "Thông báo");
                }
            }
        }

        private void txtSĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) // kiem tra kí tự không cho nhap kí tự chỉ cho nhạp số
            {
                e.Handled = true;
                MessageBox.Show("Số điện thoại phải là kiểu SỐ", "Thông báo");
                txtSĐT.Focus();
            }
        }
    }
}

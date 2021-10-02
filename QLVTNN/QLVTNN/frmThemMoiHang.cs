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
    public partial class frmThemMoiHang : Form
    {
        public frmThemMoiHang()
        {
            InitializeComponent();
        }
        private List<Loai_DTO> lstLoai = Loai_BUS.LayLoai();
        public string user;
        private void frmThemMoiHang_Load(object sender, EventArgs e)
        {
            cbbLoai.DataSource = lstLoai;
            cbbLoai.DisplayMember = "tenloai";
            cbbLoai.ValueMember = "maloai";
        }

        private void btnAdd_SP_Click(object sender, EventArgs e)
        {
            if(txtID_SP.Text == "")
            {
                MessageBox.Show("Mã Hàng Hóa không được bỏ trống!", "Thông báo");
                txtID_SP.Focus();
            }else if(txtName_SP.Text == "")
            {
                MessageBox.Show("Tên Hàng Hóa không được bỏ trống!", "Thông báo");
                txtName_SP.Focus();
            }
            else if (txtDVT_SP.Text =="")
            {
                MessageBox.Show("Đơn vị tính Hàng Hóa không được bỏ trống!", "Thông báo");
                txtDVT_SP.Focus();
            }
            else if(txtGiaBan.Text == "")
            {
                MessageBox.Show("Giá bán Hàng Hóa không được bỏ trống!", "Thông báo");
                txtGiaBan.Focus();
            }
            else if(txtGiaMua.Text== "")
            {
                MessageBox.Show("Giá mua Hàng Hóa không được bỏ trống!", "Thông báo");
                txtGiaMua.Focus();
            }
            else if (Convert.ToInt32(txtGiaMua.Text) == Convert.ToInt32(txtGiaBan.Text))
            {
                MessageBox.Show("Nhập Hàng không thể với GIÁ MUA bằng GIÁ BÁN", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Convert.ToInt32(txtGiaMua.Text) > Convert.ToInt32(txtGiaBan.Text))
            {
                MessageBox.Show("Nhập Hàng không thể với GIÁ BÁN nhỏ GIÁ MUA", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (HangHoa_BUS.Tim(txtID_SP.Text) == null)
                {
                    if (HangHoa_BUS.Them(txtID_SP.Text, txtName_SP.Text, 0, cbbLoai.SelectedValue.ToString(), txtDVT_SP.Text, Convert.ToInt32(txtGiaMua.Text), Convert.ToInt32(txtGiaBan.Text)))
                    {
                        MessageBox.Show("Thêm Hàng Hóa " + txtName_SP.Text + " thành công", "Thông báo");
                        LichSu_BUS.Add(user, DateTime.Now, "Thêm mới hàng " + txtName_SP.Text);
                        txtID_SP.Clear();
                        txtName_SP.Clear();
                        txtGiaMua.Clear();
                        txtGiaBan.Clear();
                        txtDVT_SP.Clear();
                    }
                    else
                        MessageBox.Show("Thêm thất bại", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Mã Hàng Hóa đã tồn lại, vui lòng chọn mã khác và thao tác lại!", "Thông báo");
                    txtID_SP.Focus();
                }
            }
        }

        private void txtGiaMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) // kiem tra kí tự không cho nhap kí tự chỉ cho nhạp số
            {
                e.Handled = true;
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) // kiem tra kí tự không cho nhap kí tự chỉ cho nhạp số
            {
                e.Handled = true;
            }
        }

        private void txtDVT_SP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) // kiem tra kí tự không cho nhap kí tự chỉ cho nhạp số
            {
                e.Handled = true;
                MessageBox.Show("Đơn vị tính phải là kiểu KÍ TỰ", "Thông báo");
                txtDVT_SP.Focus();
            }
        }
    }
}

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
    public partial class frmKho : Form
    {
        public frmKho()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }
        private List<Loai_DTO> lstLoai = Loai_BUS.LayLoai();
        private List<HangHoa_DTO> lstHangHoa = HangHoa_BUS.GetHangHoa();
        private string masp;
        public string type;
        public string user;
        private void frmKho_Load(object sender, EventArgs e)
        {
            //Nếu người dùng là nhân viên 
            if (type == "NV")
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
            }
            dgDS_HangHoa.DataSource = lstHangHoa;
            cbbLoai.DataSource = lstLoai;
            cbbLoai.DisplayMember = "tenloai";
            cbbLoai.ValueMember = "maloai";
        }

        //Tìm kiếm hàng hóa
        private void btnFind_Click(object sender, EventArgs e)
        {
            if(txtFind.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã hoặc Tên cần tìm", "Thông báo");
            }
            else
            {
                if(HangHoa_BUS.Tim(txtFind.Text)== null)
                {
                    MessageBox.Show("Không tìn thấy!!", "Thông báo");
                }
                else
                {
                    lstHangHoa = HangHoa_BUS.Tim(txtFind.Text);
                    dgDS_HangHoa.DataSource = lstHangHoa;
                }
            }
        }
        //Chọn hàng hóa
        private void dgDS_HangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgDS_HangHoa.SelectedRows[0];
            txtID.Text = dr.Cells[0].Value.ToString();
            masp = dr.Cells[0].Value.ToString();
            txtName.Text = dr.Cells[1].Value.ToString();
            nmSoLuong.Value =Convert.ToDecimal(dr.Cells[2].Value.ToString());
            cbbLoai.SelectedValue = dr.Cells[3].Value.ToString();
            txtDVT.Text = dr.Cells[4].Value.ToString();
            txtGiaMua.Text = dr.Cells[5].Value.ToString();
            txtGiaBan.Text = dr.Cells[6].Value.ToString();
            txtTTrang.Text = dr.Cells[7].Value.ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("Mã Hàng Hóa không được bỏ trống!", "Thông báo");
                txtID.Focus();
            }else if(txtName.Text == "")
            {
                MessageBox.Show("Tên Hàng Hóa không được bỏ trống!", "Thông báo");
                txtName.Focus();
            }
            else if (txtDVT.Text =="")
            {
                MessageBox.Show("Đơn vị tính Hàng Hóa không được bỏ trống!", "Thông báo");
                txtDVT.Focus();
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
            else
            {
                if(txtID.Text == dgDS_HangHoa.SelectedRows[0].Cells[0].Value.ToString())
                {
                    if (HangHoa_BUS.Sua(txtID.Text, txtName.Text, Convert.ToInt32(nmSoLuong.Value.ToString()), cbbLoai.SelectedValue.ToString(), txtDVT.Text, Convert.ToInt32(txtGiaMua.Text), Convert.ToInt32(txtGiaBan.Text), txtTTrang.Text))
                    {
                        MessageBox.Show("Sửa Hàng Hóa " + txtName.Text + " thành công", "Thông báo");
                        lstHangHoa = HangHoa_BUS.GetHangHoa();
                        dgDS_HangHoa.DataSource = null;
                        dgDS_HangHoa.DataSource = lstHangHoa;
                        LichSu_BUS.Add(user, DateTime.Now, "Sửa thông tin khách hàng " + txtName.Text);
                        txtID.Clear();
                        txtName.Clear();
                        txtGiaMua.Clear();
                        txtGiaBan.Clear();
                        txtDVT.Clear();
                        nmSoLuong.Value = 0;
                        txtTTrang.Clear();
                    }
                    else
                        MessageBox.Show("Sửa thất bại", "Thông báo");
                }
                else
                {
                    if(HangHoa_BUS.TimByID(txtID.Text) == null)
                    {
                        if(HangHoa_BUS.SuaCoMa(masp, txtID.Text, txtName.Text, Convert.ToInt32(nmSoLuong.Value.ToString()), cbbLoai.SelectedValue.ToString(), txtDVT.Text, Convert.ToInt32(txtGiaMua.Text), Convert.ToInt32(txtGiaBan.Text), txtTTrang.Text))
                        {
                            MessageBox.Show("Sửa thành công", "Thông báo");
                            lstHangHoa = HangHoa_BUS.GetHangHoa();
                            dgDS_HangHoa.DataSource = null;
                            dgDS_HangHoa.DataSource = lstHangHoa;
                            txtID.Clear();
                            txtName.Clear();
                            txtGiaMua.Clear();
                            txtGiaBan.Clear();
                            txtDVT.Clear();
                            nmSoLuong.Value = 0;
                            txtTTrang.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại", "Thông báo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mã Hàng Hóa đã tồn tại, vui lòng nhập mã khác", "Thông báo");
                        txtID.Focus();
                    }
                }
                    
               
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            lstHangHoa = HangHoa_BUS.GetHangHoa();
            dgDS_HangHoa.DataSource = null;
            dgDS_HangHoa.DataSource = lstHangHoa;
            txtDVT.Clear();
            txtFind.Clear();
            txtGiaBan.Clear();
            txtGiaMua.Clear();
            txtID.Clear();
            txtName.Clear();
            txtTTrang.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Hàng hóa muốn xóa và thao tác lại", "Thông báo");
            }
            else
            {
                if(MessageBox.Show("Xác nhận muốn xóa "+ txtName.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (HangHoa_BUS.Xoa(txtID.Text))
                    {
                        MessageBox.Show("Xóa " + txtName.Text + " thành công", "Thông báo");
                        lstHangHoa = HangHoa_BUS.GetHangHoa();
                        dgDS_HangHoa.DataSource = null;
                        dgDS_HangHoa.DataSource = lstHangHoa;
                        txtDVT.Clear();
                        txtFind.Clear();
                        txtGiaBan.Clear();
                        txtGiaMua.Clear();
                        txtID.Clear();
                        txtName.Clear();
                        txtTTrang.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa khách hàng " + txtName.Text, "Thông báo");
                    }
                }
                
            }
        }

        private void txtGiaMua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) // kiem tra kí tự không cho nhap kí tự chỉ cho nhạp số
            {
                e.Handled = true;
                MessageBox.Show("Giá bán phải là kiểu SỐ", "Thông báo");
                txtGiaMua.Focus();
            }
        }

        private void txtGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) // kiem tra kí tự không cho nhap kí tự chỉ cho nhạp số
            {
                e.Handled = true;
                MessageBox.Show("Giá bán phải là kiểu SỐ", "Thông báo");
                txtGiaBan.Focus();
            }
        }

        private void txtDVT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) // kiem tra kí tự không cho nhap kí tự chỉ cho nhạp số
            {
                e.Handled = true;
                MessageBox.Show("Đơn vị tính phải là kiểu KÍ TỰ", "Thông báo");
                txtDVT.Focus();
            }
        }

        private void tsThemNew_Click(object sender, EventArgs e)
        {
            frmAddMoi ft = new frmAddMoi();
            ft.user = user;
            ft.ShowDialog();
        }

        private void tsAddLoai_Click(object sender, EventArgs e)
        {
            frmLoai fl = new frmLoai();
            fl.user = user;
            fl.ShowDialog();
        }

        private void tsHangHet_Click(object sender, EventArgs e)
        {
            if (HangHoa_BUS.GetHangHoaHet() == null)
            {
                MessageBox.Show("Không có hàng hóa hết", "Thông báo");
            }
            else
            {
                frmHangHet fh = new frmHangHet();
                fh.ShowDialog();
            }
        }
        private void thêmMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsThemNew_Click(this, new EventArgs());
        }

        private void thêmLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsAddLoai_Click(this, new EventArgs());
        }

        private void hàngHếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsHangHet_Click(this, new EventArgs());
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnEdit_Click(this, new EventArgs());
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnDelete_Click(this, new EventArgs());
        }

        private void tạoMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTaoMoi_Click(this, new EventArgs());
        }

        private void tìmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFind_Click(this, new EventArgs());
        }

        private void trởVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBack_Click(this, new EventArgs());
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBack_Click(this, new EventArgs());
        }
    }
}

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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();   
        }
        private List<KhachHang_DTO> listKhachHang = new List<KhachHang_DTO>();
        public string type;
        public string user;
        private void TaoMoi()
        {
            listKhachHang = KhachHang_BUS.GetKhachHang();
            dgDS_KH.DataSource = null;
            dgDS_KH.DataSource = listKhachHang;
            dgChitiet_KH.DataSource = null;
            txtDiaChi.Clear();
            txtFind.Clear();
            txtName.Clear();
            txtSĐT.Clear();
            dtNgaysinh.Value = DateTime.Now;

        }
        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            listKhachHang = KhachHang_BUS.GetKhachHang();
            dgDS_KH.DataSource = listKhachHang;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string makh = "KH0"+ (KhachHang_BUS.SLKH()+1).ToString();
            if (txtName.Text != "" && txtSĐT.Text != "" && txtDiaChi.Text != "")
            {
                if (KhachHang_BUS.AddKhachHang(makh, txtName.Text, txtSĐT.Text,Convert.ToDateTime(dtNgaysinh.Value.ToShortDateString()), txtDiaChi.Text))
                {
                    LichSu_BUS.Add(user, DateTime.Now, "Thêm khách hàng " + txtName.Text);
                    MessageBox.Show("Thêm khách hàng " + txtName.Text + " thành công với Mã là "+makh, "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtDiaChi.Clear();
                    txtName.Clear();
                    txtSĐT.Clear();
                }
                else
                    MessageBox.Show("Thêm khách hàng thất bại!!", "Thông báo!");
            }
            else
                MessageBox.Show("Thông tin không được bỏ trống, hãy thêm đầy đủ rồi thao tác lại!!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dgDS_KH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgDS_KH.SelectedRows[0];
            txtName.Text = dr.Cells[1].Value.ToString();
            txtSĐT.Text = dr.Cells[2].Value.ToString();
            txtDiaChi.Text = dr.Cells[4].Value.ToString();
            dtNgaysinh.Value = Convert.ToDateTime(dr.Cells[3].Value.ToString());
            if (dr.Cells[5].Value.ToString() == "Bật")
            {
                btnTrangThai.Text = "Tắt";
            }
            else
                btnTrangThai.Text = "Bật";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Tên khách hàng không được bỏ trống!", "Thống báo!!");
            }
            else if (txtSĐT.Text == "")
            {
                MessageBox.Show("Số điện thoại khách hàng không được bỏ trống!", "Thống báo!!");
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ khách hàng không được bỏ trống!", "Thống báo!!");
            }
            else
            {
                if (KhachHang_BUS.Edit(dgDS_KH.SelectedRows[0].Cells[0].Value.ToString(), txtName.Text, txtSĐT.Text, dtNgaysinh.Value, txtDiaChi.Text))
                {
                    LichSu_BUS.Add(user, DateTime.Now, "Thay đổi thông tin khách hàng " + txtName.Text);
                    MessageBox.Show("Chỉnh sửa thông tin khách hàng " + txtName.Text + " thành công!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                    MessageBox.Show("Chỉnh sửa thất bại!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            TaoMoi();
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgDS_KH.SelectedRows[0].Cells[0].Value.ToString() =="")
            {

            }
            if(MessageBox.Show("Xác nhận muốn Xóa Khách Hang " +txtName.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (KhachHang_BUS.Delete(dgDS_KH.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    LichSu_BUS.Add(user, DateTime.Now, "Xóa khách hàng " + txtName.Text);
                    MessageBox.Show("Xóa Khách Hàng " + txtName.Text + " thành công.", "Thông báo");
                }
                else
                    MessageBox.Show("Không thể xóa Khách Hàng " + txtName.Text + " chỉ có thể tắt hoạt động.", "Thông báo");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn trở về giao diện chính không??", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(txtFind.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã hoặc Tên khách hàng cần tìm, và thao tác lại!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFind.Focus();
            }
            else
            {
                if(KhachHang_BUS.TimKhachHang(txtFind.Text)== null)
                {
                    MessageBox.Show("Không tìm thấy khách hàng cần tìm!", "Thông báo!");
                }
                else
                {
                    listKhachHang = KhachHang_BUS.TimKhachHang(txtFind.Text);
                    dgDS_KH.DataSource = null;
                    dgDS_KH.DataSource = listKhachHang;
                }
                
            }
        }

        private void txtSĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) // kiem tra kí tự không cho nhap kí tự chỉ cho nhạp số
            {
                e.Handled = true;
                MessageBox.Show("Số điện thoại phải là kiểu SỐ", "Thông báo");
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("      Cửa Hàng Điện Nước", new Font("Arial", 22, FontStyle.Regular), Brushes.Black, new Point(210, 20));
            e.Graphics.DrawString("                         Địa Chỉ: Nhân Hòa, Mỹ Hào, Hưng Yên", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(105, 60));
            e.Graphics.DrawString("Điện Thoại: 0963541319 - 0963541319", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(240, 85));
            e.Graphics.DrawString("Email: anhtuanhym204@gmail.com", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(260, 110));
            e.Graphics.DrawString("Danh Sách Khách Hàng", new Font("Arial", 22, FontStyle.Regular), Brushes.Black, new Point(270, 150));
            e.Graphics.DrawString("Ngày: " + DateTime.Now.ToShortDateString() + "   " + DateTime.Now.ToLongTimeString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(280, 190));
            e.Graphics.DrawString("Nhân Viên: " + NhanVien_BUS.GetNamebyID(user).ToString().Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 240));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 260));
            e.Graphics.DrawString("Mã KH", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 280));
            e.Graphics.DrawString("Tên KH", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 280));
            e.Graphics.DrawString("SĐT", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(310, 280));
            e.Graphics.DrawString("Ngày sinh", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 280));
            e.Graphics.DrawString("Địa chỉ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(580, 280));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 300));
            int location = 320;
            foreach(var i in listKhachHang)
            {
                e.Graphics.DrawString(i.Makh, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, location));
                e.Graphics.DrawString(i.Tenkh, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, location));
                e.Graphics.DrawString(i.Sdt, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(280, location));
                e.Graphics.DrawString(i.Ngaysinh.ToShortDateString(), new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, location));
                e.Graphics.DrawString(i.Diachi, new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, location));
                location += 30;
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, location - 10));

        }
        private void tsPrint_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng đang được cập nhật!", "Thông báo!");
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();// print man hinh
            printDocument1.Print();// xuát ra file pdf
        }

        private void tsNo_Click(object sender, EventArgs e)
        {
            frmXuLyNo fx = new frmXuLyNo();
            fx.ShowDialog();
        }

        private void inDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsPrint_Click(this, new EventArgs());
        }

        private void côngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsNo_Click(this, new EventArgs());
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd_Click(this, new EventArgs());
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
            btnRefesh_Click(this, new EventArgs());
        }

        private void tìmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnFind_Click(this, new EventArgs());
        }

        private void đóngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBack_Click(this, new EventArgs());
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExit_Click(this, new EventArgs());
        }

        private void tsChiTietNo_Click(object sender, EventArgs e)
        {
            if (dgDS_KH.SelectedRows[0].Cells[0].Value.ToString() == "")
            {
                MessageBox.Show("Hãy chọn khách hàng cần xem rồi thao tác lại!!", "Thông báo!!");
            }
            else
            {
                List<HoaDon_DTO> listHoaDon = HoaDon_BUS.GetHoaDonByIDKH(dgDS_KH.SelectedRows[0].Cells[0].Value.ToString());
                if (listHoaDon == null)
                {
                    MessageBox.Show("Khách hang " + txtName.Text + " chưa có giao dịch!!", "Thông báo!!");
                }
                else
                    dgChitiet_KH.DataSource = listHoaDon;
            }
        }

        private void btnTrangThai_Click(object sender, EventArgs e)
        {
            if(btnTrangThai.Text == "Tắt")
            {
                if(MessageBox.Show("Tắt, Khách Hàng KHÔNG thể giao với hệ thống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
                {
                    if (KhachHang_BUS.Tat(dgDS_KH.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        LichSu_BUS.Add(user, DateTime.Now, "Vô hiệu hóa khách hàng" + txtName.Text);
                        MessageBox.Show("Vô hiệu hóa Khách Hàng" + txtName.Text + " thành công", "Thông báo");
                    }else
                        MessageBox.Show("Vô hiệu hóa Khách Hàng" + txtName.Text + " không thành công", "Thông báo");
                }  
            }
            else
            {
                if (MessageBox.Show("Bật, Khách Hàng CÓ thể giao với hệ thống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (KhachHang_BUS.Bat(dgDS_KH.SelectedRows[0].Cells[0].Value.ToString()))
                    {
                        MessageBox.Show("Kích hoạt lại Khách Hàng" + txtName.Text + " thành công", "Thông báo");
                        LichSu_BUS.Add(user, DateTime.Now, "Kích hoạt lại khách hàng" + txtName.Text);
                    }
                    else
                        MessageBox.Show("Kích hoạt lại Khách Hàng" + txtName.Text + " không thành công", "Thông báo");
                }
            }
        }

        private void btnSeenAll_Click(object sender, EventArgs e)
        {
            listKhachHang = KhachHang_BUS.GetKhachHangAll();
            dgDS_KH.DataSource = null;
            dgDS_KH.DataSource = listKhachHang;
        }

        private void bậtTắtKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTrangThai_Click(this, new EventArgs());
        }

        private void xemTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSeenAll_Click(this, new EventArgs());
        }

        private void chiTiếtNợToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tsChiTietNo_Click(this, new EventArgs());
        }

        private void thoátToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnBack_Click(this, new EventArgs());
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

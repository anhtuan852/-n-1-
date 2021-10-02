using System;
using DTO;
using BUS;
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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            //dgDSNhanVien.Columns[0].Width = 60;
        }
        private List<ChucVu_DTO> lstChucVu = NhanVien_BUS.GetChucVu();
        private List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.GetNhanVien();
        private List<HoaDon_DTO> lstCHiTiet;
        private string manv;
        public string type;
        public string user;
        private string idnv = "";

        private void Edit()
        {
            if (NhanVien_BUS.SuacKhongCoManv(idnv, txtName.Text, cbbChucVu.SelectedValue.ToString(), txtSDT.Text, Convert.ToDateTime(dtNgaysinh.Value.ToShortDateString()), txtDiaChi.Text))
                    {
                        Account_BUS.EditType(idnv, cbbChucVu.SelectedValue.ToString());
                        MessageBox.Show("Sửa Nhân Viên " + txtName.Text + " thành công", "Thông báo");
                        lstNhanVien = NhanVien_BUS.GetNhanVien();
                        dgDSNhanVien.DataSource = null;
                        dgDSNhanVien.DataSource = lstNhanVien;
                        txtSDT.Clear();
                        txtName.Clear();
                        txtDiaChi.Clear();
                        txtFind.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Sửa Nhân Viên " + txtName.Text + " thất bại", "Thông báo");
                    }
        }
        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            lbTime_Main.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
            cbbChucVu.DataSource = lstChucVu;
            cbbChucVu.DisplayMember = "tencv";
            cbbChucVu.ValueMember = "macv";
            dgDSNhanVien.DataSource = lstNhanVien;
        }

        private void dgDSNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
            idnv = dr.Cells[0].Value.ToString();
            manv = dr.Cells[0].Value.ToString();
            txtName.Text = dr.Cells[1].Value.ToString();
            cbbChucVu.SelectedValue = dr.Cells[2].Value.ToString();
            txtSDT.Text = dr.Cells[3].Value.ToString();
            dtNgaysinh.Value =Convert.ToDateTime(dr.Cells[4].Value.ToString());
            txtDiaChi.Text = dr.Cells[5].Value.ToString();
            if (dr.Cells[6].Value.ToString() == "Bật")
            {
                btnTrangThai.Text = "Tắt";
            }
            else
                btnTrangThai.Text = "Bật";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            idnv = "NV0"+ (NhanVien_BUS.SLNV() + 1).ToString();
            if (txtName.Text == "")
            {
                MessageBox.Show("Tên Nhân Viên không được bỏ trống", "Thông báo");
            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại Nhân Viên không được bỏ trống", "Thông báo");
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ Nhân Viên không được bỏ trống", "Thông báo");
            }
            else
            {
                if (MessageBox.Show("Thêm nhân viên " + txtName.Text + " với chức vụ là " + cbbChucVu.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (NhanVien_BUS.Them(idnv, txtName.Text, cbbChucVu.SelectedValue.ToString(), txtSDT.Text, dtNgaysinh.Value.ToShortDateString(), txtDiaChi.Text))
                    {
                        MessageBox.Show("Thêm Nhân Viên " + txtName.Text + " thành công", "Thông báo");
                        lstNhanVien = NhanVien_BUS.GetNhanVien();
                        dgDSNhanVien.DataSource = null;
                        dgDSNhanVien.DataSource = lstNhanVien;
                        Account_BUS.Add(idnv, cbbChucVu.SelectedValue.ToString());
                        txtSDT.Clear();
                        txtName.Clear();
                        txtDiaChi.Clear();
                        txtFind.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Nhân Viên thất bại", "Thông báo");
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (txtName.Text == "")
            {
                MessageBox.Show("Tên Nhân Viên không được bỏ trống", "Thông báo");
            }
            else if (txtSDT.Text == "")
            {
                MessageBox.Show("Số điện thoại Nhân Viên không được bỏ trống", "Thông báo");
            }
            else if (txtDiaChi.Text == "")
            {
                MessageBox.Show("Địa chỉ Nhân Viên không được bỏ trống", "Thông báo");
            }
            else
            {   // nếu không đỗi mã nv thì sửa nhân viên không sửa mã
                int dem = 0;
                if(cbbChucVu.SelectedValue.ToString() == "NV")
                {
                    for (int i = 0; i < lstNhanVien.Count; i++)
                    {
                        if (lstNhanVien[i].Macv == "AD")
                        {
                            dem++;
                        }
                    }
                    if (dem > 1)
                    {
                        Edit();
                    }
                    else
                    {
                        MessageBox.Show("Hệ thống không thể Không có Quản Lý", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    Edit();
                }
            }
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            lstNhanVien = NhanVien_BUS.GetNhanVien();
            dgDSNhanVien.DataSource = null;
            dgDSNhanVien.DataSource = lstNhanVien;
            dgChiTietGD.DataSource = null;
            //lstCHiTiet.Clear();
            txtSDT.Clear();
            txtName.Clear();
            txtDiaChi.Clear();
            txtFind.Clear();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(idnv == "")
            {
                MessageBox.Show("Vui lòng chọn Nhân Viên cần xoa, vào thực hiện lại", "Thông báo");
            }
            else
            {
                if (MessageBox.Show("Xác nhận xóa nhân viên "+ txtName.Text, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    if (NhanVien_BUS.Xoa(idnv))
                    {
                        MessageBox.Show("Xóa nhân viên " + txtName.Text + " thành công");
                        lstNhanVien = NhanVien_BUS.GetNhanVien();
                        dgDSNhanVien.DataSource = null;
                        dgDSNhanVien.DataSource = lstNhanVien;
                        Account_BUS.Delete(idnv);
                        txtSDT.Clear();
                        txtName.Clear();
                        txtDiaChi.Clear();
                        txtFind.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Không thê nhân viên " + txtName.Text + ", hãy tắt hoạt động", "Thông báo");
                    }
                }
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if(txtFind.Text == "")
            {
                MessageBox.Show("Vui lòng nhập MÃ hoặc TÊN nhân viên cần tìm!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(NhanVien_BUS.Tim(txtFind.Text) == null)
                {
                    MessageBox.Show("Không tìm thấy", "Thông báo");
                }
                else
                {
                    lstNhanVien = NhanVien_BUS.Tim(txtFind.Text);
                    dgDSNhanVien.DataSource = null;
                    dgDSNhanVien.DataSource = lstNhanVien;
                    txtFind.Clear();
                    dgChiTietGD.DataSource = null;
                }
            }
        }

        private void btnChiTietGD_Click(object sender, EventArgs e)
        {
            if(idnv == "")
            {
                MessageBox.Show("Vui lòng chọn nhân nhân cần xem chi tiết giao dịch", "Thông báo");
            }
            else
            {
                if(HoaDon_BUS.GetHoaDonByIDNhanVien(idnv) == null)
                {
                    MessageBox.Show("Nhân viên " + txtName.Text + " chưa có giao dịch", "Thông báo");
                }
                else
                {
                    lstCHiTiet = HoaDon_BUS.GetHoaDonByIDNhanVien(idnv);
                    dgChiTietGD.DataSource = lstCHiTiet;
                }
                
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) // kiem tra kí tự không cho nhap kí tự chỉ cho nhạp số
            {
                e.Handled = true;
                MessageBox.Show("Số điện thoại phải là kiểu SỐ", "Thông báo");
                txtSDT.Focus();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Cửa Hàng Vật Liệu Xây Dựng", new Font("Arial", 22, FontStyle.Regular), Brushes.Black, new Point(210, 20));
            e.Graphics.DrawString("Địa Chỉ: 18, Ung Văn Khiêm, P.Mỹ Xuyên, TP.Long Xuyên, An Giang", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(105, 60));
            e.Graphics.DrawString("Điện Thoại: 0338931582 - 0372712376", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(240, 85));
            e.Graphics.DrawString("Email: kieukhang1805@gmail.com", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(260, 110));
            e.Graphics.DrawString("Danh Sách Nhân Viên", new Font("Arial", 22, FontStyle.Regular), Brushes.Black, new Point(270, 150));
            e.Graphics.DrawString("Ngày: " + DateTime.Now.ToShortDateString() + "   " + DateTime.Now.ToLongTimeString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(280, 190));
            e.Graphics.DrawString("Nhân Viên: " + NhanVien_BUS.GetNamebyID(user).ToString().Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 240));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 260));
            e.Graphics.DrawString("Mã NV", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(5, 280));
            e.Graphics.DrawString("Tên NV", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(70, 280));
            e.Graphics.DrawString("CV", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(230, 280));
            e.Graphics.DrawString("SĐT", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(310, 280));
            e.Graphics.DrawString("Ngày sinh", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(400, 280));
            e.Graphics.DrawString("Địa chỉ", new Font("Arial", 12, FontStyle.Regular), Brushes.Black, new Point(500, 280));
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 300));
            int location = 320;
            foreach (var i in lstNhanVien)
            {
                e.Graphics.DrawString(i.Manv, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(5, location));
                e.Graphics.DrawString(i.Tennv, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(70, location));
                e.Graphics.DrawString(i.Macv, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(230, location));
                e.Graphics.DrawString(i.Sdt, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(280, location));
                e.Graphics.DrawString(i.Ngaysinh.ToShortDateString(), new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(400, location));
                e.Graphics.DrawString(i.Diachi, new Font("Arial", 11, FontStyle.Regular), Brushes.Black, new Point(500, location));
                location += 30;
            }
            e.Graphics.DrawString("------------------------------------------------------------------------------------------------------------------------------------------", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, location-10));

        }

        private void tsExcel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức năng đang được cập nhật", "Thông báo");
        }

        private void tsPrint_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng đang được cập nhật", "Thông báo");
            //printPreviewDialog1.Document = printDocument1;
            //printPreviewDialog1.ShowDialog();// print man hinh
            printDocument1.Print();// xuát ra file pdf
        }

        private void tsSetting_Click(object sender, EventArgs e)
        {
            frmCaiDat fc = new frmCaiDat();
            fc.type = type;
            fc.user = user;
            fc.ShowDialog();
        }

        private void tsHelp_Click(object sender, EventArgs e)
        {
            frmTroGiup ft = new frmTroGiup();
            ft.ShowDialog();
        }

        private void xuấtExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsExcel_Click(this, new EventArgs());
        }

        private void inDanhSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsPrint_Click(this, new EventArgs());
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsSetting_Click(this, new EventArgs());
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsHelp_Click(this, new EventArgs());
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAdd_Click(this, new EventArgs());
        }

        private void sửaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSua_Click(this, new EventArgs());
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoa_Click(this, new EventArgs());
        }

        private void chiTiếtGiaoDịchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnChiTietGD_Click(this, new EventArgs());
        }

        private void tạoMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnTaoMoi_Click(this, new EventArgs());
        }

        private void trởVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBack_Click(this, new EventArgs());
        }
        private void btnSeenAll_Click(object sender, EventArgs e)
        {
            lstNhanVien = NhanVien_BUS.GetNhanVienAll();
            dgDSNhanVien.DataSource = null;
            dgDSNhanVien.DataSource = lstNhanVien;
        }

        private void btnTrangThai_Click(object sender, EventArgs e)
        {
            if(idnv == "")
            {
                MessageBox.Show("Vui lòng chọn lại nhân viên", "Thông báo");
            }
            else
            {
                if (btnTrangThai.Text == "Tắt")
                {
                    if (MessageBox.Show("Tắt, Nhân Viên KHÔNG thể giao với hệ thống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (NhanVien_BUS.Tat(idnv) && Account_BUS.Tat(idnv))
                        {
                            MessageBox.Show("Ngưng hoạt động Nhân Viên" + txtName.Text + " thành công", "Thông báo");
                        }
                        else
                            MessageBox.Show("Ngưng hoạt động Nhân Viên" + txtName.Text + " không thành công", "Thông báo");
                    }
                }
                else
                {
                    if (MessageBox.Show("Bật, Nhân Viên CÓ thể giao với hệ thống", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (NhanVien_BUS.Bat(idnv) && Account_BUS.Bat(idnv))
                        {
                            MessageBox.Show("Tiếp tục hoạt động Nhân Viên" + txtName.Text + " thành công", "Thông báo");
                        }
                        else
                            MessageBox.Show("Tiếp tục hoạt động Nhân Viên" + txtName.Text + " không thành công", "Thông báo");
                    }
                }
            }
        }

        private void bậtTắtNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnTrangThai_Click(this, new EventArgs());
        }

        private void xemTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSeenAll_Click(this, new EventArgs());
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBack_Click(this, new EventArgs());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime_Main.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}

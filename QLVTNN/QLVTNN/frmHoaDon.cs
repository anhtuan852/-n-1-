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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }
        private List<HoaDon_DTO> listHoaDon = HoaDon_BUS.GetHoaDon();
        private List<ThongTinHoaDon_DTO> lsttt = new List<ThongTinHoaDon_DTO>();
        private List<KhachHang_DTO> lstKh = KhachHang_BUS.GetKhachHang();
        public string type;
        public string user;
        int tong, tra, conlai;

        private PrintDialog printDialog1 = new PrintDialog();

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // Tải danh sách khách hàng vào ComboBox
            cbbKh.DataSource = lstKh;
            cbbKh.DisplayMember = "tenkh";
            cbbKh.ValueMember = "makh";
            // Tải danh sách hóa đơn vào DataGridView
            dgDS_HD.DataSource = listHoaDon;
            if(listHoaDon != null)
            {
                lbTongDoanhThu.Text = "Tổng Doanh Thu: " + (listHoaDon.Sum(x => x.Tonghd)).ToString();
                lbSLHD.Text = "Tổng Số Hóa Đơn: " + listHoaDon.Count.ToString();
            }
            
        }
        //Xem chi tiết hóa đơn
        private void btnChitiet_HD_Click(object sender, EventArgs e)
        {
            List<ThongTinHoaDon_DTO> listTTHoaDon = ThongTinHoaDon_BUS.GetThongTinHDByIDHD(Convert.ToInt32(dgDS_HD.SelectedRows[0].Cells[0].Value.ToString()));
            dgChitiet_HD.DataSource = listTTHoaDon;
        }
        //Làm mới dữ liệu
        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            listHoaDon = HoaDon_BUS.GetHoaDon();
            dgChitiet_HD.DataSource = null;
            dgDS_HD.DataSource = listHoaDon;
            lbTongDoanhThu.Text = "Tổng Doanh Thu: " + (listHoaDon.Sum(x => x.Tonghd)).ToString();
            lbSLHD.Text = "Tổng Số Hóa Đơn: " + listHoaDon.Count.ToString();
            
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Tìm kiếm hóa đơn theo ngày
        private void btn_Find_Click(object sender, EventArgs e)
        {
            if(HoaDon_BUS.XemTheoNgay(dtNgayStart.Value.ToShortDateString()+ " 00:00:00", dt_NgayEnd.Value.ToShortDateString() + " 23:59:59") == null)
            {
                MessageBox.Show("Trống, không có hóa đơn!", "Thông báo");
            }else
            {
                listHoaDon = HoaDon_BUS.XemTheoNgay(dtNgayStart.Value.ToShortDateString() + " 00:00:00", dt_NgayEnd.Value.ToShortDateString() + " 23:59:59");
                dgDS_HD.DataSource = null;
                dgDS_HD.DataSource = listHoaDon;
            }
        }
        private void xemChiTiếtHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnChitiet_HD_Click(this, new EventArgs());
        }

        private void tạoMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Refesh_Click(this, new EventArgs());
        }

        private void trởVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Back_Click(this, new EventArgs());
        }

        private void tìmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Find_Click(this, new EventArgs());
        }
        // Hiển thị thông tin chi tiết khi chọn hóa đơn
        private void dgDS_HD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lsttt = ThongTinHoaDon_BUS.GetThongTinHDByIDHD(Convert.ToInt32(dgDS_HD.SelectedRows[0].Cells[0].Value));
            tong = Convert.ToInt32(dgDS_HD.SelectedRows[0].Cells[4].Value);
            tra = Convert.ToInt32(dgDS_HD.SelectedRows[0].Cells[5].Value);
            conlai = Convert.ToInt32(dgDS_HD.SelectedRows[0].Cells[6].Value);
            if (dgDS_HD.SelectedRows[0].Cells[7].Value.ToString() == "Đã thanh toán")
            {
                cbbTthai.SelectedIndex = 1;
            }
            else
                cbbTthai.SelectedIndex = 0;

        }

        private void tsPint_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn hay không
            if (dgDS_HD.SelectedRows.Count > 0)
            {
                // Hiển thị cửa sổ in để người dùng chọn máy in và các tùy chọn in khác
                if (printDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Gọi phương thức in của đối tượng PrintDocument
                    printDocument1.Print();

                    // Thêm vào lịch sử
                    LichSu_BUS.Add(user, DateTime.Now, "In lại hóa đơn " + dgDS_HD.SelectedRows[0].Cells[0].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hóa đơn để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //Tìm hóa đơn theo khách hàng
        private void btnSeenKH_Click(object sender, EventArgs e)
        {
            listHoaDon = HoaDon_BUS.GetHoaDonByIDKH(cbbKh.SelectedValue.ToString());
            if (listHoaDon == null)
            {
                MessageBox.Show("Không có giao dịch", "Thông báo");
            }
            else
            {
                dgDS_HD.DataSource = null;
                dgDS_HD.DataSource = listHoaDon;
            }    
        }

        private void printDocument2_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("      Cửa Hàng Điện Nước", new Font("Arial", 22, FontStyle.Regular), Brushes.Black, new Point(210, 20));
            e.Graphics.DrawString("                         Địa Chỉ: Nhân Hòa, Mỹ Hào, Hưng Yên", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(105, 60));
            e.Graphics.DrawString("Điện Thoại: 0963541319 - 0963541319", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(240, 85));
            e.Graphics.DrawString("Email: anhtuanhym204@gmail.com", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(260, 110));
            e.Graphics.DrawString("  Hóa Đơn Bán Hàng", new Font("Arial", 22, FontStyle.Regular), Brushes.Black, new Point(270, 150));
            e.Graphics.DrawString("Ngày: " + DateTime.Now.ToShortDateString() + "   " + DateTime.Now.ToLongTimeString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(280, 190));
            e.Graphics.DrawString("Tên Khách Hàng: " + KhachHang_BUS.GetName(dgDS_HD.SelectedRows[0].Cells[2].Value.ToString()).Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 240));
            e.Graphics.DrawString("Số Điện Thoại: " + KhachHang_BUS.GetSDTbtIDKH(dgDS_HD.SelectedRows[0].Cells[2].Value.ToString()).Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(430, 240));
            e.Graphics.DrawString("Địa Chỉ: " + KhachHang_BUS.GetAddressbtIDKH(dgDS_HD.SelectedRows[0].Cells[2].Value.ToString()).Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 270));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------",
            new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 290));
            e.Graphics.DrawString("Mã HD", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(20, 310));
            e.Graphics.DrawString("Nhân Viên", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(130, 310));
            e.Graphics.DrawString("Ngày", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(330, 310));
            e.Graphics.DrawString("Tổng", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(480, 310));
            e.Graphics.DrawString("Trả", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(610, 310));
            e.Graphics.DrawString("Còn lại", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(730, 310));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------",
            new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 330));
            e.Graphics.DrawString(dgDS_HD.SelectedRows[0].Cells[0].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 350));
            e.Graphics.DrawString(dgDS_HD.SelectedRows[0].Cells[1].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(150, 350));
            e.Graphics.DrawString(dgDS_HD.SelectedRows[0].Cells[3].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(265, 350));
            e.Graphics.DrawString(dgDS_HD.SelectedRows[0].Cells[4].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(480, 350));
            e.Graphics.DrawString(dgDS_HD.SelectedRows[0].Cells[5].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(610, 350));
            e.Graphics.DrawString(dgDS_HD.SelectedRows[0].Cells[6].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(720, 350));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------",
            new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 370));
            e.Graphics.DrawString("Tổng Hóa Đơn:  " + tong.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(580, 400));
            e.Graphics.DrawString("Thanh toán:        " + conlai.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(580, 430));
            e.Graphics.DrawString("Tổng Trả:             " + tong.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(580, 460));
            e.Graphics.DrawString("Còn lại:                ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(580, 490));
            e.Graphics.DrawString("Nhân viên thanh toán", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(480, 530));
            e.Graphics.DrawString("(Ký và ghi rõ họ tên)", new Font("Arial", 14, FontStyle.Italic), Brushes.Black, new Point(490, 550));
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Back_Click(this, new EventArgs());
        }
        //Cập nhật trạng thái hóa đơn và in hóa đơn
        private void btnTthai_Click(object sender, EventArgs e)
        {
            if(cbbTthai.SelectedIndex == 0)
            {
                MessageBox.Show("Không thể đỗi trạng thái sang Chưa Thanh Toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(MessageBox.Show("Xác nhận Hóa Đơn "+ dgDS_HD.SelectedRows[0].Cells[0].Value.ToString()+ " Đã Thanh Toán", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    HoaDon_BUS.EditTthai(dgDS_HD.SelectedRows[0].Cells[0].Value.ToString(),Convert.ToInt32(dgDS_HD.SelectedRows[0].Cells[6].Value), cbbTthai.Text);
                    KhachHang_BUS.UpdateNoGiam(dgDS_HD.SelectedRows[0].Cells[2].Value.ToString(), conlai);
                    listHoaDon = HoaDon_BUS.GetHoaDon();
                    dgDS_HD.DataSource = null;
                    dgDS_HD.DataSource = listHoaDon;
                    //printPreviewDialog1.Document = printDocument2;
                    //printPreviewDialog1.ShowDialog();
                    printDocument2.Print();
                }
                
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("      Cửa Hàng Điện Nước", new Font("Arial", 22, FontStyle.Regular), Brushes.Black, new Point(210, 20));
            e.Graphics.DrawString("                         Địa Chỉ: Nhân Hòa, Mỹ Hào, Hưng Yên", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(105, 60));
            e.Graphics.DrawString("Điện Thoại: 0963541319 - 0963541319", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(240, 85));
            e.Graphics.DrawString("Email: anhtuanhym204@gmail.com", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(260, 110));
            e.Graphics.DrawString("  Hóa Đơn Bán Hàng", new Font("Arial", 22, FontStyle.Regular), Brushes.Black, new Point(270, 150));
            e.Graphics.DrawString("Ngày: " + DateTime.Now.ToShortDateString() + "   " + DateTime.Now.ToLongTimeString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(280, 190));
            e.Graphics.DrawString("Tên Khách Hàng: " + KhachHang_BUS.GetName(dgDS_HD.SelectedRows[0].Cells[2].Value.ToString()).Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 240));
            e.Graphics.DrawString("Số Điện Thoại: " + KhachHang_BUS.GetSDTbtIDKH(dgDS_HD.SelectedRows[0].Cells[2].Value.ToString()).Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 270));
            e.Graphics.DrawString("Địa Chỉ: " + KhachHang_BUS.GetAddressbtIDKH(dgDS_HD.SelectedRows[0].Cells[2].Value.ToString()).Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 300));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------",
            new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 320));
            e.Graphics.DrawString("Mã SP", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 340));
            e.Graphics.DrawString("Tên SP", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(110, 340));
            e.Graphics.DrawString("DVT", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(350, 340));
            e.Graphics.DrawString("Giá", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(450, 340));
            e.Graphics.DrawString("Số Lượng", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(580, 340));
            e.Graphics.DrawString("Thành Tiền", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(700, 340));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------",
            new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 370));
            int location = 390;
            foreach (var i in lsttt)
            {
                e.Graphics.DrawString(i.Masp, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, location));
                e.Graphics.DrawString(i.Tensp, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(110, location));
                e.Graphics.DrawString(i.Dvtinh, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(350, location));
                e.Graphics.DrawString(i.Gia.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(450, location));
                e.Graphics.DrawString(i.Soluong.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(610, location));
                e.Graphics.DrawString(i.Thanhtien.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(720, location));
                location += 30;
            }
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------",
            new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, location - 10));
            e.Graphics.DrawString("Tổng Hóa Đơn:  " + tong.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(580, location + 20));
            e.Graphics.DrawString("Đã thanh toán:    " + tra.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(580, location + 50));
            e.Graphics.DrawString("Còn lại:                 " + conlai.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(580, location + 80));
            e.Graphics.DrawString("Ngày giao hàng:.............. ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(20, location + 100));
            e.Graphics.DrawString("Địa chỉ giao hàng:........................................................................ ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(20, location + 130));
            e.Graphics.DrawString("Nhân viên thanh toán", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(480, location + 160));
            e.Graphics.DrawString("(Ký và ghi rõ họ tên)" , new Font("Arial", 14, FontStyle.Italic), Brushes.Black, new Point(490, location + 190));
        }
    }
}

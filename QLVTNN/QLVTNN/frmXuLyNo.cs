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
    public partial class frmXuLyNo : Form
    {
        public frmXuLyNo()
        {
            InitializeComponent();
        }
        int tthai =0;
        private List<HoaDon_DTO> lstHD = new List<HoaDon_DTO>();
        List<HoaDon_DTO> lstHDT = new List<HoaDon_DTO>();
        public string user;
        private void frmXuLyNo_Load(object sender, EventArgs e)
        {
            List<KhachHang_DTO> lstKhachHang = KhachHang_BUS.GetKhachHang();
            
            cbb_IDKH.DataSource = lstKhachHang;
            cbb_IDKH.DisplayMember = "tenkh";
            cbb_IDKH.ValueMember = "makh";
            lstHDT = HoaDon_BUS.GetHoaDonByIDKH(cbb_IDKH.SelectedValue.ToString());
            lbNO.Text = "Nợ: " + (KhachHang_BUS.GetCongNo(cbb_IDKH.SelectedValue.ToString())).ToString();
            if (HoaDon_BUS.GetHoaDonByIDKHChuaTT(cbb_IDKH.SelectedValue.ToString()) != null)
            {
                lstHD = HoaDon_BUS.GetHoaDonByIDKHChuaTT(cbb_IDKH.SelectedValue.ToString());
                lstHDT = HoaDon_BUS.GetHoaDonByIDKH(cbb_IDKH.SelectedValue.ToString());
                lbslHD.Text = "Hóa đơn: " + lstHDT.Count;
                dgDsHD.DataSource = null;
                dgDsHD.DataSource = lstHD;
            }
        }

        private void cbb_IDKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbNO.Text = "Nợ: " + (KhachHang_BUS.GetCongNo(cbb_IDKH.SelectedValue.ToString())).ToString();
            if (HoaDon_BUS.GetHoaDonByIDKHChuaTT(cbb_IDKH.SelectedValue.ToString()) != null)
            {
                lstHD = HoaDon_BUS.GetHoaDonByIDKHChuaTT(cbb_IDKH.SelectedValue.ToString());
                lstHDT = HoaDon_BUS.GetHoaDonByIDKH(cbb_IDKH.SelectedValue.ToString());
                lbslHD.Text = "Hóa đơn: " + lstHDT.Count;
                dgDsHD.DataSource = null;
                dgDsHD.DataSource = lstHD;
            }
            else
            {
                dgDsHD.DataSource = null;
            }
        }

        private void txtTra_TextChanged(object sender, EventArgs e)
        {
            if(txtTra.Text != "")
            {
                txtConLai.Text = (Convert.ToInt32(dgDsHD.SelectedRows[0].Cells[6].Value.ToString()) - Convert.ToInt32(txtTra.Text)).ToString();
            }
            else
            {
                txtConLai.Text = dgDsHD.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int conlai = Convert.ToInt32(txtConLai.Text);
            string t;
            if (conlai == 0)
            {
                t = "Đã thanh toán";
            }
            else
                t = "Chưa thanh toán";
            if (tthai ==0)
            {
                MessageBox.Show("Vui lòng chọn Hóa Đơn cần thanh toán", "Thông báo");
            }
            else if(txtTra.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền trả trước khi thanh toán", "Thông báo");
            }
            else
            {
                int tra = Convert.ToInt32(txtTra.Text);
                if (Convert.ToInt32(dgDsHD.SelectedRows[0].Cells[6].Value.ToString()) - tra < 0)
                {
                    MessageBox.Show("Số tiền trả lớn hơn số tiền phải trả", "Thông báo");
                }
                else
                {
                    if (MessageBox.Show("Xác nhận thanh toán nợ khách hàng: " + cbb_IDKH.Text + "??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        if (HoaDon_BUS.EditThanhToan(dgDsHD.SelectedRows[0].Cells[0].Value.ToString(),Convert.ToInt32(txtTra.Text) ,Convert.ToInt32(txtConLai.Text), t))
                        {
                            KhachHang_BUS.UpdateNoGiam(cbb_IDKH.SelectedValue.ToString(), tra);
                            MessageBox.Show("Thanh toán nợ thành công, nợ mới " + cbb_IDKH.Text + ": " + KhachHang_BUS.GetCongNo(cbb_IDKH.SelectedValue.ToString()), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            lstHD = HoaDon_BUS.GetHoaDonByIDKHChuaTT(cbb_IDKH.SelectedValue.ToString());
                            dgDsHD.DataSource = null;
                            dgDsHD.DataSource = lstHD;
                            //printPreviewDialog1.Document = printDocument1;
                            //printPreviewDialog1.ShowDialog();
                            printDocument1.Print();
                            LichSu_BUS.Add(user, DateTime.Now, "Thanh toán nợ khách hàng " + cbb_IDKH.Text + ": " + txtTra.Text);
                        }
                        else
                        {
                            MessageBox.Show("Thanh toán nợ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
        }

        private void txtTra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) // kiem tra kí tự không cho nhap kí tự chỉ cho nhạp số
            {
                e.Handled = true;
                MessageBox.Show("Số tiền trả phải là kiểu SỐ", "Thông báo");
                txtTra.Focus();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgDsHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tthai = 1;
            lbNO.Text = "Nợ: " + dgDsHD.SelectedRows[0].Cells[6].Value.ToString();
            txtConLai.Text = dgDsHD.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if(tthai == 1)
            {
                txtTra.Text = dgDsHD.SelectedRows[0].Cells[6].Value.ToString();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Cửa Hàng Vật Liệu Xây Dựng", new Font("Arial", 22, FontStyle.Regular), Brushes.Black, new Point(170, 20));
            e.Graphics.DrawString("Địa Chỉ: 07, Tổ 06, Ấp Phú Hạ, Xã Phú Xuân, Huyện Phú Tân, An Giang", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(105, 60));
            e.Graphics.DrawString("Điện Thoại: 0338931582 - 0372712376", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(240, 85));
            e.Graphics.DrawString("Email: kieukhang1805@gmail.com", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(260, 110));
            e.Graphics.DrawString("Hóa Đơn Bán Hàng", new Font("Arial", 22, FontStyle.Regular), Brushes.Black, new Point(270, 150));
            e.Graphics.DrawString("Ngày: " + DateTime.Now.ToShortDateString() + "   " + DateTime.Now.ToLongTimeString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(280, 190));
            e.Graphics.DrawString("Tên Khách Hàng: " + cbb_IDKH.Text.Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 240));
            e.Graphics.DrawString("Số Điện Thoại: " + KhachHang_BUS.GetSDTbtIDKH(cbb_IDKH.SelectedValue.ToString()).Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(430, 240));
            e.Graphics.DrawString("Địa Chỉ: " + KhachHang_BUS.GetAddressbtIDKH(cbb_IDKH.SelectedValue.ToString()).Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 270));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------",
            new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 290));
            e.Graphics.DrawString("Mã HD", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(20, 310));
            e.Graphics.DrawString("Nhân Viên", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(130, 310));
            e.Graphics.DrawString("Ngày", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(350, 310));
            e.Graphics.DrawString("Tổng", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(480, 310));
            e.Graphics.DrawString("Trả", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(610, 310));
            e.Graphics.DrawString("Còn lại", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(730, 310));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------",
            new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 330));
            e.Graphics.DrawString(dgDsHD.SelectedRows[0].Cells[0].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 350));
            e.Graphics.DrawString(dgDsHD.SelectedRows[0].Cells[1].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(150, 350));
            e.Graphics.DrawString(dgDsHD.SelectedRows[0].Cells[3].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(265, 350));
            e.Graphics.DrawString(dgDsHD.SelectedRows[0].Cells[4].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(480, 350));
            e.Graphics.DrawString(dgDsHD.SelectedRows[0].Cells[5].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(610, 350));
            e.Graphics.DrawString(dgDsHD.SelectedRows[0].Cells[6].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(720, 350));
            e.Graphics.DrawString("----------------------------------------------------------------------------------------------------------------------------------------",
            new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(0, 370));
            e.Graphics.DrawString("Tổng Hóa Đơn:  " + dgDsHD.SelectedRows[0].Cells[4].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(580, 400));
            e.Graphics.DrawString("Thanh toán:        " + txtTra.Text, new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(580, 430));
            e.Graphics.DrawString("Tổng Trả:             " + dgDsHD.SelectedRows[0].Cells[5].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(580, 460));
            e.Graphics.DrawString("Còn lại:                " + dgDsHD.SelectedRows[0].Cells[6].Value.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(580, 490));
            e.Graphics.DrawString("Nhân viên thanh toán", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(480, 530));
            e.Graphics.DrawString("(Ký và ghi rõ họ tên)", new Font("Arial", 14, FontStyle.Italic), Brushes.Black, new Point(490, 550));

        }
    }
}

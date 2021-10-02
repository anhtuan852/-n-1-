using DTO;
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
using System.Drawing.Printing;

namespace QLVTNN
{
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
        }
        public string type; // khai báo để lấy loại tài khoản
        private List<ThongTinHoaDon_DTO> lstHD = new List<ThongTinHoaDon_DTO>(); // 
        private List<ThongTinHoaDon_TMP> lstHD_tmp = new List<ThongTinHoaDon_TMP>();
        int TongHD;
        public string user;
        int SLHang;
        public int count = 0;
        int idtthd = 1;
        int mahoadon;
        public int tra;
        public int conlai;

        private void LoadDataInCBB()
        {
            List<Loai_DTO> lstLoai = Loai_BUS.LayLoai();// Hien loai len combobox
            cbb_Loai.DataSource = lstLoai;
            cbb_Loai.DisplayMember = "tenloai";
            cbb_Loai.ValueMember = "maloai";
            List<HangHoa_DTO> lstHangHoa = HangHoa_BUS.GetHangHoaByID(cbb_Loai.SelectedValue.ToString());// show masp tensp theo loai
            cbb_Name_SP.DataSource = lstHangHoa;
            cbb_Name_SP.ValueMember = "tensp";
            cbb_ID_SP.DataSource = lstHangHoa;
            cbb_ID_SP.ValueMember = "masp";
            cbb_Price.DataSource = lstHangHoa;
            cbb_Price.ValueMember = "giaban";
            cbb_DVT.DataSource = lstHangHoa;
            cbb_DVT.ValueMember = "dvtinh"; 
            List<KhachHang_DTO> lstKhachHang = KhachHang_BUS.GetKhachHang();//Hien thong tin khach hang len combobox
            cbb_ID_KH.DataSource = lstKhachHang;
            cbb_ID_KH.DisplayMember = "tenkh";
            cbb_ID_KH.ValueMember = "makh";
            cbb_ID_KH.SelectedIndex = -1;
            //cbb_Name_KH.DataSource = lstKhachHang;
            //cbb_Name_KH.ValueMember = "tenkh";
        }
        // load from---------------------------------------------------------------------------------------------------------------
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            LoadDataInCBB();
            if(HoaDon_BUS.GetSLHD() < 1)
            {
                mahoadon = 1000000;
            }
            else
            {
                mahoadon = (HoaDon_BUS.GetSLHD() + 1);// get ma hd
            }
        }

        // sự kiện  cbb loại ----------------------------------------------------------------------------------------------------
        private void cbb_Loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            // khi thay doi loai dc chon load lai data masp, tensp, giaban va dvtinh
            List<HangHoa_DTO> lstHangHoa = HangHoa_BUS.GetHangHoaByID(cbb_Loai.SelectedValue.ToString());
            cbb_Name_SP.DataSource = lstHangHoa;
            cbb_Name_SP.ValueMember = "tensp";
            cbb_ID_SP.DataSource = lstHangHoa;
            cbb_ID_SP.ValueMember = "masp";
            cbb_Price.DataSource = lstHangHoa;
            cbb_Price.ValueMember = "giaban";
            cbb_DVT.DataSource = lstHangHoa;
            cbb_DVT.ValueMember = "dvtinh"; 
        }
        private void ThemHangHoa()
        {
            ThongTinHoaDon_TMP tmp = new ThongTinHoaDon_TMP();
            tmp.Loaisp = cbb_Loai.SelectedValue.ToString();
            tmp.Masp = cbb_ID_SP.SelectedValue.ToString();
            tmp.Tensp = cbb_Name_SP.SelectedValue.ToString();
            tmp.Dvtinh = cbb_DVT.SelectedValue.ToString();
            tmp.Gia = Convert.ToInt32(cbb_Price.SelectedValue.ToString());
            tmp.Soluong = Convert.ToInt32(nm_SL.Value.ToString());
            tmp.Thanhtien = Convert.ToInt32(cbb_Price.SelectedValue.ToString()) * Convert.ToInt32(nm_SL.Value.ToString());

            ThongTinHoaDon_DTO item = new ThongTinHoaDon_DTO();
            item.Id = ThongTinHoaDon_BUS.GetIDThongTinHoaDon() + idtthd;
            item.Loaisp = cbb_Loai.SelectedValue.ToString();
            item.Masp = cbb_ID_SP.SelectedValue.ToString();
            item.Tensp = cbb_Name_SP.SelectedValue.ToString();
            item.Dvtinh = cbb_DVT.SelectedValue.ToString();
            item.Gia = Convert.ToInt32(cbb_Price.SelectedValue.ToString());
            item.Soluong = Convert.ToInt32(nm_SL.Value.ToString());
            item.Thanhtien = Convert.ToInt32(cbb_Price.SelectedValue.ToString()) * Convert.ToInt32(nm_SL.Value.ToString());
            item.Idhd = mahoadon;
            lstHD.Add(item);// them hang hóa chon vao list
            lstHD_tmp.Add(tmp);
            dgBanHang.DataSource = null;// cho dg rõng
            dgBanHang.DataSource = lstHD_tmp;// hien lại dg sau khi them hang hoa

            TongHD = Convert.ToInt32(lstHD.Sum(x => x.Thanhtien)); // cap nhat tong hd
            lbTongHD.Text = "Tổng Hóa Đơn: " + TongHD.ToString() + " VNĐ";
            SLHang += 1; // cap nhat sl sp
            lbSLHang.Text = "Tổng Số Hàng: " + SLHang.ToString();

            nm_SL.Value = 0;// sau khi them xoa du lieuj nuber soluong
            idtthd++;
        }
        // Nút thêm hàng hóa ---------------------------------------------------------------------------------------------------
        private void btn_Add_Click(object sender, EventArgs e)
        {
            int tmp = 0;
            if (nm_SL.Value == 0)
            {
                MessageBox.Show("Chưa chọn Số Lượng Hàng Hóa, vui lòng chọn và thực hiện lại!!", "Thống báo");
            }
            else
            {
                if (Convert.ToInt32(nm_SL.Value.ToString()) < HangHoa_BUS.GetSLByIDSP(cbb_ID_SP.SelectedValue.ToString()))
                {
                    if(lstHD.Count > 0)// nếu đã có hàng hóa thì kiểm tra hàng thêm có trùng vs hàng đã thêm không có thì cập nhật số lượng, không thì thêm mới
                    {
                        for (int i = 0; i < lstHD.Count; i++)
                        {
                            if (cbb_ID_SP.SelectedValue.ToString() == lstHD[i].Masp)
                            {
                                lstHD[i].Soluong += Convert.ToInt32(nm_SL.Value.ToString());
                                lstHD_tmp[i].Soluong += Convert.ToInt32(nm_SL.Value.ToString());

                                dgBanHang.DataSource = null;
                                dgBanHang.DataSource = lstHD_tmp;
                                
                                tmp = 1; // ghi giá trị tạm
                            }
                        }
                        if(tmp == 0)// nếu giá trị bạn khác 0 có nghiã hàng hóa đã có chỉ cập nhật số lượng
                        {
                            ThemHangHoa();
                        }

                    }
                    else
                    {
                        ThemHangHoa();// thêm mới hàng hóa
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng " + cbb_Name_SP.SelectedValue.ToString() + " hiện tại " + HangHoa_BUS.GetSLByIDSP(cbb_ID_SP.SelectedValue.ToString()) +
                        " nhỏ hơn số lượng chọn vui lòng nhập thêm hàng hóa hoặc chọn sản phẩm khác và thao tác lại!", "Thông báo");
                    nm_SL.Focus();
                }
            }
        }

        // sự kiện click datagridview ------------------------------------------------------------------------------------------
        private void dgBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgBanHang.SelectedRows[0];
            cbb_Loai.SelectedValue = dr.Cells[0].Value.ToString();
            nm_SL.Value = Convert.ToDecimal(dr.Cells[5].Value.ToString());
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgBanHang.Rows.Count == 0)
            {
                MessageBox.Show("Không có thông tin để xóa!", "Thông báo!");
            }
            else
            {
                int index = dgBanHang.CurrentCell.RowIndex;// lấy index xóa
                lstHD_tmp.RemoveAt(index);// xóa item tại index tạm
                lstHD.RemoveAt(index);// xóa item tại index 
                dgBanHang.DataSource = null;
                dgBanHang.DataSource = lstHD_tmp; // cap nhat lại dgBanHang
                //dgBanHang.Columns["id"].HeaderText = "ID";
                TongHD = Convert.ToInt32(lstHD.Sum(x => x.Thanhtien));// cap nhat tonghd
                lbTongHD.Text = "Tổng Hóa Đơn: " + TongHD.ToString() + " VNĐ";
                SLHang -= 1; // cap nhat slsp
                lbSLHang.Text = "Tổng Số Hàng: " + SLHang.ToString();
                // sau khi them xoa du lieuj txt soluong
                nm_SL.Value = 0;
            }
        }

        private void btn_Pay_Click(object sender, EventArgs e)
        {
            if(cbb_ID_KH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn khách hàng thanh toán", "Thông báo");
            }
            else
            {
                if (dgBanHang.Rows.Count == 0)
                {
                    MessageBox.Show("Không có gì để THANH TOÁN", "Thong báo");
                }
                else
                {
                    if (MessageBox.Show("Xác nhân thanh toán hóa đơn khách hàng: " + cbb_ID_KH.Text + " với tổng hóa đơn: " + TongHD, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        frmThanhToan ftt = new frmThanhToan();
                        ftt.IDHD = mahoadon;
                        ftt.tenkh = cbb_ID_KH.Text;
                        ftt.user = user;
                        ftt.tongHD = TongHD;
                        ftt.makh = cbb_ID_KH.SelectedValue.ToString();
                        ftt.slsp = SLHang;
                        if (ftt.ShowDialog() == DialogResult.OK) //neu lick thanh toan trong from thi thục thi bên duói
                        {
                            for (int i = 0; i < dgBanHang.Rows.Count; i++) // vong lap row trong datagridview
                            {
                                ThongTinHoaDon_DTO tt = new ThongTinHoaDon_DTO();
                                tt.Id = ThongTinHoaDon_BUS.GetIDThongTinHoaDon() + 1;
                                tt.Loaisp = dgBanHang.Rows[i].Cells[0].Value.ToString();
                                tt.Masp = dgBanHang.Rows[i].Cells[1].Value.ToString();
                                tt.Tensp = dgBanHang.Rows[i].Cells[2].Value.ToString();
                                tt.Dvtinh = dgBanHang.Rows[i].Cells[3].Value.ToString();
                                tt.Gia = Convert.ToInt32(dgBanHang.Rows[i].Cells[4].Value.ToString());
                                tt.Soluong = Convert.ToInt32(dgBanHang.Rows[i].Cells[5].Value.ToString());
                                tt.Thanhtien = Convert.ToInt32(dgBanHang.Rows[i].Cells[6].Value.ToString());
                                tt.Idhd = mahoadon;
                                ThongTinHoaDon_BUS.ThemTTHoaDon(tt); // add thong tin hoa don tren dâtgridview
                                HangHoa_BUS.UpdateSLSP(dgBanHang.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(dgBanHang.Rows[i].Cells[5].Value.ToString()));// cap nhat sl sp
                            }
                            tra = ftt.tra;
                            conlai = ftt.conlai;
                            //printPreviewDialog1.Document = printDocument1;
                            //printPreviewDialog1.ShowDialog();// print man hinh
                            printDocument1.Print();// xuát ra file pdf
                            lstHD.Clear(); // xoa list
                            lstHD_tmp.Clear();// xoa list tạm
                            dgBanHang.DataSource = null; // xóa datagridview

                            lbTongHD.Text = "Tổng Hóa Đơn: 0 VNĐ";
                            SLHang += 1; // cap nhat sl sp
                            lbSLHang.Text = "Tổng Số Hàng: 0";
                        }
                    }
                }
            }

        }

        private void btn_Refesh_Click(object sender, EventArgs e)
        {
            LoadDataInCBB(); // load data in cbb
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Cửa Hàng Vật Liệu Xây Dựng", new Font("Arial", 22, FontStyle.Regular), Brushes.Black, new Point(170, 20));
            e.Graphics.DrawString("Địa Chỉ: 07, Tổ 06, Ấp Phú Hạ, Xã Phú Xuân, Huyện Phú Tân, An Giang", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(105, 60));
            e.Graphics.DrawString("Điện Thoại: 0338931582 - 0372712376", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(240, 85));
            e.Graphics.DrawString("Email: kieukhang1805@gmail.com", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(260, 110));
            e.Graphics.DrawString("Hóa Đơn Bán Hàng", new Font("Arial", 22, FontStyle.Regular), Brushes.Black, new Point(270, 150));
            e.Graphics.DrawString("Ngày: " + DateTime.Now.ToShortDateString()+ "   "+ DateTime.Now.ToLongTimeString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(280, 190));
            e.Graphics.DrawString("Tên Khách Hàng: " + cbb_ID_KH.Text.Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 240));
            e.Graphics.DrawString("Số Điện Thoại: " + KhachHang_BUS.GetSDTbtIDKH(cbb_ID_KH.SelectedValue.ToString()).Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 270));
            e.Graphics.DrawString("Địa Chỉ: " + KhachHang_BUS.GetAddressbtIDKH(cbb_ID_KH.SelectedValue.ToString()).Trim(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(10, 300));
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
            foreach (var i in lstHD)
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
            e.Graphics.DrawString("Tổng Hóa Đơn:  " + TongHD.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(580, location + 20));
            e.Graphics.DrawString("Đã thanh toán:    " + tra.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(580, location + 50));
            e.Graphics.DrawString("Còn lại:                 " + conlai.ToString(), new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(580, location + 80));
            e.Graphics.DrawString("Ngày giao hàng:.............. ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(20, location + 100));
            e.Graphics.DrawString("Địa chỉ giao hàng:........................................................................ ", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(20, location + 130));
            e.Graphics.DrawString("Nhân viên thanh toán", new Font("Arial", 14, FontStyle.Regular), Brushes.Black, new Point(480, location + 160));
            e.Graphics.DrawString("(Ký và ghi rõ họ tên)", new Font("Arial", 14, FontStyle.Italic), Brushes.Black, new Point(490, location + 190));
        }

        private void tsSeenPrice_Click(object sender, EventArgs e)
        {
            frmSeenPrice fs = new frmSeenPrice();
            fs.ShowDialog();
        }

        private void tsHangHet_Click(object sender, EventArgs e)
        {
            if (HangHoa_BUS.GetHangHoaHet() == null)
            {
                MessageBox.Show("Hiện tại không có hàng nào hết!", "Thông báo");
            }
            else
            {
                frmHangHet fh = new frmHangHet();
                fh.ShowDialog();
            }
        }
        private void tsAddKh_Click(object sender, EventArgs e)
        {
            frmThemKhachHang fa = new frmThemKhachHang();
            fa.ShowDialog();
        }

        private void xemGiáToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsSeenPrice_Click(this, new EventArgs());
        }

        private void xemHàngHếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsHangHet_Click(this, new EventArgs());
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsNhapHang_Click(this, new EventArgs());
        }

        private void tsNhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang fn = new frmNhapHang();
            fn.user = user;
            fn.type = type;
            fn.ShowDialog();
        }


        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsAddKh_Click(this, new EventArgs());
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Add_Click(this, new EventArgs());
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Delete_Click(this, new EventArgs());
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Pay_Click(this, new EventArgs());
        }

        private void tạoMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Refesh_Click(this, new EventArgs());
        }

        private void trởVềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Back_Click(this, new EventArgs());
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Back_Click(this, new EventArgs());
        }
    }
}

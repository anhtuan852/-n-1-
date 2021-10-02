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
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }
        private int id = NhapHang_BUS.GetID() + 1;
        private int id_tmp = 1;
        private List<NhapHang_DTO> lstNhapTam = new List<NhapHang_DTO>();
        private int SLHang = 0;
        public string user;
        public string type;
        private void NhapHang()
        {
            NhapHang_DTO nhap = new NhapHang_DTO();
            nhap.Id = id;
            nhap.Masp = cbb_ID_SP.SelectedValue.ToString();
            nhap.Tensp = cbb_Name_SP.SelectedValue.ToString();
            nhap.Soluong = Convert.ToInt32(nm_SL.Value.ToString());
            nhap.Ngaynhap = DateTime.Now;
            nhap.Manv = "NV01";
            nhap.Dvtinh = cbbDVT.SelectedValue.ToString();
            nhap.Gia = Convert.ToInt32(cbbGia.SelectedValue.ToString());
            nhap.Tong = nhap.Soluong * nhap.Gia;
            lstNhapTam.Add(nhap);
            dgNhapHang.DataSource = null;
            dgNhapHang.DataSource = lstNhapTam;
            SLHang++;
            lbTong.Text = "Tổng nhập: " + (lstNhapTam.Sum(x => x.Tong)).ToString();
            lbSL.Text = "Số hàng: " + SLHang.ToString();
            id++;
            nm_SL.Value = 0;
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if(dgNhapHang.Rows.Count == 0)
            {
                MessageBox.Show("Danh sách hàng trống, vui lòng thêm vào danh nhập", "Thông báo");
            }
            else if(MessageBox.Show("Xác nhận nhập hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
            {
                for(int i =0; i<dgNhapHang.Rows.Count; i++)
                {
                    NhapHang_DTO nh = new NhapHang_DTO();
                    nh.Id =Convert.ToInt32(dgNhapHang.Rows[i].Cells[0].Value.ToString());
                    nh.Masp = dgNhapHang.Rows[i].Cells[1].Value.ToString();
                    nh.Tensp = dgNhapHang.Rows[i].Cells[2].Value.ToString();
                    nh.Soluong =Convert.ToInt32(dgNhapHang.Rows[i].Cells[3].Value.ToString());
                    nh.Ngaynhap =DateTime.Now;
                    nh.Manv = dgNhapHang.Rows[i].Cells[5].Value.ToString();
                    nh.Dvtinh = dgNhapHang.Rows[i].Cells[6].Value.ToString();
                    nh.Gia =Convert.ToInt32(dgNhapHang.Rows[i].Cells[7].Value.ToString());
                    nh.Tong =Convert.ToInt32(dgNhapHang.Rows[i].Cells[8].Value.ToString());
                    NhapHang_BUS.Them(nh);
                    HangHoa_BUS.CapNhatTang(nh.Masp.ToString(), nh.Soluong);
                }
                MessageBox.Show("Nhập hàng thành công", "Thông báo");
                lstNhapTam.Clear();
                dgNhapHang.DataSource = null;
                dgNhapHang.DataSource = lstNhapTam;
            }
            
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            List<HangHoa_DTO> listHangHoa = HangHoa_BUS.GetHangHoa();
            //dgNhapHang.DataSource = listHangHoa;

            cbb_ID_SP.DataSource = listHangHoa;
            cbb_ID_SP.ValueMember = "masp";
            cbb_Name_SP.DataSource = listHangHoa;
            cbb_Name_SP.ValueMember = "tensp";
            cbbDVT.DataSource = listHangHoa;
            cbbDVT.ValueMember = "dvtinh";
            cbbGia.DataSource = listHangHoa;
            cbbGia.ValueMember = "giaban";
        }

        private void btnRefesh_Click(object sender, EventArgs e)
        {
            List<HangHoa_DTO> lstHangHoa = HangHoa_BUS.GetHangHoa();
            cbb_ID_SP.DataSource = lstHangHoa;
            cbb_ID_SP.ValueMember = "masp";
            cbb_Name_SP.DataSource = lstHangHoa;
            cbb_Name_SP.ValueMember = "tensp";
            if(lstNhapTam.Count >0)
            {
                lbSL.Text = "Số hàng: "+lstNhapTam.Count.ToString();
                lbTong.Text = "Tổng nhập: " + lstNhapTam.Sum(x => x.Tong).ToString();
                dgNhapHang.DataSource = null;
                dgNhapHang.DataSource = lstNhapTam;
            }
            else
            {
                lbSL.Text = "Số hàng: 0";
                lbTong.Text = "Tổng nhập: 0";
            }
        }

        private void btn_Find_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cbb_ID_SP.SelectedValue.ToString());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int tmp = 0;
            if (nm_SL.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng hàng nhập!", "Thông báo");
            }
            else
            {
                if (lstNhapTam.Count > 0)// nếu đã có hàng hóa thì kiểm tra hàng thêm có trùng vs hàng đã thêm không có thì cập nhật số lượng, không thì thêm mới
                {
                    for (int i = 0; i < lstNhapTam.Count; i++)
                    {
                        if (cbb_ID_SP.SelectedValue.ToString() == lstNhapTam[i].Masp)
                        {
                            lstNhapTam[i].Soluong += Convert.ToInt32(nm_SL.Value.ToString());
                            dgNhapHang.DataSource = null;
                            dgNhapHang.DataSource = lstNhapTam;

                            tmp = 1; // ghi giá trị tạm
                        }
                    }
                    if (tmp == 0)// nếu giá trị bạn khác 0 có nghiã hàng hóa đã có chỉ cập nhật số lượng
                    {
                        NhapHang();
                    }
                }
                else
                {
                    NhapHang();
                }
            }
        }

        private void dgNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgNhapHang.SelectedRows[0];
            id_tmp =Convert.ToInt32(dr.Cells[0].Value.ToString());
            cbb_ID_SP.Text = dr.Cells[1].Value.ToString();
            cbb_Name_SP.Text = dr.Cells[2].Value.ToString();
            nm_SL.Value = Convert.ToDecimal(dr.Cells[3].Value.ToString());
            cbbDVT.Text = dr.Cells[6].Value.ToString();
            cbbGia.Text = dr.Cells[7].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsAddNew_Click(object sender, EventArgs e)
        {
            frmThemMoiHang ft = new frmThemMoiHang();
            ft.ShowDialog();
        }

        private void tsAddLoai_Click(object sender, EventArgs e)
        {
            frmLoai fl = new frmLoai();
            fl.ShowDialog();
        }

        private void tsHangHet_Click(object sender, EventArgs e)
        {
            if (HangHoa_BUS.GetHangHoaHet() == null)
            {
                MessageBox.Show("Không có hàng hóa nào hết số lượng", "Thông báo");
            }
            else
            {
                frmHangHet fh = new frmHangHet();
                fh.ShowDialog();
            }
        }

        private void tsChiTietNhap_Click(object sender, EventArgs e)
        {
            frmChiTietNhap ft = new frmChiTietNhap();
            ft.user = user;
            ft.type = type;
            ft.ShowDialog();
        }

        private void tsSetting_Click(object sender, EventArgs e)
        {
            frmCaiDat fc = new frmCaiDat();
            fc.type = type;
            fc.user = user;
            fc.ShowDialog();
        }

        private void thêmHàngMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsAddNew_Click(this, new EventArgs());
        }

        private void thêmLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsAddLoai_Click(this, new EventArgs());
        }

        private void hàngHếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsHangHet_Click(this, new EventArgs());
        }

        private void chiTiếtNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsChiTietNhap_Click(this, new EventArgs());
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsSetting_Click(this, new EventArgs());
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsHelp_Click(this, new EventArgs());
        }

        private void tsHelp_Click(object sender, EventArgs e)
        {
            frmTroGiup ft = new frmTroGiup();
            ft.ShowDialog();
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThem_Click(this, new EventArgs());
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnXoa_Click_1(this, new EventArgs());
        }

        private void nhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNhapHang_Click(this, new EventArgs());
        }

        private void tạoMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnRefesh_Click(this, new EventArgs());
        }

        private void tìmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btn_Find_Click(this, new EventArgs());
        }

        private void trởLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBack_Click(this, new EventArgs());
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBack_Click(this, new EventArgs());
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if(id_tmp == -1)
            {
                MessageBox.Show("Vui lòng chọn lại chi tiết nhập cần xóa", "Thông báo");
            }
            else
            {
                var index = dgNhapHang.CurrentCell.RowIndex;
                lstNhapTam.RemoveAt(index);
                dgNhapHang.DataSource = null;
                dgNhapHang.DataSource = lstNhapTam;
                SLHang--;
                lbTong.Text = "Tổng nhập: " + (lstNhapTam.Sum(x => x.Tong)).ToString();
                lbSL.Text = "Số hàng: " + SLHang.ToString();
                id--;
                nm_SL.Value = 0;

            }
        }
    }
}

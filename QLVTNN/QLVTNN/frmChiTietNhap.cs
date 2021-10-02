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

namespace QLVTNN
{
    public partial class frmChiTietNhap : Form
    {
        public frmChiTietNhap()
        {
            InitializeComponent();
        }
        private List<NhapHang_DTO> lstNhapHang = NhapHang_BUS.GetNhapHang();
        public string type;
        public string user;


        private void frmChiTietNhap_Load(object sender, EventArgs e)
        {
            if (type == "AD")
                btnDelete.Enabled = true;
            else
                btnDelete.Enabled = false;
            dgDSNhap.DataSource = lstNhapHang;
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            lstNhapHang = NhapHang_BUS.GetNhapHang();
            dgDSNhap.DataSource = null;
            dgDSNhap.DataSource = lstNhapHang;
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmBaoCaoNhap fb = new frmBaoCaoNhap();
            fb.user = user;
            fb.type = type;
            fb.ShowDialog();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if(NhapHang_BUS.Xem(dtStart.Value.ToShortDateString()+ " 00:00:00", dtEnd.Value.ToShortDateString()+ " 23:59:59") == null)
            {
                MessageBox.Show("Trống, không tìm thấy thông tin", "Thông tin");
            }
            else
            {
                lstNhapHang = NhapHang_BUS.Xem(dtStart.Value.ToShortDateString() + " 00:00:00", dtEnd.Value.ToShortDateString() + " 23:59:59");
                dgDSNhap.DataSource = null;
                dgDSNhap.DataSource = lstNhapHang;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Xác nhận in danh sách chi tiết nhập và xóa toàn bộ chi tiết nhập hàng", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (NhapHang_BUS.Delete())
                {
                    MessageBox.Show("In và Xóa chi tiết nhập hàng thành công", "Thông báo");
                    lstNhapHang = NhapHang_BUS.GetNhapHang();
                    dgDSNhap.DataSource = null;
                    dgDSNhap.DataSource = lstNhapHang;
                }
            }
        }
    }
}

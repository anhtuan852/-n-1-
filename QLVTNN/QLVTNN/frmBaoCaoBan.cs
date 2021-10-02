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
    public partial class frmBaoCaoBan : Form
    {
        public frmBaoCaoBan()
        {
            InitializeComponent();
        }
        public string user;
        public string type;
        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLVLXDDataSet3.USP_BaoCaoNgay' table. You can move, or remove it, as needed.
            this.USP_BaoCaoNgayTableAdapter.Fill(this.QLVLXDDataSet3.USP_BaoCaoNgay);
            // TODO: This line of code loads data into the 'QLVLXDDataSet1.USP_HoaDonChiTiet' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'QLVLXDDataSet.USP_HoaDon' table. You can move, or remove it, as needed.

            //this.reportViewer3.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer3.RefreshReport();
        }

        private void btnBaoCao_Click_1(object sender, EventArgs e)
        {
            this.USP_HoaDonTableAdapter.Fill(this.QLVLXDDataSet.USP_HoaDon, Convert.ToDateTime(dtStart.Value.ToShortDateString()), Convert.ToDateTime(dtEnd.Value.ToShortDateString()));
            
            this.reportViewer1.RefreshReport();
            LichSu_BUS.Add(user, DateTime.Now, "Báo cáo bán hàng");

        }

        private void btnBaoCaoTT_Click(object sender, EventArgs e)
        {
            this.USP_HoaDonChiTietTableAdapter.Fill(this.QLVLXDDataSet1.USP_HoaDonChiTiet, Convert.ToDateTime(dtStarttt.Value.ToShortDateString()), Convert.ToDateTime(dtEndtt.Value.ToShortDateString()));
            
            this.reportViewer2.RefreshReport();
            LichSu_BUS.Add(user, DateTime.Now, "Báo cáo bán hàng chi tiết");
        }
    }
}

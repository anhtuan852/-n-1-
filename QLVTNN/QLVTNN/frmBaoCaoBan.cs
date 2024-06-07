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
using System.Data.SqlClient;

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
            // TODO: This line of code loads data into the 'qLCHDNDataSet1.USP_BaoCaoNgay' table. You can move, or remove it, as needed.
            this.uSP_BaoCaoNgayTableAdapter.Fill(this.qLCHDNDataSet1.USP_BaoCaoNgay);
            // TODO: This line of code loads data into the 'QLVLXDDataSet3.USP_BaoCaoNgay' table. You can move, or remove it, as needed.
            //this.USP_BaoCaoNgayTableAdapter.Fill(this.QLVLXDDataSet3.USP_BaoCaoNgay);
            // TODO: This line of code loads data into the 'QLVLXDDataSet1.USP_HoaDonChiTiet' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'QLVLXDDataSet.USP_HoaDon' table. You can move, or remove it, as needed.

            //this.reportViewer3.RefreshReport();
            //this.reportViewer3.RefreshReport();
            //this.reportViewer3.RefreshReport();
            //this.uSP_BaoCaoNgayTableAdapter.FillByCurrentDay(this.qLCHDNDataSet1.USP_BaoCaoNgay);
            this.reportViewer3.RefreshReport();
        }

        private void btnBaoCao_Click_1(object sender, EventArgs e)
        {
            this.uSP_HoaDonTableAdapter.Fill(this.qLCHDNDataSet2.USP_HoaDon, Convert.ToDateTime(dtStart.Value.ToShortDateString()), Convert.ToDateTime(dtEnd.Value.ToShortDateString()));
            
            this.reportViewer1.RefreshReport();

        }

        private void btnBaoCaoTT_Click(object sender, EventArgs e)
        {
            this.uSP_HoaDonChiTietTableAdapter.Fill(this.qLCHDNDataSet3.USP_HoaDonChiTiet, Convert.ToDateTime(dtStarttt.Value.ToShortDateString()), Convert.ToDateTime(dtEndtt.Value.ToShortDateString()));
            
            this.reportViewer2.RefreshReport();
        }


    }
}

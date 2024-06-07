using System;
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
    public partial class frmBaoCaoNhap : Form
    {
        public frmBaoCaoNhap()
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            InitializeComponent();
        }
        public string user;
        public string type;

        private void frmBaoCaoNhap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLVLXDDataSet2.USP_NhapHang' table. You can move, or remove it, as needed.
            
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            this.uSP_NhapHangTableAdapter.Fill(this.qLCHDNDataSet.USP_NhapHang, Convert.ToDateTime(dtStart.Value.ToShortDateString()), Convert.ToDateTime(dtEnd.Value.ToShortDateString()));

            this.reportViewer1.RefreshReport();
            LichSu_BUS.Add(user, DateTime.Now, "Báo cáo nhập hàng");
        }
    }
}

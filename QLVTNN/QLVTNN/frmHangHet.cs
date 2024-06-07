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
    public partial class frmHangHet : Form
    {
        public frmHangHet()
        {
            InitializeComponent();
        }
        private List<HangHoa_TMP> lstHangHoa = HangHoa_BUS.GetHangHoaHet();
        private void frmHangHet_Load(object sender, EventArgs e)
        {
            if(lstHangHoa != null)
            {
                dgDS_HangHet.DataSource = lstHangHoa;
            }
            else
            {
                MessageBox.Show("Không có Hàng Hóa hết số lượng", "Thông báo");
                this.Close();
            } 
        }
    }
}

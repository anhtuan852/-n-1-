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
    public partial class frmSeenPrice : Form
    {
        public frmSeenPrice()
        {
            InitializeComponent();
        }
        private List<HangHoa_TMP> lstHangHoa = HangHoa_BUS.GetHangHoa_TMP();
        private void frmSeenPrice_Load(object sender, EventArgs e)
        {
            dgDs.DataSource = lstHangHoa;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (txtFind.Text == "")
            {
                MessageBox.Show("Vui lòng nhập Mã hoặc Tên cần tìm!!", "Thông báo");
            }
            else
            {
                if (HangHoa_BUS.Tim(txtFind.Text) == null)
                {
                    MessageBox.Show("Không tìm thấy!", "Thông báo");
                }
                else
                {
                    List<HangHoa_TMP> lstFind = HangHoa_BUS.Tim_TMP(txtFind.Text);
                    dgDs.DataSource = null;
                    dgDs.DataSource = lstFind;
                }

            }
        }

        private void txtTaoMoi_Click(object sender, EventArgs e)
        {
            dgDs.DataSource = null;
            dgDs.DataSource = lstHangHoa;
            txtFind.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

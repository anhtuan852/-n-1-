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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }
        private List<ChamCong_DTO> lst = new List<ChamCong_DTO>();
        private int id;

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            List<NhanVien_DTO> lstNV = NhanVien_BUS.GetNhanVien();
            cbbNhanVien.DataSource = lstNV;
            cbbNhanVien.DisplayMember = "tennv";
            cbbNhanVien.ValueMember = "manv";
            lst = ChamCong_BUS.GetChamCong();
            if(lst != null)
            {
                dgChamCong.DataSource = lst;
            }
        }

        private void btnChamCong_Click(object sender, EventArgs e)
        {
            if (txtGhiChu.Text == "")
            {
                ChamCong_BUS.Add(cbbNhanVien.SelectedValue.ToString(), Convert.ToDateTime(dtNgay.Value), "");
                lst = ChamCong_BUS.GetChamCong();
                dgChamCong.DataSource = null;
                dgChamCong.DataSource = lst;
            }
            else
            {
                ChamCong_BUS.Add(cbbNhanVien.SelectedValue.ToString(), Convert.ToDateTime(dtNgay.Value), txtGhiChu.Text);
                lst = ChamCong_BUS.GetChamCong();
                dgChamCong.DataSource = null;
                dgChamCong.DataSource = lst;
            }    
                
        }

        private void dgChamCong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id =  Convert.ToInt32(dgChamCong.SelectedRows[0].Cells[0].Value.ToString());
            cbbNhanVien.SelectedValue = dgChamCong.SelectedRows[0].Cells[1].Value.ToString();
            dtNgay.Value = Convert.ToDateTime(dgChamCong.SelectedRows[0].Cells[2].Value.ToString());
            txtGhiChu.Text = dgChamCong.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

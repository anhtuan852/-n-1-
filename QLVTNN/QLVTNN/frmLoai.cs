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
    public partial class frmLoai : Form
    {
        public frmLoai()
        {
            InitializeComponent();
        }
        private List<Loai_DTO> lstLoai = Loai_BUS.LayLoai();
        public string user;
        private void frmLoai_Load(object sender, EventArgs e)
        {
            dgDs.DataSource = lstLoai;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("Mã Loại không được bỏ trống", "Thông báo");
                txtID.Focus();
            }else if(txtName.Text == "")
            {
                MessageBox.Show("Tên Loại không được bỏ trống", "Thông báo");
                txtName.Focus();
            }
            else
            {
                if (Loai_BUS.Tim(txtID.Text) != null)
                {
                    MessageBox.Show("Mã Loại "+txtID.Text+" đã tồn lại, vui lòng nhập mã khác và thao tác lại", "Thông báo");
                }
                else
                {
                    if (Loai_BUS.Them(txtID.Text, txtName.Text))
                    {
                        MessageBox.Show("Thêm thành công!", "Thông báo");
                        LichSu_BUS.Add(user, DateTime.Now, "Thêm loại " + txtName.Text);
                        lstLoai = Loai_BUS.LayLoai();
                        //dgDs.DataSource = null;
                        dgDs.DataSource = lstLoai;
                    }
                    else
                        MessageBox.Show("Thêm thất bại", "Thông báo");
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Mã Loại không được bỏ trống", "Thông báo");
                txtID.Focus();
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Tên Loại không được bỏ trống", "Thông báo");
                txtName.Focus();
            }
            else
            {
                if (Loai_BUS.Sua(dgDs.SelectedRows[0].Cells[0].Value.ToString(), txtID.Text, txtName.Text))
                {
                    MessageBox.Show("Sửa thành công!", "Thông báo");
                    lstLoai = Loai_BUS.LayLoai();
                    LichSu_BUS.Add(user, DateTime.Now, "Sửa thông tin loại " + txtName.Text);
                    //dgDs.DataSource = null;
                    dgDs.DataSource = lstLoai;
                }
                else
                    MessageBox.Show("Sửa thất bại", "Thông báo");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Chức năng đang được cập nhật!", "Thông báo");
            if (MessageBox.Show("Xác nhận Xóa "+dgDs.SelectedRows[0].Cells[0].Value.ToString(), "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (Loai_BUS.Xoa(txtID.Text))
                {
                    MessageBox.Show("Xóa " + dgDs.SelectedRows[0].Cells[0].Value.ToString() + " thành công", "Thông báo");
                    lstLoai = Loai_BUS.LayLoai();
                    LichSu_BUS.Add(user, DateTime.Now, "Xóa loại " + txtName.Text);
                    dgDs.DataSource = null;
                    dgDs.DataSource = lstLoai;
                }
                else
                    MessageBox.Show("Xóa " + dgDs.SelectedRows[0].Cells[0].Value.ToString() + " Thất bại, loại này có hàng hóa, cần xóa hết hàng hóa thuộc loại này, Đang Cập Nhật", "Thông báo");
            }
            
        }

        private void btnTaoMoi_Click(object sender, EventArgs e)
        {
            lstLoai = Loai_BUS.LayLoai();
            dgDs.DataSource = null;
            dgDs.DataSource = lstLoai;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void dgDs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgDs.SelectedRows[0];
            txtID.Text = dr.Cells[0].Value.ToString();
            txtName.Text = dr.Cells[1].Value.ToString();
        }
    }
}

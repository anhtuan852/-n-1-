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
    public partial class frmCaiDat : Form
    {
        public frmCaiDat()
        {
            InitializeComponent();
        }
        public string type;
        public string user;
        List<Account_DTO_tmp> lst = Account_BUS.GetAccount();
        public void RefreshAccount()
        {
            if (type == "AD")
            {
                dgAccount.DataSource = lst;
            }
            else
            {
                List<Account_DTO_tmp> lsta = Account_BUS.GetbyUser(user);
                dgAccount.DataSource = lsta;
                btnRefresh.Enabled = false;
            }
        }
        private void frmCaiDat_Load(object sender, EventArgs e)
        {
            if (type == "AD")
            {
                dgAccount.DataSource = lst;
            }
            else
            {
                List<Account_DTO_tmp> lsta = Account_BUS.GetbyUser(user);
                dgAccount.DataSource = lsta;
                btnRefresh.Enabled = false;
            }
            txtUser.Enabled = false;
        }
        private void dgAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dr = dgAccount.SelectedRows[0];
            txtUser.Text = dr.Cells[0].Value.ToString();
            if (user != dr.Cells[0].Value.ToString())
            {
                txtPass.Enabled = false;
                txtPassXacNhan.Enabled = false;
                btnEdit.Enabled = false;
                //
            }
            else
            {
                txtPass.Enabled = true;
                txtPassXacNhan.Enabled = true;
                btnEdit.Enabled = true;
            }
            //if(type !=Convert.ToInt32(dr.Cells[0].Value.ToString()) && user != dr.Cells[0].Value.ToString())
            ////{
            //    btnEdit.Enabled = false;
           // }else
            //    btnEdit.Enabled = true;


        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // refresh pass
            if(txtUser.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần Refresh Pass", "Thông báo");
            }
            else
            {
                if(MessageBox.Show("Xác nhận Refresh Pass tài khoản "+txtUser.Text+" ??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)== DialogResult.OK)
                {
                    if (Account_BUS.Refresh(txtUser.Text))
                    {
                        MessageBox.Show("Refresh Pass tài khoản " + txtUser.Text + " thành công");
                        LichSu_BUS.Add(user, DateTime.Now, "Refresh Pass tài khoản" + dgAccount.SelectedRows[0].Cells[0].Value.ToString());
                    }
                    else
                        MessageBox.Show("Refresh Pass thất bại", "Thông báo");
                }
                
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(txtPass.Text == "")
            {
                MessageBox.Show("Mật khẩu không được bỏ trống");
            }
            else if (txtUser.Text == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản cẩn đổi mật khẩu");
            }
            else if(txtPass.Text != txtPassXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu và mật khẩu xác nhân không trùng khớp", "Thông báo");
            }
            
            else
            {
                if(Account_BUS.EditPass(txtUser.Text, txtPass.Text))
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo");
                    LichSu_BUS.Add(user, DateTime.Now, "Đỗi mật khẩu tài khoản" + dgAccount.SelectedRows[0].Cells[0].Value.ToString());
                    txtPass.Clear();
                    txtPassXacNhan.Clear();
                }else
                    MessageBox.Show("Đổi mật khẩu không thành công", "Thông báo");
            }
        }
    }
}

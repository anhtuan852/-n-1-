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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public string user;
        public string type = "XX";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmProressbar fp = new frmProressbar();
            fp.ShowDialog();
            // lấy thông tin người dùng nhập
            string username = txtUsername.Text;
            string password = txtPassword.Text;



            // nếu == null có nghĩ không có username và password hoặc không đúng từ người dùng nhập
            if(Account_BUS.LayAccount(username, password)== null)
            {
                // xuất câu thông báo
                MessageBox.Show("Tài khoản, mật khẩu không chính xác hoặc đã bị tạm khóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                type = "XX";
                user = "";
            }
            // ngược lại đúng là có tồn tại username và password mà dùng dùng nhập
            else
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain fm = new frmMain();
                this.Close();// ẩn from hiện tại
                // lấy thông tin loại tài khoản mà dùng nhập, là Admin hay Nhân Viên
                type = Account_BUS.GetTypeAccont(username, password);
                user = txtUsername.Text;
                LichSu_BUS.Add(user, DateTime.Now, "Đăng nhập");
                if (checkBox1.Checked)
                {
                    Properties.Settings.Default.user = txtUsername.Text;
                    Properties.Settings.Default.pass = txtPassword.Text;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.user = "";
                    Properties.Settings.Default.pass = "";
                    Properties.Settings.Default.Save();
                }
                // show ra from bán hàng hay from chính của phần mềm
            }
            //MessageBox.Show(user.ToString());
            fp.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Properties.Settings.Default.user;
            txtPassword.Text = Properties.Settings.Default.pass;
        }
    }
}

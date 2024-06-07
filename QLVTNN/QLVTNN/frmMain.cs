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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }
        public string typeuser = "XX";
        public string username;

        frmBanHang banhang = null;
        private void btnBanHang()
        {
            if (banhang == null || banhang.IsDisposed)
            {
                if (typeuser != "XX") // nếu type bằng -1 là chưa đăng nhập
                {
                    banhang = new frmBanHang();
                    IsMdiContainer = true;
                    banhang.MdiParent = this;
                    banhang.user = username;
                    banhang.type = typeuser;
                    banhang.Show();
                }
                else
                {
                    MessageBox.Show("Bạn hãy ĐĂNG NHẬP trước khi thao tác!", "Thông báo");
                }

            }
            else
                banhang.Activate();
        }
        frmNhapHang nhaphang = null;
        private void btnNhanHang()
        {
            if (nhaphang == null || nhaphang.IsDisposed)
            {
                if (typeuser != "XX")
                {
                    nhaphang = new frmNhapHang();
                    IsMdiContainer = true;
                    nhaphang.MdiParent = this;
                    nhaphang.user = username;
                    nhaphang.type = typeuser;
                    nhaphang.Show();
                }
                else
                {
                    MessageBox.Show("Bạn hãy ĐĂNG NHẬP trước khi thao tác!", "Thông báo");
                }
            }
            else
                nhaphang.Activate();
        }

        frmKhachHang kh = null;
        private void btnQLKhachHang()
        {
            if (kh == null || kh.IsDisposed)
            {
                if (typeuser != "XX")
                {
                    kh = new frmKhachHang();
                    IsMdiContainer = true;
                    kh.MdiParent = this;
                    kh.user = username;
                    kh.type = typeuser;
                    kh.Show();
                }
                else
                {
                    MessageBox.Show("Bạn hãy ĐĂNG NHẬP trước khi thao tác!", "Thông báo");
                }
            }
            else
                kh.Activate();
        }

        frmNhanVien nv = null;
        private void btnQLNhanVien()
        {
            if (nv == null || nv.IsDisposed)
            {
                if (typeuser != "XX")
                {
                    if (typeuser == "AD")
                    {
                        nv = new frmNhanVien();
                        IsMdiContainer = true;
                        nv.MdiParent = this;
                        nv.user = username;
                        nv.type = typeuser;
                        nv.Show();
                    }
                    else
                    {
                        MessageBox.Show("Bạn hãy đăng nhập với quyền QUẢN LÝ và thao tác lại", "Thông báo");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn hãy ĐĂNG NHẬP trước khi thao tác!", "Thông báo");
                }
            }
            else
                nv.Activate();
        }

        frmHoaDon hd = null;
        private void btnQLHoaDon()
        {
            if (hd == null || hd.IsDisposed)
            {
                if (typeuser != "XX")
                {
                    hd = new frmHoaDon();
                    IsMdiContainer = true;
                    hd.MdiParent = this;
                    hd.user = username;
                    hd.type = typeuser;
                    hd.Show();
                }
                else
                {
                    MessageBox.Show("Bạn hãy ĐĂNG NHẬP trước khi thao tác!", "Thông báo");
                }
            }
            else
                hd.Activate();
        }

        frmKho kho = null;
        private void btnQLKho()
        {
            if (kho == null || kho.IsDisposed)
            {
                if (typeuser != "XX")
                {
                    kho = new frmKho();
                    IsMdiContainer = true;
                    kho.MdiParent = this;
                    kho.user = username;
                    kho.type = typeuser;
                    kho.Show();
                }
                else
                {
                    MessageBox.Show("Bạn hãy ĐĂNG NHẬP trước khi thao tác!", "Thông báo");
                }
            }
            else
                kho.Activate();
        }

        // load from----------------------------------------------------------------------------------------------------------------
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            lbTime_Main.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        // time---------------------------------------------------------------------------------------------------------------
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime_Main.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        // Button sự kiện click --------------------------------------------------------------------------------------------------
        private void tsbtnSale_Click(object sender, EventArgs e)
        {
            btnBanHang();
        }
        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnBanHang();
        }

        private void tsbtnNhap_Click(object sender, EventArgs e)
        {
            btnNhanHang();
        }
        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnNhanHang();
        }
        private void tsbtnKhachhang_Click(object sender, EventArgs e)
        {
            btnQLKhachHang();
        }
        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnQLKhachHang();
        }

        private void tsbtnNhanvien_Click(object sender, EventArgs e)
        {
            btnQLNhanVien();
        }
        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnQLNhanVien();
        }

        private void tsbtnHoadon_Click(object sender, EventArgs e)
        {
            btnQLHoaDon();
        }

        private void quảnKýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnQLHoaDon();
        }

        private void tsbtnKho_Click(object sender, EventArgs e)
        {
            btnQLKho();
        }

        private void quảnLýKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnQLKho();
        }

        private void báoCáoBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tsbtnBCban_Click(this, new EventArgs());
        }

        private void báoCáoNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tsbtnBCnhap_Click(this, new EventArgs());
        }

        private void càiĐặtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (typeuser != "XX")
            {
                frmCaiDat fb = new frmCaiDat();
                fb.user = username;
                fb.type = typeuser;
                this.Hide();
                fb.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn hãy ĐĂNG NHẬP trước khi thao tác!", "Thông báo");
            }

        }
        private void saoLưuToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if(typeuser == "AD")
            {
                FolderBrowserDialog saoluu = new FolderBrowserDialog();
                saoluu.Description = "Chọn thư mục lưu trữ sao lưu dữ liệu";
                if (saoluu.ShowDialog() == DialogResult.OK)
                {
                    string sDuongDan = saoluu.SelectedPath;
                    if (DuLieu_BUS.SaoLuu(sDuongDan) == true)
                        MessageBox.Show("Đã sao lưu dữ liệu vào " + sDuongDan, "Thông báo");
                    else
                        MessageBox.Show("Sao lưu dữ liệu thất bại!", "Thông báo");
                }
            }
            else
            {
                MessageBox.Show("Chỉ có thể thao tác với quyền Quản Lý!", "Thông báo");
            }

        }

        private void khôiPhụcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (typeuser == "AD")
            {
                OpenFileDialog phuchoi = new OpenFileDialog();
                phuchoi.Filter = "*.bak|*.bak";
                phuchoi.Title = "Chọn tập tin phục hồi (.bak)"; ;
                if (phuchoi.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(phuchoi.FileName);
                    string duongdan = phuchoi.FileName;
                    DuLieu_BUS.PhucHoi(duongdan);
                    
                    if (DuLieu_BUS.PhucHoi(duongdan))
                    {
                        if(MessageBox.Show("Khôi phục dữ liệu thành công, cần khởi động lại Hệ thống", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            Application.Restart();
                        }
                    }    
                    else
                       MessageBox.Show("Khôi phục không thành công", "Thôn báo"); 
                }

            }
            else
            {
                MessageBox.Show("Chỉ có thể thao tác với quyền Quản Lý!", "Thông báo");
            } 
        }
        // suwk kien X tren from
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Xác nhận muốn ĐÓNG chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                e.Cancel = false;
                //Application.Exit(); 
                if(typeuser != "XX")
                {
                    LichSu_BUS.Add(username, DateTime.Now, "Đăng xuất, đóng chương trình");
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void tsbtnLogin_Click(object sender, EventArgs e)
        {
            if (typeuser == "XX")
            {
                frmLogin fl = new frmLogin();
                fl.ShowDialog();
                username = fl.user;
                typeuser = fl.type;
            }

        }

        private void tsbtnLogout_Click(object sender, EventArgs e)
        {
            if (typeuser == "XX")
            {
                MessageBox.Show("Bạn chưa đăng nhập, vui lòng đăng nhập là thao tác lại!", "Thông báo");
            }
            else
            {
                if (MessageBox.Show("Xác nhận đăng xuất??", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    typeuser = "XX";
                    username = "";
                    MessageBox.Show("Đăng xuất khỏi " + username + " thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        frmBaoCaoBan bcb = null;
        private void tsbtnBCban_Click(object sender, EventArgs e)
        {
            if (bcb == null || bcb.IsDisposed)
            {
                if (typeuser != "XX")
                {
                    bcb = new frmBaoCaoBan();
                    IsMdiContainer = true;
                    bcb.MdiParent = this;
                    bcb.Show();
                }
                else
                {
                    MessageBox.Show("Bạn hãy ĐĂNG NHẬP trước khi thao tác!", "Thông báo");
                }
            }
            else
                bcb.Activate();
        }

        frmBaoCaoNhap bcn = null;
        private void tsbtnBCnhap_Click(object sender, EventArgs e)
        {
            if (bcn == null || bcn.IsDisposed)
            {
                if (typeuser != "XX")
                {
                    bcn = new frmBaoCaoNhap();
                    IsMdiContainer = true;
                    bcn.MdiParent = this;
                    bcn.Show();
                }
                else
                {
                    MessageBox.Show("Bạn hãy ĐĂNG NHẬP trước khi thao tác!", "Thông báo");
                }
            }
            else
                bcn.Activate();
        }

        frmAdmin admin = null;
        private void quảnLýToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (admin == null || admin.IsDisposed)
            {
                if (typeuser == "AD")
                {
                    admin = new frmAdmin();
                    IsMdiContainer = true;
                    admin.MdiParent = this;
                    admin.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng đăng nhập với tài khoản Quản lý");
                }
            }
            else
                admin.Activate();
        }

        private void đăngNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tsbtnLogin_Click(this, new EventArgs());
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tsbtnLogout_Click(this, new EventArgs());
        }
        frmTroGiup help = null;
        private void tsmHelp_Click(object sender, EventArgs e)
        {
            if (help == null || help.IsDisposed)
            {
                if (typeuser != "XX")
                {
                    help = new frmTroGiup();
                    IsMdiContainer = true;
                    help.MdiParent = this;
                    help.Show();
                }
                else
                {
                    MessageBox.Show("Bạn hãy ĐĂNG NHẬP trước khi thao tác!", "Thông báo");
                }
            }
            else
                help.Activate();
        }

        // Sửa tên nút và sự kiện Click cho nút Thống kê nhập
        private void btnThongKeNhapHang_Click(object sender, EventArgs e)
        {
            if (typeuser != "XX")
            {
                frmThongkeNhapHang thongkeNhapHang = new frmThongkeNhapHang(); // Khởi tạo form thống kê nhập
                thongkeNhapHang.MdiParent = this; // Đặt frmMain là form cha
                thongkeNhapHang.Show(); // Hiển thị form thống kê nhập
            }
            else
            {
                MessageBox.Show("Bạn hãy ĐĂNG NHẬP trước khi thao tác!", "Thông báo");
            }
        }

        // Sửa tên nút và sự kiện Click cho nút Thống kê bán
        private void btnThongKeBanHang_Click(object sender, EventArgs e)
        {
            if (typeuser != "XX")
            {
                frmThongkebanhang thongkeBanHang = new frmThongkebanhang(); // Khởi tạo form thống kê bán
                thongkeBanHang.MdiParent = this; // Đặt frmMain là form cha
                thongkeBanHang.Show(); // Hiển thị form thống kê bán
            }
            else
            {
                MessageBox.Show("Bạn hãy ĐĂNG NHẬP trước khi thao tác!", "Thông báo");
            }
        }

        private void thongkeban_Click(object sender, EventArgs e)
        {
            if (typeuser != "XX")
            {
                frmThongkebanhang thongkeBanHang = new frmThongkebanhang(); // Khởi tạo form thống kê bán
                thongkeBanHang.MdiParent = this; // Đặt frmMain là form cha
                thongkeBanHang.Show(); // Hiển thị form thống kê bán
            }
            else
            {
                MessageBox.Show("Bạn hãy ĐĂNG NHẬP trước khi thao tác!", "Thông báo");
            }
        }

        private void btnthongkenhaphang_Click_1(object sender, EventArgs e)
        {
            if (typeuser != "XX")
            {
                frmThongkeNhapHang thongkeNhapHang = new frmThongkeNhapHang(); // Khởi tạo form thống kê nhập
                thongkeNhapHang.MdiParent = this; // Đặt frmMain là form cha
                thongkeNhapHang.Show(); // Hiển thị form thống kê nhập
            }
            else
            {
                MessageBox.Show("Bạn hãy ĐĂNG NHẬP trước khi thao tác!", "Thông báo");
            }
        }
    }
}

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
    public partial class frmTroGiup : Form
    {
        public frmTroGiup()
        {
            InitializeComponent();
        }

        private void frmTroGiup_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(@"D:\Lap Trinh Quan Ly\QuanLyCuaHangVatLieuXayDung\QLVTNN\QLVTNN\TroGiup\HDSD_Main.mht");
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            switch (e.Node.Name) 
            {
                case "nMain":
                    webBrowser1.Navigate(@"D:\Lap Trinh Quan Ly\QuanLyCuaHangVatLieuXayDung\QLVTNN\QLVTNN\TroGiup\HDSD_Main.mht");
                    break;
                case "nSale":
                    webBrowser1.Navigate(@"D:\Lap Trinh Quan Ly\QuanLyCuaHangVatLieuXayDung\QLVTNN\QLVTNN\TroGiup\HDSD_BanHang.mht");
                    break;
                case "nNhap":
                    webBrowser1.Navigate(@"D:\Lap Trinh Quan Ly\QuanLyCuaHangVatLieuXayDung\QLVTNN\QLVTNN\TroGiup\HDSD_NhapHang.mht");
                    break;
                case "nNhapNew":
                    webBrowser1.Navigate(@"D:\Lap Trinh Quan Ly\QuanLyCuaHangVatLieuXayDung\QLVTNN\QLVTNN\TroGiup\HDSD_NhapHangNew.mht");
                    break;
                case "nKHMain":
                    webBrowser1.Navigate(@"D:\Lap Trinh Quan Ly\QuanLyCuaHangVatLieuXayDung\QLVTNN\QLVTNN\TroGiup\HDSD_QLKhachHang.mht");
                    break;
                case "nNVMain":
                    webBrowser1.Navigate(@"D:\Lap Trinh Quan Ly\QuanLyCuaHangVatLieuXayDung\QLVTNN\QLVTNN\TroGiup\HDSD_QLNhanVien.mht");
                    break;
                case "nHDMain":
                    webBrowser1.Navigate(@"D:\Lap Trinh Quan Ly\QuanLyCuaHangVatLieuXayDung\QLVTNN\QLVTNN\TroGiup\HDSD_QLHoaDon.mht");
                    break;
                case "nKHOMain":
                    webBrowser1.Navigate(@"D:\Lap Trinh Quan Ly\QuanLyCuaHangVatLieuXayDung\QLVTNN\QLVTNN\TroGiup\HDSD_QLKho.mht");
                    break;
                case "nBaoCao_ban":
                    webBrowser1.Navigate(@"D:\Lap Trinh Quan Ly\QuanLyCuaHangVatLieuXayDung\QLVTNN\QLVTNN\TroGiup\HDSD_BCNhap.mht");
                    break;
                case "nBaoCao_nhap":
                    webBrowser1.Navigate(@"D:\Lap Trinh Quan Ly\QuanLyCuaHangVatLieuXayDung\QLVTNN\QLVTNN\TroGiup\HDSD_BCBanHang.mht");
                    break;
            }

        }
    }
}

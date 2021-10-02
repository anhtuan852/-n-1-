
namespace QLVTNN
{
    partial class frmTroGiup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Giao diện chính");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Bán hàng");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Nhập hàng đã có");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Nhập hàng mới");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Nhập hàng", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Quản lý khách hàng");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Quản lý nhân viên");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Quản lý hóa đơn");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Quản lý kho");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Báo cáo bán hàng");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Báo cáo nhập hàng");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Báo cáo", new System.Windows.Forms.TreeNode[] {
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTroGiup));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nMain";
            treeNode1.Text = "Giao diện chính";
            treeNode2.Name = "nSale";
            treeNode2.Text = "Bán hàng";
            treeNode3.Name = "nNhap";
            treeNode3.Text = "Nhập hàng đã có";
            treeNode4.Name = "nNhapNew";
            treeNode4.Text = "Nhập hàng mới";
            treeNode5.Name = "nNhapMain";
            treeNode5.Text = "Nhập hàng";
            treeNode6.Name = "nKHMain";
            treeNode6.Text = "Quản lý khách hàng";
            treeNode7.Name = "nNVMain";
            treeNode7.Text = "Quản lý nhân viên";
            treeNode8.Name = "nHDMain";
            treeNode8.Text = "Quản lý hóa đơn";
            treeNode9.Name = "nKHOMain";
            treeNode9.Text = "Quản lý kho";
            treeNode10.Name = "nBC_ban";
            treeNode10.Text = "Báo cáo bán hàng";
            treeNode11.Name = "nBC_nhap";
            treeNode11.Text = "Báo cáo nhập hàng";
            treeNode12.Name = "nBaoCao";
            treeNode12.Text = "Báo cáo";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9,
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(214, 520);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(233, 13);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(680, 520);
            this.webBrowser1.TabIndex = 1;
            // 
            // frmTroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 545);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTroGiup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTroGiup";
            this.Load += new System.EventHandler(this.frmTroGiup_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}
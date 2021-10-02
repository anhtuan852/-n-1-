﻿
namespace QLVTNN
{
    partial class frmHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Find = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_NgayEnd = new System.Windows.Forms.DateTimePicker();
            this.dtNgayStart = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChitiet_HD = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Refesh = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgDS_HD = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dgChitiet_HD = new System.Windows.Forms.DataGridView();
            this.lbSLHD = new System.Windows.Forms.Label();
            this.lbTongDoanhThu = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtBáoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xuấtLạiHóaĐonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemChiTiếtHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trởVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBaoCao = new System.Windows.Forms.ToolStripButton();
            this.tsPint = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTthai = new System.Windows.Forms.ComboBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnSeenKH = new System.Windows.Forms.Button();
            this.cbbKh = new System.Windows.Forms.ComboBox();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDS_HD)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChitiet_HD)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btn_Find);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dt_NgayEnd);
            this.groupBox1.Controls.Add(this.dtNgayStart);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(845, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 86);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết xem";
            // 
            // btn_Find
            // 
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Find.Image = global::QLVTNN.Properties.Resources.find;
            this.btn_Find.Location = new System.Drawing.Point(188, 18);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(75, 58);
            this.btn_Find.TabIndex = 16;
            this.btn_Find.Text = "Xem";
            this.btn_Find.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Find.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_Find, "Xem hóa đơn");
            this.btn_Find.UseVisualStyleBackColor = true;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đến ngày:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Từ ngày:";
            // 
            // dt_NgayEnd
            // 
            this.dt_NgayEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_NgayEnd.Location = new System.Drawing.Point(80, 52);
            this.dt_NgayEnd.Name = "dt_NgayEnd";
            this.dt_NgayEnd.Size = new System.Drawing.Size(102, 25);
            this.dt_NgayEnd.TabIndex = 15;
            // 
            // dtNgayStart
            // 
            this.dtNgayStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayStart.Location = new System.Drawing.Point(80, 21);
            this.dtNgayStart.Name = "dtNgayStart";
            this.dtNgayStart.Size = new System.Drawing.Size(102, 25);
            this.dtNgayStart.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnChitiet_HD);
            this.groupBox2.Controls.Add(this.btn_Back);
            this.groupBox2.Controls.Add(this.btn_Refesh);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(271, 86);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnChitiet_HD
            // 
            this.btnChitiet_HD.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnChitiet_HD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChitiet_HD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChitiet_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChitiet_HD.Image = global::QLVTNN.Properties.Resources.exit__1_;
            this.btnChitiet_HD.Location = new System.Drawing.Point(6, 20);
            this.btnChitiet_HD.Name = "btnChitiet_HD";
            this.btnChitiet_HD.Size = new System.Drawing.Size(94, 58);
            this.btnChitiet_HD.TabIndex = 8;
            this.btnChitiet_HD.Text = "Xem Chi Tiết";
            this.btnChitiet_HD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChitiet_HD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnChitiet_HD, "Xem chi tiết hóa đơn");
            this.btnChitiet_HD.UseVisualStyleBackColor = false;
            this.btnChitiet_HD.Click += new System.EventHandler(this.btnChitiet_HD_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Image = global::QLVTNN.Properties.Resources.exit__1_;
            this.btn_Back.Location = new System.Drawing.Point(187, 19);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 58);
            this.btn_Back.TabIndex = 12;
            this.btn_Back.Text = "Đóng";
            this.btn_Back.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Back.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_Back, "Trở về trước");
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // btn_Refesh
            // 
            this.btn_Refesh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Refesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refesh.Image = global::QLVTNN.Properties.Resources.reload;
            this.btn_Refesh.Location = new System.Drawing.Point(106, 19);
            this.btn_Refesh.Name = "btn_Refesh";
            this.btn_Refesh.Size = new System.Drawing.Size(75, 58);
            this.btn_Refesh.TabIndex = 11;
            this.btn_Refesh.Text = "Tạo Mới";
            this.btn_Refesh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Refesh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_Refesh, "Tạo mới thông tin hóa đơn");
            this.btn_Refesh.UseVisualStyleBackColor = false;
            this.btn_Refesh.Click += new System.EventHandler(this.btn_Refesh_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.dgDS_HD);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 172);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1107, 248);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách Hóa Đơn";
            // 
            // dgDS_HD
            // 
            this.dgDS_HD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDS_HD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDS_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDS_HD.Location = new System.Drawing.Point(7, 22);
            this.dgDS_HD.Name = "dgDS_HD";
            this.dgDS_HD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDS_HD.Size = new System.Drawing.Size(1094, 220);
            this.dgDS_HD.TabIndex = 17;
            this.dgDS_HD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDS_HD_CellClick);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox5.Controls.Add(this.dgChitiet_HD);
            this.groupBox5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(12, 426);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1107, 127);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chi tiết Hóa Đơn";
            // 
            // dgChitiet_HD
            // 
            this.dgChitiet_HD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgChitiet_HD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChitiet_HD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChitiet_HD.Location = new System.Drawing.Point(9, 21);
            this.dgChitiet_HD.Name = "dgChitiet_HD";
            this.dgChitiet_HD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChitiet_HD.Size = new System.Drawing.Size(1092, 100);
            this.dgChitiet_HD.TabIndex = 18;
            // 
            // lbSLHD
            // 
            this.lbSLHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSLHD.AutoSize = true;
            this.lbSLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLHD.Location = new System.Drawing.Point(744, 154);
            this.lbSLHD.Name = "lbSLHD";
            this.lbSLHD.Size = new System.Drawing.Size(118, 15);
            this.lbSLHD.TabIndex = 8;
            this.lbSLHD.Text = "Tổng Số Hóa Đơn: 0";
            // 
            // lbTongDoanhThu
            // 
            this.lbTongDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongDoanhThu.AutoSize = true;
            this.lbTongDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongDoanhThu.Location = new System.Drawing.Point(915, 154);
            this.lbTongDoanhThu.Name = "lbTongDoanhThu";
            this.lbTongDoanhThu.Size = new System.Drawing.Size(112, 15);
            this.lbTongDoanhThu.TabIndex = 9;
            this.lbTongDoanhThu.Text = "Tổng Doanh Thu: 0";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1131, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtBáoCáoToolStripMenuItem,
            this.xuấtLạiHóaĐonToolStripMenuItem,
            this.khoToolStripMenuItem,
            this.càiĐặtToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // xuấtBáoCáoToolStripMenuItem
            // 
            this.xuấtBáoCáoToolStripMenuItem.Name = "xuấtBáoCáoToolStripMenuItem";
            this.xuấtBáoCáoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.xuấtBáoCáoToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.xuấtBáoCáoToolStripMenuItem.Text = "Xuất báo cáo";
            this.xuấtBáoCáoToolStripMenuItem.Click += new System.EventHandler(this.xuấtBáoCáoToolStripMenuItem_Click);
            // 
            // xuấtLạiHóaĐonToolStripMenuItem
            // 
            this.xuấtLạiHóaĐonToolStripMenuItem.Name = "xuấtLạiHóaĐonToolStripMenuItem";
            this.xuấtLạiHóaĐonToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.P)));
            this.xuấtLạiHóaĐonToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.xuấtLạiHóaĐonToolStripMenuItem.Text = "Xuất lại hóa đơn";
            // 
            // khoToolStripMenuItem
            // 
            this.khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            this.khoToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemChiTiếtHóaĐơnToolStripMenuItem,
            this.tạoMớiToolStripMenuItem,
            this.tìmToolStripMenuItem,
            this.trởVềToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // xemChiTiếtHóaĐơnToolStripMenuItem
            // 
            this.xemChiTiếtHóaĐơnToolStripMenuItem.Name = "xemChiTiếtHóaĐơnToolStripMenuItem";
            this.xemChiTiếtHóaĐơnToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.xemChiTiếtHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.xemChiTiếtHóaĐơnToolStripMenuItem.Text = "Xem chi tiết hóa đơn";
            this.xemChiTiếtHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.xemChiTiếtHóaĐơnToolStripMenuItem_Click);
            // 
            // tạoMớiToolStripMenuItem
            // 
            this.tạoMớiToolStripMenuItem.Name = "tạoMớiToolStripMenuItem";
            this.tạoMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tạoMớiToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.tạoMớiToolStripMenuItem.Text = "Tạo mới";
            this.tạoMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoMớiToolStripMenuItem_Click);
            // 
            // tìmToolStripMenuItem
            // 
            this.tìmToolStripMenuItem.Name = "tìmToolStripMenuItem";
            this.tìmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tìmToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.tìmToolStripMenuItem.Text = "Tìm";
            this.tìmToolStripMenuItem.Click += new System.EventHandler(this.tìmToolStripMenuItem_Click);
            // 
            // trởVềToolStripMenuItem
            // 
            this.trởVềToolStripMenuItem.Name = "trởVềToolStripMenuItem";
            this.trởVềToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.trởVềToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.trởVềToolStripMenuItem.Text = "Đóng";
            this.trởVềToolStripMenuItem.Click += new System.EventHandler(this.trởVềToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBaoCao,
            this.tsPint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1131, 38);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBaoCao
            // 
            this.tsBaoCao.Image = global::QLVTNN.Properties.Resources.printer__1_;
            this.tsBaoCao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBaoCao.Name = "tsBaoCao";
            this.tsBaoCao.Size = new System.Drawing.Size(82, 35);
            this.tsBaoCao.Text = "Xuất Báo Cáo";
            this.tsBaoCao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsBaoCao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBaoCao.Click += new System.EventHandler(this.tsBaoCao_Click);
            // 
            // tsPint
            // 
            this.tsPint.Image = global::QLVTNN.Properties.Resources.printer1;
            this.tsPint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPint.Name = "tsPint";
            this.tsPint.Size = new System.Drawing.Size(73, 35);
            this.tsPint.Text = "Xuất Lại HD";
            this.tsPint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsPint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPint.ToolTipText = "Xuất lại hóa đơn";
            this.tsPint.Click += new System.EventHandler(this.tsPint_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btnPay);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.cbbTthai);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(289, 65);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 86);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trạng thái hóa đơn";
            // 
            // btnPay
            // 
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPay.Image = global::QLVTNN.Properties.Resources.pay;
            this.btnPay.Location = new System.Drawing.Point(210, 19);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(90, 56);
            this.btnPay.TabIndex = 18;
            this.btnPay.Text = "Thanh toán";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnTthai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Trạng thái:";
            // 
            // cbbTthai
            // 
            this.cbbTthai.FormattingEnabled = true;
            this.cbbTthai.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cbbTthai.Location = new System.Drawing.Point(85, 35);
            this.cbbTthai.Name = "cbbTthai";
            this.cbbTthai.Size = new System.Drawing.Size(119, 25);
            this.cbbTthai.TabIndex = 0;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox6.Controls.Add(this.btnSeenKH);
            this.groupBox6.Controls.Add(this.cbbKh);
            this.groupBox6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(601, 65);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(238, 86);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Khách Hàng";
            // 
            // btnSeenKH
            // 
            this.btnSeenKH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeenKH.Image = global::QLVTNN.Properties.Resources.find1;
            this.btnSeenKH.Location = new System.Drawing.Point(153, 20);
            this.btnSeenKH.Name = "btnSeenKH";
            this.btnSeenKH.Size = new System.Drawing.Size(75, 58);
            this.btnSeenKH.TabIndex = 19;
            this.btnSeenKH.Text = "Xem";
            this.btnSeenKH.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeenKH.UseVisualStyleBackColor = true;
            this.btnSeenKH.Click += new System.EventHandler(this.btnSeenKH_Click);
            // 
            // cbbKh
            // 
            this.cbbKh.FormattingEnabled = true;
            this.cbbKh.Items.AddRange(new object[] {
            "Chưa thanh toán",
            "Đã thanh toán"});
            this.cbbKh.Location = new System.Drawing.Point(6, 35);
            this.cbbKh.Name = "cbbKh";
            this.cbbKh.Size = new System.Drawing.Size(141, 25);
            this.cbbKh.TabIndex = 19;
            // 
            // printDocument2
            // 
            this.printDocument2.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument2_PrintPage);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 565);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbTongDoanhThu);
            this.Controls.Add(this.lbSLHD);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Hóa Đơn";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDS_HD)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChitiet_HD)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dt_NgayEnd;
        private System.Windows.Forms.DateTimePicker dtNgayStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgDS_HD;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dgChitiet_HD;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Refesh;
        private System.Windows.Forms.Button btnChitiet_HD;
        private System.Windows.Forms.Label lbSLHD;
        private System.Windows.Forms.Label lbTongDoanhThu;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xuấtBáoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemChiTiếtHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trởVềToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBaoCao;
        private System.Windows.Forms.ToolStripMenuItem tìmToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ComboBox cbbTthai;
        private System.Windows.Forms.ToolStripButton tsPint;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolStripMenuItem xuấtLạiHóaĐonToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSeenKH;
        private System.Windows.Forms.ComboBox cbbKh;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}
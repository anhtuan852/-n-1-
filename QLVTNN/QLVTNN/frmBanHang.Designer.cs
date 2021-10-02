
namespace QLVTNN
{
    partial class frmBanHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBanHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_ID_KH = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nm_SL = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_Price = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_DVT = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbb_Name_SP = new System.Windows.Forms.ComboBox();
            this.cbb_ID_SP = new System.Windows.Forms.ComboBox();
            this.cbb_Loai = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Pay = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_Refesh = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgBanHang = new System.Windows.Forms.DataGridView();
            this.lbTongHD = new System.Windows.Forms.Label();
            this.lbSLHang = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemGiáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemHàngHếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.khoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trởVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSeenPrice = new System.Windows.Forms.ToolStripButton();
            this.tsHangHet = new System.Windows.Forms.ToolStripButton();
            this.tsAddKh = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_SL)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBanHang)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbb_ID_KH);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khách Hàng:";
            // 
            // cbb_ID_KH
            // 
            this.cbb_ID_KH.FormattingEnabled = true;
            this.cbb_ID_KH.Location = new System.Drawing.Point(109, 46);
            this.cbb_ID_KH.Name = "cbb_ID_KH";
            this.cbb_ID_KH.Size = new System.Drawing.Size(187, 25);
            this.cbb_ID_KH.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.nm_SL);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbb_Price);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbb_DVT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbb_Name_SP);
            this.groupBox2.Controls.Add(this.cbb_ID_SP);
            this.groupBox2.Controls.Add(this.cbb_Loai);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(327, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(874, 108);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Hàng Hóa";
            // 
            // nm_SL
            // 
            this.nm_SL.Location = new System.Drawing.Point(675, 66);
            this.nm_SL.Name = "nm_SL";
            this.nm_SL.Size = new System.Drawing.Size(55, 25);
            this.nm_SL.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Số lượng:";
            // 
            // cbb_Price
            // 
            this.cbb_Price.Enabled = false;
            this.cbb_Price.FormattingEnabled = true;
            this.cbb_Price.Location = new System.Drawing.Point(383, 65);
            this.cbb_Price.Name = "cbb_Price";
            this.cbb_Price.Size = new System.Drawing.Size(180, 25);
            this.cbb_Price.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Giá:";
            // 
            // cbb_DVT
            // 
            this.cbb_DVT.Enabled = false;
            this.cbb_DVT.FormattingEnabled = true;
            this.cbb_DVT.Location = new System.Drawing.Point(114, 65);
            this.cbb_DVT.Name = "cbb_DVT";
            this.cbb_DVT.Size = new System.Drawing.Size(162, 25);
            this.cbb_DVT.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Đơn vị tính:";
            // 
            // cbb_Name_SP
            // 
            this.cbb_Name_SP.FormattingEnabled = true;
            this.cbb_Name_SP.Location = new System.Drawing.Point(675, 30);
            this.cbb_Name_SP.Name = "cbb_Name_SP";
            this.cbb_Name_SP.Size = new System.Drawing.Size(193, 25);
            this.cbb_Name_SP.TabIndex = 13;
            // 
            // cbb_ID_SP
            // 
            this.cbb_ID_SP.FormattingEnabled = true;
            this.cbb_ID_SP.Location = new System.Drawing.Point(383, 30);
            this.cbb_ID_SP.Name = "cbb_ID_SP";
            this.cbb_ID_SP.Size = new System.Drawing.Size(180, 25);
            this.cbb_ID_SP.TabIndex = 11;
            // 
            // cbb_Loai
            // 
            this.cbb_Loai.FormattingEnabled = true;
            this.cbb_Loai.Location = new System.Drawing.Point(114, 30);
            this.cbb_Loai.Name = "cbb_Loai";
            this.cbb_Loai.Size = new System.Drawing.Size(162, 25);
            this.cbb_Loai.TabIndex = 9;
            this.cbb_Loai.SelectedIndexChanged += new System.EventHandler(this.cbb_Loai_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Hàng Hóa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Hàng Hóa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại Hàng Hóa:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btn_Pay);
            this.groupBox3.Controls.Add(this.btn_Back);
            this.groupBox3.Controls.Add(this.btn_Refesh);
            this.groupBox3.Controls.Add(this.btn_Delete);
            this.groupBox3.Controls.Add(this.btn_Add);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 184);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1189, 97);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // btn_Pay
            // 
            this.btn_Pay.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Pay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pay.Image = global::QLVTNN.Properties.Resources.pay;
            this.btn_Pay.Location = new System.Drawing.Point(168, 23);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(91, 62);
            this.btn_Pay.TabIndex = 18;
            this.btn_Pay.Text = "Thanh Toán";
            this.btn_Pay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Pay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_Pay, "Thanh toán sản phảm đã chọn");
            this.btn_Pay.UseVisualStyleBackColor = false;
            this.btn_Pay.Click += new System.EventHandler(this.btn_Pay_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Image = global::QLVTNN.Properties.Resources.exit__1_;
            this.btn_Back.Location = new System.Drawing.Point(346, 23);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 62);
            this.btn_Back.TabIndex = 21;
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
            this.btn_Refesh.Location = new System.Drawing.Point(265, 23);
            this.btn_Refesh.Name = "btn_Refesh";
            this.btn_Refesh.Size = new System.Drawing.Size(75, 62);
            this.btn_Refesh.TabIndex = 19;
            this.btn_Refesh.Text = "Tạo Mới";
            this.btn_Refesh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Refesh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_Refesh, "Tạo mới thông tin bán hàng");
            this.btn_Refesh.UseVisualStyleBackColor = false;
            this.btn_Refesh.Click += new System.EventHandler(this.btn_Refesh_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Image = global::QLVTNN.Properties.Resources.delete;
            this.btn_Delete.Location = new System.Drawing.Point(87, 23);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 62);
            this.btn_Delete.TabIndex = 17;
            this.btn_Delete.Text = "Xóa";
            this.btn_Delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_Delete, "Xóa hàng đã chọn");
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Image = global::QLVTNN.Properties.Resources.button;
            this.btn_Add.Location = new System.Drawing.Point(6, 23);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 62);
            this.btn_Add.TabIndex = 15;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btn_Add, "Thêm hàng vào danh sách chọn");
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.dgBanHang);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 312);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1188, 209);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách chọn";
            // 
            // dgBanHang
            // 
            this.dgBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgBanHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgBanHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBanHang.Location = new System.Drawing.Point(6, 23);
            this.dgBanHang.Name = "dgBanHang";
            this.dgBanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBanHang.Size = new System.Drawing.Size(1176, 180);
            this.dgBanHang.TabIndex = 0;
            this.dgBanHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBanHang_CellClick);
            // 
            // lbTongHD
            // 
            this.lbTongHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongHD.AutoSize = true;
            this.lbTongHD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongHD.Location = new System.Drawing.Point(973, 291);
            this.lbTongHD.Name = "lbTongHD";
            this.lbTongHD.Size = new System.Drawing.Size(100, 17);
            this.lbTongHD.TabIndex = 7;
            this.lbTongHD.Text = "Tổng Hóa Đơn:";
            // 
            // lbSLHang
            // 
            this.lbSLHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSLHang.AutoSize = true;
            this.lbSLHang.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLHang.Location = new System.Drawing.Point(812, 291);
            this.lbSLHang.Name = "lbSLHang";
            this.lbSLHang.Size = new System.Drawing.Size(96, 17);
            this.lbSLHang.TabIndex = 8;
            this.lbSLHang.Text = "Tổng Số Hàng:";
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1213, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemGiáToolStripMenuItem,
            this.xemHàngHếtToolStripMenuItem,
            this.nhậpHàngToolStripMenuItem,
            this.thêmKháchHàngToolStripMenuItem,
            this.khoToolStripMenuItem,
            this.càiĐặtToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // xemGiáToolStripMenuItem
            // 
            this.xemGiáToolStripMenuItem.Name = "xemGiáToolStripMenuItem";
            this.xemGiáToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.xemGiáToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.xemGiáToolStripMenuItem.Text = "Xem giá";
            this.xemGiáToolStripMenuItem.Click += new System.EventHandler(this.xemGiáToolStripMenuItem_Click);
            // 
            // xemHàngHếtToolStripMenuItem
            // 
            this.xemHàngHếtToolStripMenuItem.Name = "xemHàngHếtToolStripMenuItem";
            this.xemHàngHếtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.W)));
            this.xemHàngHếtToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.xemHàngHếtToolStripMenuItem.Text = "Xem hàng hết";
            this.xemHàngHếtToolStripMenuItem.Click += new System.EventHandler(this.xemHàngHếtToolStripMenuItem_Click);
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.nhậpHàngToolStripMenuItem.Text = "Nhập hàng";
            this.nhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.nhậpHàngToolStripMenuItem_Click);
            // 
            // thêmKháchHàngToolStripMenuItem
            // 
            this.thêmKháchHàngToolStripMenuItem.Name = "thêmKháchHàngToolStripMenuItem";
            this.thêmKháchHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.thêmKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            this.thêmKháchHàngToolStripMenuItem.Text = "Thêm khách hàng";
            this.thêmKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thêmKháchHàngToolStripMenuItem_Click);
            // 
            // khoToolStripMenuItem
            // 
            this.khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            this.khoToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(207, 22);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.thanhToánToolStripMenuItem,
            this.tạoMớiToolStripMenuItem,
            this.trởVềToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // tạoMớiToolStripMenuItem
            // 
            this.tạoMớiToolStripMenuItem.Name = "tạoMớiToolStripMenuItem";
            this.tạoMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tạoMớiToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.tạoMớiToolStripMenuItem.Text = "Tạo mới";
            this.tạoMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoMớiToolStripMenuItem_Click);
            // 
            // trởVềToolStripMenuItem
            // 
            this.trởVềToolStripMenuItem.Name = "trởVềToolStripMenuItem";
            this.trởVềToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.trởVềToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
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
            this.tsSeenPrice,
            this.tsHangHet,
            this.tsAddKh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1213, 38);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsSeenPrice
            // 
            this.tsSeenPrice.Image = global::QLVTNN.Properties.Resources.find1;
            this.tsSeenPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSeenPrice.Name = "tsSeenPrice";
            this.tsSeenPrice.Size = new System.Drawing.Size(55, 35);
            this.tsSeenPrice.Text = "Xem Giá";
            this.tsSeenPrice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsSeenPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsSeenPrice.Click += new System.EventHandler(this.tsSeenPrice_Click);
            // 
            // tsHangHet
            // 
            this.tsHangHet.Image = global::QLVTNN.Properties.Resources.package;
            this.tsHangHet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsHangHet.Name = "tsHangHet";
            this.tsHangHet.Size = new System.Drawing.Size(62, 35);
            this.tsHangHet.Text = "Hàng Hết";
            this.tsHangHet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsHangHet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsHangHet.Click += new System.EventHandler(this.tsHangHet_Click);
            // 
            // tsAddKh
            // 
            this.tsAddKh.Image = global::QLVTNN.Properties.Resources.add_friend;
            this.tsAddKh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddKh.Name = "tsAddKh";
            this.tsAddKh.Size = new System.Drawing.Size(60, 35);
            this.tsAddKh.Text = "Thêm KH";
            this.tsAddKh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsAddKh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAddKh.Click += new System.EventHandler(this.tsAddKh_Click);
            // 
            // frmBanHang
            // 
            this.AcceptButton = this.btn_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1213, 534);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbSLHang);
            this.Controls.Add(this.lbTongHD);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_SL)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBanHang)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_ID_KH;
        private System.Windows.Forms.ComboBox cbb_Name_SP;
        private System.Windows.Forms.ComboBox cbb_ID_SP;
        private System.Windows.Forms.ComboBox cbb_Loai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgBanHang;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.NumericUpDown nm_SL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_Price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_DVT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button btn_Refesh;
        private System.Windows.Forms.Button btn_Pay;
        private System.Windows.Forms.Label lbTongHD;
        private System.Windows.Forms.Label lbSLHang;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trởVềToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemGiáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xemHàngHếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem khoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsSeenPrice;
        private System.Windows.Forms.ToolStripButton tsHangHet;
        private System.Windows.Forms.ToolStripButton tsAddKh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}
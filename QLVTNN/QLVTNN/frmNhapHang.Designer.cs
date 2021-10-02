
namespace QLVTNN
{
    partial class frmNhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbGia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDVT = new System.Windows.Forms.ComboBox();
            this.nm_SL = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cbb_Name_SP = new System.Windows.Forms.ComboBox();
            this.cbb_ID_SP = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgNhapHang = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHàngMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trởLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đóngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsAddNew = new System.Windows.Forms.ToolStripButton();
            this.tsAddLoai = new System.Windows.Forms.ToolStripButton();
            this.tsHangHet = new System.Windows.Forms.ToolStripButton();
            this.tsChiTietNhap = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsSetting = new System.Windows.Forms.ToolStripButton();
            this.tsHelp = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTong = new System.Windows.Forms.Label();
            this.lbSL = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_SL)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhapHang)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRefesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.Image = global::QLVTNN.Properties.Resources.reload;
            this.btnRefesh.Location = new System.Drawing.Point(249, 19);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(75, 58);
            this.btnRefesh.TabIndex = 9;
            this.btnRefesh.Text = "Tạo Mới";
            this.btnRefesh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefesh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnRefesh, "Tạo mới thông tin nhập hàng");
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnRefesh_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Image = global::QLVTNN.Properties.Resources.direct_download;
            this.btnNhapHang.Location = new System.Drawing.Point(168, 19);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(75, 58);
            this.btnNhapHang.TabIndex = 6;
            this.btnNhapHang.Text = "Nhập";
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnNhapHang, "Nhập hàng đã chọn");
            this.btnNhapHang.UseVisualStyleBackColor = false;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbbGia);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbbDVT);
            this.groupBox2.Controls.Add(this.nm_SL);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cbb_Name_SP);
            this.groupBox2.Controls.Add(this.cbb_ID_SP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1013, 88);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Hàng Hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Giá:";
            // 
            // cbbGia
            // 
            this.cbbGia.Enabled = false;
            this.cbbGia.FormattingEnabled = true;
            this.cbbGia.Location = new System.Drawing.Point(553, 22);
            this.cbbGia.Name = "cbbGia";
            this.cbbGia.Size = new System.Drawing.Size(137, 25);
            this.cbbGia.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "ĐVT:";
            // 
            // cbbDVT
            // 
            this.cbbDVT.Enabled = false;
            this.cbbDVT.FormattingEnabled = true;
            this.cbbDVT.Location = new System.Drawing.Point(395, 51);
            this.cbbDVT.Name = "cbbDVT";
            this.cbbDVT.Size = new System.Drawing.Size(91, 25);
            this.cbbDVT.TabIndex = 15;
            // 
            // nm_SL
            // 
            this.nm_SL.Location = new System.Drawing.Point(395, 23);
            this.nm_SL.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nm_SL.Name = "nm_SL";
            this.nm_SL.Size = new System.Drawing.Size(91, 25);
            this.nm_SL.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(325, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Số lượng:";
            // 
            // cbb_Name_SP
            // 
            this.cbb_Name_SP.FormattingEnabled = true;
            this.cbb_Name_SP.Location = new System.Drawing.Point(123, 51);
            this.cbb_Name_SP.Name = "cbb_Name_SP";
            this.cbb_Name_SP.Size = new System.Drawing.Size(180, 25);
            this.cbb_Name_SP.TabIndex = 8;
            // 
            // cbb_ID_SP
            // 
            this.cbb_ID_SP.FormattingEnabled = true;
            this.cbb_ID_SP.Location = new System.Drawing.Point(123, 22);
            this.cbb_ID_SP.Name = "cbb_ID_SP";
            this.cbb_ID_SP.Size = new System.Drawing.Size(180, 25);
            this.cbb_ID_SP.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Hàng Hóa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Hàng Hóa:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.dgNhapHang);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 248);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1012, 289);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Hàng Hóa";
            // 
            // dgNhapHang
            // 
            this.dgNhapHang.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgNhapHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNhapHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgNhapHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNhapHang.Location = new System.Drawing.Point(6, 21);
            this.dgNhapHang.Name = "dgNhapHang";
            this.dgNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNhapHang.Size = new System.Drawing.Size(1000, 262);
            this.dgNhapHang.TabIndex = 0;
            this.dgNhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNhapHang_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox4.Controls.Add(this.btnBack);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnRefesh);
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.Controls.Add(this.btnNhapHang);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(827, 83);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::QLVTNN.Properties.Resources.exit__1_;
            this.btnBack.Location = new System.Drawing.Point(330, 19);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 58);
            this.btnBack.TabIndex = 10;
            this.btnBack.Text = "Đóng";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnBack, "Trở về trước");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::QLVTNN.Properties.Resources.delete;
            this.btnDelete.Location = new System.Drawing.Point(87, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 58);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnDelete, "Xóa hàng đã chọn");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::QLVTNN.Properties.Resources.button;
            this.btnAdd.Location = new System.Drawing.Point(6, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 58);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnAdd, "Nhập hàng");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1037, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmHàngMớiToolStripMenuItem,
            this.thêmLoạiToolStripMenuItem,
            this.hàngHếtToolStripMenuItem,
            this.chiTiếtNhậpToolStripMenuItem,
            this.càiĐặtToolStripMenuItem,
            this.trợGiúpToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // thêmHàngMớiToolStripMenuItem
            // 
            this.thêmHàngMớiToolStripMenuItem.Name = "thêmHàngMớiToolStripMenuItem";
            this.thêmHàngMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.thêmHàngMớiToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.thêmHàngMớiToolStripMenuItem.Text = "Thêm hàng mới";
            this.thêmHàngMớiToolStripMenuItem.Click += new System.EventHandler(this.thêmHàngMớiToolStripMenuItem_Click);
            // 
            // thêmLoạiToolStripMenuItem
            // 
            this.thêmLoạiToolStripMenuItem.Name = "thêmLoạiToolStripMenuItem";
            this.thêmLoạiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.thêmLoạiToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.thêmLoạiToolStripMenuItem.Text = "Thêm loại";
            this.thêmLoạiToolStripMenuItem.Click += new System.EventHandler(this.thêmLoạiToolStripMenuItem_Click);
            // 
            // hàngHếtToolStripMenuItem
            // 
            this.hàngHếtToolStripMenuItem.Name = "hàngHếtToolStripMenuItem";
            this.hàngHếtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.hàngHếtToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.hàngHếtToolStripMenuItem.Text = "Hàng hết";
            // 
            // chiTiếtNhậpToolStripMenuItem
            // 
            this.chiTiếtNhậpToolStripMenuItem.Name = "chiTiếtNhậpToolStripMenuItem";
            this.chiTiếtNhậpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.chiTiếtNhậpToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.chiTiếtNhậpToolStripMenuItem.Text = "Chi tiết nhập hàng";
            this.chiTiếtNhậpToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtNhậpToolStripMenuItem_Click);
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.càiĐặtToolStripMenuItem.Text = "Cài đặt";
            this.càiĐặtToolStripMenuItem.Click += new System.EventHandler(this.càiĐặtToolStripMenuItem_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.nhậpToolStripMenuItem,
            this.tạoMớiToolStripMenuItem,
            this.tìmToolStripMenuItem,
            this.trởLạiToolStripMenuItem,
            this.đóngToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // nhậpToolStripMenuItem
            // 
            this.nhậpToolStripMenuItem.Name = "nhậpToolStripMenuItem";
            this.nhậpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.nhậpToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.nhậpToolStripMenuItem.Text = "Nhập";
            this.nhậpToolStripMenuItem.Click += new System.EventHandler(this.nhậpToolStripMenuItem_Click);
            // 
            // tạoMớiToolStripMenuItem
            // 
            this.tạoMớiToolStripMenuItem.Name = "tạoMớiToolStripMenuItem";
            this.tạoMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tạoMớiToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tạoMớiToolStripMenuItem.Text = "Tạo mới";
            this.tạoMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoMớiToolStripMenuItem_Click);
            // 
            // tìmToolStripMenuItem
            // 
            this.tìmToolStripMenuItem.Name = "tìmToolStripMenuItem";
            this.tìmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tìmToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.tìmToolStripMenuItem.Text = "Tìm";
            this.tìmToolStripMenuItem.Click += new System.EventHandler(this.tìmToolStripMenuItem_Click);
            // 
            // trởLạiToolStripMenuItem
            // 
            this.trởLạiToolStripMenuItem.Name = "trởLạiToolStripMenuItem";
            this.trởLạiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.trởLạiToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.trởLạiToolStripMenuItem.Text = "Trở lại";
            this.trởLạiToolStripMenuItem.Click += new System.EventHandler(this.trởLạiToolStripMenuItem_Click);
            // 
            // đóngToolStripMenuItem
            // 
            this.đóngToolStripMenuItem.Name = "đóngToolStripMenuItem";
            this.đóngToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
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
            this.tsAddNew,
            this.tsAddLoai,
            this.tsHangHet,
            this.tsChiTietNhap,
            this.toolStripSeparator1,
            this.tsSetting,
            this.tsHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1037, 38);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsAddNew
            // 
            this.tsAddNew.Image = global::QLVTNN.Properties.Resources.button;
            this.tsAddNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddNew.Name = "tsAddNew";
            this.tsAddNew.Size = new System.Drawing.Size(65, 35);
            this.tsAddNew.Text = "Thêm Mới";
            this.tsAddNew.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsAddNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAddNew.ToolTipText = "Thêm Hàng Hóa Mới";
            this.tsAddNew.Click += new System.EventHandler(this.tsAddNew_Click);
            // 
            // tsAddLoai
            // 
            this.tsAddLoai.Image = global::QLVTNN.Properties.Resources.list;
            this.tsAddLoai.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddLoai.Name = "tsAddLoai";
            this.tsAddLoai.Size = new System.Drawing.Size(66, 35);
            this.tsAddLoai.Text = "Thêm Loại";
            this.tsAddLoai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsAddLoai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAddLoai.Click += new System.EventHandler(this.tsAddLoai_Click);
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
            // tsChiTietNhap
            // 
            this.tsChiTietNhap.Image = global::QLVTNN.Properties.Resources.loan;
            this.tsChiTietNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsChiTietNhap.Name = "tsChiTietNhap";
            this.tsChiTietNhap.Size = new System.Drawing.Size(83, 35);
            this.tsChiTietNhap.Text = "Chi Tiết Nhập";
            this.tsChiTietNhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsChiTietNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsChiTietNhap.Click += new System.EventHandler(this.tsChiTietNhap_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // tsSetting
            // 
            this.tsSetting.Image = global::QLVTNN.Properties.Resources.settings__1_;
            this.tsSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSetting.Name = "tsSetting";
            this.tsSetting.Size = new System.Drawing.Size(49, 35);
            this.tsSetting.Text = "Cài Đặt";
            this.tsSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsSetting.Click += new System.EventHandler(this.tsSetting_Click);
            // 
            // tsHelp
            // 
            this.tsHelp.Image = global::QLVTNN.Properties.Resources.info;
            this.tsHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsHelp.Name = "tsHelp";
            this.tsHelp.Size = new System.Drawing.Size(55, 35);
            this.tsHelp.Text = "Trợ Giúp";
            this.tsHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsHelp.Click += new System.EventHandler(this.tsHelp_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.lbTong);
            this.panel1.Controls.Add(this.lbSL);
            this.panel1.Location = new System.Drawing.Point(845, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 83);
            this.panel1.TabIndex = 21;
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(14, 54);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(86, 16);
            this.lbTong.TabIndex = 20;
            this.lbTong.Text = "Tổng nhập: 0";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSL.Location = new System.Drawing.Point(14, 14);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(71, 16);
            this.lbSL.TabIndex = 19;
            this.lbSL.Text = "Số hàng: 0";
            // 
            // frmNhapHang
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 549);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmNhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập Hàng";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_SL)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgNhapHang)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nm_SL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbb_Name_SP;
        private System.Windows.Forms.ComboBox cbb_ID_SP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgNhapHang;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbDVT;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmHàngMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trởLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đóngToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAddNew;
        private System.Windows.Forms.ToolStripButton tsAddLoai;
        private System.Windows.Forms.ToolStripButton tsHangHet;
        private System.Windows.Forms.ToolStripButton tsChiTietNhap;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsSetting;
        private System.Windows.Forms.ToolStripButton tsHelp;
        private System.Windows.Forms.ToolStripMenuItem tìmToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}

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
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hàngHếtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trởLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsChiTietNhap = new System.Windows.Forms.ToolStripButton();
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
            this.btnRefesh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRefesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.Image = global::QLVTNN.Properties.Resources.refresh_page_option;
            this.btnRefesh.Location = new System.Drawing.Point(332, 23);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(100, 71);
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
            this.btnNhapHang.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhapHang.Image = global::QLVTNN.Properties.Resources.double_check;
            this.btnNhapHang.Location = new System.Drawing.Point(224, 23);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(100, 71);
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
            this.groupBox2.BackColor = System.Drawing.Color.White;
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
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(16, 80);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1351, 108);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin Hàng Hóa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(687, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Giá:";
            // 
            // cbbGia
            // 
            this.cbbGia.Enabled = false;
            this.cbbGia.FormattingEnabled = true;
            this.cbbGia.Location = new System.Drawing.Point(737, 27);
            this.cbbGia.Margin = new System.Windows.Forms.Padding(4);
            this.cbbGia.Name = "cbbGia";
            this.cbbGia.Size = new System.Drawing.Size(181, 27);
            this.cbbGia.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "ĐVT:";
            // 
            // cbbDVT
            // 
            this.cbbDVT.Enabled = false;
            this.cbbDVT.FormattingEnabled = true;
            this.cbbDVT.Location = new System.Drawing.Point(527, 63);
            this.cbbDVT.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDVT.Name = "cbbDVT";
            this.cbbDVT.Size = new System.Drawing.Size(120, 27);
            this.cbbDVT.TabIndex = 15;
            // 
            // nm_SL
            // 
            this.nm_SL.Location = new System.Drawing.Point(527, 28);
            this.nm_SL.Margin = new System.Windows.Forms.Padding(4);
            this.nm_SL.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nm_SL.Name = "nm_SL";
            this.nm_SL.Size = new System.Drawing.Size(121, 26);
            this.nm_SL.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(433, 31);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Số lượng:";
            // 
            // cbb_Name_SP
            // 
            this.cbb_Name_SP.FormattingEnabled = true;
            this.cbb_Name_SP.Location = new System.Drawing.Point(164, 63);
            this.cbb_Name_SP.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_Name_SP.Name = "cbb_Name_SP";
            this.cbb_Name_SP.Size = new System.Drawing.Size(239, 27);
            this.cbb_Name_SP.TabIndex = 8;
            // 
            // cbb_ID_SP
            // 
            this.cbb_ID_SP.FormattingEnabled = true;
            this.cbb_ID_SP.Location = new System.Drawing.Point(164, 27);
            this.cbb_ID_SP.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_ID_SP.Name = "cbb_ID_SP";
            this.cbb_ID_SP.Size = new System.Drawing.Size(239, 27);
            this.cbb_ID_SP.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Hàng Hóa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Hàng Hóa:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.dgNhapHang);
            this.groupBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.groupBox3.Location = new System.Drawing.Point(17, 305);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(1349, 319);
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
            this.dgNhapHang.Location = new System.Drawing.Point(8, 26);
            this.dgNhapHang.Margin = new System.Windows.Forms.Padding(4);
            this.dgNhapHang.Name = "dgNhapHang";
            this.dgNhapHang.RowHeadersWidth = 51;
            this.dgNhapHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNhapHang.Size = new System.Drawing.Size(1333, 286);
            this.dgNhapHang.TabIndex = 0;
            this.dgNhapHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgNhapHang_CellClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.btnBack);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnRefesh);
            this.groupBox4.Controls.Add(this.btnAdd);
            this.groupBox4.Controls.Add(this.btnNhapHang);
            this.groupBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.groupBox4.Location = new System.Drawing.Point(16, 196);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(1103, 102);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::QLVTNN.Properties.Resources.exit;
            this.btnBack.Location = new System.Drawing.Point(440, 23);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 71);
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
            this.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::QLVTNN.Properties.Resources.trash;
            this.btnDelete.Location = new System.Drawing.Point(116, 23);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 71);
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
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::QLVTNN.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(8, 23);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 71);
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
            this.menuStrip1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.tsmChucNang,
            this.tsmClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1383, 27);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu,
            this.thêmLoạiToolStripMenuItem,
            this.hàngHếtToolStripMenuItem,
            this.chiTiếtNhậpToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(63, 23);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tsmMenu
            // 
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.tsmMenu.Size = new System.Drawing.Size(271, 26);
            this.tsmMenu.Text = "Thêm hàng mới";
            this.tsmMenu.Click += new System.EventHandler(this.thêmHàngMớiToolStripMenuItem_Click);
            // 
            // thêmLoạiToolStripMenuItem
            // 
            this.thêmLoạiToolStripMenuItem.Name = "thêmLoạiToolStripMenuItem";
            this.thêmLoạiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.thêmLoạiToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.thêmLoạiToolStripMenuItem.Text = "Thêm loại";
            this.thêmLoạiToolStripMenuItem.Click += new System.EventHandler(this.thêmLoạiToolStripMenuItem_Click);
            // 
            // hàngHếtToolStripMenuItem
            // 
            this.hàngHếtToolStripMenuItem.Name = "hàngHếtToolStripMenuItem";
            this.hàngHếtToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.hàngHếtToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.hàngHếtToolStripMenuItem.Text = "Hàng hết";
            // 
            // chiTiếtNhậpToolStripMenuItem
            // 
            this.chiTiếtNhậpToolStripMenuItem.Name = "chiTiếtNhậpToolStripMenuItem";
            this.chiTiếtNhậpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.chiTiếtNhậpToolStripMenuItem.Size = new System.Drawing.Size(271, 26);
            this.chiTiếtNhậpToolStripMenuItem.Text = "Chi tiết nhập hàng";
            this.chiTiếtNhậpToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtNhậpToolStripMenuItem_Click);
            // 
            // tsmChucNang
            // 
            this.tsmChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.nhậpToolStripMenuItem,
            this.tạoMớiToolStripMenuItem,
            this.tìmToolStripMenuItem,
            this.trởLạiToolStripMenuItem});
            this.tsmChucNang.Name = "tsmChucNang";
            this.tsmChucNang.Size = new System.Drawing.Size(102, 23);
            this.tsmChucNang.Text = "Chức năng";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // nhậpToolStripMenuItem
            // 
            this.nhậpToolStripMenuItem.Name = "nhậpToolStripMenuItem";
            this.nhậpToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.nhậpToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.nhậpToolStripMenuItem.Text = "Nhập";
            this.nhậpToolStripMenuItem.Click += new System.EventHandler(this.nhậpToolStripMenuItem_Click);
            // 
            // tạoMớiToolStripMenuItem
            // 
            this.tạoMớiToolStripMenuItem.Name = "tạoMớiToolStripMenuItem";
            this.tạoMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tạoMớiToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.tạoMớiToolStripMenuItem.Text = "Tạo mới";
            this.tạoMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoMớiToolStripMenuItem_Click);
            // 
            // tìmToolStripMenuItem
            // 
            this.tìmToolStripMenuItem.Name = "tìmToolStripMenuItem";
            this.tìmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tìmToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.tìmToolStripMenuItem.Text = "Tìm";
            this.tìmToolStripMenuItem.Click += new System.EventHandler(this.tìmToolStripMenuItem_Click);
            // 
            // trởLạiToolStripMenuItem
            // 
            this.trởLạiToolStripMenuItem.Name = "trởLạiToolStripMenuItem";
            this.trởLạiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.trởLạiToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.trởLạiToolStripMenuItem.Text = "Trở lại";
            this.trởLạiToolStripMenuItem.Click += new System.EventHandler(this.trởLạiToolStripMenuItem_Click);
            // 
            // tsmClose
            // 
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(66, 23);
            this.tsmClose.Text = "Thoát";
            this.tsmClose.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsChiTietNhap});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1383, 46);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsChiTietNhap
            // 
            this.tsChiTietNhap.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tsChiTietNhap.Image = global::QLVTNN.Properties.Resources._10168047151595234985_128;
            this.tsChiTietNhap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsChiTietNhap.Name = "tsChiTietNhap";
            this.tsChiTietNhap.Size = new System.Drawing.Size(111, 43);
            this.tsChiTietNhap.Text = "Chi Tiết Nhập";
            this.tsChiTietNhap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsChiTietNhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsChiTietNhap.Click += new System.EventHandler(this.tsChiTietNhap_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lbTong);
            this.panel1.Controls.Add(this.lbSL);
            this.panel1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.panel1.Location = new System.Drawing.Point(1127, 196);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 102);
            this.panel1.TabIndex = 21;
            // 
            // lbTong
            // 
            this.lbTong.AutoSize = true;
            this.lbTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTong.Location = new System.Drawing.Point(19, 66);
            this.lbTong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTong.Name = "lbTong";
            this.lbTong.Size = new System.Drawing.Size(106, 20);
            this.lbTong.TabIndex = 20;
            this.lbTong.Text = "Tổng nhập: 0";
            // 
            // lbSL
            // 
            this.lbSL.AutoSize = true;
            this.lbSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSL.Location = new System.Drawing.Point(19, 17);
            this.lbSL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSL.Name = "lbSL";
            this.lbSL.Size = new System.Drawing.Size(89, 20);
            this.lbSL.TabIndex = 19;
            this.lbSL.Text = "Số hàng: 0";
            // 
            // frmNhapHang
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 639);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.ToolStripMenuItem thêmLoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hàngHếtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmChucNang;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trởLạiToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsChiTietNhap;
        private System.Windows.Forms.ToolStripMenuItem tìmToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTong;
        private System.Windows.Forms.Label lbSL;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
    }
}
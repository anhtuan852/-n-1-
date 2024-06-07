namespace QLVTNN
{
    partial class frmNhanVien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanVien));
            this.dgChiTietGD = new System.Windows.Forms.DataGridView();
            this.dgDSNhanVien = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.grChiTietGD = new System.Windows.Forms.GroupBox();
            this.grDSNV = new System.Windows.Forms.GroupBox();
            this.grFind = new System.Windows.Forms.GroupBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.grChucNang = new System.Windows.Forms.GroupBox();
            this.btnSeenAll = new System.Windows.Forms.Button();
            this.btnTrangThai = new System.Windows.Forms.Button();
            this.btnChiTietGD = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefesh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grTTNV = new System.Windows.Forms.GroupBox();
            this.dtNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.inDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bậtTắtNhânViênToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chiTiếtGiaoDịchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xemTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trởVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsPrint = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietGD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSNhanVien)).BeginInit();
            this.grChiTietGD.SuspendLayout();
            this.grDSNV.SuspendLayout();
            this.grFind.SuspendLayout();
            this.grChucNang.SuspendLayout();
            this.grTTNV.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgChiTietGD
            // 
            this.dgChiTietGD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgChiTietGD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChiTietGD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChiTietGD.Location = new System.Drawing.Point(3, 26);
            this.dgChiTietGD.Margin = new System.Windows.Forms.Padding(4);
            this.dgChiTietGD.Name = "dgChiTietGD";
            this.dgChiTietGD.RowHeadersWidth = 51;
            this.dgChiTietGD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChiTietGD.Size = new System.Drawing.Size(1572, 70);
            this.dgChiTietGD.TabIndex = 0;
            // 
            // dgDSNhanVien
            // 
            this.dgDSNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDSNhanVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDSNhanVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSNhanVien.Location = new System.Drawing.Point(8, 26);
            this.dgDSNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgDSNhanVien.Name = "dgDSNhanVien";
            this.dgDSNhanVien.RowHeadersWidth = 51;
            this.dgDSNhanVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDSNhanVien.Size = new System.Drawing.Size(1565, 251);
            this.dgDSNhanVien.TabIndex = 0;
            this.dgDSNhanVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDSNhanVien_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nhập Mã hoặc Tên:";
            // 
            // grChiTietGD
            // 
            this.grChiTietGD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grChiTietGD.BackColor = System.Drawing.Color.White;
            this.grChiTietGD.Controls.Add(this.dgChiTietGD);
            this.grChiTietGD.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grChiTietGD.Location = new System.Drawing.Point(15, 554);
            this.grChiTietGD.Margin = new System.Windows.Forms.Padding(4);
            this.grChiTietGD.Name = "grChiTietGD";
            this.grChiTietGD.Padding = new System.Windows.Forms.Padding(4);
            this.grChiTietGD.Size = new System.Drawing.Size(1583, 103);
            this.grChiTietGD.TabIndex = 13;
            this.grChiTietGD.TabStop = false;
            this.grChiTietGD.Text = "Chi tiết Giao Dịch";
            // 
            // grDSNV
            // 
            this.grDSNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grDSNV.BackColor = System.Drawing.Color.White;
            this.grDSNV.Controls.Add(this.dgDSNhanVien);
            this.grDSNV.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grDSNV.Location = new System.Drawing.Point(15, 262);
            this.grDSNV.Margin = new System.Windows.Forms.Padding(4);
            this.grDSNV.Name = "grDSNV";
            this.grDSNV.Padding = new System.Windows.Forms.Padding(4);
            this.grDSNV.Size = new System.Drawing.Size(1583, 284);
            this.grDSNV.TabIndex = 14;
            this.grDSNV.TabStop = false;
            this.grDSNV.Text = "Danh sách Nhân Viên";
            // 
            // grFind
            // 
            this.grFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grFind.BackColor = System.Drawing.Color.White;
            this.grFind.Controls.Add(this.txtFind);
            this.grFind.Controls.Add(this.btnFind);
            this.grFind.Controls.Add(this.label6);
            this.grFind.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grFind.Location = new System.Drawing.Point(1016, 150);
            this.grFind.Margin = new System.Windows.Forms.Padding(4);
            this.grFind.Name = "grFind";
            this.grFind.Padding = new System.Windows.Forms.Padding(4);
            this.grFind.Size = new System.Drawing.Size(581, 105);
            this.grFind.TabIndex = 12;
            this.grFind.TabStop = false;
            this.grFind.Text = "Tìm Nhân Viên";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(224, 44);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(224, 26);
            this.txtFind.TabIndex = 11;
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFind.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = global::QLVTNN.Properties.Resources.icons8_search_30;
            this.btnFind.Location = new System.Drawing.Point(459, 26);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 63);
            this.btnFind.TabIndex = 15;
            this.btnFind.Text = "Xem";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnFind, "Tìm nhân viên");
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // grChucNang
            // 
            this.grChucNang.BackColor = System.Drawing.Color.White;
            this.grChucNang.Controls.Add(this.btnSeenAll);
            this.grChucNang.Controls.Add(this.btnTrangThai);
            this.grChucNang.Controls.Add(this.btnChiTietGD);
            this.grChucNang.Controls.Add(this.btnBack);
            this.grChucNang.Controls.Add(this.btnRefesh);
            this.grChucNang.Controls.Add(this.btnDelete);
            this.grChucNang.Controls.Add(this.btnEdit);
            this.grChucNang.Controls.Add(this.btnAdd);
            this.grChucNang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grChucNang.Location = new System.Drawing.Point(16, 149);
            this.grChucNang.Margin = new System.Windows.Forms.Padding(4);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Padding = new System.Windows.Forms.Padding(4);
            this.grChucNang.Size = new System.Drawing.Size(992, 106);
            this.grChucNang.TabIndex = 11;
            this.grChucNang.TabStop = false;
            this.grChucNang.Text = "Chức năng";
            // 
            // btnSeenAll
            // 
            this.btnSeenAll.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSeenAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSeenAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeenAll.Image = global::QLVTNN.Properties.Resources.icons8_expand_30;
            this.btnSeenAll.Location = new System.Drawing.Point(548, 22);
            this.btnSeenAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnSeenAll.Name = "btnSeenAll";
            this.btnSeenAll.Size = new System.Drawing.Size(100, 71);
            this.btnSeenAll.TabIndex = 10;
            this.btnSeenAll.Text = "Xem All";
            this.btnSeenAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSeenAll.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnSeenAll, "Xóa nhân viên");
            this.btnSeenAll.UseVisualStyleBackColor = false;
            this.btnSeenAll.Click += new System.EventHandler(this.btnSeenAll_Click);
            // 
            // btnTrangThai
            // 
            this.btnTrangThai.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTrangThai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTrangThai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrangThai.Image = global::QLVTNN.Properties.Resources.power_button;
            this.btnTrangThai.Location = new System.Drawing.Point(224, 25);
            this.btnTrangThai.Margin = new System.Windows.Forms.Padding(4);
            this.btnTrangThai.Name = "btnTrangThai";
            this.btnTrangThai.Size = new System.Drawing.Size(100, 71);
            this.btnTrangThai.TabIndex = 7;
            this.btnTrangThai.Text = "Bật";
            this.btnTrangThai.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTrangThai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnTrangThai, "Xóa nhân viên");
            this.btnTrangThai.UseVisualStyleBackColor = false;
            this.btnTrangThai.Click += new System.EventHandler(this.btnTrangThai_Click);
            // 
            // btnChiTietGD
            // 
            this.btnChiTietGD.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnChiTietGD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnChiTietGD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChiTietGD.Image = global::QLVTNN.Properties.Resources.icons8_list_30;
            this.btnChiTietGD.Location = new System.Drawing.Point(440, 23);
            this.btnChiTietGD.Margin = new System.Windows.Forms.Padding(4);
            this.btnChiTietGD.Name = "btnChiTietGD";
            this.btnChiTietGD.Size = new System.Drawing.Size(100, 70);
            this.btnChiTietGD.TabIndex = 8;
            this.btnChiTietGD.Text = "Chi Tiết";
            this.btnChiTietGD.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnChiTietGD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnChiTietGD, "Chi tiết giao dịch nhân viên");
            this.btnChiTietGD.UseVisualStyleBackColor = false;
            this.btnChiTietGD.Click += new System.EventHandler(this.btnChiTietGD_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::QLVTNN.Properties.Resources.exit;
            this.btnBack.Location = new System.Drawing.Point(764, 23);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 70);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Đóng";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnBack, "Trở về trước");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRefesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefesh.Image = global::QLVTNN.Properties.Resources.refresh_page_option;
            this.btnRefesh.Location = new System.Drawing.Point(656, 23);
            this.btnRefesh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Size = new System.Drawing.Size(100, 70);
            this.btnRefesh.TabIndex = 11;
            this.btnRefesh.Text = "Tạo Mới";
            this.btnRefesh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefesh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnRefesh, "Tạo mới thông tin nhân viên");
            this.btnRefesh.UseVisualStyleBackColor = false;
            this.btnRefesh.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::QLVTNN.Properties.Resources.trash;
            this.btnDelete.Location = new System.Drawing.Point(332, 23);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 71);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnDelete, "Xóa nhân viên");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::QLVTNN.Properties.Resources.edit_button;
            this.btnEdit.Location = new System.Drawing.Point(116, 25);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 71);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnEdit, "Sửa thông tin nhân viên");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::QLVTNN.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(8, 25);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 71);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnAdd, "Thêm nhân viên");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grTTNV
            // 
            this.grTTNV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grTTNV.BackColor = System.Drawing.Color.White;
            this.grTTNV.Controls.Add(this.dtNgaysinh);
            this.grTTNV.Controls.Add(this.label5);
            this.grTTNV.Controls.Add(this.cbbChucVu);
            this.grTTNV.Controls.Add(this.label4);
            this.grTTNV.Controls.Add(this.txtDiaChi);
            this.grTTNV.Controls.Add(this.txtName);
            this.grTTNV.Controls.Add(this.txtSDT);
            this.grTTNV.Controls.Add(this.label3);
            this.grTTNV.Controls.Add(this.label2);
            this.grTTNV.Controls.Add(this.label1);
            this.grTTNV.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grTTNV.Location = new System.Drawing.Point(16, 80);
            this.grTTNV.Margin = new System.Windows.Forms.Padding(4);
            this.grTTNV.Name = "grTTNV";
            this.grTTNV.Padding = new System.Windows.Forms.Padding(4);
            this.grTTNV.Size = new System.Drawing.Size(1581, 62);
            this.grTTNV.TabIndex = 10;
            this.grTTNV.TabStop = false;
            this.grTTNV.Text = "Thông tin Nhân Viên";
            // 
            // dtNgaysinh
            // 
            this.dtNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaysinh.Location = new System.Drawing.Point(888, 21);
            this.dtNgaysinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgaysinh.Name = "dtNgaysinh";
            this.dtNgaysinh.Size = new System.Drawing.Size(117, 26);
            this.dtNgaysinh.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(783, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Ngày Sinh:";
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Location = new System.Drawing.Point(96, 22);
            this.cbbChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(159, 27);
            this.cbbChucVu.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1015, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa Chỉ:";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiaChi.Location = new System.Drawing.Point(1096, 20);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(477, 26);
            this.txtDiaChi.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(319, 22);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(204, 26);
            this.txtName.TabIndex = 1;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(591, 22);
            this.txtSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(183, 26);
            this.txtSDT.TabIndex = 2;
            this.txtSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSDT_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 26);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "SĐT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chức Vụ:";
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
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu,
            this.tsmChucNang,
            this.tsmClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1613, 27);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmMenu
            // 
            this.tsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inDanhSáchToolStripMenuItem});
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(63, 23);
            this.tsmMenu.Text = "Menu";
            // 
            // inDanhSáchToolStripMenuItem
            // 
            this.inDanhSáchToolStripMenuItem.Name = "inDanhSáchToolStripMenuItem";
            this.inDanhSáchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.inDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.inDanhSáchToolStripMenuItem.Text = "In danh sách";
            this.inDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.inDanhSáchToolStripMenuItem_Click);
            // 
            // tsmChucNang
            // 
            this.tsmChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.sửaToolStripMenuItem,
            this.bậtTắtNhânViênToolStripMenuItem1,
            this.xóaToolStripMenuItem,
            this.chiTiếtGiaoDịchToolStripMenuItem,
            this.tìmToolStripMenuItem,
            this.xemTấtCảToolStripMenuItem,
            this.tạoMớiToolStripMenuItem,
            this.trởVềToolStripMenuItem});
            this.tsmChucNang.Name = "tsmChucNang";
            this.tsmChucNang.Size = new System.Drawing.Size(102, 23);
            this.tsmChucNang.Text = "Chức năng";
            // 
            // thêmToolStripMenuItem
            // 
            this.thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            this.thêmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // sửaToolStripMenuItem
            // 
            this.sửaToolStripMenuItem.Name = "sửaToolStripMenuItem";
            this.sửaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.sửaToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.sửaToolStripMenuItem.Text = "Sửa";
            this.sửaToolStripMenuItem.Click += new System.EventHandler(this.sửaToolStripMenuItem_Click);
            // 
            // bậtTắtNhânViênToolStripMenuItem1
            // 
            this.bậtTắtNhânViênToolStripMenuItem1.Name = "bậtTắtNhânViênToolStripMenuItem1";
            this.bậtTắtNhânViênToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.bậtTắtNhânViênToolStripMenuItem1.Size = new System.Drawing.Size(280, 26);
            this.bậtTắtNhânViênToolStripMenuItem1.Text = "Bật/Tắt nhân viên";
            this.bậtTắtNhânViênToolStripMenuItem1.Click += new System.EventHandler(this.bậtTắtNhânViênToolStripMenuItem1_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // chiTiếtGiaoDịchToolStripMenuItem
            // 
            this.chiTiếtGiaoDịchToolStripMenuItem.Name = "chiTiếtGiaoDịchToolStripMenuItem";
            this.chiTiếtGiaoDịchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.chiTiếtGiaoDịchToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.chiTiếtGiaoDịchToolStripMenuItem.Text = "Chi tiết giao dịch";
            this.chiTiếtGiaoDịchToolStripMenuItem.Click += new System.EventHandler(this.chiTiếtGiaoDịchToolStripMenuItem_Click);
            // 
            // tìmToolStripMenuItem
            // 
            this.tìmToolStripMenuItem.Name = "tìmToolStripMenuItem";
            this.tìmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tìmToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.tìmToolStripMenuItem.Text = "Tìm";
            // 
            // xemTấtCảToolStripMenuItem
            // 
            this.xemTấtCảToolStripMenuItem.Name = "xemTấtCảToolStripMenuItem";
            this.xemTấtCảToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.xemTấtCảToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.xemTấtCảToolStripMenuItem.Text = "Xem tất cả";
            this.xemTấtCảToolStripMenuItem.Click += new System.EventHandler(this.xemTấtCảToolStripMenuItem_Click);
            // 
            // tạoMớiToolStripMenuItem
            // 
            this.tạoMớiToolStripMenuItem.Name = "tạoMớiToolStripMenuItem";
            this.tạoMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tạoMớiToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.tạoMớiToolStripMenuItem.Text = "Tạo mới";
            this.tạoMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoMớiToolStripMenuItem_Click);
            // 
            // trởVềToolStripMenuItem
            // 
            this.trởVềToolStripMenuItem.Name = "trởVềToolStripMenuItem";
            this.trởVềToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.trởVềToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.trởVềToolStripMenuItem.Text = "Trở về";
            this.trởVềToolStripMenuItem.Click += new System.EventHandler(this.trởVềToolStripMenuItem_Click);
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
            this.tsPrint});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1613, 46);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsPrint
            // 
            this.tsPrint.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tsPrint.Image = global::QLVTNN.Properties.Resources.printer;
            this.tsPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsPrint.Name = "tsPrint";
            this.tsPrint.Size = new System.Drawing.Size(111, 43);
            this.tsPrint.Text = "In Danh Sách";
            this.tsPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsPrint.Click += new System.EventHandler(this.tsPrint_Click);
            // 
            // frmNhanVien
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1613, 672);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.grChiTietGD);
            this.Controls.Add(this.grDSNV);
            this.Controls.Add(this.grFind);
            this.Controls.Add(this.grChucNang);
            this.Controls.Add(this.grTTNV);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmNhanVien";
            this.Text = "Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgChiTietGD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSNhanVien)).EndInit();
            this.grChiTietGD.ResumeLayout(false);
            this.grDSNV.ResumeLayout(false);
            this.grFind.ResumeLayout(false);
            this.grFind.PerformLayout();
            this.grChucNang.ResumeLayout(false);
            this.grTTNV.ResumeLayout(false);
            this.grTTNV.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.DataGridView dgChiTietGD;
        private System.Windows.Forms.DataGridView dgDSNhanVien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefesh;
        private System.Windows.Forms.GroupBox grChiTietGD;
        private System.Windows.Forms.GroupBox grDSNV;
        private System.Windows.Forms.GroupBox grFind;
        private System.Windows.Forms.GroupBox grChucNang;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox grTTNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbChucVu;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.DateTimePicker dtNgaysinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnChiTietGD;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsPrint;
        private System.Windows.Forms.ToolStripMenuItem inDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmChucNang;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chiTiếtGiaoDịchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trởVềToolStripMenuItem;
        private System.Windows.Forms.Button btnSeenAll;
        private System.Windows.Forms.Button btnTrangThai;
        private System.Windows.Forms.ToolStripMenuItem bậtTắtNhânViênToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem xemTấtCảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.ToolStripMenuItem tìmToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}
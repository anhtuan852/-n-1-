
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
            this.grTTKH = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_ID_KH = new System.Windows.Forms.ComboBox();
            this.grTTHH = new System.Windows.Forms.GroupBox();
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
            this.grChucNang = new System.Windows.Forms.GroupBox();
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsSeenPrice = new System.Windows.Forms.ToolStripButton();
            this.tsAddKh = new System.Windows.Forms.ToolStripButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tsmMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.xemGiáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tạoMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trởVềToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClose = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.grTTKH.SuspendLayout();
            this.grTTHH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_SL)).BeginInit();
            this.grChucNang.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBanHang)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grTTKH
            // 
            this.grTTKH.BackColor = System.Drawing.Color.White;
            this.grTTKH.Controls.Add(this.label1);
            this.grTTKH.Controls.Add(this.cbb_ID_KH);
            this.grTTKH.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTTKH.Location = new System.Drawing.Point(12, 70);
            this.grTTKH.Name = "grTTKH";
            this.grTTKH.Size = new System.Drawing.Size(295, 108);
            this.grTTKH.TabIndex = 4;
            this.grTTKH.TabStop = false;
            this.grTTKH.Text = "Thông tin Khách Hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khách Hàng:";
            // 
            // cbb_ID_KH
            // 
            this.cbb_ID_KH.FormattingEnabled = true;
            this.cbb_ID_KH.Location = new System.Drawing.Point(98, 46);
            this.cbb_ID_KH.Name = "cbb_ID_KH";
            this.cbb_ID_KH.Size = new System.Drawing.Size(187, 27);
            this.cbb_ID_KH.TabIndex = 7;
            // 
            // grTTHH
            // 
            this.grTTHH.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grTTHH.BackColor = System.Drawing.Color.White;
            this.grTTHH.Controls.Add(this.nm_SL);
            this.grTTHH.Controls.Add(this.label8);
            this.grTTHH.Controls.Add(this.cbb_Price);
            this.grTTHH.Controls.Add(this.label7);
            this.grTTHH.Controls.Add(this.cbb_DVT);
            this.grTTHH.Controls.Add(this.label6);
            this.grTTHH.Controls.Add(this.cbb_Name_SP);
            this.grTTHH.Controls.Add(this.cbb_ID_SP);
            this.grTTHH.Controls.Add(this.cbb_Loai);
            this.grTTHH.Controls.Add(this.label5);
            this.grTTHH.Controls.Add(this.label4);
            this.grTTHH.Controls.Add(this.label3);
            this.grTTHH.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grTTHH.Location = new System.Drawing.Point(313, 70);
            this.grTTHH.Name = "grTTHH";
            this.grTTHH.Size = new System.Drawing.Size(876, 108);
            this.grTTHH.TabIndex = 5;
            this.grTTHH.TabStop = false;
            this.grTTHH.Text = "Thông tin Hàng Hóa";
            // 
            // nm_SL
            // 
            this.nm_SL.Location = new System.Drawing.Point(675, 66);
            this.nm_SL.Name = "nm_SL";
            this.nm_SL.Size = new System.Drawing.Size(55, 26);
            this.nm_SL.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(569, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "Số lượng:";
            // 
            // cbb_Price
            // 
            this.cbb_Price.Enabled = false;
            this.cbb_Price.FormattingEnabled = true;
            this.cbb_Price.Location = new System.Drawing.Point(383, 65);
            this.cbb_Price.Name = "cbb_Price";
            this.cbb_Price.Size = new System.Drawing.Size(180, 27);
            this.cbb_Price.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(282, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 19);
            this.label7.TabIndex = 11;
            this.label7.Text = "Giá:";
            // 
            // cbb_DVT
            // 
            this.cbb_DVT.Enabled = false;
            this.cbb_DVT.FormattingEnabled = true;
            this.cbb_DVT.Location = new System.Drawing.Point(114, 65);
            this.cbb_DVT.Name = "cbb_DVT";
            this.cbb_DVT.Size = new System.Drawing.Size(162, 27);
            this.cbb_DVT.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 9;
            this.label6.Text = "Đơn vị tính:";
            // 
            // cbb_Name_SP
            // 
            this.cbb_Name_SP.FormattingEnabled = true;
            this.cbb_Name_SP.Location = new System.Drawing.Point(675, 30);
            this.cbb_Name_SP.Name = "cbb_Name_SP";
            this.cbb_Name_SP.Size = new System.Drawing.Size(193, 27);
            this.cbb_Name_SP.TabIndex = 13;
            // 
            // cbb_ID_SP
            // 
            this.cbb_ID_SP.FormattingEnabled = true;
            this.cbb_ID_SP.Location = new System.Drawing.Point(383, 30);
            this.cbb_ID_SP.Name = "cbb_ID_SP";
            this.cbb_ID_SP.Size = new System.Drawing.Size(180, 27);
            this.cbb_ID_SP.TabIndex = 11;
            // 
            // cbb_Loai
            // 
            this.cbb_Loai.FormattingEnabled = true;
            this.cbb_Loai.Location = new System.Drawing.Point(114, 30);
            this.cbb_Loai.Name = "cbb_Loai";
            this.cbb_Loai.Size = new System.Drawing.Size(162, 27);
            this.cbb_Loai.TabIndex = 9;
            this.cbb_Loai.SelectedIndexChanged += new System.EventHandler(this.cbb_Loai_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(569, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tên Hàng Hóa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mã Hàng Hóa:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Loại Hàng Hóa:";
            // 
            // grChucNang
            // 
            this.grChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grChucNang.BackColor = System.Drawing.Color.White;
            this.grChucNang.Controls.Add(this.btn_Pay);
            this.grChucNang.Controls.Add(this.btn_Back);
            this.grChucNang.Controls.Add(this.btn_Refesh);
            this.grChucNang.Controls.Add(this.btn_Delete);
            this.grChucNang.Controls.Add(this.btn_Add);
            this.grChucNang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grChucNang.Location = new System.Drawing.Point(11, 184);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Size = new System.Drawing.Size(1177, 97);
            this.grChucNang.TabIndex = 5;
            this.grChucNang.TabStop = false;
            this.grChucNang.Text = "Chức năng";
            // 
            // btn_Pay
            // 
            this.btn_Pay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Pay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Pay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pay.Image = global::QLVTNN.Properties.Resources.payment;
            this.btn_Pay.Location = new System.Drawing.Point(168, 23);
            this.btn_Pay.Name = "btn_Pay";
            this.btn_Pay.Size = new System.Drawing.Size(115, 62);
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
            this.btn_Back.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Image = global::QLVTNN.Properties.Resources.exit;
            this.btn_Back.Location = new System.Drawing.Point(383, 23);
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
            this.btn_Refesh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Refesh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Refesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refesh.Image = global::QLVTNN.Properties.Resources.refresh_page_option;
            this.btn_Refesh.Location = new System.Drawing.Point(289, 23);
            this.btn_Refesh.Name = "btn_Refesh";
            this.btn_Refesh.Size = new System.Drawing.Size(88, 62);
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
            this.btn_Delete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Image = global::QLVTNN.Properties.Resources.trash;
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
            this.btn_Add.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Image = global::QLVTNN.Properties.Resources.add;
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
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.Controls.Add(this.dgBanHang);
            this.groupBox4.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(12, 312);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1176, 209);
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
            this.dgBanHang.RowHeadersWidth = 51;
            this.dgBanHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBanHang.Size = new System.Drawing.Size(1164, 180);
            this.dgBanHang.TabIndex = 0;
            this.dgBanHang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgBanHang_CellClick);
            // 
            // lbTongHD
            // 
            this.lbTongHD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTongHD.AutoSize = true;
            this.lbTongHD.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongHD.Location = new System.Drawing.Point(961, 291);
            this.lbTongHD.Name = "lbTongHD";
            this.lbTongHD.Size = new System.Drawing.Size(123, 19);
            this.lbTongHD.TabIndex = 7;
            this.lbTongHD.Text = "Tổng Hóa Đơn:";
            // 
            // lbSLHang
            // 
            this.lbSLHang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSLHang.AutoSize = true;
            this.lbSLHang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSLHang.Location = new System.Drawing.Point(800, 291);
            this.lbSLHang.Name = "lbSLHang";
            this.lbSLHang.Size = new System.Drawing.Size(121, 19);
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
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsSeenPrice,
            this.tsAddKh});
            this.toolStrip1.Location = new System.Drawing.Point(0, 27);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1201, 46);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsSeenPrice
            // 
            this.tsSeenPrice.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tsSeenPrice.Image = global::QLVTNN.Properties.Resources._10168047151595234985_128;
            this.tsSeenPrice.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSeenPrice.Name = "tsSeenPrice";
            this.tsSeenPrice.Size = new System.Drawing.Size(76, 43);
            this.tsSeenPrice.Text = "Xem Giá";
            this.tsSeenPrice.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsSeenPrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsSeenPrice.Click += new System.EventHandler(this.tsSeenPrice_Click);
            // 
            // tsAddKh
            // 
            this.tsAddKh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tsAddKh.Image = global::QLVTNN.Properties.Resources._17437607421571662152_128;
            this.tsAddKh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddKh.Name = "tsAddKh";
            this.tsAddKh.Size = new System.Drawing.Size(81, 43);
            this.tsAddKh.Text = "Thêm KH";
            this.tsAddKh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tsAddKh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAddKh.Click += new System.EventHandler(this.tsAddKh_Click);
            // 
            // tsmMenu
            // 
            this.tsmMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xemGiáToolStripMenuItem,
            this.thêmKháchHàngToolStripMenuItem});
            this.tsmMenu.Name = "tsmMenu";
            this.tsmMenu.Size = new System.Drawing.Size(63, 23);
            this.tsmMenu.Text = "Menu";
            // 
            // xemGiáToolStripMenuItem
            // 
            this.xemGiáToolStripMenuItem.Name = "xemGiáToolStripMenuItem";
            this.xemGiáToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.xemGiáToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.xemGiáToolStripMenuItem.Text = "Xem giá";
            this.xemGiáToolStripMenuItem.Click += new System.EventHandler(this.xemGiáToolStripMenuItem_Click);
            // 
            // thêmKháchHàngToolStripMenuItem
            // 
            this.thêmKháchHàngToolStripMenuItem.Name = "thêmKháchHàngToolStripMenuItem";
            this.thêmKháchHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.thêmKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(274, 26);
            this.thêmKháchHàngToolStripMenuItem.Text = "Thêm khách hàng";
            this.thêmKháchHàngToolStripMenuItem.Click += new System.EventHandler(this.thêmKháchHàngToolStripMenuItem_Click);
            // 
            // tsmChucNang
            // 
            this.tsmChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmToolStripMenuItem,
            this.xóaToolStripMenuItem,
            this.thanhToánToolStripMenuItem,
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
            this.thêmToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.thêmToolStripMenuItem.Text = "Thêm";
            this.thêmToolStripMenuItem.Click += new System.EventHandler(this.thêmToolStripMenuItem_Click);
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // tạoMớiToolStripMenuItem
            // 
            this.tạoMớiToolStripMenuItem.Name = "tạoMớiToolStripMenuItem";
            this.tạoMớiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.tạoMớiToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.tạoMớiToolStripMenuItem.Text = "Tạo mới";
            this.tạoMớiToolStripMenuItem.Click += new System.EventHandler(this.tạoMớiToolStripMenuItem_Click);
            // 
            // trởVềToolStripMenuItem
            // 
            this.trởVềToolStripMenuItem.Name = "trởVềToolStripMenuItem";
            this.trởVềToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.trởVềToolStripMenuItem.Size = new System.Drawing.Size(268, 26);
            this.trởVềToolStripMenuItem.Text = "Đóng";
            this.trởVềToolStripMenuItem.Click += new System.EventHandler(this.trởVềToolStripMenuItem_Click);
            // 
            // tsmClose
            // 
            this.tsmClose.Name = "tsmClose";
            this.tsmClose.Size = new System.Drawing.Size(66, 23);
            this.tsmClose.Text = "Thoát";
            this.tsmClose.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMenu,
            this.tsmChucNang,
            this.tsmClose});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1201, 27);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmBanHang
            // 
            this.AcceptButton = this.btn_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1201, 534);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.lbSLHang);
            this.Controls.Add(this.lbTongHD);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grChucNang);
            this.Controls.Add(this.grTTHH);
            this.Controls.Add(this.grTTKH);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmBanHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bán Hàng";
            this.Load += new System.EventHandler(this.frmBanHang_Load);
            this.grTTKH.ResumeLayout(false);
            this.grTTKH.PerformLayout();
            this.grTTHH.ResumeLayout(false);
            this.grTTHH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nm_SL)).EndInit();
            this.grChucNang.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgBanHang)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grTTKH;
        private System.Windows.Forms.GroupBox grTTHH;
        private System.Windows.Forms.GroupBox grChucNang;
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsSeenPrice;
        private System.Windows.Forms.ToolStripButton tsAddKh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem tsmMenu;
        private System.Windows.Forms.ToolStripMenuItem xemGiáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmChucNang;
        private System.Windows.Forms.ToolStripMenuItem thêmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tạoMớiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trởVềToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmClose;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}
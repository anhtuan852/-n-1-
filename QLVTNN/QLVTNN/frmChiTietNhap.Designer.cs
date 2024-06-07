
namespace QLVTNN
{
    partial class frmChiTietNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChiTietNhap));
            this.grChucNang = new System.Windows.Forms.GroupBox();
            this.btnPrintDelete = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.grDS = new System.Windows.Forms.GroupBox();
            this.dgDSNhap = new System.Windows.Forms.DataGridView();
            this.grChiTietXem = new System.Windows.Forms.GroupBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.lbEnd = new System.Windows.Forms.Label();
            this.lbStart = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grChucNang.SuspendLayout();
            this.grDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDSNhap)).BeginInit();
            this.grChiTietXem.SuspendLayout();
            this.SuspendLayout();
            // 
            // grChucNang
            // 
            this.grChucNang.BackColor = System.Drawing.Color.White;
            this.grChucNang.Controls.Add(this.btnPrintDelete);
            this.grChucNang.Controls.Add(this.btnReport);
            this.grChucNang.Controls.Add(this.btnBack);
            this.grChucNang.Controls.Add(this.btnTaoMoi);
            this.grChucNang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grChucNang.Location = new System.Drawing.Point(16, 15);
            this.grChucNang.Margin = new System.Windows.Forms.Padding(4);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Padding = new System.Windows.Forms.Padding(4);
            this.grChucNang.Size = new System.Drawing.Size(673, 102);
            this.grChucNang.TabIndex = 0;
            this.grChucNang.TabStop = false;
            this.grChucNang.Text = "Chức năng";
            // 
            // btnPrintDelete
            // 
            this.btnPrintDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPrintDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrintDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrintDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.btnPrintDelete.Image = global::QLVTNN.Properties.Resources.trash;
            this.btnPrintDelete.Location = new System.Drawing.Point(136, 21);
            this.btnPrintDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrintDelete.Name = "btnPrintDelete";
            this.btnPrintDelete.Size = new System.Drawing.Size(100, 71);
            this.btnPrintDelete.TabIndex = 7;
            this.btnPrintDelete.Text = "In và Xóa";
            this.btnPrintDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrintDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnPrintDelete, "Tạo mới thong tin nhạp hàng");
            this.btnPrintDelete.UseVisualStyleBackColor = false;
            this.btnPrintDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.btnReport.Image = global::QLVTNN.Properties.Resources.printer;
            this.btnReport.Location = new System.Drawing.Point(11, 21);
            this.btnReport.Margin = new System.Windows.Forms.Padding(4);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(117, 71);
            this.btnReport.TabIndex = 4;
            this.btnReport.Text = "Báo Cáo";
            this.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnReport, "Xuất báo cáo nhập hàng");
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.btnBack.Image = global::QLVTNN.Properties.Resources.exit;
            this.btnBack.Location = new System.Drawing.Point(352, 21);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 71);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Đóng";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnBack, "Trở về trước");
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTaoMoi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoMoi.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.btnTaoMoi.Image = global::QLVTNN.Properties.Resources.refresh_page_option;
            this.btnTaoMoi.Location = new System.Drawing.Point(244, 21);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(100, 71);
            this.btnTaoMoi.TabIndex = 5;
            this.btnTaoMoi.Text = "Tạo Mới";
            this.btnTaoMoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTaoMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnTaoMoi, "Tạo mới thong tin nhạp hàng");
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // grDS
            // 
            this.grDS.BackColor = System.Drawing.Color.White;
            this.grDS.Controls.Add(this.dgDSNhap);
            this.grDS.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grDS.Location = new System.Drawing.Point(17, 126);
            this.grDS.Margin = new System.Windows.Forms.Padding(4);
            this.grDS.Name = "grDS";
            this.grDS.Padding = new System.Windows.Forms.Padding(4);
            this.grDS.Size = new System.Drawing.Size(1187, 326);
            this.grDS.TabIndex = 1;
            this.grDS.TabStop = false;
            this.grDS.Text = "Danh sách chi tiết";
            // 
            // dgDSNhap
            // 
            this.dgDSNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDSNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDSNhap.Location = new System.Drawing.Point(9, 27);
            this.dgDSNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dgDSNhap.Name = "dgDSNhap";
            this.dgDSNhap.RowHeadersWidth = 51;
            this.dgDSNhap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDSNhap.Size = new System.Drawing.Size(1169, 292);
            this.dgDSNhap.TabIndex = 10;
            // 
            // grChiTietXem
            // 
            this.grChiTietXem.BackColor = System.Drawing.Color.White;
            this.grChiTietXem.Controls.Add(this.btnXem);
            this.grChiTietXem.Controls.Add(this.dtEnd);
            this.grChiTietXem.Controls.Add(this.dtStart);
            this.grChiTietXem.Controls.Add(this.lbEnd);
            this.grChiTietXem.Controls.Add(this.lbStart);
            this.grChiTietXem.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grChiTietXem.Location = new System.Drawing.Point(697, 15);
            this.grChiTietXem.Margin = new System.Windows.Forms.Padding(4);
            this.grChiTietXem.Name = "grChiTietXem";
            this.grChiTietXem.Padding = new System.Windows.Forms.Padding(4);
            this.grChiTietXem.Size = new System.Drawing.Size(507, 103);
            this.grChiTietXem.TabIndex = 3;
            this.grChiTietXem.TabStop = false;
            this.grChiTietXem.Text = "Chi tiết xem";
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXem.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.btnXem.Image = global::QLVTNN.Properties.Resources.icons8_search_301;
            this.btnXem.Location = new System.Drawing.Point(208, 16);
            this.btnXem.Margin = new System.Windows.Forms.Padding(4);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 71);
            this.btnXem.TabIndex = 9;
            this.btnXem.Text = "Xem";
            this.btnXem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnXem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnXem, "Xem chi tiết");
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(63, 60);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(136, 26);
            this.dtEnd.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dtEnd, "Ngày kết thúc");
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(63, 18);
            this.dtStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(136, 26);
            this.dtStart.TabIndex = 7;
            this.toolTip1.SetToolTip(this.dtStart, "Ngày bắt đầu");
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.Location = new System.Drawing.Point(8, 63);
            this.lbEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(45, 19);
            this.lbEnd.TabIndex = 3;
            this.lbEnd.Text = "Đến:";
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.Location = new System.Drawing.Point(8, 25);
            this.lbStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(35, 19);
            this.lbStart.TabIndex = 2;
            this.lbStart.Text = "Từ:";
            // 
            // frmChiTietNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 466);
            this.Controls.Add(this.grChiTietXem);
            this.Controls.Add(this.grDS);
            this.Controls.Add(this.grChucNang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChiTietNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi Tiết Nhập Hàng";
            this.Load += new System.EventHandler(this.frmChiTietNhap_Load);
            this.grChucNang.ResumeLayout(false);
            this.grDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDSNhap)).EndInit();
            this.grChiTietXem.ResumeLayout(false);
            this.grChiTietXem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grChucNang;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.GroupBox grDS;
        private System.Windows.Forms.DataGridView dgDSNhap;
        private System.Windows.Forms.GroupBox grChiTietXem;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnPrintDelete;
    }
}
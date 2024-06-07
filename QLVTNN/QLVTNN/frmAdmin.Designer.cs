
namespace QLVTNN
{
    partial class frmAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grChucNang = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnChamCong = new System.Windows.Forms.Button();
            this.grDs = new System.Windows.Forms.GroupBox();
            this.dgChamCong = new System.Windows.Forms.DataGridView();
            this.grThongtin = new System.Windows.Forms.GroupBox();
            this.lbGhiChu = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lbDay = new System.Windows.Forms.Label();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.cbbNhanVien = new System.Windows.Forms.ComboBox();
            this.lbNV = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grChucNang.SuspendLayout();
            this.grDs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgChamCong)).BeginInit();
            this.grThongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.tabControl1.Location = new System.Drawing.Point(15, 15);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 485);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.grChucNang);
            this.tabPage1.Controls.Add(this.grDs);
            this.tabPage1.Controls.Add(this.grThongtin);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 453);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chấm Công";
            // 
            // grChucNang
            // 
            this.grChucNang.BackColor = System.Drawing.Color.White;
            this.grChucNang.Controls.Add(this.btnBack);
            this.grChucNang.Controls.Add(this.btnEdit);
            this.grChucNang.Controls.Add(this.btnChamCong);
            this.grChucNang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grChucNang.Location = new System.Drawing.Point(8, 87);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Size = new System.Drawing.Size(813, 66);
            this.grChucNang.TabIndex = 2;
            this.grChucNang.TabStop = false;
            this.grChucNang.Text = "Chức năng";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.btnBack.Location = new System.Drawing.Point(168, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 40);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Trở Về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.btnEdit.Location = new System.Drawing.Point(87, 20);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 40);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnChamCong
            // 
            this.btnChamCong.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnChamCong.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChamCong.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.btnChamCong.Location = new System.Drawing.Point(6, 20);
            this.btnChamCong.Name = "btnChamCong";
            this.btnChamCong.Size = new System.Drawing.Size(75, 40);
            this.btnChamCong.TabIndex = 0;
            this.btnChamCong.Text = "Chấm Công";
            this.btnChamCong.UseVisualStyleBackColor = false;
            this.btnChamCong.Click += new System.EventHandler(this.btnChamCong_Click);
            // 
            // grDs
            // 
            this.grDs.Controls.Add(this.dgChamCong);
            this.grDs.Location = new System.Drawing.Point(8, 159);
            this.grDs.Name = "grDs";
            this.grDs.Size = new System.Drawing.Size(813, 292);
            this.grDs.TabIndex = 1;
            this.grDs.TabStop = false;
            this.grDs.Text = "Danh sách";
            // 
            // dgChamCong
            // 
            this.dgChamCong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgChamCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgChamCong.Location = new System.Drawing.Point(6, 20);
            this.dgChamCong.Name = "dgChamCong";
            this.dgChamCong.RowHeadersWidth = 51;
            this.dgChamCong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgChamCong.Size = new System.Drawing.Size(801, 266);
            this.dgChamCong.TabIndex = 0;
            this.dgChamCong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgChamCong_CellClick);
            // 
            // grThongtin
            // 
            this.grThongtin.BackColor = System.Drawing.Color.White;
            this.grThongtin.Controls.Add(this.lbGhiChu);
            this.grThongtin.Controls.Add(this.txtGhiChu);
            this.grThongtin.Controls.Add(this.lbDay);
            this.grThongtin.Controls.Add(this.dtNgay);
            this.grThongtin.Controls.Add(this.cbbNhanVien);
            this.grThongtin.Controls.Add(this.lbNV);
            this.grThongtin.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grThongtin.Location = new System.Drawing.Point(8, 8);
            this.grThongtin.Name = "grThongtin";
            this.grThongtin.Size = new System.Drawing.Size(813, 72);
            this.grThongtin.TabIndex = 0;
            this.grThongtin.TabStop = false;
            this.grThongtin.Text = "Thông Tin";
            // 
            // lbGhiChu
            // 
            this.lbGhiChu.AutoSize = true;
            this.lbGhiChu.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.lbGhiChu.Location = new System.Drawing.Point(375, 31);
            this.lbGhiChu.Name = "lbGhiChu";
            this.lbGhiChu.Size = new System.Drawing.Size(74, 19);
            this.lbGhiChu.TabIndex = 5;
            this.lbGhiChu.Text = "Ghi Chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.txtGhiChu.Location = new System.Drawing.Point(432, 28);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(375, 26);
            this.txtGhiChu.TabIndex = 4;
            // 
            // lbDay
            // 
            this.lbDay.AutoSize = true;
            this.lbDay.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.lbDay.Location = new System.Drawing.Point(232, 31);
            this.lbDay.Name = "lbDay";
            this.lbDay.Size = new System.Drawing.Size(54, 19);
            this.lbDay.TabIndex = 3;
            this.lbDay.Text = "Ngày:";
            // 
            // dtNgay
            // 
            this.dtNgay.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.dtNgay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgay.Location = new System.Drawing.Point(274, 28);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(95, 26);
            this.dtNgay.TabIndex = 2;
            // 
            // cbbNhanVien
            // 
            this.cbbNhanVien.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.cbbNhanVien.FormattingEnabled = true;
            this.cbbNhanVien.Location = new System.Drawing.Point(72, 28);
            this.cbbNhanVien.Name = "cbbNhanVien";
            this.cbbNhanVien.Size = new System.Drawing.Size(154, 27);
            this.cbbNhanVien.TabIndex = 1;
            // 
            // lbNV
            // 
            this.lbNV.AutoSize = true;
            this.lbNV.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.lbNV.Location = new System.Drawing.Point(6, 31);
            this.lbNV.Name = "lbNV";
            this.lbNV.Size = new System.Drawing.Size(90, 19);
            this.lbNV.TabIndex = 0;
            this.lbNV.Text = "Nhân Viên:";
            // 
            // frmAdmin
            // 
            this.AcceptButton = this.btnChamCong;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 512);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.frmAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grChucNang.ResumeLayout(false);
            this.grDs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgChamCong)).EndInit();
            this.grThongtin.ResumeLayout(false);
            this.grThongtin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox grChucNang;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnChamCong;
        private System.Windows.Forms.GroupBox grDs;
        private System.Windows.Forms.DataGridView dgChamCong;
        private System.Windows.Forms.GroupBox grThongtin;
        private System.Windows.Forms.Label lbGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label lbDay;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.ComboBox cbbNhanVien;
        private System.Windows.Forms.Label lbNV;
    }
}

namespace QLVTNN
{
    partial class frmThemMoiHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThemMoiHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbLoai = new System.Windows.Forms.ComboBox();
            this.txtDVT_SP = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtGiaBan = new System.Windows.Forms.TextBox();
            this.txtGiaMua = new System.Windows.Forms.TextBox();
            this.txtID_SP = new System.Windows.Forms.TextBox();
            this.txtName_SP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnAdd_SP = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cbbLoai);
            this.groupBox1.Controls.Add(this.txtDVT_SP);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtGiaBan);
            this.groupBox1.Controls.Add(this.txtGiaMua);
            this.groupBox1.Controls.Add(this.txtID_SP);
            this.groupBox1.Controls.Add(this.txtName_SP);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hàng hóa";
            // 
            // cbbLoai
            // 
            this.cbbLoai.FormattingEnabled = true;
            this.cbbLoai.Location = new System.Drawing.Point(46, 23);
            this.cbbLoai.Name = "cbbLoai";
            this.cbbLoai.Size = new System.Drawing.Size(127, 24);
            this.cbbLoai.TabIndex = 1;
            // 
            // txtDVT_SP
            // 
            this.txtDVT_SP.Location = new System.Drawing.Point(256, 59);
            this.txtDVT_SP.Name = "txtDVT_SP";
            this.txtDVT_SP.Size = new System.Drawing.Size(93, 22);
            this.txtDVT_SP.TabIndex = 4;
            this.txtDVT_SP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDVT_SP_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(212, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 15;
            this.label7.Text = "ĐVT:";
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.Location = new System.Drawing.Point(249, 96);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(100, 22);
            this.txtGiaBan.TabIndex = 6;
            this.txtGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaBan_KeyPress);
            // 
            // txtGiaMua
            // 
            this.txtGiaMua.Location = new System.Drawing.Point(76, 95);
            this.txtGiaMua.Name = "txtGiaMua";
            this.txtGiaMua.Size = new System.Drawing.Size(100, 22);
            this.txtGiaMua.TabIndex = 5;
            this.txtGiaMua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGiaMua_KeyPress);
            // 
            // txtID_SP
            // 
            this.txtID_SP.Location = new System.Drawing.Point(215, 26);
            this.txtID_SP.Name = "txtID_SP";
            this.txtID_SP.Size = new System.Drawing.Size(134, 22);
            this.txtID_SP.TabIndex = 2;
            // 
            // txtName_SP
            // 
            this.txtName_SP.Location = new System.Drawing.Point(47, 59);
            this.txtName_SP.Name = "txtName_SP";
            this.txtName_SP.Size = new System.Drawing.Size(162, 22);
            this.txtName_SP.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(179, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Giá Bán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Giá Mua:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mã:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Loại:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnTaoMoi);
            this.groupBox2.Controls.Add(this.btnAdd_SP);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(393, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(102, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnTaoMoi
            // 
            this.btnTaoMoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaoMoi.Image = global::QLVTNN.Properties.Resources.reload;
            this.btnTaoMoi.Location = new System.Drawing.Point(15, 81);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(65, 52);
            this.btnTaoMoi.TabIndex = 20;
            this.btnTaoMoi.Text = "Refesh";
            this.btnTaoMoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTaoMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            // 
            // btnAdd_SP
            // 
            this.btnAdd_SP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAdd_SP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_SP.Image = global::QLVTNN.Properties.Resources.button;
            this.btnAdd_SP.Location = new System.Drawing.Point(15, 23);
            this.btnAdd_SP.Name = "btnAdd_SP";
            this.btnAdd_SP.Size = new System.Drawing.Size(65, 52);
            this.btnAdd_SP.TabIndex = 19;
            this.btnAdd_SP.Text = "Thêm";
            this.btnAdd_SP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd_SP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAdd_SP.UseVisualStyleBackColor = false;
            this.btnAdd_SP.Click += new System.EventHandler(this.btnAdd_SP_Click);
            // 
            // frmThemMoiHang
            // 
            this.AcceptButton = this.btnAdd_SP;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 160);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmThemMoiHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Mới Hàng Hóa";
            this.Load += new System.EventHandler(this.frmThemMoiHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDVT_SP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtGiaBan;
        private System.Windows.Forms.TextBox txtGiaMua;
        private System.Windows.Forms.TextBox txtID_SP;
        private System.Windows.Forms.TextBox txtName_SP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbLoai;
        private System.Windows.Forms.Button btnAdd_SP;
        private System.Windows.Forms.Button btnTaoMoi;
    }
}
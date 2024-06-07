
namespace QLVTNN
{
    partial class frmAddKH
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddKH));
            this.grThongTinKH = new System.Windows.Forms.GroupBox();
            this.dtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lbDob = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtSĐT = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.lbSĐT = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.grChucNang = new System.Windows.Forms.GroupBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.grThongTinKH.SuspendLayout();
            this.grChucNang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grThongTinKH
            // 
            this.grThongTinKH.BackColor = System.Drawing.Color.White;
            this.grThongTinKH.Controls.Add(this.dtNgaySinh);
            this.grThongTinKH.Controls.Add(this.lbDob);
            this.grThongTinKH.Controls.Add(this.txtAddress);
            this.grThongTinKH.Controls.Add(this.txtSĐT);
            this.grThongTinKH.Controls.Add(this.txtName);
            this.grThongTinKH.Controls.Add(this.txtID);
            this.grThongTinKH.Controls.Add(this.lbAddress);
            this.grThongTinKH.Controls.Add(this.lbSĐT);
            this.grThongTinKH.Controls.Add(this.lbName);
            this.grThongTinKH.Controls.Add(this.lbID);
            this.grThongTinKH.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grThongTinKH.Location = new System.Drawing.Point(17, 16);
            this.grThongTinKH.Margin = new System.Windows.Forms.Padding(4);
            this.grThongTinKH.Name = "grThongTinKH";
            this.grThongTinKH.Padding = new System.Windows.Forms.Padding(4);
            this.grThongTinKH.Size = new System.Drawing.Size(563, 145);
            this.grThongTinKH.TabIndex = 0;
            this.grThongTinKH.TabStop = false;
            this.grThongTinKH.Text = "Thông tin khách hàng";
            // 
            // dtNgaySinh
            // 
            this.dtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgaySinh.Location = new System.Drawing.Point(357, 60);
            this.dtNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgaySinh.Name = "dtNgaySinh";
            this.dtNgaySinh.Size = new System.Drawing.Size(196, 26);
            this.dtNgaySinh.TabIndex = 9;
            // 
            // lbDob
            // 
            this.lbDob.AutoSize = true;
            this.lbDob.Location = new System.Drawing.Point(216, 68);
            this.lbDob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDob.Name = "lbDob";
            this.lbDob.Size = new System.Drawing.Size(88, 19);
            this.lbDob.TabIndex = 8;
            this.lbDob.Text = "Ngày sinh:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(75, 108);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(324, 26);
            this.txtAddress.TabIndex = 7;
            // 
            // txtSĐT
            // 
            this.txtSĐT.Location = new System.Drawing.Point(75, 64);
            this.txtSĐT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(132, 26);
            this.txtSĐT.TabIndex = 6;
            this.txtSĐT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSĐT_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(287, 21);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(267, 26);
            this.txtName.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(75, 21);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(132, 26);
            this.txtID.TabIndex = 4;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Location = new System.Drawing.Point(9, 117);
            this.lbAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(64, 19);
            this.lbAddress.TabIndex = 3;
            this.lbAddress.Text = "Địa chỉ:";
            // 
            // lbSĐT
            // 
            this.lbSĐT.AutoSize = true;
            this.lbSĐT.Location = new System.Drawing.Point(9, 68);
            this.lbSĐT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSĐT.Name = "lbSĐT";
            this.lbSĐT.Size = new System.Drawing.Size(46, 19);
            this.lbSĐT.TabIndex = 2;
            this.lbSĐT.Text = "SĐT:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(216, 25);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(69, 19);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Tên KH:";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(9, 25);
            this.lbID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(64, 19);
            this.lbID.TabIndex = 0;
            this.lbID.Text = "Mã KH:";
            // 
            // grChucNang
            // 
            this.grChucNang.BackColor = System.Drawing.Color.White;
            this.grChucNang.Controls.Add(this.btn_Add);
            this.grChucNang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grChucNang.Location = new System.Drawing.Point(588, 16);
            this.grChucNang.Margin = new System.Windows.Forms.Padding(4);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Padding = new System.Windows.Forms.Padding(4);
            this.grChucNang.Size = new System.Drawing.Size(167, 145);
            this.grChucNang.TabIndex = 1;
            this.grChucNang.TabStop = false;
            this.grChucNang.Text = "Chức năng";
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Image = global::QLVTNN.Properties.Resources.add;
            this.btn_Add.Location = new System.Drawing.Point(35, 48);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(100, 71);
            this.btn_Add.TabIndex = 7;
            this.btn_Add.Text = "Thêm";
            this.btn_Add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // frmAddKH
            // 
            this.AcceptButton = this.btn_Add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 171);
            this.Controls.Add(this.grChucNang);
            this.Controls.Add(this.grThongTinKH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddKH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Khách Hàng";
            this.grThongTinKH.ResumeLayout(false);
            this.grThongTinKH.PerformLayout();
            this.grChucNang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grThongTinKH;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtSĐT;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbSĐT;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.GroupBox grChucNang;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.DateTimePicker dtNgaySinh;
        private System.Windows.Forms.Label lbDob;
    }
}
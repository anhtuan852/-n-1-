
namespace QLVTNN
{
    partial class frmThanhToan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToan));
            this.btnThanhToan_TT = new System.Windows.Forms.Button();
            this.txtTra_HD_TT = new System.Windows.Forms.TextBox();
            this.txtConLai_HD_TT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTongHD_TT = new System.Windows.Forms.Label();
            this.lable9 = new System.Windows.Forms.Label();
            this.lbTongSLSP_TT = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbID_HD_TT = new System.Windows.Forms.Label();
            this.lbID_KH_TT = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNv = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThanhToan_TT
            // 
            this.btnThanhToan_TT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThanhToan_TT.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnThanhToan_TT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThanhToan_TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan_TT.Image = global::QLVTNN.Properties.Resources.pay;
            this.btnThanhToan_TT.Location = new System.Drawing.Point(6, 21);
            this.btnThanhToan_TT.Name = "btnThanhToan_TT";
            this.btnThanhToan_TT.Size = new System.Drawing.Size(82, 58);
            this.btnThanhToan_TT.TabIndex = 7;
            this.btnThanhToan_TT.Text = "Thanh Toán";
            this.btnThanhToan_TT.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnThanhToan_TT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnThanhToan_TT.UseVisualStyleBackColor = false;
            this.btnThanhToan_TT.Click += new System.EventHandler(this.btnThanhToan_TT_Click);
            // 
            // txtTra_HD_TT
            // 
            this.txtTra_HD_TT.Location = new System.Drawing.Point(283, 28);
            this.txtTra_HD_TT.Name = "txtTra_HD_TT";
            this.txtTra_HD_TT.Size = new System.Drawing.Size(106, 22);
            this.txtTra_HD_TT.TabIndex = 1;
            this.txtTra_HD_TT.TextChanged += new System.EventHandler(this.txtTra_HD_TT_TextChanged);
            this.txtTra_HD_TT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTra_HD_TT_KeyPress);
            // 
            // txtConLai_HD_TT
            // 
            this.txtConLai_HD_TT.Location = new System.Drawing.Point(490, 28);
            this.txtConLai_HD_TT.Name = "txtConLai_HD_TT";
            this.txtConLai_HD_TT.Size = new System.Drawing.Size(106, 22);
            this.txtConLai_HD_TT.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tổng HD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Trả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(429, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Còn Lại:";
            // 
            // lbTongHD_TT
            // 
            this.lbTongHD_TT.AutoSize = true;
            this.lbTongHD_TT.Location = new System.Drawing.Point(75, 31);
            this.lbTongHD_TT.Name = "lbTongHD_TT";
            this.lbTongHD_TT.Size = new System.Drawing.Size(15, 16);
            this.lbTongHD_TT.TabIndex = 12;
            this.lbTongHD_TT.Text = "0";
            // 
            // lable9
            // 
            this.lable9.AutoSize = true;
            this.lable9.Location = new System.Drawing.Point(149, 31);
            this.lable9.Name = "lable9";
            this.lable9.Size = new System.Drawing.Size(62, 16);
            this.lable9.TabIndex = 13;
            this.lable9.Text = "Tổng SL:";
            // 
            // lbTongSLSP_TT
            // 
            this.lbTongSLSP_TT.AutoSize = true;
            this.lbTongSLSP_TT.Location = new System.Drawing.Point(217, 31);
            this.lbTongSLSP_TT.Name = "lbTongSLSP_TT";
            this.lbTongSLSP_TT.Size = new System.Drawing.Size(15, 16);
            this.lbTongSLSP_TT.TabIndex = 14;
            this.lbTongSLSP_TT.Text = "0";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.btnMove);
            this.groupBox2.Controls.Add(this.lbTongSLSP_TT);
            this.groupBox2.Controls.Add(this.lable9);
            this.groupBox2.Controls.Add(this.lbTongHD_TT);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtConLai_HD_TT);
            this.groupBox2.Controls.Add(this.txtTra_HD_TT);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(602, 61);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Thanh Toán";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(393, 28);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(33, 23);
            this.btnMove.TabIndex = 15;
            this.btnMove.Text = "<<";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(366, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhân Viên GD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khách Hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Hóa Đơn:";
            // 
            // lbID_HD_TT
            // 
            this.lbID_HD_TT.AutoSize = true;
            this.lbID_HD_TT.Location = new System.Drawing.Point(90, 40);
            this.lbID_HD_TT.Name = "lbID_HD_TT";
            this.lbID_HD_TT.Size = new System.Drawing.Size(21, 16);
            this.lbID_HD_TT.TabIndex = 9;
            this.lbID_HD_TT.Text = "ID";
            // 
            // lbID_KH_TT
            // 
            this.lbID_KH_TT.AutoSize = true;
            this.lbID_KH_TT.Location = new System.Drawing.Point(239, 40);
            this.lbID_KH_TT.Name = "lbID_KH_TT";
            this.lbID_KH_TT.Size = new System.Drawing.Size(21, 16);
            this.lbID_KH_TT.TabIndex = 10;
            this.lbID_KH_TT.Text = "ID";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtNv);
            this.groupBox1.Controls.Add(this.lbID_KH_TT);
            this.groupBox1.Controls.Add(this.lbID_HD_TT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 77);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Hóa Đơn";
            // 
            // txtNv
            // 
            this.txtNv.Enabled = false;
            this.txtNv.Location = new System.Drawing.Point(468, 37);
            this.txtNv.Name = "txtNv";
            this.txtNv.Size = new System.Drawing.Size(128, 22);
            this.txtNv.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::QLVTNN.Properties.Resources.back;
            this.btnBack.Location = new System.Drawing.Point(6, 84);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 58);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Trở Về";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btnThanhToan_TT);
            this.groupBox3.Controls.Add(this.btnBack);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(622, 14);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(95, 145);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chức năng";
            // 
            // frmThanhToan
            // 
            this.AcceptButton = this.btnThanhToan_TT;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 170);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh Toán";
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnThanhToan_TT;
        private System.Windows.Forms.TextBox txtTra_HD_TT;
        private System.Windows.Forms.TextBox txtConLai_HD_TT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTongHD_TT;
        private System.Windows.Forms.Label lable9;
        private System.Windows.Forms.Label lbTongSLSP_TT;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbID_HD_TT;
        private System.Windows.Forms.Label lbID_KH_TT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtNv;
        private System.Windows.Forms.Button btnMove;
    }
}
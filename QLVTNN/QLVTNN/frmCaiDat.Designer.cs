
namespace QLVTNN
{
    partial class frmCaiDat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCaiDat));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grTTTK = new System.Windows.Forms.GroupBox();
            this.txtPassXacNhan = new System.Windows.Forms.TextBox();
            this.lbXacNhanMK = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.lbMK = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lbTK = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgAccount = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.grTTTK.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.tabControl1.Location = new System.Drawing.Point(17, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(683, 494);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.grTTTK);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(675, 462);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tài Khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.btnBack);
            this.groupBox2.Controls.Add(this.btnRefresh);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.groupBox2.Location = new System.Drawing.Point(8, 160);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(657, 98);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức năng";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.btnEdit.Image = global::QLVTNN.Properties.Resources.edit_button;
            this.btnEdit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnEdit.Location = new System.Drawing.Point(8, 20);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 71);
            this.btnEdit.TabIndex = 23;
            this.btnEdit.Text = "Đổi Pass";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.btnBack.Image = global::QLVTNN.Properties.Resources.exit;
            this.btnBack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBack.Location = new System.Drawing.Point(242, 20);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 71);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Đóng";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.btnRefresh.Image = global::QLVTNN.Properties.Resources.refresh_page_option;
            this.btnRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRefresh.Location = new System.Drawing.Point(115, 20);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(119, 71);
            this.btnRefresh.TabIndex = 19;
            this.btnRefresh.Text = "Refresh Pass";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // grTTTK
            // 
            this.grTTTK.BackColor = System.Drawing.Color.White;
            this.grTTTK.Controls.Add(this.txtPassXacNhan);
            this.grTTTK.Controls.Add(this.lbXacNhanMK);
            this.grTTTK.Controls.Add(this.txtPass);
            this.grTTTK.Controls.Add(this.lbMK);
            this.grTTTK.Controls.Add(this.txtUser);
            this.grTTTK.Controls.Add(this.lbTK);
            this.grTTTK.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grTTTK.Location = new System.Drawing.Point(8, 7);
            this.grTTTK.Margin = new System.Windows.Forms.Padding(4);
            this.grTTTK.Name = "grTTTK";
            this.grTTTK.Padding = new System.Windows.Forms.Padding(4);
            this.grTTTK.Size = new System.Drawing.Size(657, 122);
            this.grTTTK.TabIndex = 3;
            this.grTTTK.TabStop = false;
            this.grTTTK.Text = "Thông tin Tài Khoản";
            // 
            // txtPassXacNhan
            // 
            this.txtPassXacNhan.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.txtPassXacNhan.Location = new System.Drawing.Point(447, 81);
            this.txtPassXacNhan.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassXacNhan.Name = "txtPassXacNhan";
            this.txtPassXacNhan.Size = new System.Drawing.Size(180, 26);
            this.txtPassXacNhan.TabIndex = 5;
            this.txtPassXacNhan.UseSystemPasswordChar = true;
            // 
            // lbXacNhanMK
            // 
            this.lbXacNhanMK.AutoSize = true;
            this.lbXacNhanMK.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.lbXacNhanMK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbXacNhanMK.Location = new System.Drawing.Point(279, 85);
            this.lbXacNhanMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbXacNhanMK.Name = "lbXacNhanMK";
            this.lbXacNhanMK.Size = new System.Drawing.Size(161, 19);
            this.lbXacNhanMK.TabIndex = 4;
            this.lbXacNhanMK.Text = "Xác Nhận Mật Khẩu:";
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.txtPass.Location = new System.Drawing.Point(447, 36);
            this.txtPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(180, 26);
            this.txtPass.TabIndex = 3;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // lbMK
            // 
            this.lbMK.AutoSize = true;
            this.lbMK.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.lbMK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbMK.Location = new System.Drawing.Point(279, 43);
            this.lbMK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMK.Name = "lbMK";
            this.lbMK.Size = new System.Drawing.Size(86, 19);
            this.lbMK.TabIndex = 2;
            this.lbMK.Text = "Mật Khẩu:";
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.txtUser.Location = new System.Drawing.Point(116, 39);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(143, 26);
            this.txtUser.TabIndex = 1;
            // 
            // lbTK
            // 
            this.lbTK.AutoSize = true;
            this.lbTK.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.lbTK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTK.Location = new System.Drawing.Point(24, 43);
            this.lbTK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTK.Name = "lbTK";
            this.lbTK.Size = new System.Drawing.Size(89, 19);
            this.lbTK.TabIndex = 0;
            this.lbTK.Text = "Tài Khoản:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.dgAccount);
            this.groupBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.groupBox3.Location = new System.Drawing.Point(8, 266);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(657, 175);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tài Khoản";
            // 
            // dgAccount
            // 
            this.dgAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAccount.Location = new System.Drawing.Point(11, 23);
            this.dgAccount.Margin = new System.Windows.Forms.Padding(4);
            this.dgAccount.Name = "dgAccount";
            this.dgAccount.RowHeadersWidth = 51;
            this.dgAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAccount.Size = new System.Drawing.Size(639, 144);
            this.dgAccount.TabIndex = 0;
            this.dgAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAccount_CellClick);
            // 
            // frmCaiDat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 513);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCaiDat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cài Đặt";
            this.Load += new System.EventHandler(this.frmCaiDat_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.grTTTK.ResumeLayout(false);
            this.grTTTK.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox grTTTK;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lbTK;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgAccount;
        private System.Windows.Forms.TextBox txtPassXacNhan;
        private System.Windows.Forms.Label lbXacNhanMK;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label lbMK;
        private System.Windows.Forms.Button btnEdit;
    }
}
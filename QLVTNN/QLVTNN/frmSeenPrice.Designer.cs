
namespace QLVTNN
{
    partial class frmSeenPrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeenPrice));
            this.grTim = new System.Windows.Forms.GroupBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.lblNhap = new System.Windows.Forms.Label();
            this.grHangHoa = new System.Windows.Forms.GroupBox();
            this.dgDs = new System.Windows.Forms.DataGridView();
            this.grChucnang = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtTaoMoi = new System.Windows.Forms.Button();
            this.grTim.SuspendLayout();
            this.grHangHoa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDs)).BeginInit();
            this.grChucnang.SuspendLayout();
            this.SuspendLayout();
            // 
            // grTim
            // 
            this.grTim.BackColor = System.Drawing.Color.White;
            this.grTim.Controls.Add(this.txtFind);
            this.grTim.Controls.Add(this.lblNhap);
            this.grTim.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grTim.Location = new System.Drawing.Point(16, 15);
            this.grTim.Margin = new System.Windows.Forms.Padding(4);
            this.grTim.Name = "grTim";
            this.grTim.Padding = new System.Windows.Forms.Padding(4);
            this.grTim.Size = new System.Drawing.Size(475, 106);
            this.grTim.TabIndex = 3;
            this.grTim.TabStop = false;
            this.grTim.Text = "Tìm Hàng Hóa";
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(188, 41);
            this.txtFind.Margin = new System.Windows.Forms.Padding(4);
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(224, 26);
            this.txtFind.TabIndex = 1;
            // 
            // lblNhap
            // 
            this.lblNhap.AutoSize = true;
            this.lblNhap.BackColor = System.Drawing.Color.White;
            this.lblNhap.Location = new System.Drawing.Point(12, 44);
            this.lblNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNhap.Name = "lblNhap";
            this.lblNhap.Size = new System.Drawing.Size(154, 19);
            this.lblNhap.TabIndex = 0;
            this.lblNhap.Text = "Nhập Mã hoặc Tên:";
            // 
            // grHangHoa
            // 
            this.grHangHoa.BackColor = System.Drawing.Color.White;
            this.grHangHoa.Controls.Add(this.dgDs);
            this.grHangHoa.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grHangHoa.Location = new System.Drawing.Point(16, 128);
            this.grHangHoa.Margin = new System.Windows.Forms.Padding(4);
            this.grHangHoa.Name = "grHangHoa";
            this.grHangHoa.Padding = new System.Windows.Forms.Padding(4);
            this.grHangHoa.Size = new System.Drawing.Size(815, 209);
            this.grHangHoa.TabIndex = 4;
            this.grHangHoa.TabStop = false;
            this.grHangHoa.Text = "Hàng Hóa";
            // 
            // dgDs
            // 
            this.dgDs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDs.Location = new System.Drawing.Point(9, 25);
            this.dgDs.Margin = new System.Windows.Forms.Padding(4);
            this.dgDs.Name = "dgDs";
            this.dgDs.RowHeadersWidth = 51;
            this.dgDs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDs.Size = new System.Drawing.Size(797, 177);
            this.dgDs.TabIndex = 0;
            // 
            // grChucnang
            // 
            this.grChucnang.BackColor = System.Drawing.Color.White;
            this.grChucnang.Controls.Add(this.btnExit);
            this.grChucnang.Controls.Add(this.btnFind);
            this.grChucnang.Controls.Add(this.txtTaoMoi);
            this.grChucnang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grChucnang.Location = new System.Drawing.Point(499, 15);
            this.grChucnang.Margin = new System.Windows.Forms.Padding(4);
            this.grChucnang.Name = "grChucnang";
            this.grChucnang.Padding = new System.Windows.Forms.Padding(4);
            this.grChucnang.Size = new System.Drawing.Size(332, 106);
            this.grChucnang.TabIndex = 8;
            this.grChucnang.TabStop = false;
            this.grChucnang.Text = "Chức năng";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = global::QLVTNN.Properties.Resources.exit;
            this.btnExit.Location = new System.Drawing.Point(224, 27);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 71);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Đóng";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Image = global::QLVTNN.Properties.Resources.icons8_search_30;
            this.btnFind.Location = new System.Drawing.Point(8, 27);
            this.btnFind.Margin = new System.Windows.Forms.Padding(4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(100, 71);
            this.btnFind.TabIndex = 6;
            this.btnFind.Text = "Xem";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtTaoMoi
            // 
            this.txtTaoMoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.txtTaoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTaoMoi.Image = global::QLVTNN.Properties.Resources.refresh_page_option;
            this.txtTaoMoi.Location = new System.Drawing.Point(116, 27);
            this.txtTaoMoi.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaoMoi.Name = "txtTaoMoi";
            this.txtTaoMoi.Size = new System.Drawing.Size(100, 71);
            this.txtTaoMoi.TabIndex = 7;
            this.txtTaoMoi.Text = "Tạo Mới";
            this.txtTaoMoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.txtTaoMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.txtTaoMoi.UseVisualStyleBackColor = false;
            this.txtTaoMoi.Click += new System.EventHandler(this.txtTaoMoi_Click);
            // 
            // frmSeenPrice
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 352);
            this.Controls.Add(this.grChucnang);
            this.Controls.Add(this.grTim);
            this.Controls.Add(this.grHangHoa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSeenPrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem giá hàng hóa";
            this.Load += new System.EventHandler(this.frmSeenPrice_Load);
            this.grTim.ResumeLayout(false);
            this.grTim.PerformLayout();
            this.grHangHoa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDs)).EndInit();
            this.grChucnang.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grTim;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtFind;
        private System.Windows.Forms.Label lblNhap;
        private System.Windows.Forms.GroupBox grHangHoa;
        private System.Windows.Forms.DataGridView dgDs;
        private System.Windows.Forms.Button txtTaoMoi;
        private System.Windows.Forms.GroupBox grChucnang;
        private System.Windows.Forms.Button btnExit;
    }
}
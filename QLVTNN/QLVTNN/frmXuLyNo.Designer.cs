
namespace QLVTNN
{
    partial class frmXuLyNo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuLyNo));
            this.grTTKH = new System.Windows.Forms.GroupBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.lbslHD = new System.Windows.Forms.Label();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.txtTra = new System.Windows.Forms.TextBox();
            this.lbConlai = new System.Windows.Forms.Label();
            this.lbTra = new System.Windows.Forms.Label();
            this.lbNO = new System.Windows.Forms.Label();
            this.cbb_IDKH = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.grChucNang = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.grDS = new System.Windows.Forms.GroupBox();
            this.dgDsHD = new System.Windows.Forms.DataGridView();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.grTTKH.SuspendLayout();
            this.grChucNang.SuspendLayout();
            this.grDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDsHD)).BeginInit();
            this.SuspendLayout();
            // 
            // grTTKH
            // 
            this.grTTKH.BackColor = System.Drawing.Color.White;
            this.grTTKH.Controls.Add(this.btnMove);
            this.grTTKH.Controls.Add(this.lbslHD);
            this.grTTKH.Controls.Add(this.txtConLai);
            this.grTTKH.Controls.Add(this.txtTra);
            this.grTTKH.Controls.Add(this.lbConlai);
            this.grTTKH.Controls.Add(this.lbTra);
            this.grTTKH.Controls.Add(this.lbNO);
            this.grTTKH.Controls.Add(this.cbb_IDKH);
            this.grTTKH.Controls.Add(this.lbName);
            this.grTTKH.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grTTKH.Location = new System.Drawing.Point(17, 16);
            this.grTTKH.Margin = new System.Windows.Forms.Padding(4);
            this.grTTKH.Name = "grTTKH";
            this.grTTKH.Padding = new System.Windows.Forms.Padding(4);
            this.grTTKH.Size = new System.Drawing.Size(625, 117);
            this.grTTKH.TabIndex = 0;
            this.grTTKH.TabStop = false;
            this.grTTKH.Text = "Thông tin Khách Hàng";
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(279, 69);
            this.btnMove.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(43, 31);
            this.btnMove.TabIndex = 8;
            this.btnMove.Text = "<<";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // lbslHD
            // 
            this.lbslHD.AutoSize = true;
            this.lbslHD.Location = new System.Drawing.Point(323, 32);
            this.lbslHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbslHD.Name = "lbslHD";
            this.lbslHD.Size = new System.Drawing.Size(94, 19);
            this.lbslHD.TabIndex = 7;
            this.lbslHD.Text = "Hóa đơn: 0";
            // 
            // txtConLai
            // 
            this.txtConLai.Enabled = false;
            this.txtConLai.Location = new System.Drawing.Point(404, 71);
            this.txtConLai.Margin = new System.Windows.Forms.Padding(4);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.Size = new System.Drawing.Size(191, 26);
            this.txtConLai.TabIndex = 6;
            // 
            // txtTra
            // 
            this.txtTra.Location = new System.Drawing.Point(79, 71);
            this.txtTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtTra.Name = "txtTra";
            this.txtTra.Size = new System.Drawing.Size(191, 26);
            this.txtTra.TabIndex = 5;
            this.txtTra.TextChanged += new System.EventHandler(this.txtTra_TextChanged);
            this.txtTra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTra_KeyPress);
            // 
            // lbConlai
            // 
            this.lbConlai.AutoSize = true;
            this.lbConlai.Location = new System.Drawing.Point(329, 75);
            this.lbConlai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConlai.Name = "lbConlai";
            this.lbConlai.Size = new System.Drawing.Size(71, 19);
            this.lbConlai.TabIndex = 4;
            this.lbConlai.Text = "Còn Lại:";
            // 
            // lbTra
            // 
            this.lbTra.AutoSize = true;
            this.lbTra.Location = new System.Drawing.Point(8, 75);
            this.lbTra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTra.Name = "lbTra";
            this.lbTra.Size = new System.Drawing.Size(40, 19);
            this.lbTra.TabIndex = 3;
            this.lbTra.Text = "Trả:";
            // 
            // lbNO
            // 
            this.lbNO.AutoSize = true;
            this.lbNO.Location = new System.Drawing.Point(472, 32);
            this.lbNO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNO.Name = "lbNO";
            this.lbNO.Size = new System.Drawing.Size(37, 19);
            this.lbNO.TabIndex = 2;
            this.lbNO.Text = "Nợ:";
            // 
            // cbb_IDKH
            // 
            this.cbb_IDKH.FormattingEnabled = true;
            this.cbb_IDKH.Location = new System.Drawing.Point(79, 28);
            this.cbb_IDKH.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_IDKH.Name = "cbb_IDKH";
            this.cbb_IDKH.Size = new System.Drawing.Size(191, 27);
            this.cbb_IDKH.TabIndex = 1;
            this.cbb_IDKH.SelectedIndexChanged += new System.EventHandler(this.cbb_IDKH_SelectedIndexChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(8, 32);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(69, 19);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tên KH:";
            // 
            // grChucNang
            // 
            this.grChucNang.BackColor = System.Drawing.Color.White;
            this.grChucNang.Controls.Add(this.btnBack);
            this.grChucNang.Controls.Add(this.btnPay);
            this.grChucNang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grChucNang.Location = new System.Drawing.Point(651, 15);
            this.grChucNang.Margin = new System.Windows.Forms.Padding(4);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Padding = new System.Windows.Forms.Padding(4);
            this.grChucNang.Size = new System.Drawing.Size(437, 117);
            this.grChucNang.TabIndex = 1;
            this.grChucNang.TabStop = false;
            this.grChucNang.Text = "Chức năng";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Image = global::QLVTNN.Properties.Resources.close;
            this.btnBack.Location = new System.Drawing.Point(128, 32);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 71);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "Trở Về";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Image = global::QLVTNN.Properties.Resources.payment;
            this.btnPay.Location = new System.Drawing.Point(8, 32);
            this.btnPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(112, 71);
            this.btnPay.TabIndex = 10;
            this.btnPay.Text = "Thanh Toán";
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // grDS
            // 
            this.grDS.Controls.Add(this.dgDsHD);
            this.grDS.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grDS.Location = new System.Drawing.Point(16, 140);
            this.grDS.Margin = new System.Windows.Forms.Padding(4);
            this.grDS.Name = "grDS";
            this.grDS.Padding = new System.Windows.Forms.Padding(4);
            this.grDS.Size = new System.Drawing.Size(1072, 229);
            this.grDS.TabIndex = 2;
            this.grDS.TabStop = false;
            this.grDS.Text = "Danh sách hóa đơn";
            // 
            // dgDsHD
            // 
            this.dgDsHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDsHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDsHD.Location = new System.Drawing.Point(9, 25);
            this.dgDsHD.Margin = new System.Windows.Forms.Padding(4);
            this.dgDsHD.Name = "dgDsHD";
            this.dgDsHD.RowHeadersWidth = 51;
            this.dgDsHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDsHD.Size = new System.Drawing.Size(1055, 192);
            this.dgDsHD.TabIndex = 0;
            this.dgDsHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDsHD_CellClick);
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
            // frmXuLyNo
            // 
            this.AcceptButton = this.btnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 380);
            this.Controls.Add(this.grDS);
            this.Controls.Add(this.grChucNang);
            this.Controls.Add(this.grTTKH);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmXuLyNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xử Lý Nợ Khách Hàng";
            this.Load += new System.EventHandler(this.frmXuLyNo_Load);
            this.grTTKH.ResumeLayout(false);
            this.grTTKH.PerformLayout();
            this.grChucNang.ResumeLayout(false);
            this.grDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDsHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grTTKH;
        private System.Windows.Forms.TextBox txtConLai;
        private System.Windows.Forms.TextBox txtTra;
        private System.Windows.Forms.Label lbConlai;
        private System.Windows.Forms.Label lbTra;
        private System.Windows.Forms.Label lbNO;
        private System.Windows.Forms.ComboBox cbb_IDKH;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox grChucNang;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grDS;
        private System.Windows.Forms.DataGridView dgDsHD;
        private System.Windows.Forms.Label lbslHD;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

namespace QLVTNN
{
    partial class frmBaoCaoBan
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBaoCaoBan));
            this.uSPBaoCaoNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHDNDataSet1 = new QLVTNN.QLCHDNDataSet1();
            this.uSPHoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHDNDataSet2 = new QLVTNN.QLCHDNDataSet2();
            this.uSPHoaDonChiTietBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLCHDNDataSet3 = new QLVTNN.QLCHDNDataSet3();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reportViewer3 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtEndtt = new System.Windows.Forms.DateTimePicker();
            this.btnBaoCaoTT = new System.Windows.Forms.Button();
            this.dtStarttt = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.uSP_BaoCaoNgayTableAdapter = new QLVTNN.QLCHDNDataSet1TableAdapters.USP_BaoCaoNgayTableAdapter();
            this.uSP_HoaDonTableAdapter = new QLVTNN.QLCHDNDataSet2TableAdapters.USP_HoaDonTableAdapter();
            this.uSP_HoaDonChiTietTableAdapter = new QLVTNN.QLCHDNDataSet3TableAdapters.USP_HoaDonChiTietTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.uSPBaoCaoNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDNDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPHoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDNDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPHoaDonChiTietBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDNDataSet3)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uSPBaoCaoNgayBindingSource
            // 
            this.uSPBaoCaoNgayBindingSource.DataMember = "USP_BaoCaoNgay";
            this.uSPBaoCaoNgayBindingSource.DataSource = this.qLCHDNDataSet1;
            // 
            // qLCHDNDataSet1
            // 
            this.qLCHDNDataSet1.DataSetName = "QLCHDNDataSet1";
            this.qLCHDNDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPHoaDonBindingSource
            // 
            this.uSPHoaDonBindingSource.DataMember = "USP_HoaDon";
            this.uSPHoaDonBindingSource.DataSource = this.qLCHDNDataSet2;
            // 
            // qLCHDNDataSet2
            // 
            this.qLCHDNDataSet2.DataSetName = "QLCHDNDataSet2";
            this.qLCHDNDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uSPHoaDonChiTietBindingSource
            // 
            this.uSPHoaDonChiTietBindingSource.DataMember = "USP_HoaDonChiTiet";
            this.uSPHoaDonChiTietBindingSource.DataSource = this.qLCHDNDataSet3;
            // 
            // qLCHDNDataSet3
            // 
            this.qLCHDNDataSet3.DataSetName = "QLCHDNDataSet3";
            this.qLCHDNDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.tabControl1.Location = new System.Drawing.Point(17, 16);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(952, 576);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(944, 544);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Báo Cáo Ngày";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.uSPBaoCaoNgayBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "QLVTNN.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(4, 4);
            this.reportViewer3.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(936, 536);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(944, 544);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Báo Cáo Bán Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.btnBaoCao);
            this.groupBox1.Controls.Add(this.dtStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(929, 84);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn ngày báo cáo";
            // 
            // dtEnd
            // 
            this.dtEnd.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(517, 34);
            this.dtEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(137, 26);
            this.dtEnd.TabIndex = 5;
            this.toolTip1.SetToolTip(this.dtEnd, "Ngày kết thúc");
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaoCao.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaoCao.Location = new System.Drawing.Point(664, 26);
            this.btnBaoCao.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(100, 46);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "Báo Cáo";
            this.toolTip1.SetToolTip(this.btnBaoCao, "Xem báo cáo ");
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click_1);
            // 
            // dtStart
            // 
            this.dtStart.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(272, 34);
            this.dtStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(137, 26);
            this.dtStart.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dtStart, "Ngày bắt đầu");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(419, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.SystemColors.Control;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.uSPHoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLVTNN.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(5, 99);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(930, 441);
            this.reportViewer1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(944, 544);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Báo Cáo Chi Tiết Bán Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.dtEndtt);
            this.groupBox2.Controls.Add(this.btnBaoCaoTT);
            this.groupBox2.Controls.Add(this.dtStarttt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(7, 7);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(929, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn ngày báo cáo chi tiết";
            // 
            // dtEndtt
            // 
            this.dtEndtt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndtt.Location = new System.Drawing.Point(517, 34);
            this.dtEndtt.Margin = new System.Windows.Forms.Padding(4);
            this.dtEndtt.Name = "dtEndtt";
            this.dtEndtt.Size = new System.Drawing.Size(137, 26);
            this.dtEndtt.TabIndex = 5;
            this.toolTip1.SetToolTip(this.dtEndtt, "Ngày kết thúc");
            // 
            // btnBaoCaoTT
            // 
            this.btnBaoCaoTT.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBaoCaoTT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaoCaoTT.Location = new System.Drawing.Point(664, 26);
            this.btnBaoCaoTT.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaoCaoTT.Name = "btnBaoCaoTT";
            this.btnBaoCaoTT.Size = new System.Drawing.Size(100, 46);
            this.btnBaoCaoTT.TabIndex = 4;
            this.btnBaoCaoTT.Text = "Báo Cáo";
            this.toolTip1.SetToolTip(this.btnBaoCaoTT, "Xem báo cáo");
            this.btnBaoCaoTT.UseVisualStyleBackColor = false;
            this.btnBaoCaoTT.Click += new System.EventHandler(this.btnBaoCaoTT_Click);
            // 
            // dtStarttt
            // 
            this.dtStarttt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStarttt.Location = new System.Drawing.Point(272, 34);
            this.dtStarttt.Margin = new System.Windows.Forms.Padding(4);
            this.dtStarttt.Name = "dtStarttt";
            this.dtStarttt.Size = new System.Drawing.Size(137, 26);
            this.dtStarttt.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dtStarttt, "Ngày bắt đầu");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Từ ngày:";
            // 
            // reportViewer2
            // 
            this.reportViewer2.BackColor = System.Drawing.SystemColors.Control;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.uSPHoaDonChiTietBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QLVTNN.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(5, 98);
            this.reportViewer2.Margin = new System.Windows.Forms.Padding(4);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(930, 453);
            this.reportViewer2.TabIndex = 4;
            // 
            // uSP_BaoCaoNgayTableAdapter
            // 
            this.uSP_BaoCaoNgayTableAdapter.ClearBeforeFill = true;
            // 
            // uSP_HoaDonTableAdapter
            // 
            this.uSP_HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // uSP_HoaDonChiTietTableAdapter
            // 
            this.uSP_HoaDonChiTietTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 596);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBaoCaoBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Bán Hàng";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uSPBaoCaoNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDNDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPHoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDNDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uSPHoaDonChiTietBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLCHDNDataSet3)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBaoCaoTT;
        private System.Windows.Forms.DateTimePicker dtStarttt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtEndtt;
        private System.Windows.Forms.ToolTip toolTip1;
        private QLCHDNDataSet1 qLCHDNDataSet1;
        private System.Windows.Forms.BindingSource uSPBaoCaoNgayBindingSource;
        private QLCHDNDataSet1TableAdapters.USP_BaoCaoNgayTableAdapter uSP_BaoCaoNgayTableAdapter;
        private System.Windows.Forms.BindingSource uSPHoaDonBindingSource;
        private QLCHDNDataSet2 qLCHDNDataSet2;
        private QLCHDNDataSet2TableAdapters.USP_HoaDonTableAdapter uSP_HoaDonTableAdapter;
        private System.Windows.Forms.BindingSource uSPHoaDonChiTietBindingSource;
        private QLCHDNDataSet3 qLCHDNDataSet3;
        private QLCHDNDataSet3TableAdapters.USP_HoaDonChiTietTableAdapter uSP_HoaDonChiTietTableAdapter;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
    }
}
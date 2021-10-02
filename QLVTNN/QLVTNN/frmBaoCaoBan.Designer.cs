
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
            this.USP_BaoCaoNgayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLVLXDDataSet3 = new QLVTNN.QLVLXDDataSet3();
            this.USP_HoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLVLXDDataSet = new QLVTNN.QLVLXDDataSet();
            this.USP_HoaDonChiTietBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLVLXDDataSet1 = new QLVTNN.QLVLXDDataSet1();
            this.USP_HoaDonTableAdapter = new QLVTNN.QLVLXDDataSetTableAdapters.USP_HoaDonTableAdapter();
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
            this.USP_HoaDonChiTietTableAdapter = new QLVTNN.QLVLXDDataSet1TableAdapters.USP_HoaDonChiTietTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.USP_BaoCaoNgayTableAdapter = new QLVTNN.QLVLXDDataSet3TableAdapters.USP_BaoCaoNgayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.USP_BaoCaoNgayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLVLXDDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_HoaDonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLVLXDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_HoaDonChiTietBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLVLXDDataSet1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // USP_BaoCaoNgayBindingSource
            // 
            this.USP_BaoCaoNgayBindingSource.DataMember = "USP_BaoCaoNgay";
            this.USP_BaoCaoNgayBindingSource.DataSource = this.QLVLXDDataSet3;
            // 
            // QLVLXDDataSet3
            // 
            this.QLVLXDDataSet3.DataSetName = "QLVLXDDataSet3";
            this.QLVLXDDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_HoaDonBindingSource
            // 
            this.USP_HoaDonBindingSource.DataMember = "USP_HoaDon";
            this.USP_HoaDonBindingSource.DataSource = this.QLVLXDDataSet;
            // 
            // QLVLXDDataSet
            // 
            this.QLVLXDDataSet.DataSetName = "QLVLXDDataSet";
            this.QLVLXDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_HoaDonChiTietBindingSource
            // 
            this.USP_HoaDonChiTietBindingSource.DataMember = "USP_HoaDonChiTiet";
            this.USP_HoaDonChiTietBindingSource.DataSource = this.QLVLXDDataSet1;
            // 
            // QLVLXDDataSet1
            // 
            this.QLVLXDDataSet1.DataSetName = "QLVLXDDataSet1";
            this.QLVLXDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_HoaDonTableAdapter
            // 
            this.USP_HoaDonTableAdapter.ClearBeforeFill = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(714, 468);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reportViewer3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(706, 440);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Báo Cáo Ngày";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reportViewer3
            // 
            this.reportViewer3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_BaoCaoNgayBindingSource;
            this.reportViewer3.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer3.LocalReport.ReportEmbeddedResource = "QLVTNN.Report3.rdlc";
            this.reportViewer3.Location = new System.Drawing.Point(6, 6);
            this.reportViewer3.Name = "reportViewer3";
            this.reportViewer3.ServerReport.BearerToken = null;
            this.reportViewer3.Size = new System.Drawing.Size(694, 428);
            this.reportViewer3.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.reportViewer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(706, 440);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Báo Cáo Bán Hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.dtEnd);
            this.groupBox1.Controls.Add(this.btnBaoCao);
            this.groupBox1.Controls.Add(this.dtStart);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 68);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn ngày báo cáo";
            // 
            // dtEnd
            // 
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEnd.Location = new System.Drawing.Point(388, 28);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(104, 25);
            this.dtEnd.TabIndex = 5;
            this.toolTip1.SetToolTip(this.dtEnd, "Ngày kết thúc");
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaoCao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaoCao.Location = new System.Drawing.Point(498, 21);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(75, 37);
            this.btnBaoCao.TabIndex = 4;
            this.btnBaoCao.Text = "Báo Cáo";
            this.toolTip1.SetToolTip(this.btnBaoCao, "Xem báo cáo ");
            this.btnBaoCao.UseVisualStyleBackColor = false;
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click_1);
            // 
            // dtStart
            // 
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStart.Location = new System.Drawing.Point(204, 28);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(104, 25);
            this.dtStart.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dtStart, "Ngày bắt đầu");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(314, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đến ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Từ ngày:";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.BackColor = System.Drawing.SystemColors.Control;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.USP_HoaDonBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLVTNN.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(4, 80);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(698, 356);
            this.reportViewer1.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(706, 440);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Báo Cáo Chi Tiết Bán Hàng";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.dtEndtt);
            this.groupBox2.Controls.Add(this.btnBaoCaoTT);
            this.groupBox2.Controls.Add(this.dtStarttt);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(697, 68);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chọn ngày báo cáo chi tiết";
            // 
            // dtEndtt
            // 
            this.dtEndtt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtEndtt.Location = new System.Drawing.Point(388, 28);
            this.dtEndtt.Name = "dtEndtt";
            this.dtEndtt.Size = new System.Drawing.Size(104, 25);
            this.dtEndtt.TabIndex = 5;
            this.toolTip1.SetToolTip(this.dtEndtt, "Ngày kết thúc");
            // 
            // btnBaoCaoTT
            // 
            this.btnBaoCaoTT.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBaoCaoTT.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBaoCaoTT.Location = new System.Drawing.Point(498, 21);
            this.btnBaoCaoTT.Name = "btnBaoCaoTT";
            this.btnBaoCaoTT.Size = new System.Drawing.Size(75, 37);
            this.btnBaoCaoTT.TabIndex = 4;
            this.btnBaoCaoTT.Text = "Báo Cáo";
            this.toolTip1.SetToolTip(this.btnBaoCaoTT, "Xem báo cáo");
            this.btnBaoCaoTT.UseVisualStyleBackColor = false;
            this.btnBaoCaoTT.Click += new System.EventHandler(this.btnBaoCaoTT_Click);
            // 
            // dtStarttt
            // 
            this.dtStarttt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtStarttt.Location = new System.Drawing.Point(204, 28);
            this.dtStarttt.Name = "dtStarttt";
            this.dtStarttt.Size = new System.Drawing.Size(104, 25);
            this.dtStarttt.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dtStarttt, "Ngày bắt đầu");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Đến ngày:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Từ ngày:";
            // 
            // reportViewer2
            // 
            this.reportViewer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer2.BackColor = System.Drawing.SystemColors.Control;
            reportDataSource3.Name = "DataSet1";
            reportDataSource3.Value = this.USP_HoaDonChiTietBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "QLVTNN.Report2.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(4, 80);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(698, 356);
            this.reportViewer2.TabIndex = 4;
            // 
            // USP_HoaDonChiTietTableAdapter
            // 
            this.USP_HoaDonChiTietTableAdapter.ClearBeforeFill = true;
            // 
            // USP_BaoCaoNgayTableAdapter
            // 
            this.USP_BaoCaoNgayTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 484);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBaoCaoBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Bán Hàng";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.USP_BaoCaoNgayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLVLXDDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_HoaDonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLVLXDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_HoaDonChiTietBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLVLXDDataSet1)).EndInit();
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
        private System.Windows.Forms.BindingSource USP_HoaDonBindingSource;
        private QLVLXDDataSet QLVLXDDataSet;
        private QLVLXDDataSetTableAdapters.USP_HoaDonTableAdapter USP_HoaDonTableAdapter;
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
        private System.Windows.Forms.BindingSource USP_HoaDonChiTietBindingSource;
        private QLVLXDDataSet1 QLVLXDDataSet1;
        private QLVLXDDataSet1TableAdapters.USP_HoaDonChiTietTableAdapter USP_HoaDonChiTietTableAdapter;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtEndtt;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPage3;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer3;
        private System.Windows.Forms.BindingSource USP_BaoCaoNgayBindingSource;
        private QLVLXDDataSet3 QLVLXDDataSet3;
        private QLVLXDDataSet3TableAdapters.USP_BaoCaoNgayTableAdapter USP_BaoCaoNgayTableAdapter;
    }
}
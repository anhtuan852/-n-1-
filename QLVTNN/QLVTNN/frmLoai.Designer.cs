
namespace QLVTNN
{
    partial class frmLoai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoai));
            this.grTTLoai = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.grChucNang = new System.Windows.Forms.GroupBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTaoMoi = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grDS = new System.Windows.Forms.GroupBox();
            this.dgDs = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grTTLoai.SuspendLayout();
            this.grChucNang.SuspendLayout();
            this.grDS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDs)).BeginInit();
            this.SuspendLayout();
            // 
            // grTTLoai
            // 
            this.grTTLoai.BackColor = System.Drawing.Color.White;
            this.grTTLoai.Controls.Add(this.txtName);
            this.grTTLoai.Controls.Add(this.lbName);
            this.grTTLoai.Controls.Add(this.lbId);
            this.grTTLoai.Controls.Add(this.txtID);
            this.grTTLoai.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grTTLoai.Location = new System.Drawing.Point(17, 16);
            this.grTTLoai.Margin = new System.Windows.Forms.Padding(4);
            this.grTTLoai.Name = "grTTLoai";
            this.grTTLoai.Padding = new System.Windows.Forms.Padding(4);
            this.grTTLoai.Size = new System.Drawing.Size(584, 96);
            this.grTTLoai.TabIndex = 0;
            this.grTTLoai.TabStop = false;
            this.grTTLoai.Text = "Thông tin loại";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(384, 32);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(187, 26);
            this.txtName.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(291, 36);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(78, 19);
            this.lbName.TabIndex = 2;
            this.lbName.Text = "Tên Loại:";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(8, 36);
            this.lbId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(73, 19);
            this.lbId.TabIndex = 1;
            this.lbId.Text = "Mã Loại:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(95, 32);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(187, 26);
            this.txtID.TabIndex = 0;
            // 
            // grChucNang
            // 
            this.grChucNang.BackColor = System.Drawing.Color.White;
            this.grChucNang.Controls.Add(this.btnBack);
            this.grChucNang.Controls.Add(this.btnTaoMoi);
            this.grChucNang.Controls.Add(this.btnDelete);
            this.grChucNang.Controls.Add(this.btnEdit);
            this.grChucNang.Controls.Add(this.btnAdd);
            this.grChucNang.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grChucNang.Location = new System.Drawing.Point(16, 119);
            this.grChucNang.Margin = new System.Windows.Forms.Padding(4);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Padding = new System.Windows.Forms.Padding(4);
            this.grChucNang.Size = new System.Drawing.Size(585, 95);
            this.grChucNang.TabIndex = 1;
            this.grChucNang.TabStop = false;
            this.grChucNang.Text = "Chức năng";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Image = global::QLVTNN.Properties.Resources.close;
            this.btnBack.Location = new System.Drawing.Point(385, 26);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(85, 60);
            this.btnBack.TabIndex = 15;
            this.btnBack.Text = "Trở Lại";
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
            this.btnTaoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoMoi.Image = global::QLVTNN.Properties.Resources.refresh_page_option;
            this.btnTaoMoi.Location = new System.Drawing.Point(292, 27);
            this.btnTaoMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoMoi.Name = "btnTaoMoi";
            this.btnTaoMoi.Size = new System.Drawing.Size(85, 60);
            this.btnTaoMoi.TabIndex = 14;
            this.btnTaoMoi.Text = "Tạo Mới";
            this.btnTaoMoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTaoMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnTaoMoi, "Tạo mới thông tin loại");
            this.btnTaoMoi.UseVisualStyleBackColor = false;
            this.btnTaoMoi.Click += new System.EventHandler(this.btnTaoMoi_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::QLVTNN.Properties.Resources.trash;
            this.btnDelete.Location = new System.Drawing.Point(199, 27);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(85, 60);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnDelete, "Xóa loại");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Image = global::QLVTNN.Properties.Resources.edit_button;
            this.btnEdit.Location = new System.Drawing.Point(101, 27);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(85, 60);
            this.btnEdit.TabIndex = 12;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnEdit, "Sửa thông tin loại");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::QLVTNN.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(8, 27);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(85, 60);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolTip1.SetToolTip(this.btnAdd, "Thêm loại");
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grDS
            // 
            this.grDS.BackColor = System.Drawing.Color.White;
            this.grDS.Controls.Add(this.dgDs);
            this.grDS.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F);
            this.grDS.Location = new System.Drawing.Point(16, 222);
            this.grDS.Margin = new System.Windows.Forms.Padding(4);
            this.grDS.Name = "grDS";
            this.grDS.Padding = new System.Windows.Forms.Padding(4);
            this.grDS.Size = new System.Drawing.Size(585, 207);
            this.grDS.TabIndex = 2;
            this.grDS.TabStop = false;
            this.grDS.Text = "Danh sách loại";
            // 
            // dgDs
            // 
            this.dgDs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDs.Location = new System.Drawing.Point(9, 27);
            this.dgDs.Margin = new System.Windows.Forms.Padding(4);
            this.dgDs.Name = "dgDs";
            this.dgDs.RowHeadersWidth = 51;
            this.dgDs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDs.Size = new System.Drawing.Size(564, 172);
            this.dgDs.TabIndex = 0;
            this.dgDs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDs_CellClick);
            // 
            // frmLoai
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 443);
            this.Controls.Add(this.grDS);
            this.Controls.Add(this.grChucNang);
            this.Controls.Add(this.grTTLoai);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại Hàng Hóa";
            this.Load += new System.EventHandler(this.frmLoai_Load);
            this.grTTLoai.ResumeLayout(false);
            this.grTTLoai.PerformLayout();
            this.grChucNang.ResumeLayout(false);
            this.grDS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grTTLoai;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox grChucNang;
        private System.Windows.Forms.GroupBox grDS;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTaoMoi;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridView dgDs;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
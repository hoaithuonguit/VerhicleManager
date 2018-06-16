namespace Desktop
{
    partial class frmNhapHang
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_TenSanPham = new System.Windows.Forms.TextBox();
            this.cbb_Loai = new System.Windows.Forms.ComboBox();
            this.cbb_PhanLoai = new System.Windows.Forms.ComboBox();
            this.cbb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.tb_MoTa = new System.Windows.Forms.TextBox();
            this.tb_Hang = new System.Windows.Forms.TextBox();
            this.tb_SoLuong = new System.Windows.Forms.TextBox();
            this.dtp_NgayNhapHang = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DuLieu = new System.Windows.Forms.DataGridView();
            this.cl_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_PhanLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.strip_Them = new System.Windows.Forms.ToolStripButton();
            this.btn_Xuat = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.tb_TenSanPham);
            this.groupBox1.Controls.Add(this.cbb_Loai);
            this.groupBox1.Controls.Add(this.cbb_PhanLoai);
            this.groupBox1.Controls.Add(this.cbb_TinhTrang);
            this.groupBox1.Controls.Add(this.tb_MoTa);
            this.groupBox1.Controls.Add(this.tb_Hang);
            this.groupBox1.Controls.Add(this.tb_SoLuong);
            this.groupBox1.Controls.Add(this.dtp_NgayNhapHang);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(8, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(467, 577);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập hàng";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tb_TenSanPham
            // 
            this.tb_TenSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_TenSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_TenSanPham.Location = new System.Drawing.Point(195, 78);
            this.tb_TenSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_TenSanPham.Name = "tb_TenSanPham";
            this.tb_TenSanPham.Size = new System.Drawing.Size(235, 30);
            this.tb_TenSanPham.TabIndex = 2;
            // 
            // cbb_Loai
            // 
            this.cbb_Loai.AutoCompleteCustomSource.AddRange(new string[] {
            "Xe nâng",
            "Phụ tùng"});
            this.cbb_Loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Loai.FormattingEnabled = true;
            this.cbb_Loai.Items.AddRange(new object[] {
            "Xe nâng",
            "Phụ tùng"});
            this.cbb_Loai.Location = new System.Drawing.Point(195, 39);
            this.cbb_Loai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_Loai.Name = "cbb_Loai";
            this.cbb_Loai.Size = new System.Drawing.Size(235, 33);
            this.cbb_Loai.TabIndex = 1;
            this.cbb_Loai.SelectedIndexChanged += new System.EventHandler(this.cbb_Loai_SelectedIndexChanged);
            // 
            // cbb_PhanLoai
            // 
            this.cbb_PhanLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbb_PhanLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_PhanLoai.FormattingEnabled = true;
            this.cbb_PhanLoai.Location = new System.Drawing.Point(195, 303);
            this.cbb_PhanLoai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_PhanLoai.Name = "cbb_PhanLoai";
            this.cbb_PhanLoai.Size = new System.Drawing.Size(235, 33);
            this.cbb_PhanLoai.TabIndex = 8;
            this.cbb_PhanLoai.SelectedIndexChanged += new System.EventHandler(this.cbb_PhanLoai_SelectedIndexChanged);
            // 
            // cbb_TinhTrang
            // 
            this.cbb_TinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TinhTrang.FormattingEnabled = true;
            this.cbb_TinhTrang.Location = new System.Drawing.Point(195, 189);
            this.cbb_TinhTrang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbb_TinhTrang.Name = "cbb_TinhTrang";
            this.cbb_TinhTrang.Size = new System.Drawing.Size(235, 33);
            this.cbb_TinhTrang.TabIndex = 5;
            this.cbb_TinhTrang.SelectedIndexChanged += new System.EventHandler(this.cbb_TinhTrang_SelectedIndexChanged);
            // 
            // tb_MoTa
            // 
            this.tb_MoTa.Location = new System.Drawing.Point(195, 265);
            this.tb_MoTa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_MoTa.Name = "tb_MoTa";
            this.tb_MoTa.Size = new System.Drawing.Size(235, 30);
            this.tb_MoTa.TabIndex = 7;
            // 
            // tb_Hang
            // 
            this.tb_Hang.Location = new System.Drawing.Point(195, 227);
            this.tb_Hang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Hang.Name = "tb_Hang";
            this.tb_Hang.Size = new System.Drawing.Size(235, 30);
            this.tb_Hang.TabIndex = 6;
            // 
            // tb_SoLuong
            // 
            this.tb_SoLuong.Location = new System.Drawing.Point(195, 153);
            this.tb_SoLuong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_SoLuong.Name = "tb_SoLuong";
            this.tb_SoLuong.Size = new System.Drawing.Size(235, 30);
            this.tb_SoLuong.TabIndex = 4;
            this.tb_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // dtp_NgayNhapHang
            // 
            this.dtp_NgayNhapHang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayNhapHang.Location = new System.Drawing.Point(195, 116);
            this.dtp_NgayNhapHang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtp_NgayNhapHang.Name = "dtp_NgayNhapHang";
            this.dtp_NgayNhapHang.Size = new System.Drawing.Size(235, 30);
            this.dtp_NgayNhapHang.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(24, 267);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mô tả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(24, 41);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 25);
            this.label8.TabIndex = 9;
            this.label8.Text = "Loại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(24, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hãng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(24, 305);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phân loại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(24, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tình trạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(24, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(24, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(24, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày nhập hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_DuLieu);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(479, 8);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(741, 577);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu nhập hàng";
            // 
            // dgv_DuLieu
            // 
            this.dgv_DuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DuLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_ID,
            this.cl_Loai,
            this.cl_TenSanPham,
            this.cl_SoLuong,
            this.cl_Status,
            this.cl_PhanLoai,
            this.cl_MoTa,
            this.cl_NgayNhap});
            this.dgv_DuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DuLieu.Location = new System.Drawing.Point(2, 56);
            this.dgv_DuLieu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_DuLieu.Name = "dgv_DuLieu";
            this.dgv_DuLieu.RowTemplate.Height = 28;
            this.dgv_DuLieu.Size = new System.Drawing.Size(737, 519);
            this.dgv_DuLieu.TabIndex = 2;
            this.dgv_DuLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DuLieu_CellClick);
            // 
            // cl_ID
            // 
            this.cl_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_ID.DataPropertyName = "ID";
            this.cl_ID.HeaderText = "ID";
            this.cl_ID.Name = "cl_ID";
            this.cl_ID.Width = 56;
            // 
            // cl_Loai
            // 
            this.cl_Loai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_Loai.DataPropertyName = "Category";
            this.cl_Loai.HeaderText = "Loại";
            this.cl_Loai.Name = "cl_Loai";
            this.cl_Loai.Width = 74;
            // 
            // cl_TenSanPham
            // 
            this.cl_TenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_TenSanPham.DataPropertyName = "ProductName";
            this.cl_TenSanPham.HeaderText = "Tên sản phẩm";
            this.cl_TenSanPham.Name = "cl_TenSanPham";
            this.cl_TenSanPham.Width = 149;
            // 
            // cl_SoLuong
            // 
            this.cl_SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_SoLuong.DataPropertyName = "Quantities";
            this.cl_SoLuong.HeaderText = "Số Lượng";
            this.cl_SoLuong.Name = "cl_SoLuong";
            this.cl_SoLuong.Width = 112;
            // 
            // cl_Status
            // 
            this.cl_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_Status.DataPropertyName = "Status";
            this.cl_Status.HeaderText = "Trạng thái";
            this.cl_Status.Name = "cl_Status";
            this.cl_Status.Width = 114;
            // 
            // cl_PhanLoai
            // 
            this.cl_PhanLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_PhanLoai.DataPropertyName = "Classification";
            this.cl_PhanLoai.HeaderText = "Phân loại";
            this.cl_PhanLoai.Name = "cl_PhanLoai";
            this.cl_PhanLoai.Width = 108;
            // 
            // cl_MoTa
            // 
            this.cl_MoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_MoTa.DataPropertyName = "Description";
            this.cl_MoTa.HeaderText = "Mô tả";
            this.cl_MoTa.Name = "cl_MoTa";
            this.cl_MoTa.Width = 65;
            // 
            // cl_NgayNhap
            // 
            this.cl_NgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_NgayNhap.DataPropertyName = "DateCreate";
            this.cl_NgayNhap.HeaderText = "Ngày nhập hàng";
            this.cl_NgayNhap.Name = "cl_NgayNhap";
            this.cl_NgayNhap.Width = 165;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_Them,
            this.btn_Xuat});
            this.toolStrip1.Location = new System.Drawing.Point(2, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(737, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // strip_Them
            // 
            this.strip_Them.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.strip_Them.ForeColor = System.Drawing.Color.Red;
            this.strip_Them.Image = global::Desktop.Properties.Resources.icons8_plus_48;
            this.strip_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_Them.Name = "strip_Them";
            this.strip_Them.Size = new System.Drawing.Size(77, 28);
            this.strip_Them.Text = "Thêm";
            this.strip_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Xuat.ForeColor = System.Drawing.Color.Red;
            this.btn_Xuat.Image = global::Desktop.Properties.Resources.icons8_export_csv_40;
            this.btn_Xuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(107, 28);
            this.btn_Xuat.Text = "Xuất Excel";
            this.btn_Xuat.ToolTipText = "Xuất Excel";
            this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1228, 573);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmNhapHang";
            this.Text = "Thông tin nhập hàng";
            this.Load += new System.EventHandler(this.frmNhapHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_DuLieu;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton strip_Them;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhapHang;
        private System.Windows.Forms.ComboBox cbb_Loai;
        private System.Windows.Forms.ComboBox cbb_PhanLoai;
        private System.Windows.Forms.ComboBox cbb_TinhTrang;
        private System.Windows.Forms.TextBox tb_MoTa;
        private System.Windows.Forms.TextBox tb_Hang;
        private System.Windows.Forms.TextBox tb_SoLuong;
        private System.Windows.Forms.TextBox tb_TenSanPham;
        private System.Windows.Forms.ToolStripButton btn_Xuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_PhanLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_NgayNhap;
    }
}
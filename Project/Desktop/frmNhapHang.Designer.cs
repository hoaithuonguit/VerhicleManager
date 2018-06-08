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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.strip_Them = new System.Windows.Forms.ToolStripButton();
            this.btn_Xuat = new System.Windows.Forms.ToolStripButton();
            this.cl_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_PhanLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 888);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập hàng";
            // 
            // tb_TenSanPham
            // 
            this.tb_TenSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_TenSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_TenSanPham.Location = new System.Drawing.Point(235, 113);
            this.tb_TenSanPham.Name = "tb_TenSanPham";
            this.tb_TenSanPham.Size = new System.Drawing.Size(350, 35);
            this.tb_TenSanPham.TabIndex = 1;
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
            this.cbb_Loai.Location = new System.Drawing.Point(235, 60);
            this.cbb_Loai.Name = "cbb_Loai";
            this.cbb_Loai.Size = new System.Drawing.Size(350, 37);
            this.cbb_Loai.TabIndex = 19;
            this.cbb_Loai.SelectedIndexChanged += new System.EventHandler(this.cbb_Loai_SelectedIndexChanged);
            // 
            // cbb_PhanLoai
            // 
            this.cbb_PhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_PhanLoai.FormattingEnabled = true;
            this.cbb_PhanLoai.Location = new System.Drawing.Point(235, 438);
            this.cbb_PhanLoai.Name = "cbb_PhanLoai";
            this.cbb_PhanLoai.Size = new System.Drawing.Size(350, 37);
            this.cbb_PhanLoai.TabIndex = 18;
            this.cbb_PhanLoai.SelectedIndexChanged += new System.EventHandler(this.cbb_PhanLoai_SelectedIndexChanged);
            // 
            // cbb_TinhTrang
            // 
            this.cbb_TinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TinhTrang.FormattingEnabled = true;
            this.cbb_TinhTrang.Location = new System.Drawing.Point(235, 272);
            this.cbb_TinhTrang.Name = "cbb_TinhTrang";
            this.cbb_TinhTrang.Size = new System.Drawing.Size(350, 37);
            this.cbb_TinhTrang.TabIndex = 17;
            this.cbb_TinhTrang.SelectedIndexChanged += new System.EventHandler(this.cbb_TinhTrang_SelectedIndexChanged);
            // 
            // tb_MoTa
            // 
            this.tb_MoTa.Location = new System.Drawing.Point(235, 383);
            this.tb_MoTa.Name = "tb_MoTa";
            this.tb_MoTa.Size = new System.Drawing.Size(350, 35);
            this.tb_MoTa.TabIndex = 5;
            // 
            // tb_Hang
            // 
            this.tb_Hang.Location = new System.Drawing.Point(235, 325);
            this.tb_Hang.Name = "tb_Hang";
            this.tb_Hang.Size = new System.Drawing.Size(350, 35);
            this.tb_Hang.TabIndex = 4;
            // 
            // tb_SoLuong
            // 
            this.tb_SoLuong.Location = new System.Drawing.Point(235, 219);
            this.tb_SoLuong.Name = "tb_SoLuong";
            this.tb_SoLuong.Size = new System.Drawing.Size(350, 35);
            this.tb_SoLuong.TabIndex = 3;
            this.tb_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ID_KeyPress);
            // 
            // dtp_NgayNhapHang
            // 
            this.dtp_NgayNhapHang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayNhapHang.Location = new System.Drawing.Point(235, 164);
            this.dtp_NgayNhapHang.Name = "dtp_NgayNhapHang";
            this.dtp_NgayNhapHang.Size = new System.Drawing.Size(350, 35);
            this.dtp_NgayNhapHang.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 381);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 29);
            this.label9.TabIndex = 10;
            this.label9.Text = "Mô tả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "Loại:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 29);
            this.label7.TabIndex = 8;
            this.label7.Text = "Hãng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 441);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phân loại:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tình trạng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 29);
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
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(675, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1155, 888);
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
            this.dgv_DuLieu.Location = new System.Drawing.Point(3, 63);
            this.dgv_DuLieu.Name = "dgv_DuLieu";
            this.dgv_DuLieu.RowTemplate.Height = 28;
            this.dgv_DuLieu.Size = new System.Drawing.Size(1149, 822);
            this.dgv_DuLieu.TabIndex = 2;
            this.dgv_DuLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DuLieu_CellClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_Them,
            this.btn_Xuat});
            this.toolStrip1.Location = new System.Drawing.Point(3, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1149, 32);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // strip_Them
            // 
            this.strip_Them.Image = global::Desktop.Properties.Resources.icons8_plus_48;
            this.strip_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_Them.Name = "strip_Them";
            this.strip_Them.Size = new System.Drawing.Size(84, 29);
            this.strip_Them.Text = "Thêm";
            this.strip_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.Image = global::Desktop.Properties.Resources.icons8_export_csv_40;
            this.btn_Xuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(119, 29);
            this.btn_Xuat.Text = "Xuất Excel";
            this.btn_Xuat.ToolTipText = "Xuất Excel";
            this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
            // 
            // cl_ID
            // 
            this.cl_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_ID.DataPropertyName = "ID";
            this.cl_ID.HeaderText = "ID";
            this.cl_ID.Name = "cl_ID";
            this.cl_ID.Width = 72;
            // 
            // cl_Loai
            // 
            this.cl_Loai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_Loai.DataPropertyName = "Category";
            this.cl_Loai.HeaderText = "Loại";
            this.cl_Loai.Name = "cl_Loai";
            this.cl_Loai.Width = 95;
            // 
            // cl_TenSanPham
            // 
            this.cl_TenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_TenSanPham.DataPropertyName = "ProductName";
            this.cl_TenSanPham.HeaderText = "Tên sản phẩm";
            this.cl_TenSanPham.Name = "cl_TenSanPham";
            this.cl_TenSanPham.Width = 202;
            // 
            // cl_SoLuong
            // 
            this.cl_SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_SoLuong.DataPropertyName = "Quantities";
            this.cl_SoLuong.HeaderText = "Số Lượng";
            this.cl_SoLuong.Name = "cl_SoLuong";
            this.cl_SoLuong.Width = 152;
            // 
            // cl_Status
            // 
            this.cl_Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_Status.DataPropertyName = "Status";
            this.cl_Status.HeaderText = "Trạng thái";
            this.cl_Status.Name = "cl_Status";
            this.cl_Status.Width = 157;
            // 
            // cl_PhanLoai
            // 
            this.cl_PhanLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_PhanLoai.DataPropertyName = "Classification";
            this.cl_PhanLoai.HeaderText = "Phân loại";
            this.cl_PhanLoai.Name = "cl_PhanLoai";
            this.cl_PhanLoai.Width = 149;
            // 
            // cl_MoTa
            // 
            this.cl_MoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_MoTa.DataPropertyName = "Description";
            this.cl_MoTa.HeaderText = "Mô tả";
            this.cl_MoTa.Name = "cl_MoTa";
            this.cl_MoTa.Width = 108;
            // 
            // cl_NgayNhap
            // 
            this.cl_NgayNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_NgayNhap.DataPropertyName = "DateCreate";
            this.cl_NgayNhap.HeaderText = "Ngày nhập hàng";
            this.cl_NgayNhap.Name = "cl_NgayNhap";
            this.cl_NgayNhap.Width = 204;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1842, 912);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
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
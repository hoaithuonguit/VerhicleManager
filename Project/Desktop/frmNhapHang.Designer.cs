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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_XuatExcel = new System.Windows.Forms.Button();
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
            this.strip_Sua = new System.Windows.Forms.ToolStripButton();
            this.strip_Luu = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.groupBox3);
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
            this.tb_TenSanPham.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Sua);
            this.groupBox3.Controls.Add(this.btn_Them);
            this.groupBox3.Controls.Add(this.btn_XuatExcel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 514);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(651, 371);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xuất dữ liệu";
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(211, 64);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(149, 52);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(35, 64);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(148, 52);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.Location = new System.Drawing.Point(399, 64);
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(167, 52);
            this.btn_XuatExcel.TabIndex = 0;
            this.btn_XuatExcel.Text = "Xuất excel";
            this.btn_XuatExcel.UseVisualStyleBackColor = true;
            // 
            // cbb_Loai
            // 
            this.cbb_Loai.AutoCompleteCustomSource.AddRange(new string[] {
            "Xe nâng",
            "Phụ tùng"});
            this.cbb_Loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Loai.FormattingEnabled = true;
            this.cbb_Loai.Location = new System.Drawing.Point(235, 60);
            this.cbb_Loai.Name = "cbb_Loai";
            this.cbb_Loai.Size = new System.Drawing.Size(350, 37);
            this.cbb_Loai.TabIndex = 19;
            // 
            // cbb_PhanLoai
            // 
            this.cbb_PhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_PhanLoai.FormattingEnabled = true;
            this.cbb_PhanLoai.Location = new System.Drawing.Point(235, 438);
            this.cbb_PhanLoai.Name = "cbb_PhanLoai";
            this.cbb_PhanLoai.Size = new System.Drawing.Size(350, 37);
            this.cbb_PhanLoai.TabIndex = 18;
            // 
            // cbb_TinhTrang
            // 
            this.cbb_TinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TinhTrang.FormattingEnabled = true;
            this.cbb_TinhTrang.Location = new System.Drawing.Point(235, 272);
            this.cbb_TinhTrang.Name = "cbb_TinhTrang";
            this.cbb_TinhTrang.Size = new System.Drawing.Size(350, 37);
            this.cbb_TinhTrang.TabIndex = 17;
            // 
            // tb_MoTa
            // 
            this.tb_MoTa.Location = new System.Drawing.Point(235, 383);
            this.tb_MoTa.Name = "tb_MoTa";
            this.tb_MoTa.Size = new System.Drawing.Size(350, 35);
            this.tb_MoTa.TabIndex = 16;
            // 
            // tb_Hang
            // 
            this.tb_Hang.Location = new System.Drawing.Point(235, 325);
            this.tb_Hang.Name = "tb_Hang";
            this.tb_Hang.Size = new System.Drawing.Size(350, 35);
            this.tb_Hang.TabIndex = 15;
            // 
            // tb_SoLuong
            // 
            this.tb_SoLuong.Location = new System.Drawing.Point(235, 219);
            this.tb_SoLuong.Name = "tb_SoLuong";
            this.tb_SoLuong.Size = new System.Drawing.Size(350, 35);
            this.tb_SoLuong.TabIndex = 13;
            // 
            // dtp_NgayNhapHang
            // 
            this.dtp_NgayNhapHang.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayNhapHang.Location = new System.Drawing.Point(235, 164);
            this.dtp_NgayNhapHang.Name = "dtp_NgayNhapHang";
            this.dtp_NgayNhapHang.Size = new System.Drawing.Size(350, 35);
            this.dtp_NgayNhapHang.TabIndex = 11;
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
            this.dgv_DuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DuLieu.Location = new System.Drawing.Point(3, 63);
            this.dgv_DuLieu.Name = "dgv_DuLieu";
            this.dgv_DuLieu.RowTemplate.Height = 28;
            this.dgv_DuLieu.Size = new System.Drawing.Size(1149, 822);
            this.dgv_DuLieu.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_Them,
            this.strip_Sua,
            this.strip_Luu});
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
            // 
            // strip_Sua
            // 
            this.strip_Sua.Image = global::Desktop.Properties.Resources.icons8_pencil_40;
            this.strip_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_Sua.Name = "strip_Sua";
            this.strip_Sua.Size = new System.Drawing.Size(70, 29);
            this.strip_Sua.Text = "Sửa";
            // 
            // strip_Luu
            // 
            this.strip_Luu.Image = global::Desktop.Properties.Resources.BTluu;
            this.strip_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_Luu.Name = "strip_Luu";
            this.strip_Luu.Size = new System.Drawing.Size(69, 29);
            this.strip_Luu.Text = "Lưu";
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
            this.groupBox3.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripButton strip_Sua;
        private System.Windows.Forms.ToolStripButton strip_Luu;
        private System.Windows.Forms.DateTimePicker dtp_NgayNhapHang;
        private System.Windows.Forms.ComboBox cbb_Loai;
        private System.Windows.Forms.ComboBox cbb_PhanLoai;
        private System.Windows.Forms.ComboBox cbb_TinhTrang;
        private System.Windows.Forms.TextBox tb_MoTa;
        private System.Windows.Forms.TextBox tb_Hang;
        private System.Windows.Forms.TextBox tb_SoLuong;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_XuatExcel;
        private System.Windows.Forms.TextBox tb_TenSanPham;
    }
}
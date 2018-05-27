namespace Desktop
{
    partial class frmKho
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbb_LoaiSanPham = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdb_HangTonNhieuNhat = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rdb_HangBanNhieuNhat = new System.Windows.Forms.RadioButton();
            this.rdb_HangHet = new System.Windows.Forms.RadioButton();
            this.btn_KiemHang = new System.Windows.Forms.Button();
            this.btn_KiemTra = new System.Windows.Forms.Button();
            this.cbb_TenSanPham = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.strip_Them = new System.Windows.Forms.ToolStripButton();
            this.strip_Sua = new System.Windows.Forms.ToolStripButton();
            this.strip_Xoa = new System.Windows.Forms.ToolStripButton();
            this.strip_Luu = new System.Windows.Forms.ToolStripButton();
            this.strip_Thoat = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btn_KiemTra);
            this.groupBox1.Controls.Add(this.cbb_TenSanPham);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 928);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kho";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbb_LoaiSanPham);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.rdb_HangTonNhieuNhat);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.rdb_HangBanNhieuNhat);
            this.groupBox3.Controls.Add(this.rdb_HangHet);
            this.groupBox3.Controls.Add(this.btn_KiemHang);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 269);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(589, 656);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kiểm tra hàng trong kho";
            // 
            // cbb_LoaiSanPham
            // 
            this.cbb_LoaiSanPham.FormattingEnabled = true;
            this.cbb_LoaiSanPham.Items.AddRange(new object[] {
            "Xe nâng",
            "Phụ tùng"});
            this.cbb_LoaiSanPham.Location = new System.Drawing.Point(329, 297);
            this.cbb_LoaiSanPham.Name = "cbb_LoaiSanPham";
            this.cbb_LoaiSanPham.Size = new System.Drawing.Size(185, 37);
            this.cbb_LoaiSanPham.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Loại sản phẩm cần kiểm tra:";
            // 
            // rdb_HangTonNhieuNhat
            // 
            this.rdb_HangTonNhieuNhat.AutoSize = true;
            this.rdb_HangTonNhieuNhat.Location = new System.Drawing.Point(18, 211);
            this.rdb_HangTonNhieuNhat.Name = "rdb_HangTonNhieuNhat";
            this.rdb_HangTonNhieuNhat.Size = new System.Drawing.Size(250, 33);
            this.rdb_HangTonNhieuNhat.TabIndex = 4;
            this.rdb_HangTonNhieuNhat.TabStop = true;
            this.rdb_HangTonNhieuNhat.Text = "Hàng tồn nhiều nhất";
            this.rdb_HangTonNhieuNhat.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 157);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(269, 33);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hàng bán được ít nhất";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rdb_HangBanNhieuNhat
            // 
            this.rdb_HangBanNhieuNhat.AutoSize = true;
            this.rdb_HangBanNhieuNhat.Location = new System.Drawing.Point(18, 103);
            this.rdb_HangBanNhieuNhat.Name = "rdb_HangBanNhieuNhat";
            this.rdb_HangBanNhieuNhat.Size = new System.Drawing.Size(316, 33);
            this.rdb_HangBanNhieuNhat.TabIndex = 2;
            this.rdb_HangBanNhieuNhat.TabStop = true;
            this.rdb_HangBanNhieuNhat.Text = "Hàng bán được nhiều nhất";
            this.rdb_HangBanNhieuNhat.UseVisualStyleBackColor = true;
            // 
            // rdb_HangHet
            // 
            this.rdb_HangHet.AutoSize = true;
            this.rdb_HangHet.Location = new System.Drawing.Point(18, 49);
            this.rdb_HangHet.Name = "rdb_HangHet";
            this.rdb_HangHet.Size = new System.Drawing.Size(258, 33);
            this.rdb_HangHet.TabIndex = 1;
            this.rdb_HangHet.TabStop = true;
            this.rdb_HangHet.Text = "Kiểm tra hàng đã hết";
            this.rdb_HangHet.UseVisualStyleBackColor = true;
            // 
            // btn_KiemHang
            // 
            this.btn_KiemHang.Location = new System.Drawing.Point(195, 368);
            this.btn_KiemHang.Name = "btn_KiemHang";
            this.btn_KiemHang.Size = new System.Drawing.Size(139, 52);
            this.btn_KiemHang.TabIndex = 0;
            this.btn_KiemHang.Text = "Kiểm tra";
            this.btn_KiemHang.UseVisualStyleBackColor = true;
            // 
            // btn_KiemTra
            // 
            this.btn_KiemTra.Location = new System.Drawing.Point(197, 129);
            this.btn_KiemTra.Name = "btn_KiemTra";
            this.btn_KiemTra.Size = new System.Drawing.Size(127, 52);
            this.btn_KiemTra.TabIndex = 25;
            this.btn_KiemTra.Text = "Kiểm tra";
            this.btn_KiemTra.UseVisualStyleBackColor = true;
            // 
            // cbb_TenSanPham
            // 
            this.cbb_TenSanPham.FormattingEnabled = true;
            this.cbb_TenSanPham.Location = new System.Drawing.Point(197, 60);
            this.cbb_TenSanPham.Name = "cbb_TenSanPham";
            this.cbb_TenSanPham.Size = new System.Drawing.Size(369, 37);
            this.cbb_TenSanPham.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(613, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 928);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu kho";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(893, 862);
            this.dataGridView1.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_Them,
            this.strip_Sua,
            this.strip_Xoa,
            this.strip_Luu,
            this.strip_Thoat});
            this.toolStrip1.Location = new System.Drawing.Point(3, 31);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(893, 32);
            this.toolStrip1.TabIndex = 2;
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
            // strip_Xoa
            // 
            this.strip_Xoa.Image = global::Desktop.Properties.Resources.icons8_cancel_40;
            this.strip_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_Xoa.Name = "strip_Xoa";
            this.strip_Xoa.Size = new System.Drawing.Size(71, 29);
            this.strip_Xoa.Text = "Xóa";
            // 
            // strip_Luu
            // 
            this.strip_Luu.Image = global::Desktop.Properties.Resources.BTluu;
            this.strip_Luu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_Luu.Name = "strip_Luu";
            this.strip_Luu.Size = new System.Drawing.Size(69, 29);
            this.strip_Luu.Text = "Lưu";
            // 
            // strip_Thoat
            // 
            this.strip_Thoat.Image = global::Desktop.Properties.Resources.icons8_shutdown_80;
            this.strip_Thoat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_Thoat.Name = "strip_Thoat";
            this.strip_Thoat.Size = new System.Drawing.Size(85, 29);
            this.strip_Thoat.Text = "Thoát";
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 952);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKho";
            this.Text = "Quản lí kho";
            this.Load += new System.EventHandler(this.frmKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton strip_Them;
        private System.Windows.Forms.ToolStripButton strip_Sua;
        private System.Windows.Forms.ToolStripButton strip_Xoa;
        private System.Windows.Forms.ToolStripButton strip_Luu;
        private System.Windows.Forms.ToolStripButton strip_Thoat;
        private System.Windows.Forms.Button btn_KiemTra;
        private System.Windows.Forms.ComboBox cbb_TenSanPham;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbb_LoaiSanPham;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdb_HangTonNhieuNhat;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rdb_HangBanNhieuNhat;
        private System.Windows.Forms.RadioButton rdb_HangHet;
        private System.Windows.Forms.Button btn_KiemHang;
    }
}
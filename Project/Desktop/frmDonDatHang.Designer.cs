namespace Desktop
{
    partial class frmDonDatHang
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
            this.dgv_DuLieu = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Duyet = new System.Windows.Forms.Button();
            this.tb_TenNguoiDat = new System.Windows.Forms.TextBox();
            this.tb_DiaChi = new System.Windows.Forms.TextBox();
            this.tb_SDT = new System.Windows.Forms.TextBox();
            this.tb_TenHang = new System.Windows.Forms.TextBox();
            this.tb_SoLuong = new System.Windows.Forms.TextBox();
            this.tb_ThoiGian = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbb_TrangThai = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.dgv_DuLieu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(654, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(943, 894);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dữ liệu đơn đặt hàng";
            // 
            // dgv_DuLieu
            // 
            this.dgv_DuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DuLieu.Location = new System.Drawing.Point(3, 31);
            this.dgv_DuLieu.Name = "dgv_DuLieu";
            this.dgv_DuLieu.RowTemplate.Height = 28;
            this.dgv_DuLieu.Size = new System.Drawing.Size(937, 860);
            this.dgv_DuLieu.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cbb_TrangThai);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 894);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xem đơn đặt hàng";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.btn_Duyet);
            this.groupBox3.Controls.Add(this.tb_TenNguoiDat);
            this.groupBox3.Controls.Add(this.tb_DiaChi);
            this.groupBox3.Controls.Add(this.tb_SDT);
            this.groupBox3.Controls.Add(this.tb_TenHang);
            this.groupBox3.Controls.Add(this.tb_SoLuong);
            this.groupBox3.Controls.Add(this.tb_ThoiGian);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(3, 109);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(630, 782);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Duyệt đơn hàng:";
            // 
            // btn_Duyet
            // 
            this.btn_Duyet.Location = new System.Drawing.Point(223, 397);
            this.btn_Duyet.Name = "btn_Duyet";
            this.btn_Duyet.Size = new System.Drawing.Size(198, 50);
            this.btn_Duyet.TabIndex = 12;
            this.btn_Duyet.Text = "Duyệt đơn hàng";
            this.btn_Duyet.UseVisualStyleBackColor = true;
            // 
            // tb_TenNguoiDat
            // 
            this.tb_TenNguoiDat.Enabled = false;
            this.tb_TenNguoiDat.Location = new System.Drawing.Point(223, 64);
            this.tb_TenNguoiDat.Name = "tb_TenNguoiDat";
            this.tb_TenNguoiDat.Size = new System.Drawing.Size(368, 35);
            this.tb_TenNguoiDat.TabIndex = 11;
            // 
            // tb_DiaChi
            // 
            this.tb_DiaChi.Enabled = false;
            this.tb_DiaChi.Location = new System.Drawing.Point(223, 115);
            this.tb_DiaChi.Name = "tb_DiaChi";
            this.tb_DiaChi.Size = new System.Drawing.Size(368, 35);
            this.tb_DiaChi.TabIndex = 10;
            // 
            // tb_SDT
            // 
            this.tb_SDT.Enabled = false;
            this.tb_SDT.Location = new System.Drawing.Point(223, 168);
            this.tb_SDT.Name = "tb_SDT";
            this.tb_SDT.Size = new System.Drawing.Size(368, 35);
            this.tb_SDT.TabIndex = 9;
            // 
            // tb_TenHang
            // 
            this.tb_TenHang.Enabled = false;
            this.tb_TenHang.Location = new System.Drawing.Point(223, 222);
            this.tb_TenHang.Name = "tb_TenHang";
            this.tb_TenHang.Size = new System.Drawing.Size(368, 35);
            this.tb_TenHang.TabIndex = 8;
            // 
            // tb_SoLuong
            // 
            this.tb_SoLuong.Enabled = false;
            this.tb_SoLuong.Location = new System.Drawing.Point(223, 273);
            this.tb_SoLuong.Name = "tb_SoLuong";
            this.tb_SoLuong.Size = new System.Drawing.Size(368, 35);
            this.tb_SoLuong.TabIndex = 7;
            // 
            // tb_ThoiGian
            // 
            this.tb_ThoiGian.Enabled = false;
            this.tb_ThoiGian.Location = new System.Drawing.Point(223, 325);
            this.tb_ThoiGian.Name = "tb_ThoiGian";
            this.tb_ThoiGian.Size = new System.Drawing.Size(368, 35);
            this.tb_ThoiGian.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 29);
            this.label7.TabIndex = 5;
            this.label7.Text = "Thời gian cần lấy:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 29);
            this.label6.TabIndex = 4;
            this.label6.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Tên hàng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 29);
            this.label4.TabIndex = 2;
            this.label4.Text = "Số điện thoại:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tên người đặt:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Địa chỉ:";
            // 
            // cbb_TrangThai
            // 
            this.cbb_TrangThai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TrangThai.FormattingEnabled = true;
            this.cbb_TrangThai.Items.AddRange(new object[] {
            "Đã duyệt",
            "Đang chờ"});
            this.cbb_TrangThai.Location = new System.Drawing.Point(241, 51);
            this.cbb_TrangThai.Name = "cbb_TrangThai";
            this.cbb_TrangThai.Size = new System.Drawing.Size(379, 37);
            this.cbb_TrangThai.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xem đơn đặt hàng:";
            // 
            // frmDonDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 918);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmDonDatHang";
            this.Text = "frmDonDatHang";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_DuLieu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbb_TrangThai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_TenNguoiDat;
        private System.Windows.Forms.TextBox tb_DiaChi;
        private System.Windows.Forms.TextBox tb_SDT;
        private System.Windows.Forms.TextBox tb_TenHang;
        private System.Windows.Forms.TextBox tb_SoLuong;
        private System.Windows.Forms.TextBox tb_ThoiGian;
        private System.Windows.Forms.Button btn_Duyet;
    }
}
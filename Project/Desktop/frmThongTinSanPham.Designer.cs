﻿namespace Desktop
{
    partial class frmThongTinSanPham
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
            this.cbb_Loai = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbb_PhanLoai = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_TenSanPham = new System.Windows.Forms.TextBox();
            this.btn_ChonHinh5 = new System.Windows.Forms.Button();
            this.btn_ChonHinh3 = new System.Windows.Forms.Button();
            this.btn_ChonHinh4 = new System.Windows.Forms.Button();
            this.btn_ChonHinh2 = new System.Windows.Forms.Button();
            this.btn_ChonHinh1 = new System.Windows.Forms.Button();
            this.cbb_TinhTrang = new System.Windows.Forms.ComboBox();
            this.tb_MoTa = new System.Windows.Forms.TextBox();
            this.tb_HangSanXuat = new System.Windows.Forms.TextBox();
            this.tb_Doi = new System.Windows.Forms.TextBox();
            this.tb_Hieu = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DuLieu = new System.Windows.Forms.DataGridView();
            this.cl_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Hieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Doi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Hang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_PhanLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.strip_Them = new System.Windows.Forms.ToolStripButton();
            this.strip_Sua = new System.Windows.Forms.ToolStripButton();
            this.btn_XuatExcel = new System.Windows.Forms.ToolStripButton();
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
            this.groupBox1.Controls.Add(this.cbb_Loai);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.cbb_PhanLoai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tb_TenSanPham);
            this.groupBox1.Controls.Add(this.btn_ChonHinh5);
            this.groupBox1.Controls.Add(this.btn_ChonHinh3);
            this.groupBox1.Controls.Add(this.btn_ChonHinh4);
            this.groupBox1.Controls.Add(this.btn_ChonHinh2);
            this.groupBox1.Controls.Add(this.btn_ChonHinh1);
            this.groupBox1.Controls.Add(this.cbb_TinhTrang);
            this.groupBox1.Controls.Add(this.tb_MoTa);
            this.groupBox1.Controls.Add(this.tb_HangSanXuat);
            this.groupBox1.Controls.Add(this.tb_Doi);
            this.groupBox1.Controls.Add(this.tb_Hieu);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(823, 941);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin sản phẩm";
            // 
            // cbb_Loai
            // 
            this.cbb_Loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_Loai.FormattingEnabled = true;
            this.cbb_Loai.Items.AddRange(new object[] {
            "Xe nâng",
            "Phụ tùng"});
            this.cbb_Loai.Location = new System.Drawing.Point(261, 57);
            this.cbb_Loai.Name = "cbb_Loai";
            this.cbb_Loai.Size = new System.Drawing.Size(511, 44);
            this.cbb_Loai.TabIndex = 1;
            this.cbb_Loai.SelectedIndexChanged += new System.EventHandler(this.cbb_Loai_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(21, 60);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(217, 36);
            this.label14.TabIndex = 33;
            this.label14.Text = "Loại sản phẩm:";
            // 
            // cbb_PhanLoai
            // 
            this.cbb_PhanLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbb_PhanLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_PhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_PhanLoai.FormattingEnabled = true;
            this.cbb_PhanLoai.Location = new System.Drawing.Point(261, 391);
            this.cbb_PhanLoai.MaxDropDownItems = 7;
            this.cbb_PhanLoai.Name = "cbb_PhanLoai";
            this.cbb_PhanLoai.Size = new System.Drawing.Size(511, 44);
            this.cbb_PhanLoai.TabIndex = 32;
            this.cbb_PhanLoai.SelectedIndexChanged += new System.EventHandler(this.cbb_PhanLoai_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 394);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 36);
            this.label7.TabIndex = 31;
            this.label7.Text = "Phân loại:";
            // 
            // tb_TenSanPham
            // 
            this.tb_TenSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tb_TenSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_TenSanPham.Location = new System.Drawing.Point(261, 116);
            this.tb_TenSanPham.Name = "tb_TenSanPham";
            this.tb_TenSanPham.Size = new System.Drawing.Size(511, 41);
            this.tb_TenSanPham.TabIndex = 2;
            // 
            // btn_ChonHinh5
            // 
            this.btn_ChonHinh5.ForeColor = System.Drawing.Color.Red;
            this.btn_ChonHinh5.Location = new System.Drawing.Point(261, 750);
            this.btn_ChonHinh5.Name = "btn_ChonHinh5";
            this.btn_ChonHinh5.Size = new System.Drawing.Size(185, 49);
            this.btn_ChonHinh5.TabIndex = 13;
            this.btn_ChonHinh5.Text = "Chọn hình ảnh";
            this.btn_ChonHinh5.UseVisualStyleBackColor = true;
            this.btn_ChonHinh5.Click += new System.EventHandler(this.btn_ChonHinh5_Click);
            // 
            // btn_ChonHinh3
            // 
            this.btn_ChonHinh3.ForeColor = System.Drawing.Color.Red;
            this.btn_ChonHinh3.Location = new System.Drawing.Point(261, 626);
            this.btn_ChonHinh3.Name = "btn_ChonHinh3";
            this.btn_ChonHinh3.Size = new System.Drawing.Size(185, 49);
            this.btn_ChonHinh3.TabIndex = 11;
            this.btn_ChonHinh3.Text = "Chọn hình ảnh";
            this.btn_ChonHinh3.UseVisualStyleBackColor = true;
            this.btn_ChonHinh3.Click += new System.EventHandler(this.btn_ChonHinh3_Click);
            // 
            // btn_ChonHinh4
            // 
            this.btn_ChonHinh4.ForeColor = System.Drawing.Color.Red;
            this.btn_ChonHinh4.Location = new System.Drawing.Point(261, 687);
            this.btn_ChonHinh4.Name = "btn_ChonHinh4";
            this.btn_ChonHinh4.Size = new System.Drawing.Size(185, 49);
            this.btn_ChonHinh4.TabIndex = 12;
            this.btn_ChonHinh4.Text = "Chọn hình ảnh";
            this.btn_ChonHinh4.UseVisualStyleBackColor = true;
            this.btn_ChonHinh4.Click += new System.EventHandler(this.btn_ChonHinh4_Click);
            // 
            // btn_ChonHinh2
            // 
            this.btn_ChonHinh2.ForeColor = System.Drawing.Color.Red;
            this.btn_ChonHinh2.Location = new System.Drawing.Point(261, 567);
            this.btn_ChonHinh2.Name = "btn_ChonHinh2";
            this.btn_ChonHinh2.Size = new System.Drawing.Size(185, 49);
            this.btn_ChonHinh2.TabIndex = 10;
            this.btn_ChonHinh2.Text = "Chọn hình ảnh";
            this.btn_ChonHinh2.UseVisualStyleBackColor = true;
            this.btn_ChonHinh2.Click += new System.EventHandler(this.btn_ChonHinh2_Click);
            // 
            // btn_ChonHinh1
            // 
            this.btn_ChonHinh1.ForeColor = System.Drawing.Color.Red;
            this.btn_ChonHinh1.Location = new System.Drawing.Point(261, 508);
            this.btn_ChonHinh1.Name = "btn_ChonHinh1";
            this.btn_ChonHinh1.Size = new System.Drawing.Size(185, 49);
            this.btn_ChonHinh1.TabIndex = 9;
            this.btn_ChonHinh1.Text = "Chọn hình ảnh";
            this.btn_ChonHinh1.UseVisualStyleBackColor = true;
            this.btn_ChonHinh1.Click += new System.EventHandler(this.btn_ChonHinh1_Click);
            // 
            // cbb_TinhTrang
            // 
            this.cbb_TinhTrang.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbb_TinhTrang.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbb_TinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_TinhTrang.FormattingEnabled = true;
            this.cbb_TinhTrang.Location = new System.Drawing.Point(261, 448);
            this.cbb_TinhTrang.Name = "cbb_TinhTrang";
            this.cbb_TinhTrang.Size = new System.Drawing.Size(511, 44);
            this.cbb_TinhTrang.TabIndex = 18;
            this.cbb_TinhTrang.SelectedIndexChanged += new System.EventHandler(this.cbb_TinhTrang_SelectedIndexChanged);
            // 
            // tb_MoTa
            // 
            this.tb_MoTa.Location = new System.Drawing.Point(261, 336);
            this.tb_MoTa.Name = "tb_MoTa";
            this.tb_MoTa.Size = new System.Drawing.Size(511, 41);
            this.tb_MoTa.TabIndex = 6;
            // 
            // tb_HangSanXuat
            // 
            this.tb_HangSanXuat.Location = new System.Drawing.Point(261, 283);
            this.tb_HangSanXuat.Name = "tb_HangSanXuat";
            this.tb_HangSanXuat.Size = new System.Drawing.Size(511, 41);
            this.tb_HangSanXuat.TabIndex = 5;
            // 
            // tb_Doi
            // 
            this.tb_Doi.Location = new System.Drawing.Point(261, 231);
            this.tb_Doi.Name = "tb_Doi";
            this.tb_Doi.Size = new System.Drawing.Size(511, 41);
            this.tb_Doi.TabIndex = 4;
            // 
            // tb_Hieu
            // 
            this.tb_Hieu.Location = new System.Drawing.Point(261, 174);
            this.tb_Hieu.Name = "tb_Hieu";
            this.tb_Hieu.Size = new System.Drawing.Size(511, 41);
            this.tb_Hieu.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(21, 756);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(168, 36);
            this.label12.TabIndex = 12;
            this.label12.Text = "Hình ảnh 5:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(21, 693);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(160, 36);
            this.label11.TabIndex = 11;
            this.label11.Text = "Hình ảnh 4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(21, 632);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 36);
            this.label10.TabIndex = 10;
            this.label10.Text = "Hình ảnh 3:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 573);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 36);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hình ảnh 2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(21, 514);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(168, 36);
            this.label8.TabIndex = 8;
            this.label8.Text = "Hình ảnh 1:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(21, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 36);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tình trạng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 339);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 36);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mô tả sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Hãng sản xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(21, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Đời:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(21, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hiệu sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(21, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên sản phẩm:";
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
            this.groupBox2.Location = new System.Drawing.Point(841, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(967, 941);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu thông tin sản phẩm";
            // 
            // dgv_DuLieu
            // 
            this.dgv_DuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DuLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_ID,
            this.cl_Loai,
            this.cl_Ten,
            this.cl_Hieu,
            this.cl_Doi,
            this.cl_Hang,
            this.cl_MoTa,
            this.cl_TinhTrang,
            this.cl_PhanLoai});
            this.dgv_DuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DuLieu.Location = new System.Drawing.Point(3, 76);
            this.dgv_DuLieu.Name = "dgv_DuLieu";
            this.dgv_DuLieu.RowTemplate.Height = 28;
            this.dgv_DuLieu.Size = new System.Drawing.Size(961, 862);
            this.dgv_DuLieu.TabIndex = 2;
            this.dgv_DuLieu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DuLieu_CellClick);
            // 
            // cl_ID
            // 
            this.cl_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_ID.DataPropertyName = "ID";
            this.cl_ID.HeaderText = "ID";
            this.cl_ID.Name = "cl_ID";
            this.cl_ID.Width = 80;
            // 
            // cl_Loai
            // 
            this.cl_Loai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_Loai.DataPropertyName = "Loai";
            this.cl_Loai.HeaderText = "Loại";
            this.cl_Loai.Name = "cl_Loai";
            this.cl_Loai.Width = 108;
            // 
            // cl_Ten
            // 
            this.cl_Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_Ten.DataPropertyName = "Ten";
            this.cl_Ten.HeaderText = "Tên sản phẩm";
            this.cl_Ten.Name = "cl_Ten";
            this.cl_Ten.Width = 239;
            // 
            // cl_Hieu
            // 
            this.cl_Hieu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_Hieu.DataPropertyName = "Hieu";
            this.cl_Hieu.HeaderText = "Hiệu";
            this.cl_Hieu.Name = "cl_Hieu";
            this.cl_Hieu.Width = 112;
            // 
            // cl_Doi
            // 
            this.cl_Doi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_Doi.DataPropertyName = "Doi";
            this.cl_Doi.HeaderText = "Đời";
            this.cl_Doi.Name = "cl_Doi";
            this.cl_Doi.Width = 96;
            // 
            // cl_Hang
            // 
            this.cl_Hang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_Hang.DataPropertyName = "Hang";
            this.cl_Hang.HeaderText = "Hãng";
            this.cl_Hang.Name = "cl_Hang";
            this.cl_Hang.Width = 122;
            // 
            // cl_MoTa
            // 
            this.cl_MoTa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_MoTa.DataPropertyName = "MoTa";
            this.cl_MoTa.HeaderText = "Mô tả";
            this.cl_MoTa.Name = "cl_MoTa";
            this.cl_MoTa.Width = 125;
            // 
            // cl_TinhTrang
            // 
            this.cl_TinhTrang.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_TinhTrang.DataPropertyName = "TinhTrang";
            this.cl_TinhTrang.HeaderText = "Tình trạng";
            this.cl_TinhTrang.Name = "cl_TinhTrang";
            this.cl_TinhTrang.Width = 186;
            // 
            // cl_PhanLoai
            // 
            this.cl_PhanLoai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_PhanLoai.DataPropertyName = "PhanLoai";
            this.cl_PhanLoai.HeaderText = "Phân loại";
            this.cl_PhanLoai.Name = "cl_PhanLoai";
            this.cl_PhanLoai.Width = 176;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_Them,
            this.strip_Sua,
            this.btn_XuatExcel});
            this.toolStrip1.Location = new System.Drawing.Point(3, 37);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(961, 39);
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
            this.strip_Them.Size = new System.Drawing.Size(104, 36);
            this.strip_Them.Text = "Thêm";
            this.strip_Them.Click += new System.EventHandler(this.strip_Them_Click);
            // 
            // strip_Sua
            // 
            this.strip_Sua.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.strip_Sua.ForeColor = System.Drawing.Color.Red;
            this.strip_Sua.Image = global::Desktop.Properties.Resources.icons8_pencil_40;
            this.strip_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.strip_Sua.Name = "strip_Sua";
            this.strip_Sua.Size = new System.Drawing.Size(82, 36);
            this.strip_Sua.Text = "Sửa";
            this.strip_Sua.Click += new System.EventHandler(this.strip_Sua_Click);
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_XuatExcel.ForeColor = System.Drawing.Color.Red;
            this.btn_XuatExcel.Image = global::Desktop.Properties.Resources.icons8_export_csv_40;
            this.btn_XuatExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(151, 36);
            this.btn_XuatExcel.Text = "Xuất Excel";
            this.btn_XuatExcel.Click += new System.EventHandler(this.btn_XuatExcel_Click);
            // 
            // frmThongTinSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1820, 965);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmThongTinSanPham";
            this.Text = "Thông tin sản phẩm";
            this.Load += new System.EventHandler(this.frmThongTinSanPham_Load);
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
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton strip_Them;
        private System.Windows.Forms.ToolStripButton strip_Sua;
        private System.Windows.Forms.Button btn_ChonHinh5;
        private System.Windows.Forms.Button btn_ChonHinh3;
        private System.Windows.Forms.Button btn_ChonHinh4;
        private System.Windows.Forms.Button btn_ChonHinh2;
        private System.Windows.Forms.Button btn_ChonHinh1;
        private System.Windows.Forms.ComboBox cbb_TinhTrang;
        private System.Windows.Forms.TextBox tb_MoTa;
        private System.Windows.Forms.TextBox tb_HangSanXuat;
        private System.Windows.Forms.TextBox tb_Doi;
        private System.Windows.Forms.TextBox tb_Hieu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DuLieu;
        private System.Windows.Forms.TextBox tb_TenSanPham;
        private System.Windows.Forms.ComboBox cbb_PhanLoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbb_Loai;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripButton btn_XuatExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Hieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Doi;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Hang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TinhTrang;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_PhanLoai;
    }
}
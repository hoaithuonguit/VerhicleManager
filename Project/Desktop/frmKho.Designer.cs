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
            this.btn_Xuat = new System.Windows.Forms.Button();
            this.tb_TenSanPham = new System.Windows.Forms.TextBox();
            this.cbb_PhanLoai = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_KiemTra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_DuLieu = new System.Windows.Forms.DataGridView();
            this.cl_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_TenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_SoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl_NgayUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btn_Xuat);
            this.groupBox1.Controls.Add(this.tb_TenSanPham);
            this.groupBox1.Controls.Add(this.cbb_PhanLoai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btn_KiemTra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(652, 928);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin kho";
            // 
            // btn_Xuat
            // 
            this.btn_Xuat.Location = new System.Drawing.Point(239, 282);
            this.btn_Xuat.Name = "btn_Xuat";
            this.btn_Xuat.Size = new System.Drawing.Size(168, 45);
            this.btn_Xuat.TabIndex = 29;
            this.btn_Xuat.Text = "Xuất Excel";
            this.btn_Xuat.UseVisualStyleBackColor = true;
            this.btn_Xuat.Click += new System.EventHandler(this.btn_Xuat_Click);
            // 
            // tb_TenSanPham
            // 
            this.tb_TenSanPham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tb_TenSanPham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tb_TenSanPham.Location = new System.Drawing.Point(239, 125);
            this.tb_TenSanPham.Name = "tb_TenSanPham";
            this.tb_TenSanPham.Size = new System.Drawing.Size(369, 41);
            this.tb_TenSanPham.TabIndex = 2;
            // 
            // cbb_PhanLoai
            // 
            this.cbb_PhanLoai.AutoCompleteCustomSource.AddRange(new string[] {
            "Xe nâng",
            "Phụ tùng"});
            this.cbb_PhanLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_PhanLoai.FormattingEnabled = true;
            this.cbb_PhanLoai.Items.AddRange(new object[] {
            "Xe nâng",
            "Phụ tùng"});
            this.cbb_PhanLoai.Location = new System.Drawing.Point(239, 60);
            this.cbb_PhanLoai.Name = "cbb_PhanLoai";
            this.cbb_PhanLoai.Size = new System.Drawing.Size(369, 44);
            this.cbb_PhanLoai.TabIndex = 1;
            this.cbb_PhanLoai.SelectedIndexChanged += new System.EventHandler(this.cbb_PhanLoai_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 36);
            this.label3.TabIndex = 27;
            this.label3.Text = "Loại sản phẩm:";
            // 
            // btn_KiemTra
            // 
            this.btn_KiemTra.Location = new System.Drawing.Point(239, 197);
            this.btn_KiemTra.Name = "btn_KiemTra";
            this.btn_KiemTra.Size = new System.Drawing.Size(168, 52);
            this.btn_KiemTra.TabIndex = 25;
            this.btn_KiemTra.Text = "Kiểm tra";
            this.btn_KiemTra.UseVisualStyleBackColor = true;
            this.btn_KiemTra.Click += new System.EventHandler(this.btn_KiemTra_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 36);
            this.label1.TabIndex = 23;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_DuLieu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(670, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(842, 928);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu kho";
            // 
            // dgv_DuLieu
            // 
            this.dgv_DuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DuLieu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cl_ID,
            this.cl_Loai,
            this.cl_TenSanPham,
            this.cl_SoLuongTon,
            this.cl_NgayUpdate});
            this.dgv_DuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DuLieu.Location = new System.Drawing.Point(3, 37);
            this.dgv_DuLieu.Name = "dgv_DuLieu";
            this.dgv_DuLieu.RowTemplate.Height = 28;
            this.dgv_DuLieu.Size = new System.Drawing.Size(836, 888);
            this.dgv_DuLieu.TabIndex = 3;
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
            this.cl_Loai.DataPropertyName = "Category";
            this.cl_Loai.HeaderText = "Loại";
            this.cl_Loai.Name = "cl_Loai";
            this.cl_Loai.Width = 108;
            // 
            // cl_TenSanPham
            // 
            this.cl_TenSanPham.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_TenSanPham.DataPropertyName = "ProductName";
            this.cl_TenSanPham.HeaderText = "Tên sản phẩm";
            this.cl_TenSanPham.Name = "cl_TenSanPham";
            this.cl_TenSanPham.Width = 239;
            // 
            // cl_SoLuongTon
            // 
            this.cl_SoLuongTon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_SoLuongTon.DataPropertyName = "Inventories";
            this.cl_SoLuongTon.HeaderText = "Số lượng tồn";
            this.cl_SoLuongTon.Name = "cl_SoLuongTon";
            this.cl_SoLuongTon.Width = 221;
            // 
            // cl_NgayUpdate
            // 
            this.cl_NgayUpdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cl_NgayUpdate.DataPropertyName = "LastUpdate";
            this.cl_NgayUpdate.HeaderText = "Ngày cập nhật ";
            this.cl_NgayUpdate.Name = "cl_NgayUpdate";
            this.cl_NgayUpdate.Width = 251;
            // 
            // frmKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1524, 952);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKho";
            this.Text = "Quản lí kho";
            this.Load += new System.EventHandler(this.frmKho_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_DuLieu;
        private System.Windows.Forms.Button btn_KiemTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_PhanLoai;
        private System.Windows.Forms.TextBox tb_TenSanPham;
        private System.Windows.Forms.Button btn_Xuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_TenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_SoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl_NgayUpdate;
    }
}
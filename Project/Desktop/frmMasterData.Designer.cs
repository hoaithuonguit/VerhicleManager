namespace Desktop
{
    partial class frmMasterData
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.strip_Them = new System.Windows.Forms.ToolStripButton();
            this.strip_Sua = new System.Windows.Forms.ToolStripButton();
            this.strip_Xoa = new System.Windows.Forms.ToolStripButton();
            this.strip_Luu = new System.Windows.Forms.ToolStripButton();
            this.strip_Thoat = new System.Windows.Forms.ToolStripButton();
            this.dgv_DuLieu = new System.Windows.Forms.DataGridView();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Value = new System.Windows.Forms.TextBox();
            this.cbb_Key = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_XuatExcel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.cbb_Key);
            this.groupBox1.Controls.Add(this.tb_Value);
            this.groupBox1.Controls.Add(this.tb_Name);
            this.groupBox1.Controls.Add(this.tb_ID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(543, 897);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin Master data";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgv_DuLieu);
            this.groupBox2.Controls.Add(this.toolStrip1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(561, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1137, 897);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dữ liệu Master";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Key:";
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
            this.toolStrip1.Size = new System.Drawing.Size(1131, 32);
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
            // dgv_DuLieu
            // 
            this.dgv_DuLieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DuLieu.Location = new System.Drawing.Point(3, 63);
            this.dgv_DuLieu.Name = "dgv_DuLieu";
            this.dgv_DuLieu.RowTemplate.Height = 28;
            this.dgv_DuLieu.Size = new System.Drawing.Size(1131, 831);
            this.dgv_DuLieu.TabIndex = 3;
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(129, 60);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(362, 35);
            this.tb_ID.TabIndex = 4;
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(129, 107);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(362, 35);
            this.tb_Name.TabIndex = 5;
            // 
            // tb_Value
            // 
            this.tb_Value.Location = new System.Drawing.Point(129, 154);
            this.tb_Value.Name = "tb_Value";
            this.tb_Value.Size = new System.Drawing.Size(362, 35);
            this.tb_Value.TabIndex = 6;
            // 
            // cbb_Key
            // 
            this.cbb_Key.FormattingEnabled = true;
            this.cbb_Key.Location = new System.Drawing.Point(129, 201);
            this.cbb_Key.Name = "cbb_Key";
            this.cbb_Key.Size = new System.Drawing.Size(362, 37);
            this.cbb_Key.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_Them);
            this.groupBox3.Controls.Add(this.btn_XuatExcel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(3, 325);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(537, 569);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Xuất dữ liệu";
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(67, 64);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(148, 52);
            this.btn_Them.TabIndex = 1;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            // 
            // btn_XuatExcel
            // 
            this.btn_XuatExcel.Location = new System.Drawing.Point(306, 64);
            this.btn_XuatExcel.Name = "btn_XuatExcel";
            this.btn_XuatExcel.Size = new System.Drawing.Size(167, 52);
            this.btn_XuatExcel.TabIndex = 0;
            this.btn_XuatExcel.Text = "Xuất excel";
            this.btn_XuatExcel.UseVisualStyleBackColor = true;
            // 
            // frmMasterData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 921);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMasterData";
            this.Text = "Thêm Master data";
            this.Load += new System.EventHandler(this.frmMasterData_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DuLieu)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton strip_Them;
        private System.Windows.Forms.ToolStripButton strip_Sua;
        private System.Windows.Forms.ToolStripButton strip_Xoa;
        private System.Windows.Forms.ToolStripButton strip_Luu;
        private System.Windows.Forms.ToolStripButton strip_Thoat;
        private System.Windows.Forms.ComboBox cbb_Key;
        private System.Windows.Forms.TextBox tb_Value;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.DataGridView dgv_DuLieu;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_XuatExcel;
    }
}
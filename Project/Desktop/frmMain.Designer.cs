namespace Desktop
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_ChinhSuaThongTinCuaHang = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtDữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_ThemThongTinSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_NhapHang = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_BanHang = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_QuanLiKho = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip_Time = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.btn_XemDonDatHang = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.cậpNhậtDữLiệuToolStripMenuItem,
            this.strip_QuanLiKho});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1781, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_ChinhSuaThongTinCuaHang,
            this.strip_Thoat});
            this.hệThốngToolStripMenuItem.Image = global::Desktop.Properties.Resources.agt_update_drivers;
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(152, 36);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // strip_ChinhSuaThongTinCuaHang
            // 
            this.strip_ChinhSuaThongTinCuaHang.Image = global::Desktop.Properties.Resources.icons8_pencil_40;
            this.strip_ChinhSuaThongTinCuaHang.Name = "strip_ChinhSuaThongTinCuaHang";
            this.strip_ChinhSuaThongTinCuaHang.Size = new System.Drawing.Size(419, 36);
            this.strip_ChinhSuaThongTinCuaHang.Text = "Chỉnh sửa thông tin cửa hàng";
            this.strip_ChinhSuaThongTinCuaHang.Click += new System.EventHandler(this.strip_ChinhSuaThongTinCuaHang_Click);
            // 
            // strip_Thoat
            // 
            this.strip_Thoat.Image = global::Desktop.Properties.Resources.icons8_shutdown_80;
            this.strip_Thoat.Name = "strip_Thoat";
            this.strip_Thoat.Size = new System.Drawing.Size(419, 36);
            this.strip_Thoat.Text = "Thoát";
            this.strip_Thoat.Click += new System.EventHandler(this.strip_Thoat_Click);
            // 
            // cậpNhậtDữLiệuToolStripMenuItem
            // 
            this.cậpNhậtDữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_ThemThongTinSanPham,
            this.strip_NhapHang,
            this.strip_BanHang,
            this.btn_XemDonDatHang});
            this.cậpNhậtDữLiệuToolStripMenuItem.Image = global::Desktop.Properties.Resources.icons8_plus_48;
            this.cậpNhậtDữLiệuToolStripMenuItem.Name = "cậpNhậtDữLiệuToolStripMenuItem";
            this.cậpNhậtDữLiệuToolStripMenuItem.Size = new System.Drawing.Size(228, 36);
            this.cậpNhậtDữLiệuToolStripMenuItem.Text = "Cập nhật dữ liệu";
            // 
            // strip_ThemThongTinSanPham
            // 
            this.strip_ThemThongTinSanPham.Image = global::Desktop.Properties.Resources.lorrygreen1;
            this.strip_ThemThongTinSanPham.Name = "strip_ThemThongTinSanPham";
            this.strip_ThemThongTinSanPham.Size = new System.Drawing.Size(380, 36);
            this.strip_ThemThongTinSanPham.Text = "Thêm thông tin sản phẩm";
            this.strip_ThemThongTinSanPham.Click += new System.EventHandler(this.strip_ThemThongTinSanPham_Click);
            // 
            // strip_NhapHang
            // 
            this.strip_NhapHang.Image = global::Desktop.Properties.Resources.icons8_input_48;
            this.strip_NhapHang.Name = "strip_NhapHang";
            this.strip_NhapHang.Size = new System.Drawing.Size(380, 36);
            this.strip_NhapHang.Text = "Nhập hàng";
            this.strip_NhapHang.Click += new System.EventHandler(this.strip_NhapHang_Click);
            // 
            // strip_BanHang
            // 
            this.strip_BanHang.Image = global::Desktop.Properties.Resources.sell_icon;
            this.strip_BanHang.Name = "strip_BanHang";
            this.strip_BanHang.Size = new System.Drawing.Size(380, 36);
            this.strip_BanHang.Text = "Bán hàng";
            this.strip_BanHang.Click += new System.EventHandler(this.strip_BanHang_Click);
            // 
            // strip_QuanLiKho
            // 
            this.strip_QuanLiKho.Image = global::Desktop.Properties.Resources.find;
            this.strip_QuanLiKho.Name = "strip_QuanLiKho";
            this.strip_QuanLiKho.Size = new System.Drawing.Size(175, 36);
            this.strip_QuanLiKho.Text = "Quản lí kho";
            this.strip_QuanLiKho.Click += new System.EventHandler(this.strip_QuanLiKho_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_Time});
            this.statusStrip1.Location = new System.Drawing.Point(0, 935);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1781, 37);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip_Time
            // 
            this.toolStrip_Time.ForeColor = System.Drawing.Color.Red;
            this.toolStrip_Time.Name = "toolStrip_Time";
            this.toolStrip_Time.Size = new System.Drawing.Size(238, 32);
            this.toolStrip_Time.Text = "toolStripStatusLabel1";
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Main.Location = new System.Drawing.Point(0, 40);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1781, 895);
            this.tabControl_Main.TabIndex = 5;
            // 
            // btn_XemDonDatHang
            // 
            this.btn_XemDonDatHang.Image = global::Desktop.Properties.Resources.BTmoi;
            this.btn_XemDonDatHang.Name = "btn_XemDonDatHang";
            this.btn_XemDonDatHang.Size = new System.Drawing.Size(380, 36);
            this.btn_XemDonDatHang.Text = "Xem đơn đặt hàng";
            this.btn_XemDonDatHang.Click += new System.EventHandler(this.btn_XemDonDatHang_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1781, 972);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Phần mềm quản lí xe nâng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strip_ChinhSuaThongTinCuaHang;
        private System.Windows.Forms.ToolStripMenuItem strip_Thoat;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtDữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem strip_ThemThongTinSanPham;
        private System.Windows.Forms.ToolStripMenuItem strip_QuanLiKho;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStrip_Time;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.ToolStripMenuItem strip_NhapHang;
        private System.Windows.Forms.ToolStripMenuItem strip_BanHang;
        private System.Windows.Forms.ToolStripMenuItem btn_XemDonDatHang;
    }
}
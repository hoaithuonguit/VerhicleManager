using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        #region Event

        private void strip_DangXuat_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void strip_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void strip_ThemThongTinSanPham_Click(object sender, EventArgs e)
        {
            frmThongTinSanPham frm = new frmThongTinSanPham();            //child form
            frm.TopLevel = false;
            TabPage tp = new TabPage(frm.Text);
            tabControl_Main.TabPages.Add(tp);
            frm.Activate();
            frm.Parent = tp;
            frm.Dock = DockStyle.Fill;
            tabControl_Main.SelectedTab = tp;
            frm.Show();
        }

        private void strip_ChinhSuaThongTinCuaHang_Click(object sender, EventArgs e)
        {
            frmThongTinCuaHang frm = new frmThongTinCuaHang();
            frm.ShowDialog();
        }

        private void strip_NhapHang_Click(object sender, EventArgs e)
        {
            frmNhapHang frm = new frmNhapHang();            //child form
            frm.TopLevel = false;
            TabPage tp = new TabPage(frm.Text);
            tabControl_Main.TabPages.Add(tp);
            frm.Activate();
            frm.Parent = tp;
            frm.Dock = DockStyle.Fill;
            tabControl_Main.SelectedTab = tp;
            frm.Show();
        }

        private void strip_BanHang_Click(object sender, EventArgs e)
        {
            frmBanHang frm = new frmBanHang();            //child form
            frm.TopLevel = false;
            TabPage tp = new TabPage(frm.Text);
            tabControl_Main.TabPages.Add(tp);
            frm.Activate();
            frm.Parent = tp;
            frm.Dock = DockStyle.Fill;
            tabControl_Main.SelectedTab = tp;
            frm.Show();
        }

        private void strip_QuanLiKho_Click(object sender, EventArgs e)
        {
            frmKho frm = new frmKho();            //child form
            frm.TopLevel = false;
            TabPage tp = new TabPage(frm.Text);
            tabControl_Main.TabPages.Add(tp);
            frm.Activate();
            frm.Parent = tp;
            frm.Dock = DockStyle.Fill;
            tabControl_Main.SelectedTab = tp;
            frm.Show();
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
            toolStrip_Time.Text = DateTime.Now.ToString();
        }

    }
}

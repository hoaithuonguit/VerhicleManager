using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Infrastructure;

namespace Desktop
{
    public partial class frmThongTinCuaHang : Form
    {
        public frmThongTinCuaHang()
        {
            InitializeComponent();
        }

        #region Value
        #endregion

        private void frmThongTinCuaHang_Load(object sender, EventArgs e)
        {
            tb_DiaChi.Text = Helper.GetAddrStore();
            tb_TenCuaHang.Text = Helper.GetNameStore();
            tb_SanPham.Text = Helper.GetTitleStore();
        }
    }
}

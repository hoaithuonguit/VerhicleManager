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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        #region Event
        private void cbb_Loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_Loai.Text == "Xe nâng") tb_Loai.Text = "01";
            if (cbb_Loai.Text == "Phụ tùng") tb_Loai.Text = "02";
        }
        #endregion
    }
}

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
    public partial class frmKho : Form
    {
        public frmKho()
        {
            InitializeComponent();
        }

        private void frmKho_Load(object sender, EventArgs e)
        {
            strip_Luu.Enabled = false;
            strip_Sua.Enabled = false;
            strip_Them.Enabled = false;
            strip_Xoa.Enabled = false;
        }
    }
}

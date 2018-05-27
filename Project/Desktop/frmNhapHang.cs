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
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            dtp_NgayNhapHang.Format = DateTimePickerFormat.Custom;
            dtp_NgayNhapHang.CustomFormat = "dd/MM/yyyy";
        }
    }
}

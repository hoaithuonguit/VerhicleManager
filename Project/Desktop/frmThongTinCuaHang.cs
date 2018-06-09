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
        string Name;
        string Title;
        string Address;
        #endregion

        private void frmThongTinCuaHang_Load(object sender, EventArgs e)
        {
            tb_DiaChi.Text = Helper.GetAddrStore();
            tb_TenCuaHang.Text = Helper.GetNameStore();
            tb_SanPham.Text = Helper.GetTitleStore();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlg = MessageBox.Show("Xác nhận thay đổi thông tin cửa hàng!!", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg.Equals(DialogResult.OK))
                {
                    Name = tb_TenCuaHang.Text.ToString();
                    Address = tb_DiaChi.Text.ToString();
                    Title = tb_SanPham.Text.ToString();
                    Helper.SetStoreInformation(Name, Title, Address);
                    MessageBox.Show("Thay đổi thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }

        }
    }
}

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
using Services;

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
            ProductService sv = new ProductService();
            tb_DiaChi.Text = sv.GetAddressStore();
            tb_TenCuaHang.Text = sv.GetNameStore();
            tb_SanPham.Text = sv.GetTitleStore();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ProductService sv = new ProductService();
                DialogResult dlg = MessageBox.Show("Xác nhận thay đổi thông tin cửa hàng!!", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg.Equals(DialogResult.OK))
                {
                    Name = tb_TenCuaHang.Text.ToString();
                    Address = tb_DiaChi.Text.ToString();
                    Title = tb_SanPham.Text.ToString();
                    sv.SetStoreInformation(Name, Title, Address);
                    MessageBox.Show("Thay đổi thành công !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }

        }
    }
}

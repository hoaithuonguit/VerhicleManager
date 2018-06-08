using Data.Dtos;
using Data.Infrastructure;
using Data.Repositories;
using Services;
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
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }
        #region Value
        int ID;
        string Loai;
        DateTime NgayBan;
        #endregion
        #region Function
        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public void fillData()
        {
            ProductService sv = new ProductService();
            dgv_DuLieu.DataSource = sv.LoadAllSellInformation();
        }
        #endregion

        #region Envent
        private void frmBanHang_Load(object sender, EventArgs e)
        {
            HelperUI.autoCompleteTenSanPham(tb_TenSanPham, HelperUI.checkLoai(cbb_LoaiSanPham.Text.ToString()));
            dgv_DuLieu.AutoGenerateColumns = false;
            fillData();

        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrEmpty(cbb_LoaiSanPham.Text.ToString()))
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if(string.IsNullOrEmpty(tb_TenSanPham.Text.ToString()))
                {
                    MessageBox.Show("Vui lòng chọn tên sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_TenSanPham.Focus();
                }
                else if(string.IsNullOrEmpty(tb_SoLuong.Text.ToString()))
                {
                    MessageBox.Show("Vui lòng chọn số lượng sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_SoLuong.Focus();
                }
                else
                {
                    NgayBan= DateTime.Parse(dtp_NgayBan.Text.ToString());
                    ID = Helper.GetIDFromName(tb_TenSanPham.Text);
                    SellProductDto sell = new SellProductDto();
                    ProductRepo pro = new ProductRepo();
                    sell.ID_Product = ID;
                    sell.ProductName = tb_TenSanPham.Text.ToString();
                    sell.Quantities = Int32.Parse(tb_SoLuong.Text.ToString());
                    sell.Category = Loai;
                    sell.DateOfSale = NgayBan;
                    DialogResult dlg = MessageBox.Show("Xác nhận thông tin sản phẩm đã chính xác!!", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg.Equals(DialogResult.OK))
                    {
                        ProductService sv = new ProductService();
                        sv.SellProduct(sell, NgayBan);
                        MessageBox.Show("Đã thêm sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillData();
                        HelperUI.ResetAllControls(groupBox1);
                    }
                }

            }
            catch
            {

            }
        }

        private void cbb_LoaiSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loai = HelperUI.checkLoai(cbb_LoaiSanPham.Text.ToString());
            HelperUI.autoCompleteTenSanPham(tb_TenSanPham, Loai);
            
        }

        private void btn_Xuat_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "csv File (*.csv)|*.csv|All files (*.*)|*.*";
                sfd.Title = "Save an Excel File";
                sfd.ShowDialog();

                string DuongDan;
                DuongDan = sfd.FileName;
                List<SellProductDto> ls = new List<SellProductDto>();
                ProductService pro = new ProductService();
                ls = pro.LoadAllSellInformation();
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn xuất CSV!!", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg.Equals(DialogResult.OK))
                {
                    pro.ExportToCsvFile(ls, DuongDan);
                    MessageBox.Show("Xuất thành công!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #endregion

    }
}

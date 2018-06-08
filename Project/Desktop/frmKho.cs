using Data.Dtos;
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
using Data.Infrastructure;
using Data.Repositories;

namespace Desktop
{
    public partial class frmKho : Form
    {
        public frmKho()
        {
            InitializeComponent();
        }

        #region Value
        string Loai;
        int ID;
        #endregion

        #region Event
        private void frmKho_Load(object sender, EventArgs e)
        {
            ProductService sv = new ProductService();
            dgv_DuLieu.AutoGenerateColumns = false;
            HelperUI.autoCompleteTenSanPham(tb_TenSanPham,HelperUI.checkLoai(cbb_PhanLoai.Text.ToString()));
            dgv_DuLieu.DataSource= sv.LoadStockInformation();
        }

        private void cbb_PhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loai = HelperUI.checkLoai(cbb_PhanLoai.Text.ToString());
            HelperUI.autoCompleteTenSanPham(tb_TenSanPham, Loai);
            ProductService sv = new ProductService();
            dgv_DuLieu.DataSource = sv.GetStockInformationWithType(Loai);
        }

        private void btn_KiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_TenSanPham.Text))
                {
                    ProductService sv = new ProductService();
                    dgv_DuLieu.DataSource = sv.GetStockInformationWithType(Loai);
                }
                else
                {
                    
                    ProductService sv = new ProductService();
                    ID = sv.GetIDProduct(tb_TenSanPham.Text.ToString());
                    List<StockDto> ls = new List<StockDto>();
                    ls= sv.GetStockInformationOfProduct(ID);
                    dgv_DuLieu.DataSource = ls;
                }
            }
            catch
            {
                //MessageBox.Show("..");
            }
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
                List<StockDto> ls = new List<StockDto>();
                ProductService pro = new ProductService();
                ls = pro.LoadStockInformation();
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

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
    public partial class frmNhapHang : Form
    {
        public frmNhapHang()
        {
            InitializeComponent();
        }
        #region Value
        int ID;
        string Loai;
        string TinhTrang;
        string PhanLoai;
        string Type;
        #endregion

        #region Function

        public void ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        public void fillData()
        {
            ProductRepo pro = new ProductRepo();
            dgv_DuLieu.DataSource = pro.GetImportInformation();
        }
        #endregion
        #region GetCbb
        private void cbb_Loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loai = HelperUI.checkLoai(cbb_Loai.Text);
            if (Loai.Equals("01"))
            {
                Type = "TypeV";
                HelperUI.loadData_cbbPhanLoai(cbb_PhanLoai, Type);
            }

            else
            {
                Type = "Type";
                HelperUI.loadData_cbbPhanLoai(cbb_PhanLoai, Type);
            }
            HelperUI.autoCompleteTenSanPham(tb_TenSanPham,Loai);
        }

        private void cbb_TinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductService sv = new ProductService();
            TinhTrang = sv.GetCodeNameOfStatus(cbb_TinhTrang.Text.ToString());
        }

        private void cbb_PhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductService sv = new ProductService();
            PhanLoai = sv.GetCodeNameOfClassification(cbb_PhanLoai.Text.ToString());
        }
        #endregion
        #region Event
        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            HelperUI.loadData_cbbTinhTrang(cbb_TinhTrang);
            dgv_DuLieu.AutoGenerateColumns = false;
            fillData();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ImportProductDto pro = new ImportProductDto();
                ProductService sv = new ProductService();
                if(string.IsNullOrEmpty(cbb_Loai.Text))
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm !!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbb_Loai.Focus();
                }
                else if (string.IsNullOrEmpty(tb_TenSanPham.Text))
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm !!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_TenSanPham.Focus();
                }
                else if(string.IsNullOrEmpty(dtp_NgayNhapHang.Text))
                {
                    MessageBox.Show("Vui lòng chọn ngày nhập hàng!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtp_NgayNhapHang.Focus();
                }
                else if (string.IsNullOrEmpty(tb_SoLuong.Text))
                {
                    MessageBox.Show("Vui lòng nhập số lượng sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_SoLuong.Focus();
                }
                else if (string.IsNullOrEmpty(cbb_TinhTrang.Text))
                {
                    MessageBox.Show("Vui lòng chọn tình trạng sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbb_TinhTrang.Focus();
                }
                else if (string.IsNullOrEmpty(tb_Hang.Text))
                {
                    MessageBox.Show("Vui lòng nhập hãng sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Hang.Focus();
                }
                else if (string.IsNullOrEmpty(tb_MoTa.Text))
                {
                    MessageBox.Show("Vui lòng nhập mô tả sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_MoTa.Focus();
                }
                else if (string.IsNullOrEmpty(cbb_PhanLoai.Text))
                {
                    MessageBox.Show("Vui lòng chọn phân loại sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbb_PhanLoai.Focus();
                }
                else
                {
                    DateTime NgayNhap = dtp_NgayNhapHang.Value;
                    int SoLuong = Int32.Parse(tb_SoLuong.Text.ToString());
                    pro.Category = Loai;
                    pro.Status = TinhTrang;
                    pro.Classification = PhanLoai;
                    pro.ProductName = tb_TenSanPham.Text.ToString();
                    pro.ID_Product = Helper.GetIDFromName(tb_TenSanPham.Text.ToString());
                    pro.Label = tb_Hang.Text.ToString();
                    pro.Description = tb_MoTa.Text.ToString();
                    pro.Quantities = SoLuong;
                    DialogResult dlg = MessageBox.Show("Xác nhận thông tin nhập hàng đã chính xác!!", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg.Equals(DialogResult.OK))
                    {
                        sv.ImportProduct(pro, NgayNhap);
                        fillData();
                        MessageBox.Show("Đã thêm thông tin sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        HelperUI.ResetAllControls(groupBox1);
                    }
                }
            }
            catch
            {
                //MessageBox.Show("..");
            }
        }

        private void dgv_DuLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            ID = Int32.Parse(dgv_DuLieu.Rows[numrow].Cells[0].Value.ToString());
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
                List<ImportProductDto> ls = new List<ImportProductDto>();
                ProductService pro = new ProductService();
                ls = pro.LoadAllImportInformation();
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

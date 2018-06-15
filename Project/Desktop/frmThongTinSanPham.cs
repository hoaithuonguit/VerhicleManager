using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Data.Dtos;
using Services;
using Data.Infrastructure;
using Data.Repositories;
using Data.Model;
namespace Desktop
{
    public partial class frmThongTinSanPham : Form
    {
        public frmThongTinSanPham()
        {
            InitializeComponent();
        }


        #region Value
        int ID;
        string Loai;
        string PhanLoai;
        string TinhTrang;
        string Type;
        #endregion
        #region Function
        public void fillData()
        {
            List<ProductDto> ls = new List<ProductDto>();
            ProductRepo pro = new ProductRepo();
            ProductService sv = new ProductService();
            ls = sv.GetAllProduct(Loai);
            dgv_DuLieu.DataSource = ls;
        }
  
        public void resetControl()
        {
            tb_Doi.Text = string.Empty;
            tb_HangSanXuat.Text = string.Empty;
            tb_Hieu.Text = string.Empty;
            tb_MoTa.Text = string.Empty;
            tb_TenSanPham.Text = string.Empty;
            cbb_PhanLoai.Text = string.Empty;
            cbb_TinhTrang.Text = string.Empty;
        }
        #endregion
     
        #region GetCbb
        //Không thay đổi trừ Admin
        //Lấy Value - Key ""
        private void cbb_Loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loai=HelperUI.checkLoai(cbb_Loai.Text);
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

            fillData();
        }

        private void cbb_PhanLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductService sv = new ProductService();
            PhanLoai = sv.GetCodeNameOfClassification(cbb_PhanLoai.Text.ToString());
        }

        private void cbb_TinhTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductService sv = new ProductService();
            TinhTrang = sv.GetCodeNameOfStatus(cbb_TinhTrang.Text.ToString());
        }
        #endregion
        #region Envent
        //Fix MoTa 10/06/2018 4:34pm - Done
        private void btn_XuatExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "csv File (*.csv)|*.csv|All files (*.*)|*.*";
                sfd.Title = "Save an Excel File";
                sfd.ShowDialog();

                string DuongDan;
                DuongDan = sfd.FileName;
                List<ProductDto> ls = new List<ProductDto>();
                ProductService pro = new ProductService();
                ls = pro.GetAllProduct(Loai);
                DialogResult dlg = MessageBox.Show("Bạn có chắc chắn xuất CSV!!", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg.Equals(DialogResult.OK))
                {
                    pro.ExportToCsvFile(ls, DuongDan);
                    MessageBox.Show("Xuất thành công!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }

        }

        private void frmThongTinSanPham_Load(object sender, EventArgs e)
        {
            HelperUI.loadData_cbbTinhTrang(cbb_TinhTrang);
            //HelperUI.loadData_cbbPhanLoai(cbb_PhanLoai);
            dgv_DuLieu.AutoGenerateColumns = false;
            dgv_DuLieu.ForeColor = Color.Black;
        }

        private void strip_Them_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDto pro = new ProductDto();
                ProductService sv = new ProductService();
                if(string.IsNullOrEmpty(cbb_Loai.Text))
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbb_Loai.Focus();
                }
                else if (string.IsNullOrEmpty(tb_TenSanPham.Text))
                {
                    MessageBox.Show("Vui lòng điền tên sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_TenSanPham.Focus();
                }
                else if (string.IsNullOrEmpty(tb_Hieu.Text))
                {
                    MessageBox.Show("Vui lòng điền hiệu sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Hieu.Focus();
                }
                else if (string.IsNullOrEmpty(tb_Doi.Text))
                {
                    MessageBox.Show("Vui lòng điền đời sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Doi.Focus();
                }
                else if (string.IsNullOrEmpty(tb_HangSanXuat.Text))
                {
                    MessageBox.Show("Vui lòng điền hãng sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_HangSanXuat.Focus();
                }
                else if (string.IsNullOrEmpty(cbb_PhanLoai.Text))
                {
                    MessageBox.Show("Vui lòng chọn phân loại sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(cbb_TinhTrang.Text))
                {
                    MessageBox.Show("Vui lòng chọn tình trạng sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    pro.Doi = tb_Doi.Text.ToString();
                    pro.Hang = tb_HangSanXuat.Text.ToString();
                    pro.Hieu = tb_Hieu.Text.ToString();
                    pro.Ten = tb_TenSanPham.Text.ToString();
                    pro.MoTa = tb_MoTa.Text.ToString();
                    pro.Loai = Loai;
                    pro.PhanLoai = PhanLoai;
                    pro.TinhTrang = TinhTrang;
                    DialogResult dlg = MessageBox.Show("Xác nhận thông tin sản phẩm đã chính xác!!", "Thông báo!!", MessageBoxButtons.OKCancel , MessageBoxIcon.Information);
                    if(dlg.Equals(DialogResult.OK))
                    {
                        sv.AddProduct(pro, Loai);
                        MessageBox.Show("Đã thêm sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillData();
                        resetControl();
                    }
                }
                              
            }
            catch
            {
                //MessageBox.Show("..");
            }
        }

        private void strip_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                ProductDto pro = new ProductDto();
                ProductService sv = new ProductService();
                if (string.IsNullOrEmpty(cbb_Loai.Text))
                {
                    MessageBox.Show("Vui lòng chọn loại sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbb_Loai.Focus();
                }
                else if (string.IsNullOrEmpty(tb_TenSanPham.Text))
                {
                    MessageBox.Show("Vui lòng điền tên sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_TenSanPham.Focus();
                }
                else if (string.IsNullOrEmpty(tb_Hieu.Text))
                {
                    MessageBox.Show("Vui lòng điền hiệu sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Hieu.Focus();
                }
                else if (string.IsNullOrEmpty(tb_Doi.Text))
                {
                    MessageBox.Show("Vui lòng điền đời sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_Doi.Focus();
                }
                else if (string.IsNullOrEmpty(tb_HangSanXuat.Text))
                {
                    MessageBox.Show("Vui lòng điền hãng sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_HangSanXuat.Focus();
                }
                else if (string.IsNullOrEmpty(tb_MoTa.Text))
                {
                    MessageBox.Show("Vui lòng điền mô tả sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tb_MoTa.Focus();
                }
                else if (string.IsNullOrEmpty(cbb_PhanLoai.Text))
                {
                    MessageBox.Show("Vui lòng chọn phân loại sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (string.IsNullOrEmpty(cbb_TinhTrang.Text))
                {
                    MessageBox.Show("Vui lòng chọn tình trạng sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    pro.ID = ID;
                    pro.Doi = tb_Doi.Text.ToString();
                    pro.Hang = tb_HangSanXuat.Text.ToString();
                    pro.Hieu = tb_Hieu.Text.ToString();
                    pro.Ten = tb_TenSanPham.Text.ToString();
                    pro.MoTa = tb_MoTa.Text.ToString();
                    pro.Loai = Loai;
                    pro.PhanLoai = PhanLoai;
                    pro.TinhTrang = TinhTrang;
                    
                    DialogResult dlg = MessageBox.Show("Xác nhận thông tin sản phẩm đã chính xác!!", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (dlg.Equals(DialogResult.OK))
                    {
                        sv.EditVehicle(pro);
                            MessageBox.Show("Đã sửa thông tin sản phẩm!!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            fillData();
                            HelperUI.ResetAllControls(groupBox1);
                    }
                }

            }
            catch
            {
                MessageBox.Show("..");
            }
        }

        private void dgv_DuLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                ID = Int32.Parse(dgv_DuLieu.Rows[numrow].Cells[0].Value.ToString());
                tb_TenSanPham.Text = dgv_DuLieu.Rows[numrow].Cells[2].Value.ToString();
                cbb_Loai.Text = dgv_DuLieu.Rows[numrow].Cells[1].Value.ToString();
                tb_Hieu.Text = dgv_DuLieu.Rows[numrow].Cells[3].Value.ToString();
                tb_Doi.Text = dgv_DuLieu.Rows[numrow].Cells[4].Value.ToString();
                tb_HangSanXuat.Text = dgv_DuLieu.Rows[numrow].Cells[5].Value.ToString();
                tb_MoTa.Text = dgv_DuLieu.Rows[numrow].Cells[6].Value.ToString();
                cbb_PhanLoai.Text = dgv_DuLieu.Rows[numrow].Cells[8].Value.ToString();
                cbb_TinhTrang.Text = dgv_DuLieu.Rows[numrow].Cells[7].Value.ToString();
            }
            catch
            {
                  
            }
        }

        #endregion
    }


}

using Data.Dtos;
using Data.Repositories;
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
    public partial class frmDonDatHang : Form
    {
        public frmDonDatHang()
        {
            InitializeComponent();
        }

        #region Value
        int ID;
        //string Status;
        #endregion
        #region Envent
        private void btn_Duyet_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlg = MessageBox.Show("Xác nhận duyệt đơn hàng!!", "Thông báo!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dlg.Equals(DialogResult.OK))
                {
                    ProductService sv = new ProductService();
                    sv.ChangeStatusOfOrder(ID, "01");
                    MessageBox.Show("Ok!!");
                    List<OrderDetailDto> ls = new List<OrderDetailDto>();
                    ls = sv.GetAllOrdersAreWaiting();
                    dgv_DuLieu.DataSource = ls;
                    HelperUI.ResetAllControls(groupBox1);
                }

            }
            catch
            {

            }
            
            
        }

        private void cbb_TrangThai_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProductService sv = new ProductService();
            List<OrderDetailDto> ls = new List<OrderDetailDto>();
            if(cbb_TrangThai.Text.Equals("Đã duyệt"))
            {
                ls = sv.GetAllOrdersAreCensorred();
                dgv_DuLieu.DataSource = ls;
                btn_Duyet.Enabled = false;
            }
            else
            //if(cbb_TrangThai.Text.Equals("Đang chờ"))
            {
                ls = sv.GetAllOrdersAreWaiting();
                dgv_DuLieu.DataSource = ls;
                btn_Duyet.Enabled = true;
            }
        }

        private void frmDonDatHang_Load(object sender, EventArgs e)
        {
            ProductService sv = new ProductService();
            List<OrderDetailDto> ls = new List<OrderDetailDto>();
            dgv_DuLieu.AutoGenerateColumns = false;
            ls = sv.GetAllOrdersAreWaiting();
            dgv_DuLieu.DataSource = ls;
            dgv_DuLieu.ForeColor = Color.Black;
        }

        private void dgv_DuLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int numrow;
                numrow = e.RowIndex;
                ID = Int32.Parse(dgv_DuLieu.Rows[numrow].Cells[0].Value.ToString());
                tb_TenNguoiDat.Text = dgv_DuLieu.Rows[numrow].Cells[1].Value.ToString();
                tb_ThoiGian.Text = dgv_DuLieu.Rows[numrow].Cells[6].Value.ToString();
                tb_TenHang.Text = dgv_DuLieu.Rows[numrow].Cells[5].Value.ToString();
                tb_SoLuong.Text = dgv_DuLieu.Rows[numrow].Cells[7].Value.ToString();
                tb_SDT.Text = dgv_DuLieu.Rows[numrow].Cells[2].Value.ToString();
                tb_DiaChi.Text = dgv_DuLieu.Rows[numrow].Cells[4].Value.ToString();
                tb_Email.Text= dgv_DuLieu.Rows[numrow].Cells[3].Value.ToString();
            }
            catch
            {

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
                List<OrderDetailDto> ls = new List<OrderDetailDto>();
                ProductService pro = new ProductService();
                ls = pro.GetAllOrdersAreWaiting();
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

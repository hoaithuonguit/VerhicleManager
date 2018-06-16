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

namespace Desktop
{
    public partial class frmMasterData : Form
    {
        public frmMasterData()
        {
            InitializeComponent();
        }
        #region Value
        string Loai;
        #endregion
        #region Event
        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(tb_Ten.Text.ToString())) MessageBox.Show("Vui lòng điền tên loại sản phẩm !!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    ProductService sv = new ProductService();
                    sv.AddType(Loai, tb_Ten.Text.ToString());
                    MessageBox.Show("Thêm thành công !!", "Thông báo!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    List<MasterDataDto> ls = new List<MasterDataDto>();
                    if (Loai.Equals("01"))
                    {
                        ls = sv.GetAllTypeOfVehicle();
                        dgv_DuLieu.DataSource = ls;
                    }
                    else
                    {
                        ls = sv.GetAllTypeOfAccessory();
                        dgv_DuLieu.DataSource = ls;
                    }
                }
            }
            catch
            {

            }
        }

        private void cbb_Loai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loai=HelperUI.checkLoai(cbb_Loai.Text.ToString());
            ProductService sv = new ProductService();
            List<MasterDataDto> ls = new List<MasterDataDto>();
            if(Loai.Equals("01"))
            {
                ls = sv.GetAllTypeOfVehicle();
                dgv_DuLieu.DataSource = ls;
            }
            else
            {
                ls = sv.GetAllTypeOfAccessory();
                dgv_DuLieu.DataSource = ls;
            }
        }
        #endregion
    }
}

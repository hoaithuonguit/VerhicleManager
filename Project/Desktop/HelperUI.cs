using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using Data.Model;
using Data.Dtos;
using Data.Infrastructure;
using Data.Repositories;
using Services;

namespace Desktop
{
    class HelperUI
    {
        #region Function
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                }

                if (control is ComboBox)
                {
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = 0;
                }

                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }

                if (control is ListBox)
                {
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                }

                //if (control is RadioButton)
                //{
                //    RadioButton radioButton = (RadioButton)control;
                //    radioButton.Checked = false;
                //}
                if (control is DateTimePicker)
                {
                    DateTimePicker dateTimePicker = (DateTimePicker)control;
                    dateTimePicker.ResetText();
                }
                if (control is PictureBox)
                {
                    PictureBox pictureBox = (PictureBox)control;
                    pictureBox.Hide();
                }
            }
        }

        public static string GetTypeID(string type)
        {
            return type.Equals("Xe nâng") ? "01" : "02";
        }

        public static string checkStatus(string status)
        {
            return status.Equals("01") ? "Đã duyệt" : "Đang chờ";
        }

        public static string checkLoai(string type)
        {
            return type.Equals("Xe nâng") ? "01" : "02";
        }

        #endregion

        #region Load Combobox
        public static void loadData_cbbPhanLoai(ComboBox cbb)
        {
            List<string> itemList = new List<string>();
            ProductService sv = new ProductService();
            itemList = sv.GetAllClassification();
            cbb.DataSource = itemList;
        }

        public static void loadData_cbbPhanLoai(ComboBox cbb, string Type)
        {
            List<string> itemList = new List<string>();
            ProductService sv = new ProductService();
            XeNangEntities conText = new XeNangEntities();
            var query = from a in conText.MasterDatas where a.Keys.Equals(Type) select a.Value;
            itemList = query.ToList();
            cbb.DataSource = itemList;
        }

        public static void loadData_cbbTinhTrang(ComboBox cbb)
        {
            List<string> itemList = new List<string>();
            ProductService sv = new ProductService();
            itemList = sv.GetAllStatus();
            cbb.DataSource = itemList;
        }

        public static void loadCombobox_PhanLoai(ComboBox cbb, string Type, string key)
        {
            /// cần fix
            AutoCompleteStringCollection itemList = new AutoCompleteStringCollection();
            //List<string> itemList = new List<string>();
            ProductService sv = new ProductService();
            //itemList = sv.GetListProductNameLike(Type, cbb.Text.ToString());
            cbb.DataSource = itemList;
        }

        #endregion

        #region AutoComplete
        public static void autoCompleteTenSanPham(TextBox tb, string Loai)
        {
            AutoCompleteStringCollection itemList = new AutoCompleteStringCollection();
            ProductService sv = new ProductService();
            itemList.AddRange(sv.GetAllProductName(Loai));
            tb.AutoCompleteCustomSource = itemList;
        }

        public static void autoCompleteTenSanPham(TextBox tb)
        {
            AutoCompleteStringCollection itemList = new AutoCompleteStringCollection();
            ProductService sv = new ProductService();
            itemList.AddRange(sv.GetAllProductName());
            tb.AutoCompleteCustomSource = itemList;
        }

        #endregion

    }
}

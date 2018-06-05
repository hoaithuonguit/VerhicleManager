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

namespace Desktop
{
    public partial class frmThongTinSanPham : Form
    {
        public frmThongTinSanPham()
        {
            InitializeComponent();
        }

        private void frmThongTinSanPham_Load(object sender, EventArgs e)
        {
            //string ConString = @"Data Source=DESKTOP-LUHFR97\SQLEXPRESS;Initial Catalog=XeNang;Integrated Security=True";

            //using (SqlConnection con = new SqlConnection(ConString))
            //{
            //    SqlCommand cmd = new SqlCommand("SELECT Name FROM MasterData", con);
            //    con.Open();
            //    SqlDataReader reader = cmd.ExecuteReader();
            //    AutoCompleteStringCollection MyCollection = new AutoCompleteStringCollection();
            //    while (reader.Read())
            //    {
            //        MyCollection.Add(reader.GetString(0));
            //    }
            //    tb_TenSanPham.AutoCompleteCustomSource = MyCollection;
            //    con.Close();
            }
    }

        
    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSoftware.Accounting
{
    public partial class ProductSearchFrm : Form
    {
        public ProductSearchFrm()
        {
            InitializeComponent();
        }

        private void ProductSearchFrm_Load(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter1.Connection.ConnectionString = AccountingSoftware.Properties.Settings.Default.main_connection_string;
                this.productsTableAdapter1.Fill_All(this.accDs1.Products);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            
        }

        private void search_id_button1_Click(object sender, EventArgs e)
        {
            Int32 searchById;
            Int32.TryParse(this.search_id_textBox1.Text, out searchById);
            this.productsTableAdapter1.Connection.ConnectionString = AccountingSoftware.Properties.Settings.Default.main_connection_string;
            this.productsTableAdapter1.FillBy_id(this.accDs1.Products, searchById);
        }
        private void search_productId_button2_Click(object sender, EventArgs e)
        {
            string searchByProductName = "%" + this.search_productName_textBox2.Text + "%";
            this.productsTableAdapter1.Connection.ConnectionString = AccountingSoftware.Properties.Settings.Default.main_connection_string;
            this.productsTableAdapter1.FillBy_productName(this.accDs1.Products, searchByProductName);
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter1.Connection.ConnectionString = AccountingSoftware.Properties.Settings.Default.main_connection_string;
            this.productsTableAdapter1.Fill_All(this.accDs1.Products);
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
        private void cancle_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

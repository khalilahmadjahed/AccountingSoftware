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
    public partial class CustomerSearchFrm : Form
    {
        public CustomerSearchFrm()
        {
            InitializeComponent();
        }
        private void CustomerSearchFrm_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter1.Fill_All(this.accDs1.Customers);
        }

        private void search_id_button1_Click(object sender, EventArgs e)
        {
            Int32 id;
            Int32.TryParse(this.search_id_textBox1.Text, out id);
            this.customersTableAdapter1.FillBy_id(accDs1.Customers, id);
        }

        private void search_lName_button2_Click(object sender, EventArgs e)
        {
            string searchByLastName;
            searchByLastName = "%" + this.search_lName_textBox2.Text + "%";
            this.customersTableAdapter1.FillBy_lastName(accDs1.Customers, searchByLastName);
        }

        private void ok_btn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void showAll_btn_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter1.Fill_All(this.accDs1.Customers);
        }
    }
}

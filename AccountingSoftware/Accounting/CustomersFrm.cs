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
    public partial class CustomersFrm : Form
    {
        public CustomersFrm()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void CustomersFrm_Load(object sender, EventArgs e)
        {
            this.customersTableAdapter1.Fill_All(this.accDs1.Customers); 
        }
    }
}

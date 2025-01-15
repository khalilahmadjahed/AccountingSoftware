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
    public partial class SalesInvoiceList : Form
    {
        public SalesInvoiceList()
        {
            InitializeComponent();
        }

        private void SalesInvoiceList_Load(object sender, EventArgs e)
        {
            try
            {
                this.salesInvoiceTableAdapter1.Fill_All(this.accDs1.SalesInvoice);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
             AccountingSoftware.Accounting.SalesInvoiceFrm frm = new SalesInvoiceFrm();

            Int32 id;
            Int32.TryParse(this.invoiceId_txtBox.Text, out id);
            frm.sel_invoice_id = id;
            frm.ShowDialog();
            //-----------------

            SalesInvoiceList_Load(sender, e);
        }
    }
}

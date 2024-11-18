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
    public partial class SalesInvoiceFrm : Form
    {
        public SalesInvoiceFrm()
        {
            InitializeComponent();
        }

        private void SalesInvoiceFrm_Load(object sender, EventArgs e)
        {
            save_cancle_btns();
            this.salesInvoiceTableAdapter1.Fill_All(this.accDs1.SalesInvoice);
        }

        void new_edit_delete_btns()
        {
            //disable the new, edit and delete buttons
            this.new_btn.Enabled = false;
            this.edit_btn.Enabled = false;
            this.del_btn.Enabled = false;

            //Enable the save and cancle buttons
            this.save_btn.Enabled = true;
            this.cancel_btn.Enabled = true;

            //-----------------------
            this.groupBox1.Enabled = true;

            //-------------------------
            this.reg_user_label.Text = "Admin";
            this.reg_date_label.Text = DateTime.Now.ToShortDateString();
            this.reg_time_label.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        void save_cancle_btns()
        {
            //disable the save and cancle buttons
            this.save_btn.Enabled = false;
            this.cancel_btn.Enabled = false;

            //Enable the new, edit and delete buttons
            this.new_btn.Enabled = true;
            this.edit_btn.Enabled = true;
            this.del_btn.Enabled = true;

            //------------------------
            this.groupBox1.Enabled = false;
        }
        private void new_btn_Click(object sender, EventArgs e)
        {

            //Add new Invoice
            this.bindingSource1.AddNew();

            //-------------------------
            new_edit_delete_btns();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            new_edit_delete_btns();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            new_edit_delete_btns();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.bindingSource1.EndEdit();
                int returnValue = 0;
                returnValue = this.salesInvoiceTableAdapter1.Update(this.accDs1.SalesInvoice);

                //-------------------
                if (returnValue > 0)
                {
                    save_cancle_btns();
                    MessageBox.Show("It's saved: count:" + returnValue.ToString());
                }
                else
                {
                    MessageBox.Show("Not saved!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            save_cancle_btns();

            //--------------------
            this.bindingSource1.CancelEdit();
            this.accDs1.SalesInvoice.RejectChanges();
        }

        private void customerSearch_btn_Click(object sender, EventArgs e)
        {
            AccountingSoftware.Accounting.CustomerSearchFrm CSFrm = new CustomerSearchFrm(); //CSFrm ==> Customer Search Form
            CSFrm.ShowDialog();

            if (CSFrm.DialogResult == DialogResult.OK)
            {
                this.customerId_txtBox.Text = CSFrm.id_lbl.Text;
                string firstLastName = CSFrm.firstName_lbl.Text + " _ " + CSFrm.lastName_lbl.Text;
                this.customerName_txtBox.Text = firstLastName;
            }
            

        }
    }
}

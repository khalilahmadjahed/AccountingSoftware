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
    public partial class SpendMoneyFrm : Form
    {
        public SpendMoneyFrm()
        {
            InitializeComponent();
        }

        Boolean is_del_btn = false;

        //-------------------------
        public Int32 selectedPurchaseId = 0;
        public Int32 selectedCustomerId = 0;
        public String selectedCustomerName = "";

        //this function will Enable the Save and Cancle buttons after clicking the New, Edit or Delete buttons
        void new_edit_delete_btn()
        {
            //Disabled the New, Edit and Delete buttons
            this.new_btn.Enabled = false;
            this.edit_btn.Enabled = false;
            this.del_btn.Enabled = false;
            //Enabled the Save and Cancle buttons
            this.save_btn.Enabled = true;
            this.cancel_btn.Enabled = true;

            //----------------------
            this.dataGridView1.Enabled = false;
            if (is_del_btn == false)
            {
                this.groupBox1.Enabled = true;
            }
            else
            {
                this.groupBox1.Enabled = false;
            }
        }

        //this function will Enable the New, Edit and Delete buttons after clicking the Save or Cancle buttons
        void save_cancle_btns()
        {
            //Disabled the Save and Cancle buttons
            this.save_btn.Enabled = false;
            this.cancel_btn.Enabled = false;
            //Enabled New, Edit and Delete buttons
            this.new_btn.Enabled = true;
            this.edit_btn.Enabled = true;
            this.del_btn.Enabled = true;

            //------------------------
            this.dataGridView1.Enabled = true;
            this.groupBox1.Enabled = false;
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            is_del_btn = false;

            //Add new Invoice
            this.bindingSource1.AddNew();

            //-------------------------
            this.purchaseId_txtBox.Text = selectedPurchaseId.ToString();
            this.customerId_txtBox.Text = selectedCustomerId.ToString();
            this.customerName_txtBox.Text = selectedCustomerName.ToString();
            //-------------------------

            //invoice date 
            this.spendDate_dtp.Value = DateTime.Now;

            //-------------------------
            new_edit_delete_btn();
            //-------------------------

            //Reg_user, Reg_Date and Reg_time
            this.reg_user_label.Text = "Login User";
            this.reg_date_label.Text = DateTime.Now.ToShortDateString();
            this.reg_time_label.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            is_del_btn = false;
            new_edit_delete_btn();

            //-------------------------
            if (selectedPurchaseId <= 0) //Direct access
            {
            }
            else // Access due to sales invoice form
            {
                this.purchaseId_txtBox.Text = selectedPurchaseId.ToString();
                this.customerId_txtBox.Text = selectedCustomerId.ToString();
                this.customerName_txtBox.Text = selectedCustomerName.ToString();
            }
            //-------------------------

            //Reg_user, Reg_Date and Reg_time
            this.reg_user_label.Text = "Login User";
            this.reg_date_label.Text = DateTime.Now.ToShortDateString();
            this.reg_time_label.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void SpendMoneyFrm_Load(object sender, EventArgs e)
        {
            save_cancle_btns();

            //------------------
            if (selectedPurchaseId <= 0)
            {
                this.spendMoneyTableAdapter1.Fill_All(this.accDs1.SpendMoney);//Load all data
                this.customerSearch_btn.Enabled = true;
            }
            else
            {
                this.spendMoneyTableAdapter1.FillBy_PurchaseId(this.accDs1.SpendMoney, selectedPurchaseId);
                this.customerSearch_btn.Enabled = false;
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            is_del_btn = true;
            new_edit_delete_btn();
            //Remove a row
            try
            {
                this.bindingSource1.RemoveCurrent();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //---------------------------Select the customer
            if (is_del_btn == false)
            {
                if (this.customerName_txtBox.Text == "")
                {
                    MessageBox.Show("Please Select your customer!");
                    return;
                }
            }

            //---------------------------

            try
            {
                this.comment_txtBox.Focus();
                //-----------------------
                this.bindingSource1.EndEdit();
                int returnValue = 0;
                returnValue = this.spendMoneyTableAdapter1.Update(this.accDs1.SpendMoney);

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
            this.accDs1.SpendMoney.RejectChanges();
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

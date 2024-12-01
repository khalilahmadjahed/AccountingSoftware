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
            this.salesInvoiceTableAdapter1.Fill_All(this.accDs1.SalesInvoice);//Remove at the end

            //--------Load invoice products----------//Remove at the end
            int selectedInvoiceId = int.Parse(this.invoiceId_txtBox.Text);
            this.salesInvoiceProductsTableAdapter1.FillBy_InvoiceId(this.accDs1.SalesInvoiceProducts, selectedInvoiceId);

            //--------------------------------------------------
            AllSumCalc(); //Remove at the end
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

            //invoice date 
            this.invoiceDate_dtp.Value = DateTime.Now;
            //-------------------------
            new_edit_delete_btns();
            //-------------------------
            //Reg_user, Reg_Date and Reg_time
            this.reg_user_label.Text = "Login User";
            this.reg_date_label.Text = DateTime.Now.ToShortDateString();
            this.reg_time_label.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            new_edit_delete_btns();
            //-------------------------
            //Reg_user, Reg_Date and Reg_time 
            this.reg_user_label.Text = "Login User";
            this.reg_date_label.Text = DateTime.Now.ToShortDateString();
            this.reg_time_label.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            new_edit_delete_btns();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            //---------------------------Select the customer
            if (this.customerName_txtBox.Text == "")
            {
                MessageBox.Show("Please Select your customer!");
                return;
            }
            //---------------------------

            try
            {
                this.bindingSource1.EndEdit();
                int returnValue = 0;
                returnValue = this.salesInvoiceTableAdapter1.Update(this.accDs1.SalesInvoice);

                //-------------------
                if (returnValue > 0)
                {
                    save_cancle_btns();

                    AllSumCalc(); //this function will asign the sum of colmns to the numericUpDowns!
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
                this.customerId_lbl.Text = CSFrm.id_lbl.Text;
                string firstLastName = CSFrm.firstName_lbl.Text + " _ " + CSFrm.lastName_lbl.Text;
                this.customerName_txtBox.Text = firstLastName;
            }
        }

        private void productList_btn_Click(object sender, EventArgs e)
        {
            //---------------------------
            if (this.invoiceId_txtBox.Text == "")
            {
                MessageBox.Show("Please save your invoice!");
                return;
            }
            //---------------------------
            int invoiceId;
            invoiceId = int.Parse(this.invoiceId_txtBox.Text);
            if (invoiceId <= 0)
            {
                MessageBox.Show("Please save your invoice!");
                return;
            }
            //---------------------------Select the customer
            if (this.customerName_txtBox.Text == "")
            {
                MessageBox.Show("Please Select your customer!");
                return;
            }
            //---------------------------

            AccountingSoftware.Accounting.SalesInvoiceProductsFrm SIPFrm = new SalesInvoiceProductsFrm(); //SIPFrm ==> Sales Invoice Product form
            SIPFrm.selected_invoice_id = int.Parse(this.invoiceId_txtBox.Text);
            SIPFrm.ShowDialog();

            //--------Load invoice products----------
            int selectedInvoiceId;
            selectedInvoiceId = int.Parse(this.invoiceId_txtBox.Text);
            this.salesInvoiceProductsTableAdapter1.FillBy_InvoiceId(this.accDs1.SalesInvoiceProducts, selectedInvoiceId);

            AllSumCalc();

        }
        //this function will asign the sum of colmns to the numericUpDowns!
        void AllSumCalc()
        {
            try
            {
                //--------Load invoice products----------
                int selectedInvoiceId;
                selectedInvoiceId = int.Parse(this.invoiceId_txtBox.Text);
                this.salesInvoiceProductsTableAdapter1.FillBy_InvoiceId(this.accDs1.SalesInvoiceProducts, selectedInvoiceId);

                //Calculate Sum of Colnms
                decimal totalAmount, totalTaxSum, totalNetAmount, shipping, other, total, paidCash, totalDue;
                //------------calc sum of amount--------------
                totalAmount = CalculateSum("Amount");
                this.amount_nud.Value = totalAmount;

                //------------calc sum of tax sum-------------
                totalTaxSum = CalculateSum("TaxSum");
                this.taxSum_nud.Value = totalTaxSum;

                //------------calc sum of net amount-------------
                totalNetAmount = totalAmount + totalTaxSum;
                this.netAmount_nud.Value = totalNetAmount;

                //------------shipping and other numericUpDown-------------
                // shipping and other which are on the top, in the data grid view
                shipping = this.shipping_numericUpDown1.Value;
                other = this.other_numericUpDown1.Value;

                //shipping and other which are on the botton
                this.shipping_nud.Value = shipping;
                this.other_nud.Value = other;

                //------------calc the total ==> netAmount + shipping + other
                total = totalNetAmount + shipping + other;
                this.total_nud.Value = total;

                //--------Load Receive Money----------
                selectedInvoiceId = int.Parse(this.invoiceId_txtBox.Text);
                this.receiveMoneyTableAdapter1.FillBy_InvoiceId(this.accDs1.ReceiveMoney, selectedInvoiceId);

                //--------Calc sum----------

                this.payTotal_nud.Value = total;
                //--------------------------

                paidCash = CalculateReceiveMoneySum();
                this.paidAmount_nud.Value = paidCash;
                //--------------------------
                totalDue = total - paidCash;
                if (totalDue < 0)
                {
                    this.totalDue_nud.Minimum = totalDue;
                }
                else
                {
                    this.totalDue_nud.Minimum = 0;
                }
                this.totalDue_nud.Value = totalDue;
                  
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }

        decimal CalculateReceiveMoneySum()
        {
            decimal d_totalCols;
            object totalCols;
            totalCols = this.accDs1.ReceiveMoney.Compute("sum(CashAmount)", "");

            //-------------------------
            if (totalCols != DBNull.Value)
            {
                d_totalCols = decimal.Parse(totalCols.ToString());
            }
            else
            {
                d_totalCols = 0;
            }
            return d_totalCols;
        }

        //this function will calculate the sum of same colmns
        decimal CalculateSum(string colName)
        {
            decimal d_totalCols;
            object totalCols;
            totalCols = this.accDs1.SalesInvoiceProducts.Compute("sum(" + colName + ")", "");

            //-------------------------
            if (totalCols != DBNull.Value)
            {
                d_totalCols = decimal.Parse(totalCols.ToString());
            }
            else
            {
                d_totalCols = 0;
            }
            return d_totalCols;
        }

        private void receiveMoney_btn_Click(object sender, EventArgs e)
        {
            if (this.invoiceId_txtBox.Text == "")
            {
                MessageBox.Show("Please save your invoice!");
                return;
            }
            //----------------
            int id = int.Parse(this.invoiceId_txtBox.Text);
            if (id <= 0)
            {
                MessageBox.Show("Please save your invoice!");
                return;
            }

            //-----------------
            if(this.customerName_txtBox.Text == "")
            {
                MessageBox.Show("Please select your customer!");
                return;
            }


            AccountingSoftware.Accounting.ReceiveMoneyFrm RMFrm = new ReceiveMoneyFrm(); //RMFrm ==> Receive Money form

            //------------------
            RMFrm.selectedInvoiceId = Int32.Parse(this.invoiceId_txtBox.Text);
            RMFrm.selectedCustomerId = Int32.Parse(this.customerId_lbl.Text);
            RMFrm.selectedCustomerName = this.customerName_txtBox.Text;       
            //------------------

            RMFrm.ShowDialog();

            //--------Load Receive Money----------
            int selectedInvoiceId;
            selectedInvoiceId = int.Parse(this.invoiceId_txtBox.Text);
            this.receiveMoneyTableAdapter1.FillBy_InvoiceId(this.accDs1.ReceiveMoney, selectedInvoiceId);

            AllSumCalc();
        }
    }
}

﻿using System;
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
    public partial class SalesInvoiceProductsFrm : Form
    {
        public SalesInvoiceProductsFrm()
        {
            InitializeComponent();
        }

        Boolean is_del_btn = false;
        public int selected_invoice_id = 0;

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

        private void SalesInvoiceProductsFrm_Load(object sender, EventArgs e)
        {
            save_cancle_btns();

            try
            {
                this.salesInvoiceProductsTableAdapter1.Connection.ConnectionString = AccountingSoftware.Properties.Settings.Default.main_connection_string;
                this.salesInvoiceProductsTableAdapter1.FillBy_InvoiceId(this.accDs1.SalesInvoiceProducts, selected_invoice_id);
                //this.salesInvoiceProductsTableAdapter1.Fill_All(this.accDs1.SalesInvoiceProducts);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }
           
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            is_del_btn = false;
            new_edit_delete_btn();
            //Add a row
            this.bindingSource3.AddNew();
            //---------------------
            this.invoiceId_lbl.Text = selected_invoice_id.ToString();
            //---------------------
            //Reg_user, Reg_Date and Reg_time
            this.reg_user_label.Text = AccountingSoftware.Properties.Settings.Default.login_user_name;
            this.reg_date_label.Text = DateTime.Now.ToShortDateString();
            this.reg_time_label.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            is_del_btn = false;
            new_edit_delete_btn();
            //---------------------
            this.invoiceId_lbl.Text = selected_invoice_id.ToString();
            //--------------------- 
            //Reg_user, Reg_Date and Reg_time
            this.reg_user_label.Text = AccountingSoftware.Properties.Settings.Default.login_user_name;
            this.reg_date_label.Text = DateTime.Now.ToShortDateString();
            this.reg_time_label.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            is_del_btn = true;
            new_edit_delete_btn();
            //Remove a row
            this.bindingSource3.RemoveCurrent();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.bindingSource3.EndEdit();
                int returnValue = 0;
                this.salesInvoiceProductsTableAdapter1.Connection.ConnectionString = AccountingSoftware.Properties.Settings.Default.main_connection_string;
                returnValue = this.salesInvoiceProductsTableAdapter1.Update(this.accDs1.SalesInvoiceProducts);
                //--------------
                if (returnValue > 0)
                {
                    save_cancle_btns();
                    MessageBox.Show("It's saved! count: " + returnValue.ToString());
                }
                else
                {
                    MessageBox.Show("Not saved!");
                }
                //--------------
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            save_cancle_btns();
            //---------------
            this.bindingSource3.CancelEdit();
            this.accDs1.SalesInvoiceProducts.RejectChanges();
        }

        private void productSearch_btn_Click(object sender, EventArgs e)
        {
            AccountingSoftware.Accounting.ProductSearchFrm PSFrm = new ProductSearchFrm(); //PSFrm ==> Product Search Form
            PSFrm.ShowDialog();
            if (PSFrm.DialogResult == DialogResult.OK)
            {
                this.productId_txtBox.Text = PSFrm.id_lbl.Text;
                this.productName_txtBox.Text = PSFrm.productName_lbl.Text;

                //unit-price-discount--------------
                this.unit_txtBox.Text = PSFrm.unit_lbl.Text; ;
                this.unitPrice_nud.Value = decimal.Parse(PSFrm.price_lbl.Text);
                this.discount_nud.Value = decimal.Parse(PSFrm.discount_lbl.Text);
                //---------------------------------
                sum_calc();
            }
        }

        public void sum_calc()
        {
            if (this.save_btn.Enabled == false)
            {
                return;
            }
            //--------------------------------------
            try
            {
                decimal amount, net_amount, tax_rate, tax_sum;

                //amount
                amount = (this.qty_nud.Value * this.unitPrice_nud.Value) - this.discount_nud.Value;
                this.amount_nud.Value = amount;

                //tax_sum
                tax_rate = AccountingSoftware.Properties.Settings.Default.sett_salesTax;
                tax_sum = (amount * tax_rate) / 100;

                //-----------------------------------
                this.taxRate_nud.Value = tax_rate;
                this.taxSum_nud.Value = tax_sum;

                //total
                net_amount = amount + tax_sum;
                this.netAmount_nud.Value = net_amount;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void qty_nud_ValueChanged(object sender, EventArgs e)
        {
            sum_calc();
        }

        private void qty_nud_KeyUp(object sender, KeyEventArgs e)
        {
            sum_calc();
        }

        private void unitPrice_nud_ValueChanged(object sender, EventArgs e)
        {
            sum_calc();
        }

        private void unitPrice_nud_KeyUp(object sender, KeyEventArgs e)
        {
            sum_calc();
        }

        private void discount_nud_ValueChanged(object sender, EventArgs e)
        {
            sum_calc();
        }

        private void discount_nud_KeyUp(object sender, KeyEventArgs e)
        {
            sum_calc();
        }

        //-------------------------------------------
        private void taxRate_btn_Click(object sender, EventArgs e)
        {
            AccountingSoftware.Accounting.SettingsFrm SettFrm = new SettingsFrm(); //SettFrm ==> Setting form
            SettFrm.ShowDialog();
            this.taxRate_nud.Value = AccountingSoftware.Properties.Settings.Default.sett_salesTax;
        }
    }
}

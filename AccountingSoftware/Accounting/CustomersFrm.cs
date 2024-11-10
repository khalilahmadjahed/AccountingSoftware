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

        Boolean is_del_btn = false;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void CustomersFrm_Load(object sender, EventArgs e)
        {
            save_cancle_btns();
            this.customersTableAdapter1.Fill_All(this.accDs1.Customers);
        }

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
            new_edit_delete_btn();
            //Add a row
            this.bindingSource1.AddNew();
            
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            is_del_btn = false;
            new_edit_delete_btn();
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            is_del_btn = true;
            new_edit_delete_btn();
            //Remove a row
            this.bindingSource1.RemoveCurrent();
           
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            try
            {
                this.bindingSource1.EndEdit();
                int returnValue;
                returnValue = this.customersTableAdapter1.Update(this.accDs1.Customers);
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
            this.bindingSource1.CancelEdit();
            this.accDs1.Customers.RejectChanges();
        }
    }
}

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
    public partial class SettingsFrm : Form
    {
        public SettingsFrm()
        {
            InitializeComponent();
        }

        private void save_and_exit_button1_Click(object sender, EventArgs e)
        {
            try
            {
                AccountingSoftware.Properties.Settings.Default.sett_companyName = this.companyName_txtBox.Text;
                AccountingSoftware.Properties.Settings.Default.sett_manager = this.manager_txtBox.Text;
                AccountingSoftware.Properties.Settings.Default.sett_landLine = this.landLine_txtBox.Text;
                AccountingSoftware.Properties.Settings.Default.sett_cellNumber = this.cellNumber_txtBox.Text;
                AccountingSoftware.Properties.Settings.Default.sett_address = this.address_txtBox.Text;
                AccountingSoftware.Properties.Settings.Default.sett_webSite = this.webSite_txtBox.Text;
                //--------------------------
                AccountingSoftware.Properties.Settings.Default.sett_salesTax = Double.Parse(this.salesTax_txtBox.Text);
                AccountingSoftware.Properties.Settings.Default.sett_billTax = double.Parse(this.billTax_textBox.Text);
                //--------------------------
                AccountingSoftware.Properties.Settings.Default.Save();
                MessageBox.Show("It's saved!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

        private void SettingsFrm_Load(object sender, EventArgs e)
        {
            try
            {
                this.companyName_txtBox.Text = AccountingSoftware.Properties.Settings.Default.sett_companyName;
                this.manager_txtBox.Text = AccountingSoftware.Properties.Settings.Default.sett_manager;
                this.landLine_txtBox.Text = AccountingSoftware.Properties.Settings.Default.sett_landLine;
                this.cellNumber_txtBox.Text = AccountingSoftware.Properties.Settings.Default.sett_cellNumber;
                this.address_txtBox.Text = AccountingSoftware.Properties.Settings.Default.sett_address;
                this.webSite_txtBox.Text = AccountingSoftware.Properties.Settings.Default.sett_webSite;
                //--------------------------
                this.salesTax_txtBox.Text = AccountingSoftware.Properties.Settings.Default.sett_salesTax.ToString();
                this.billTax_textBox.Text = AccountingSoftware.Properties.Settings.Default.sett_salesTax.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
    }
}

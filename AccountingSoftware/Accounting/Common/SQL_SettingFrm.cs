using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSoftware.Accounting.Common
{
    public partial class SQL_SettingFrm : Form
    {
        public SQL_SettingFrm()
        {
            InitializeComponent();
        }

        private void rest_button1_Click(object sender, EventArgs e)
        {
            this.cs_textBox1.Text = AccountingSoftware.Properties.Settings.Default.default_connection_string;
        }

        private void SQL_SettingFrm_Load(object sender, EventArgs e)
        {
            this.cs_textBox1.Text = AccountingSoftware.Properties.Settings.Default.main_connection_string;
        }

        private void save_exit_button1_Click(object sender, EventArgs e)
        {
            AccountingSoftware.Properties.Settings.Default.main_connection_string = this.cs_textBox1.Text;
            AccountingSoftware.Properties.Settings.Default.Save();
            this.DialogResult = DialogResult.OK;
        }

        private void test_connection_button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter1.Connection.ConnectionString = this.cs_textBox1.Text;
                this.usersTableAdapter1.Fill(this.accDs1.Users);
                MessageBox.Show("Connection string is valid!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error! Connection string is not valid! " + ex.Message);
            }
        }
    }
}

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter1.Fill(this.accDs1.Users);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.user_password_txtBox.Text == this.correct_pass_txtBox.Text)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("The password is incorrect! Please try again!");
            }
        }
    }
}

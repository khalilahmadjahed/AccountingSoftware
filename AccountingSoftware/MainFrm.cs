using AccountingSoftware.Accounting;
using AccountingSoftware.Accounting.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccountingSoftware
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }

        private void min_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dateTime_lbl_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.dateTime_lbl.Text = DateTime.Now.ToShortDateString() + " | " + DateTime.Now.ToLongTimeString();

        }

        private void background_comBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string fn;
                fn = Application.StartupPath + "Data\\Pictures\\" + this.background_comBox.SelectedIndex.ToString() + ".jpg";
                this.BackgroundImage = Image.FromFile(fn);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void cls_btn_Click(object sender, EventArgs e)
        {
            //save the bck image after clicked the close button
            AccountingSoftware.Properties.Settings.Default.sel_img_index = this.background_comBox.SelectedIndex;
            AccountingSoftware.Properties.Settings.Default.Save();

            //Close the program
            this.Close();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            try
            {
                //-------------------- Load bck image -----------------------
                int index;
                index = AccountingSoftware.Properties.Settings.Default.sel_img_index;
                //--------------
                this.background_comBox.SelectedIndex = index;
                //-----------------------------------------------------------

                AccountingSoftware.Accounting.Common.Login frm = new Login();
                DialogResult dr = frm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    this.user_label1.Text = frm.users_comboBox1.Text;
                    this.user_pictureBox1.Image = frm.photo_pictureBox1.Image;
                    //---------------------save user name in settings---------
                    AccountingSoftware.Properties.Settings.Default.login_user_name = this.user_label1.Text;
                    AccountingSoftware.Properties.Settings.Default.Save();
                    //-------------------------------------------------------


                }
                if (dr == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //Expand the accounting tree view
        private void expand_btn_Click(object sender, EventArgs e)
        {
            this.acc_treeView.ExpandAll();
        }

        //Collapse the accounting tree view
        private void collapse_btn_Click(object sender, EventArgs e)
        {
            this.acc_treeView.CollapseAll();
        }

        private void Accounting_btn_Click(object sender, EventArgs e)
        {
            if (this.treeView_panel1.Visible == true)
            {
                this.treeView_panel1.Visible = false;
            }
            else
            {
                this.treeView_panel1.Visible = true;
            }
        }

        private void acc_treeView_DoubleClick(object sender, EventArgs e)
        {
            this.treeView_panel1.Visible = false;

            //Customers Form
            if (this.acc_treeView.SelectedNode.Name == "Customers")
            {
                AccountingSoftware.Accounting.CustomersFrm CFrm = new CustomersFrm(); // CFrm == Customers Form
                CFrm.MdiParent = this;
                CFrm.Show();
            }

            //Products Form
            if (this.acc_treeView.SelectedNode.Name == "products")
            {
                AccountingSoftware.Accounting.ProductsFrm PFrm = new ProductsFrm(); // PFrm == Products Form
                PFrm.MdiParent = this;
                PFrm.Show();
            }

            //Sales_Invoice
            if (this.acc_treeView.SelectedNode.Name == "Sales_Invoice")
            {
                AccountingSoftware.Accounting.SalesInvoiceFrm SIFrm = new SalesInvoiceFrm();
                SIFrm.MdiParent = this;
                SIFrm.Show();
            }

            //Receive_Money
            if (this.acc_treeView.SelectedNode.Name == "Receive_Money")
            {
                AccountingSoftware.Accounting.ReceiveMoneyFrm RMFrm = new ReceiveMoneyFrm(); //RmFrm ==> Receive Money Form

                RMFrm.selectedInvoiceId = 0;
                RMFrm.selectedCustomerId = 0;
                RMFrm.selectedCustomerName = "";

                RMFrm.MdiParent = this;
                RMFrm.Show();
            }

            //Purchase_Bill
            if (this.acc_treeView.SelectedNode.Name == "Purchase_Bill")
            {
                AccountingSoftware.Accounting.PurchaseBillFrm frm = new PurchaseBillFrm();
                frm.MdiParent = this;
                frm.Show();
            }

            //Spend_Money
            if (this.acc_treeView.SelectedNode.Name == "Spend_Money")
            {
                AccountingSoftware.Accounting.SpendMoneyFrm frm = new SpendMoneyFrm();
                frm.MdiParent = this;
                frm.Show();
            }

            //Cost
            if (this.acc_treeView.SelectedNode.Name == "Cost")
            {
                AccountingSoftware.Accounting.CostFrm frm = new CostFrm();
                frm.MdiParent = this;
                frm.Show();
            }

        }

        private void tools_btn_Click(object sender, EventArgs e)
        {
            Point settingPoint;
            settingPoint = new Point(this.tools_btn.Left, this.top_panel1.Height);
            this.tools_contextMenu.Show(settingPoint);
        }

        private void settings_MenuItem_Click(object sender, EventArgs e)
        {
            AccountingSoftware.Accounting.SettingsFrm SFrm = new SettingsFrm(); // SFrm == Settings Form
            SFrm.MdiParent = this;
            SFrm.Show();
        }

        private void acc_treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void report_btn_Click(object sender, EventArgs e)
        {
            Point p;
            p = new Point(this.report_btn.Left, this.top_panel1.Height);
            this.rep_cm.Show(p);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AccountingSoftware.Accounting.SalesInvoiceList SILFrm = new SalesInvoiceList(); // SILFrm == Sales Invoice List Form
            SILFrm.MdiParent = this;
            SILFrm.Show();
        }

        private void purchaseBillListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountingSoftware.Accounting.PurchaseBillListFrm PBLFrm = new PurchaseBillListFrm(); // SILFrm == Sales Invoice List Form
            PBLFrm.MdiParent = this;
            PBLFrm.Show();
        }

        private void users_toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AccountingSoftware.Accounting.Common.Users usersFrm = new Users(); // Users form
            usersFrm.MdiParent = this;
            usersFrm.Show();
        }

        private void about_us_toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            AccountingSoftware.Accounting.Common.AboutusFrm aboutUsFrm = new AboutusFrm(); // About US form
            //aboutUsFrm.MdiParent = this;
            aboutUsFrm.ShowDialog();
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            Point helpPoint;
            helpPoint = new Point(this.help_btn.Left, this.top_panel1.Height);
            this.about_cm.Show(helpPoint);
        }

        private void MainFrm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                Accounting_btn_Click(sender, e);
                this.acc_treeView.Focus();
            }
            if (e.KeyCode == Keys.F3)
            {
                report_btn_Click(sender, e);
            }
            if (e.KeyCode == Keys.F4)
            {
                tools_btn_Click(sender, e);
            }
            if (e.KeyCode == Keys.F5)
            {
                help_btn_Click(sender, e);
            }
        }

        private void acc_treeView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                acc_treeView_DoubleClick(sender, e);
            }
        }
    }
}

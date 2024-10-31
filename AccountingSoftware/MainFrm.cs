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
            //-------------------- Load bck image -----------------------
            int index;
            index = AccountingSoftware.Properties.Settings.Default.sel_img_index;
            //--------------
            this.background_comBox.SelectedIndex = index;
            //-----------------------------------------------------------
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
    }
}

using iText.Layout;
using iText.Layout.Borders;
using iText.Kernel.Colors;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;

using System;
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

        public Int32 sel_invoice_id;
        private void SalesInvoiceFrm_Load(object sender, EventArgs e)
        {
            save_cancle_btns();
            // ------------------

            this.salesInvoiceTableAdapter1.FillBy_invoice_id(this.accDs1.SalesInvoice, sel_invoice_id);

            //--------Load invoice products----------

            if (sel_invoice_id > 0)
            {
                this.salesInvoiceProductsTableAdapter1.FillBy_InvoiceId(this.accDs1.SalesInvoiceProducts, sel_invoice_id);

                //--------------------------------------------------
                AllSumCalc();
            }

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
            if (this.customerName_txtBox.Text == "")
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

        private void print_toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.accDs1.SalesInvoiceProducts.Rows.Count == 0)
            {
                MessageBox.Show("No row to Print!");
                return;
            }
            //--------------------
            this.prog_panel1.Visible = true;
            this.prog_label9.Text = "Exporting to Pdf ...";
            this.prog_panel1.Refresh();
            //--------------------
            try
            {
                //------------------------

                string fn;
                fn = Application.StartupPath + "data\\rep.pdf";
                PdfWriter writer = new PdfWriter(fn);

                PdfDocument pdf_doc = new PdfDocument(writer);

                Document final_doc = new Document(pdf_doc);
                //-------------
                pdf_doc.SetDefaultPageSize(iText.Kernel.Geom.PageSize.A4);
                //--------add title----------
                string com_name;
                com_name = AccountingSoftware.Properties.Settings.Default.sett_companyName;
                iText.Layout.Element.Paragraph title = new Paragraph(com_name);
                title.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
                title.SimulateBold();
                title.SetBorder(new iText.Layout.Borders.SolidBorder(ColorConstants.BLACK, 1));
                title.SetWidth(170);
                title.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                title.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                title.SetHeight(30);
                title.SetVerticalAlignment(VerticalAlignment.MIDDLE);
                //------
                final_doc.Add(title);
                //--------add subtitle-------
                iText.Layout.Element.Paragraph sub_title = new Paragraph("Invoice");
                //sub_title.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
                //sub_title.SetBold();
                sub_title.SetBorder(new iText.Layout.Borders.SolidBorder(ColorConstants.BLACK, 1));
                sub_title.SetWidth(150);
                sub_title.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
                sub_title.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                sub_title.SetHeight(25);
                sub_title.SetVerticalAlignment(VerticalAlignment.MIDDLE);
                //------
                final_doc.Add(sub_title);
                //--------add bill to-----
                string a;
                a = "Bill to: ID: " + this.customerId_lbl.Text.ToString() + " | " + this.customerName_txtBox.Text;
                iText.Layout.Element.Paragraph fs = new Paragraph(a);
                final_doc.Add(fs);

                //-------invoice data---------- 
                a = "Invoice ID: " + this.invoiceId_txtBox.Text + " | " + this.invoiceDate_dtp.Text;
                iText.Layout.Element.Paragraph fs_invoice = new Paragraph(a);
                final_doc.Add(fs_invoice);
                //--------add line seperator-
                iText.Layout.Element.LineSeparator ls = new LineSeparator(new SolidLine(1));
                final_doc.Add(ls);
                //--------add 2nd free space-----
                iText.Layout.Element.Paragraph fs2 = new Paragraph("");
                fs2.SetHeight(10);
                final_doc.Add(fs2);
                //---------------------------
                //=========Add table header ==================
                Table tbl = new Table(13, true);
                //----------------------
                table_header_loader(tbl, "ID", 1);
                table_header_loader(tbl, "Product Name", 2);
                table_header_loader(tbl, "Qty", 1);
                table_header_loader(tbl, "Unit", 1);
                table_header_loader(tbl, "Price", 1);
                table_header_loader(tbl, "Discount", 1);
                table_header_loader(tbl, "Amount", 1);
                table_header_loader(tbl, "Tax Sum", 1);
                table_header_loader(tbl, "Net Amount", 2);
                table_header_loader(tbl, "Comment", 2);
                //----------------------

                //==============add table data==============================
                for (int row_index = 0; row_index < this.accDs1.SalesInvoiceProducts.Rows.Count; row_index++)
                {
                    this.bindingSource3.Position = row_index;
                    table_data_loader(tbl, this.pro_id_txtBox.Text, 1, TextAlignment.CENTER);
                    table_data_loader(tbl, this.productName_txtBox.Text, 2, TextAlignment.LEFT);
                    table_data_loader(tbl, this.qty_nud.Text, 1, TextAlignment.LEFT);
                    table_data_loader(tbl, this.unit_txtBox.Text, 1, TextAlignment.CENTER);

                    //-------------
                    table_data_loader(tbl, "$ " + this.unitPrice_nud.Value.ToString("F"), 1, TextAlignment.CENTER);
                    table_data_loader(tbl, "$ " + this.discount_nud.Value.ToString("F"), 1, TextAlignment.CENTER);
                    table_data_loader(tbl, "$ " + this.amount_nud.Value.ToString("F"), 1, TextAlignment.CENTER);
                    table_data_loader(tbl, "$ " + this.tax_sum_numericUpDown2.Value.ToString("F"), 1, TextAlignment.CENTER);
                    table_data_loader(tbl, "$ " + this.net_amount_numericUpDown1.Value.ToString("F"), 2, TextAlignment.CENTER);

                    //-------------
                    table_data_loader(tbl, this.pro_comment_textBox1.Text, 2, TextAlignment.LEFT);

                    //--------------------
                    this.prog_label9.Text = "Saving Pdf " + row_index.ToString() + " of " + this.accDs1.SalesInvoiceProducts.Rows.Count.ToString();
                    this.prog_panel1.Refresh();
                    //--------------------
                }

                //==========================================================
                final_doc.Add(tbl);
                //--------2nd add line seperator------
                iText.Layout.Element.LineSeparator ls2 = new LineSeparator(new SolidLine(1));
                final_doc.Add(ls);
                //--------footer
                footer_loader("Amount: $ " + this.amount_nud.Value.ToString("F"), final_doc);
                footer_loader("+ Tax Sum: $ " + this.taxSum_nud.Value.ToString("F"), final_doc);
                footer_loader("= Net amount: $ " + this.netAmount_nud.Value.ToString("F"), final_doc);
                footer_loader("+ Shipping: $ " + this.shipping_nud.Value.ToString("F"), final_doc);
                footer_loader("+ Other: $ " + this.other_nud.Value.ToString("F"), final_doc);
                footer_loader("= Total: $ " + this.total_nud.Value.ToString("F"), final_doc);
                footer_loader("- Paid Amount: $ " + this.paidAmount_nud.Value.ToString("F"), final_doc);
                footer_loader("= Total Due: $ " + this.totalDue_nud.Value.ToString("F"), final_doc);




                //---------------
                final_doc.Close();
                //------------------------
                this.prog_panel1.Visible = false;
                //------------------------
                //MessageBox.Show("It's done!");

                AccountingSoftware.Accounting.PrintPreviewFrm frm = new PrintPreviewFrm();
                frm.webView21.Source = new Uri(fn);
                frm.Show();

            }
            catch (Exception ex)
            {
                this.prog_panel1.Visible = false;
                //------------------------
                MessageBox.Show("Error: " + ex.ToString());
            }
            //--------------------
            this.prog_panel1.Visible = false;
            //this.prog_label9.Text = "Preparing Excel ...";
            //this.prog_panel1.Refresh();
            //--------------------
        }

        void footer_loader(string txt, Document final_doc)
        {
            iText.Layout.Element.Paragraph fs_footer = new Paragraph(txt);
            fs_footer.SetWidth(158);
            fs_footer.SetBorder(new iText.Layout.Borders.SolidBorder(ColorConstants.BLACK, 1));
            fs_footer.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT);
            fs_footer.SetFontSize(8);
            fs_footer.SetPadding(1);
            fs_footer.SetMargin(0);
            final_doc.Add(fs_footer);
        }
        void table_header_loader(Table tbl, string cell_text, int col_span)
        {

            Cell cl = new Cell(1, col_span);
            //-------
            cl.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            //cl.SetBold();
            cl.SetBorder(new iText.Layout.Borders.SolidBorder(ColorConstants.BLACK, 1));
            //cl.SetWidth(150);
            cl.SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER);
            //cl.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
            cl.SetHeight(20);
            cl.SetVerticalAlignment(VerticalAlignment.MIDDLE);
            cl.SetFontSize(8);
            cl.Add(new Paragraph(cell_text));

            //----------------------
            tbl.AddCell(cl);
        }

        void table_data_loader(Table tbl, string cell_text, int col_span, TextAlignment text_align)
        {
            Cell cl = new Cell(1, col_span);
            //-------
            //cl.SetBackgroundColor(iText.Kernel.Colors.ColorConstants.LIGHT_GRAY);
            //cl.SetBold();
            cl.SetBorder(new iText.Layout.Borders.SolidBorder(ColorConstants.BLACK, 1));
            //cl.SetWidth(150);
            cl.SetTextAlignment(text_align);
            //cl.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
            cl.SetHeight(20);
            cl.SetVerticalAlignment(VerticalAlignment.MIDDLE);
            cl.SetFontSize(7);
            cl.Add(new Paragraph(cell_text));
            //----------------------
            tbl.AddCell(cl);
        }
    }
}

﻿using iText.Layout;
using iText.Layout.Borders;
using iText.Kernel.Colors;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Kernel.Pdf;
using iText.Layout.Element;
using iText.Layout.Properties;
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
    public partial class ReceiveMoneyFrm : Form
    {
        public ReceiveMoneyFrm()
        {
            InitializeComponent();
        }

        Boolean is_del_btn = false;

        //-------------------------
        public Int32 selectedInvoiceId = 0;
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
            this.invoiceId_txtBox.Text = selectedInvoiceId.ToString();
            this.customerId_txtBox.Text = selectedCustomerId.ToString();
            this.customerName_txtBox.Text = selectedCustomerName.ToString();
            //-------------------------

            //invoice date 
            this.paymentDate_dtp.Value = DateTime.Now;

            //-------------------------
            new_edit_delete_btn();
            //-------------------------

            //Reg_user, Reg_Date and Reg_time
            this.reg_user_label.Text = AccountingSoftware.Properties.Settings.Default.login_user_name;
            this.reg_date_label.Text = DateTime.Now.ToShortDateString();
            this.reg_time_label.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            is_del_btn = false;
            new_edit_delete_btn();

            //-------------------------
            if (selectedInvoiceId <= 0) //Direct access
            {
            }
            else // Access due to sales invoice form
            {
                this.invoiceId_txtBox.Text = selectedInvoiceId.ToString();
                this.customerId_txtBox.Text = selectedCustomerId.ToString();
                this.customerName_txtBox.Text = selectedCustomerName.ToString();
            }
            //-------------------------

            //Reg_user, Reg_Date and Reg_time
            this.reg_user_label.Text = AccountingSoftware.Properties.Settings.Default.login_user_name;
            this.reg_date_label.Text = DateTime.Now.ToShortDateString();
            this.reg_time_label.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void ReceiveMoneyFrm_Load(object sender, EventArgs e)
        {
            save_cancle_btns();

            try
            {
                //------------------
                if (selectedInvoiceId <= 0)
                {
                    this.receiveMoneyTableAdapter1.Connection.ConnectionString = AccountingSoftware.Properties.Settings.Default.main_connection_string;
                    this.receiveMoneyTableAdapter1.Fill_All(this.accDs1.ReceiveMoney);//Load all data
                    this.customerSearch_btn.Enabled = true;
                }
                else
                {
                    this.receiveMoneyTableAdapter1.Connection.ConnectionString = AccountingSoftware.Properties.Settings.Default.main_connection_string;
                    this.receiveMoneyTableAdapter1.FillBy_InvoiceId(this.accDs1.ReceiveMoney, selectedInvoiceId);
                    this.customerSearch_btn.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message);
            }

            

            //--------Load invoice products----------//Remove at the end
            // int selectedInvoiceId = int.Parse(this.invoiceId_txtBox.Text);
            ////this.receiveMoneyTableAdapter1.FillBy_InvoiceId(this.accDs1.SalesInvoiceProducts, selectedInvoiceId);

            //--------------------------------------------------
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
                this.receiveMoneyTableAdapter1.Connection.ConnectionString = AccountingSoftware.Properties.Settings.Default.main_connection_string;
                returnValue = this.receiveMoneyTableAdapter1.Update(this.accDs1.ReceiveMoney);

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
            this.accDs1.ReceiveMoney.RejectChanges();
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

        private void pdf_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.accDs1.ReceiveMoney.Rows.Count == 0)
            {
                MessageBox.Show("No row to save as PDF!");
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
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Pdf Files|*.pdf";

                if (sf.ShowDialog() == DialogResult.OK)
                {
                    PdfWriter writer = new PdfWriter(sf.FileName);
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
                    iText.Layout.Element.Paragraph sub_title = new Paragraph("Recive Money Report");
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
                    //--------add free space-----
                    iText.Layout.Element.Paragraph fs = new Paragraph("");
                    fs.SetHeight(10);
                    final_doc.Add(fs);
                    //--------add line seperator-
                    iText.Layout.Element.LineSeparator ls = new LineSeparator(new SolidLine(1));
                    final_doc.Add(ls);
                    //--------add 2nd free space-----
                    iText.Layout.Element.Paragraph fs2 = new Paragraph("");
                    fs2.SetHeight(10);
                    final_doc.Add(fs2);
                    //---------------------------
                    //=========Add table header ==================
                    Table tbl = new Table(8, true);
                    //----------------------
                    table_header_loader(tbl, "ID", 1);
                    table_header_loader(tbl, "Customer Name", 2);
                    table_header_loader(tbl, "Date", 1);
                    table_header_loader(tbl, "Amount", 1);
                    table_header_loader(tbl, "Comment", 3);
                    //----------------------

                    //==============add table data==============================
                    for (int row_index = 0; row_index < this.accDs1.ReceiveMoney.Rows.Count; row_index++)
                    {
                        this.bindingSource1.Position = row_index;
                        table_data_loader(tbl, this.paymentId_txtBox.Text, 1, TextAlignment.CENTER);
                        table_data_loader(tbl, this.customerName_txtBox.Text, 2, TextAlignment.LEFT);
                        table_data_loader(tbl, this.paymentDate_dtp.Text, 1, TextAlignment.LEFT);
                        //-------------
                        string sv = "";
                        decimal dc;
                        if (this.amount_nud.Value.ToString() == "")
                        {
                            sv = "";
                        }
                        else
                        {
                            dc = this.amount_nud.Value;
                            sv = "$ " + dc.ToString("F");
                        }
                        //-------------
                        table_data_loader(tbl, sv, 1, TextAlignment.CENTER);
                        table_data_loader(tbl, this.comment_txtBox.Text, 3, TextAlignment.LEFT);

                        //--------------------
                        this.prog_label9.Text = "Saving Pdf " + row_index.ToString() + " of " + this.accDs1.Cost.Rows.Count.ToString();
                        this.prog_panel1.Refresh();
                        //--------------------
                    }
                    ///--------------

                    //==========================================================
                    final_doc.Add(tbl);
                    //--------2nd add line seperator------
                    iText.Layout.Element.LineSeparator ls2 = new LineSeparator(new SolidLine(1));
                    final_doc.Add(ls);
                    //--------
                    //---------------
                    final_doc.Close();
                    //------------------------
                    this.prog_panel1.Visible = false;
                    //------------------------
                    MessageBox.Show("It's done!");
                }
                else
                {
                    this.prog_panel1.Visible = false;
                    //------------------------
                    MessageBox.Show("Invalid Pdf file!");
                }

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
            //cl.SetFontSize(9);
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
            cl.SetFontSize(9);
            cl.Add(new Paragraph(cell_text));
            //----------------------
            tbl.AddCell(cl);
        }

        private void print_toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.accDs1.ReceiveMoney.Rows.Count == 0)
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
                iText.Layout.Element.Paragraph sub_title = new Paragraph("Recive Money Report");
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
                //--------add free space-----
                iText.Layout.Element.Paragraph fs = new Paragraph("");
                fs.SetHeight(10);
                final_doc.Add(fs);
                //--------add line seperator-
                iText.Layout.Element.LineSeparator ls = new LineSeparator(new SolidLine(1));
                final_doc.Add(ls);
                //--------add 2nd free space-----
                iText.Layout.Element.Paragraph fs2 = new Paragraph("");
                fs2.SetHeight(10);
                final_doc.Add(fs2);
                //---------------------------
                //=========Add table header ==================
                Table tbl = new Table(8, true);
                //----------------------
                table_header_loader(tbl, "ID", 1);
                table_header_loader(tbl, "Customer Name", 2);
                table_header_loader(tbl, "Date", 1);
                table_header_loader(tbl, "Amount", 1);
                table_header_loader(tbl, "Comment", 3);
                //----------------------

                //==============add table data==============================
                for (int row_index = 0; row_index < this.accDs1.ReceiveMoney.Rows.Count; row_index++)
                {
                    this.bindingSource1.Position = row_index;
                    table_data_loader(tbl, this.paymentId_txtBox.Text, 1, TextAlignment.CENTER);
                    table_data_loader(tbl, this.customerName_txtBox.Text, 2, TextAlignment.LEFT);
                    table_data_loader(tbl, this.paymentDate_dtp.Text, 1, TextAlignment.LEFT);
                    //-------------
                    string sv = "";
                    decimal dc;
                    if (this.amount_nud.Value.ToString() == "")
                    {
                        sv = "";
                    }
                    else
                    {
                        dc = this.amount_nud.Value;
                        sv = "$ " + dc.ToString("F");
                    }
                    //-------------
                    table_data_loader(tbl, sv, 1, TextAlignment.CENTER);
                    table_data_loader(tbl, this.comment_txtBox.Text, 3, TextAlignment.LEFT);

                    //--------------------
                    this.prog_label9.Text = "Saving Pdf " + row_index.ToString() + " of " + this.accDs1.Cost.Rows.Count.ToString();
                    this.prog_panel1.Refresh();
                    //--------------------
                }
                ///--------------

                //==========================================================
                final_doc.Add(tbl);
                //--------2nd add line seperator------
                iText.Layout.Element.LineSeparator ls2 = new LineSeparator(new SolidLine(1));
                final_doc.Add(ls);
                //--------
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

        private void excel_printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //--------------------
                this.prog_panel1.Visible = true;
                this.prog_label9.Text = "Exporting to Excel ...";
                this.prog_panel1.Refresh();
                //--------------------
                //------------------------
                SaveFileDialog sf = new SaveFileDialog();
                sf.Filter = "Excel Files|*.xlsx";

                if (sf.ShowDialog() == DialogResult.OK)
                {
                    //------------------------
                    ClosedXML.Excel.XLWorkbook wb = new ClosedXML.Excel.XLWorkbook();
                    wb.AddWorksheet(this.accDs1.ReceiveMoney, "MySheet");
                    wb.SaveAs(sf.FileName);
                    //------------------------
                    this.prog_panel1.Visible = false;
                    //------------------------
                    MessageBox.Show("It's done!");
                }
                else
                {
                    //------------------------
                    this.prog_panel1.Visible = false;
                    //------------------------
                    MessageBox.Show("Invalid excel file!");
                }

            }
            catch (Exception ex)
            {
                this.prog_panel1.Visible = false;
                MessageBox.Show("Error: " + ex.ToString());
            }
            //------------------------
            this.prog_panel1.Visible = false;
            //------------------------
        }
    }
}

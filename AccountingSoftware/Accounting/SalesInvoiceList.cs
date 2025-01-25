using iText.Layout;
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
    public partial class SalesInvoiceList : Form
    {
        public SalesInvoiceList()
        {
            InitializeComponent();
        }

        private void SalesInvoiceList_Load(object sender, EventArgs e)
        {
            try
            {
                this.salesInvoiceTableAdapter1.Connection.ConnectionString = AccountingSoftware.Properties.Settings.Default.main_connection_string;
                this.salesInvoiceTableAdapter1.Fill_All(this.accDs1.SalesInvoice);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error! " + ex.Message);
            }
        }

        private void new_btn_Click(object sender, EventArgs e)
        {
            AccountingSoftware.Accounting.SalesInvoiceFrm frm = new SalesInvoiceFrm();

            Int32 id;
            Int32.TryParse(this.invoiceId_txtBox.Text, out id);
            frm.sel_invoice_id = id;
            frm.ShowDialog();
            //-----------------

            SalesInvoiceList_Load(sender, e);
        }

        private void pdf_toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.accDs1.SalesInvoice.Rows.Count == 0)
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
                    iText.Layout.Element.Paragraph sub_title = new Paragraph("Sales Invoice List");
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
                    Table tbl = new Table(9, true);
                    //----------------------
                    table_header_loader(tbl, "ID", 1);
                    table_header_loader(tbl, "Date", 1);
                    table_header_loader(tbl, "Cu ID", 1);
                    table_header_loader(tbl, "Customer Name", 2);
                    table_header_loader(tbl, "Shipping", 1);
                    table_header_loader(tbl, "Other", 1);
                    table_header_loader(tbl, "Comment", 2);
                    //----------------------

                    //==============add table data==============================
                    for (int row_index = 0; row_index < this.accDs1.SalesInvoice.Rows.Count; row_index++)
                    {
                        this.bindingSource1.Position = row_index;
                        table_data_loader(tbl, this.invoiceId_txtBox.Text, 1, TextAlignment.CENTER);
                        table_data_loader(tbl, this.invoiceDate_dtp.Text, 1, TextAlignment.LEFT);
                        table_data_loader(tbl, this.customerId_lbl.Text, 1, TextAlignment.LEFT);
                        table_data_loader(tbl, this.customerName_txtBox.Text, 2, TextAlignment.LEFT);

                        //-------------
                        table_data_loader(tbl, "$ " + this.shipping_numericUpDown1.Value.ToString("F"), 1, TextAlignment.LEFT);
                        table_data_loader(tbl, "$ " + this.other_numericUpDown1.Value.ToString("F"), 1, TextAlignment.LEFT);

                        //-------------
                        table_data_loader(tbl, this.comment_txtBox.Text, 2, TextAlignment.LEFT);

                        //--------------------
                        this.prog_label9.Text = "Saving Pdf " + row_index.ToString() + " of " + this.accDs1.SalesInvoice.Rows.Count.ToString();
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
            if (this.accDs1.SalesInvoice.Rows.Count == 0)
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
                iText.Layout.Element.Paragraph sub_title = new Paragraph("Sales Invoice List");
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
                Table tbl = new Table(9, true);
                //----------------------
                table_header_loader(tbl, "ID", 1);
                table_header_loader(tbl, "Date", 1);
                table_header_loader(tbl, "Cu ID", 1);
                table_header_loader(tbl, "Customer Name", 2);
                table_header_loader(tbl, "Shipping", 1);
                table_header_loader(tbl, "Other", 1);
                table_header_loader(tbl, "Comment", 2);
                //----------------------

                //==============add table data==============================
                for (int row_index = 0; row_index < this.accDs1.SalesInvoice.Rows.Count; row_index++)
                {
                    this.bindingSource1.Position = row_index;
                    table_data_loader(tbl, this.invoiceId_txtBox.Text, 1, TextAlignment.CENTER);
                    table_data_loader(tbl, this.invoiceDate_dtp.Text, 1, TextAlignment.LEFT);
                    table_data_loader(tbl, this.customerId_lbl.Text, 1, TextAlignment.LEFT);
                    table_data_loader(tbl, this.customerName_txtBox.Text, 2, TextAlignment.LEFT);

                    //-------------
                    table_data_loader(tbl, "$ " + this.shipping_numericUpDown1.Value.ToString("F"), 1, TextAlignment.LEFT);
                    table_data_loader(tbl, "$ " + this.other_numericUpDown1.Value.ToString("F"), 1, TextAlignment.LEFT);

                    //-------------
                    table_data_loader(tbl, this.comment_txtBox.Text, 2, TextAlignment.LEFT);

                    //--------------------
                    this.prog_label9.Text = "Saving Pdf " + row_index.ToString() + " of " + this.accDs1.SalesInvoice.Rows.Count.ToString();
                    this.prog_panel1.Refresh();
                    //--------------------
                }

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
                    wb.AddWorksheet(this.accDs1.SalesInvoice, "MySheet");
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

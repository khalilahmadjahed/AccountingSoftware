namespace AccountingSoftware.Accounting
{
    partial class SalesInvoiceList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            invoiceIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            invoiceDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shippingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            otherDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bindingSource1 = new BindingSource(components);
            accDs1 = new Ds.AccDs();
            toolStrip1 = new ToolStrip();
            new_btn = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripDropDownButton();
            print_toolStripMenuItem2 = new ToolStripMenuItem();
            pdf_toolStripMenuItem1 = new ToolStripMenuItem();
            excel_printToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            salesInvoiceTableAdapter1 = new Ds.AccDsTableAdapters.SalesInvoiceTableAdapter();
            invoiceId_txtBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { invoiceIdDataGridViewTextBoxColumn, invoiceDateDataGridViewTextBoxColumn, customerIdDataGridViewTextBoxColumn, customerNameDataGridViewTextBoxColumn, shippingDataGridViewTextBoxColumn, otherDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn, regUserDataGridViewTextBoxColumn, regDateDataGridViewTextBoxColumn, regTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(719, 384);
            dataGridView1.TabIndex = 17;
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceId";
            invoiceIdDataGridViewTextBoxColumn.HeaderText = "ID";
            invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            invoiceIdDataGridViewTextBoxColumn.ReadOnly = true;
            invoiceIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "InvoiceDate";
            invoiceDateDataGridViewTextBoxColumn.HeaderText = "Date";
            invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            invoiceDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "Cu ID";
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            customerIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            customerNameDataGridViewTextBoxColumn.HeaderText = "Customer Name";
            customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            customerNameDataGridViewTextBoxColumn.ReadOnly = true;
            customerNameDataGridViewTextBoxColumn.Width = 130;
            // 
            // shippingDataGridViewTextBoxColumn
            // 
            shippingDataGridViewTextBoxColumn.DataPropertyName = "Shipping";
            shippingDataGridViewTextBoxColumn.HeaderText = "Shipping";
            shippingDataGridViewTextBoxColumn.Name = "shippingDataGridViewTextBoxColumn";
            shippingDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // otherDataGridViewTextBoxColumn
            // 
            otherDataGridViewTextBoxColumn.DataPropertyName = "Other";
            otherDataGridViewTextBoxColumn.HeaderText = "Other";
            otherDataGridViewTextBoxColumn.Name = "otherDataGridViewTextBoxColumn";
            otherDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            commentDataGridViewTextBoxColumn.ReadOnly = true;
            commentDataGridViewTextBoxColumn.Width = 200;
            // 
            // regUserDataGridViewTextBoxColumn
            // 
            regUserDataGridViewTextBoxColumn.DataPropertyName = "RegUser";
            regUserDataGridViewTextBoxColumn.HeaderText = "RegUser";
            regUserDataGridViewTextBoxColumn.Name = "regUserDataGridViewTextBoxColumn";
            regUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regDateDataGridViewTextBoxColumn
            // 
            regDateDataGridViewTextBoxColumn.DataPropertyName = "RegDate";
            regDateDataGridViewTextBoxColumn.HeaderText = "RegDate";
            regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
            regDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regTimeDataGridViewTextBoxColumn
            // 
            regTimeDataGridViewTextBoxColumn.DataPropertyName = "RegTime";
            regTimeDataGridViewTextBoxColumn.HeaderText = "RegTime";
            regTimeDataGridViewTextBoxColumn.Name = "regTimeDataGridViewTextBoxColumn";
            regTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bindingSource1
            // 
            bindingSource1.DataMember = "SalesInvoice";
            bindingSource1.DataSource = accDs1;
            // 
            // accDs1
            // 
            accDs1.DataSetName = "AccDs";
            accDs1.Namespace = "http://tempuri.org/AccDs.xsd";
            accDs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.WhiteSmoke;
            toolStrip1.Items.AddRange(new ToolStripItem[] { new_btn, toolStripSeparator1, toolStripButton1, toolStripSeparator8 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(740, 64);
            toolStrip1.TabIndex = 16;
            toolStrip1.Text = "toolStrip1";
            // 
            // new_btn
            // 
            new_btn.AutoSize = false;
            new_btn.ForeColor = Color.Black;
            new_btn.Image = Properties.Resources.new_butt;
            new_btn.ImageScaling = ToolStripItemImageScaling.None;
            new_btn.ImageTransparentColor = Color.Magenta;
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(135, 58);
            new_btn.Text = "New / Edit Sales Invoice ";
            new_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            new_btn.Click += new_btn_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = Color.Black;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 64);
            // 
            // toolStripButton1
            // 
            toolStripButton1.AutoSize = false;
            toolStripButton1.DropDownItems.AddRange(new ToolStripItem[] { print_toolStripMenuItem2, pdf_toolStripMenuItem1, excel_printToolStripMenuItem });
            toolStripButton1.ForeColor = Color.Black;
            toolStripButton1.Image = Properties.Resources.printer;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(90, 58);
            toolStripButton1.Text = "Print";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // print_toolStripMenuItem2
            // 
            print_toolStripMenuItem2.Image = Properties.Resources.printer;
            print_toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            print_toolStripMenuItem2.Name = "print_toolStripMenuItem2";
            print_toolStripMenuItem2.Size = new Size(158, 30);
            print_toolStripMenuItem2.Text = "Print";
            // 
            // pdf_toolStripMenuItem1
            // 
            pdf_toolStripMenuItem1.Image = Properties.Resources.pdf;
            pdf_toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            pdf_toolStripMenuItem1.Name = "pdf_toolStripMenuItem1";
            pdf_toolStripMenuItem1.Size = new Size(158, 30);
            pdf_toolStripMenuItem1.Text = "Save as Pdf";
            // 
            // excel_printToolStripMenuItem
            // 
            excel_printToolStripMenuItem.Image = Properties.Resources.excel;
            excel_printToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            excel_printToolStripMenuItem.Name = "excel_printToolStripMenuItem";
            excel_printToolStripMenuItem.Size = new Size(158, 30);
            excel_printToolStripMenuItem.Text = "Export to Excel";
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 64);
            // 
            // salesInvoiceTableAdapter1
            // 
            salesInvoiceTableAdapter1.ClearBeforeFill = true;
            // 
            // invoiceId_txtBox
            // 
            invoiceId_txtBox.BorderStyle = BorderStyle.FixedSingle;
            invoiceId_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "InvoiceId", true));
            invoiceId_txtBox.Location = new Point(799, 77);
            invoiceId_txtBox.Name = "invoiceId_txtBox";
            invoiceId_txtBox.ReadOnly = true;
            invoiceId_txtBox.Size = new Size(52, 23);
            invoiceId_txtBox.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(737, 81);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 18;
            label1.Text = "Invoice ID:";
            // 
            // SalesInvoiceList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 450);
            Controls.Add(invoiceId_txtBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            Name = "SalesInvoiceList";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Invoice List";
            Load += SalesInvoiceList_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton new_btn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton toolStripButton1;
        private ToolStripMenuItem print_toolStripMenuItem2;
        private ToolStripMenuItem pdf_toolStripMenuItem1;
        private ToolStripMenuItem excel_printToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shippingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regTimeDataGridViewTextBoxColumn;
        private BindingSource bindingSource1;
        private Ds.AccDs accDs1;
        private Ds.AccDsTableAdapters.SalesInvoiceTableAdapter salesInvoiceTableAdapter1;
        private TextBox invoiceId_txtBox;
        private Label label1;
    }
}
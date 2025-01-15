namespace AccountingSoftware.Accounting
{
    partial class PurchaseBillListFrm
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
            customerId_lbl = new Label();
            bindingSource1 = new BindingSource(components);
            accDs1 = new Ds.AccDs();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            purchaseIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            purchaseDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            shippingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            otherDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toolStrip1 = new ToolStrip();
            new_btn = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButton1 = new ToolStripDropDownButton();
            print_toolStripMenuItem2 = new ToolStripMenuItem();
            pdf_toolStripMenuItem1 = new ToolStripMenuItem();
            excel_printToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator8 = new ToolStripSeparator();
            prog_panel1 = new Panel();
            progressBar1 = new ProgressBar();
            prog_label9 = new Label();
            label3 = new Label();
            purchaseBillTableAdapter1 = new Ds.AccDsTableAdapters.PurchaseBillTableAdapter();
            purchaseId_txtBox = new TextBox();
            label7 = new Label();
            label4 = new Label();
            other_numericUpDown1 = new NumericUpDown();
            shipping_numericUpDown1 = new NumericUpDown();
            customerSearch_btn = new Button();
            purchaseDate_dtp = new DateTimePicker();
            comment_txtBox = new TextBox();
            label9 = new Label();
            label6 = new Label();
            customerName_txtBox = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            toolStrip1.SuspendLayout();
            prog_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)other_numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shipping_numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // customerId_lbl
            // 
            customerId_lbl.DataBindings.Add(new Binding("Text", bindingSource1, "CustomerId", true));
            customerId_lbl.Location = new Point(884, 239);
            customerId_lbl.Name = "customerId_lbl";
            customerId_lbl.Size = new Size(60, 15);
            customerId_lbl.TabIndex = 52;
            customerId_lbl.Text = "0";
            // 
            // bindingSource1
            // 
            bindingSource1.DataMember = "PurchaseBill";
            bindingSource1.DataSource = accDs1;
            // 
            // accDs1
            // 
            accDs1.DataSetName = "AccDs";
            accDs1.Namespace = "http://tempuri.org/AccDs.xsd";
            accDs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(752, 239);
            label8.Name = "label8";
            label8.Size = new Size(76, 15);
            label8.TabIndex = 53;
            label8.Text = "Customer ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { purchaseIdDataGridViewTextBoxColumn, purchaseDateDataGridViewTextBoxColumn, customerIdDataGridViewTextBoxColumn, customerNameDataGridViewTextBoxColumn, shippingDataGridViewTextBoxColumn, otherDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn, regUserDataGridViewTextBoxColumn, regDateDataGridViewTextBoxColumn, regTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(719, 371);
            dataGridView1.TabIndex = 36;
            // 
            // purchaseIdDataGridViewTextBoxColumn
            // 
            purchaseIdDataGridViewTextBoxColumn.DataPropertyName = "PurchaseId";
            purchaseIdDataGridViewTextBoxColumn.HeaderText = "ID";
            purchaseIdDataGridViewTextBoxColumn.Name = "purchaseIdDataGridViewTextBoxColumn";
            purchaseIdDataGridViewTextBoxColumn.ReadOnly = true;
            purchaseIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // purchaseDateDataGridViewTextBoxColumn
            // 
            purchaseDateDataGridViewTextBoxColumn.DataPropertyName = "PurchaseDate";
            purchaseDateDataGridViewTextBoxColumn.HeaderText = "Date";
            purchaseDateDataGridViewTextBoxColumn.Name = "purchaseDateDataGridViewTextBoxColumn";
            purchaseDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            customerNameDataGridViewTextBoxColumn.Width = 120;
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
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.WhiteSmoke;
            toolStrip1.Items.AddRange(new ToolStripItem[] { new_btn, toolStripSeparator1, toolStripButton1, toolStripSeparator8 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(744, 64);
            toolStrip1.TabIndex = 35;
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
            new_btn.Text = "New / Edit Purchase Bill";
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
            print_toolStripMenuItem2.Click += print_toolStripMenuItem2_Click;
            // 
            // pdf_toolStripMenuItem1
            // 
            pdf_toolStripMenuItem1.Image = Properties.Resources.pdf;
            pdf_toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            pdf_toolStripMenuItem1.Name = "pdf_toolStripMenuItem1";
            pdf_toolStripMenuItem1.Size = new Size(158, 30);
            pdf_toolStripMenuItem1.Text = "Save as Pdf";
            pdf_toolStripMenuItem1.Click += pdf_toolStripMenuItem1_Click;
            // 
            // excel_printToolStripMenuItem
            // 
            excel_printToolStripMenuItem.Image = Properties.Resources.excel;
            excel_printToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            excel_printToolStripMenuItem.Name = "excel_printToolStripMenuItem";
            excel_printToolStripMenuItem.Size = new Size(158, 30);
            excel_printToolStripMenuItem.Text = "Export to Excel";
            excel_printToolStripMenuItem.Click += excel_printToolStripMenuItem_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new Size(6, 64);
            // 
            // prog_panel1
            // 
            prog_panel1.BackColor = Color.FromArgb(77, 161, 169);
            prog_panel1.Controls.Add(progressBar1);
            prog_panel1.Controls.Add(prog_label9);
            prog_panel1.Controls.Add(label3);
            prog_panel1.Location = new Point(272, 179);
            prog_panel1.Name = "prog_panel1";
            prog_panel1.Size = new Size(200, 92);
            prog_panel1.TabIndex = 54;
            prog_panel1.Visible = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 80);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(200, 12);
            progressBar1.TabIndex = 1;
            // 
            // prog_label9
            // 
            prog_label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            prog_label9.Location = new Point(3, 50);
            prog_label9.Name = "prog_label9";
            prog_label9.Size = new Size(194, 15);
            prog_label9.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(65, 12);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 0;
            label3.Text = "Please wait...";
            // 
            // purchaseBillTableAdapter1
            // 
            purchaseBillTableAdapter1.ClearBeforeFill = true;
            // 
            // purchaseId_txtBox
            // 
            purchaseId_txtBox.BorderStyle = BorderStyle.FixedSingle;
            purchaseId_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "PurchaseId", true));
            purchaseId_txtBox.Location = new Point(870, 60);
            purchaseId_txtBox.Name = "purchaseId_txtBox";
            purchaseId_txtBox.ReadOnly = true;
            purchaseId_txtBox.Size = new Size(148, 23);
            purchaseId_txtBox.TabIndex = 68;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(853, 180);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 66;
            label7.Text = "$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(853, 149);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 67;
            label4.Text = "$";
            // 
            // other_numericUpDown1
            // 
            other_numericUpDown1.DataBindings.Add(new Binding("Value", bindingSource1, "Other", true));
            other_numericUpDown1.DecimalPlaces = 2;
            other_numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            other_numericUpDown1.Location = new Point(870, 176);
            other_numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            other_numericUpDown1.Name = "other_numericUpDown1";
            other_numericUpDown1.Size = new Size(148, 23);
            other_numericUpDown1.TabIndex = 64;
            // 
            // shipping_numericUpDown1
            // 
            shipping_numericUpDown1.DataBindings.Add(new Binding("Value", bindingSource1, "Shipping", true));
            shipping_numericUpDown1.DecimalPlaces = 2;
            shipping_numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            shipping_numericUpDown1.Location = new Point(870, 147);
            shipping_numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            shipping_numericUpDown1.Name = "shipping_numericUpDown1";
            shipping_numericUpDown1.Size = new Size(148, 23);
            shipping_numericUpDown1.TabIndex = 65;
            // 
            // customerSearch_btn
            // 
            customerSearch_btn.Location = new Point(752, 118);
            customerSearch_btn.Name = "customerSearch_btn";
            customerSearch_btn.Size = new Size(108, 23);
            customerSearch_btn.TabIndex = 63;
            customerSearch_btn.Text = "Customer Name:";
            customerSearch_btn.UseVisualStyleBackColor = true;
            // 
            // purchaseDate_dtp
            // 
            purchaseDate_dtp.DataBindings.Add(new Binding("Value", bindingSource1, "PurchaseDate", true));
            purchaseDate_dtp.Format = DateTimePickerFormat.Short;
            purchaseDate_dtp.Location = new Point(870, 89);
            purchaseDate_dtp.Name = "purchaseDate_dtp";
            purchaseDate_dtp.Size = new Size(148, 23);
            purchaseDate_dtp.TabIndex = 62;
            // 
            // comment_txtBox
            // 
            comment_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "Comment", true));
            comment_txtBox.Location = new Point(870, 205);
            comment_txtBox.Name = "comment_txtBox";
            comment_txtBox.Size = new Size(148, 23);
            comment_txtBox.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(752, 209);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 55;
            label9.Text = "Comment:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(752, 180);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 56;
            label6.Text = "Other:";
            // 
            // customerName_txtBox
            // 
            customerName_txtBox.BorderStyle = BorderStyle.FixedSingle;
            customerName_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "CustomerName", true));
            customerName_txtBox.Location = new Point(870, 118);
            customerName_txtBox.Name = "customerName_txtBox";
            customerName_txtBox.ReadOnly = true;
            customerName_txtBox.Size = new Size(148, 23);
            customerName_txtBox.TabIndex = 60;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(752, 151);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 57;
            label5.Text = "Shipping:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(752, 93);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 58;
            label2.Text = "Purchase Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(752, 64);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 59;
            label1.Text = "Purchase ID:";
            // 
            // PurchaseBillListFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 450);
            Controls.Add(purchaseId_txtBox);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(other_numericUpDown1);
            Controls.Add(shipping_numericUpDown1);
            Controls.Add(customerSearch_btn);
            Controls.Add(purchaseDate_dtp);
            Controls.Add(comment_txtBox);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(customerName_txtBox);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(prog_panel1);
            Controls.Add(customerId_lbl);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            MaximizeBox = false;
            Name = "PurchaseBillListFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Purchase Bill List";
            Load += PurchaseBillListFrm_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            prog_panel1.ResumeLayout(false);
            prog_panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)other_numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)shipping_numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customerId_lbl;
        private Label label8;
        private DataGridView dataGridView1;
        private ToolStrip toolStrip1;
        private ToolStripButton new_btn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton toolStripButton1;
        private ToolStripMenuItem print_toolStripMenuItem2;
        private ToolStripMenuItem pdf_toolStripMenuItem1;
        private ToolStripMenuItem excel_printToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private Panel prog_panel1;
        private ProgressBar progressBar1;
        private Label prog_label9;
        private Label label3;
        private BindingSource bindingSource1;
        private Ds.AccDs accDs1;
        private DataGridViewTextBoxColumn purchaseIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn purchaseDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn shippingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn otherDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regTimeDataGridViewTextBoxColumn;
        private Ds.AccDsTableAdapters.PurchaseBillTableAdapter purchaseBillTableAdapter1;
        private TextBox purchaseId_txtBox;
        private Label label7;
        private Label label4;
        private NumericUpDown other_numericUpDown1;
        private NumericUpDown shipping_numericUpDown1;
        private Button customerSearch_btn;
        private DateTimePicker purchaseDate_dtp;
        private TextBox comment_txtBox;
        private Label label9;
        private Label label6;
        private TextBox customerName_txtBox;
        private Label label5;
        private Label label2;
        private Label label1;
    }
}
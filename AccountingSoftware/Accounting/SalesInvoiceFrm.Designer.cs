﻿namespace AccountingSoftware.Accounting
{
    partial class SalesInvoiceFrm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            toolStrip1 = new ToolStrip();
            new_btn = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            edit_btn = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            del_btn = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            save_btn = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            cancel_btn = new ToolStripButton();
            toolStripSeparator5 = new ToolStripSeparator();
            toolStripSeparator6 = new ToolStripSeparator();
            search_btn = new ToolStripButton();
            toolStripSeparator7 = new ToolStripSeparator();
            groupBox1 = new GroupBox();
            invoiceId_txtBox = new TextBox();
            bindingSource1 = new BindingSource(components);
            accDs1 = new Ds.AccDs();
            label7 = new Label();
            label4 = new Label();
            other_numericUpDown1 = new NumericUpDown();
            shipping_numericUpDown1 = new NumericUpDown();
            customerSearch_btn = new Button();
            invoiceDate_dtp = new DateTimePicker();
            comment_txtBox = new TextBox();
            label9 = new Label();
            label6 = new Label();
            customerName_txtBox = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label12 = new Label();
            customerId_lbl = new Label();
            reg_time_label = new Label();
            reg_date_label = new Label();
            label13 = new Label();
            reg_user_label = new Label();
            label10 = new Label();
            salesInvoiceTableAdapter1 = new Ds.AccDsTableAdapters.SalesInvoiceTableAdapter();
            panel2 = new Panel();
            productList_btn = new Button();
            bindingSource3 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            qtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taxRateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            taxSumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            netAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salesInvoiceProductsTableAdapter1 = new Ds.AccDsTableAdapters.SalesInvoiceProductsTableAdapter();
            label8 = new Label();
            amount_nud = new NumericUpDown();
            label11 = new Label();
            taxSum_nud = new NumericUpDown();
            label14 = new Label();
            netAmount_nud = new NumericUpDown();
            label15 = new Label();
            shipping_nud = new NumericUpDown();
            label16 = new Label();
            other_nud = new NumericUpDown();
            label17 = new Label();
            total_nud = new NumericUpDown();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            label24 = new Label();
            label23 = new Label();
            label25 = new Label();
            label26 = new Label();
            label27 = new Label();
            label28 = new Label();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)other_numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shipping_numericUpDown1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amount_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taxSum_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)netAmount_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)shipping_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)other_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)total_nud).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { new_btn, toolStripSeparator1, edit_btn, toolStripSeparator2, del_btn, toolStripSeparator3, save_btn, toolStripSeparator4, cancel_btn, toolStripSeparator5, toolStripSeparator6, search_btn, toolStripSeparator7 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(889, 64);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // new_btn
            // 
            new_btn.AutoSize = false;
            new_btn.Image = Properties.Resources.new_butt;
            new_btn.ImageScaling = ToolStripItemImageScaling.None;
            new_btn.ImageTransparentColor = Color.Magenta;
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(100, 58);
            new_btn.Text = "New Invoice";
            new_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            new_btn.Click += new_btn_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 64);
            // 
            // edit_btn
            // 
            edit_btn.AutoSize = false;
            edit_btn.Image = Properties.Resources.edit_butt;
            edit_btn.ImageScaling = ToolStripItemImageScaling.None;
            edit_btn.ImageTransparentColor = Color.Magenta;
            edit_btn.Name = "edit_btn";
            edit_btn.Size = new Size(70, 58);
            edit_btn.Text = "Edit";
            edit_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            edit_btn.Click += edit_btn_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 64);
            // 
            // del_btn
            // 
            del_btn.AutoSize = false;
            del_btn.Image = Properties.Resources.del_butt;
            del_btn.ImageScaling = ToolStripItemImageScaling.None;
            del_btn.ImageTransparentColor = Color.Magenta;
            del_btn.Name = "del_btn";
            del_btn.Size = new Size(90, 58);
            del_btn.Text = "Delete";
            del_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            del_btn.Visible = false;
            del_btn.Click += del_btn_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 64);
            toolStripSeparator3.Visible = false;
            // 
            // save_btn
            // 
            save_btn.AutoSize = false;
            save_btn.Enabled = false;
            save_btn.Image = Properties.Resources.save_utt;
            save_btn.ImageScaling = ToolStripItemImageScaling.None;
            save_btn.ImageTransparentColor = Color.Magenta;
            save_btn.Name = "save_btn";
            save_btn.Size = new Size(90, 58);
            save_btn.Text = "Save";
            save_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            save_btn.Click += save_btn_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 64);
            // 
            // cancel_btn
            // 
            cancel_btn.AutoSize = false;
            cancel_btn.Enabled = false;
            cancel_btn.Image = Properties.Resources.canecl_butt;
            cancel_btn.ImageScaling = ToolStripItemImageScaling.None;
            cancel_btn.ImageTransparentColor = Color.Magenta;
            cancel_btn.Name = "cancel_btn";
            cancel_btn.Size = new Size(90, 58);
            cancel_btn.Text = "Cancel";
            cancel_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            cancel_btn.Click += cancel_btn_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 64);
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 64);
            // 
            // search_btn
            // 
            search_btn.Alignment = ToolStripItemAlignment.Right;
            search_btn.AutoSize = false;
            search_btn.Image = Properties.Resources.Search;
            search_btn.ImageScaling = ToolStripItemImageScaling.None;
            search_btn.ImageTransparentColor = Color.Magenta;
            search_btn.Name = "search_btn";
            search_btn.Size = new Size(90, 58);
            search_btn.Text = "Search";
            search_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 64);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(invoiceId_txtBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(other_numericUpDown1);
            groupBox1.Controls.Add(shipping_numericUpDown1);
            groupBox1.Controls.Add(customerSearch_btn);
            groupBox1.Controls.Add(invoiceDate_dtp);
            groupBox1.Controls.Add(comment_txtBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(customerName_txtBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(865, 224);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // invoiceId_txtBox
            // 
            invoiceId_txtBox.BorderStyle = BorderStyle.FixedSingle;
            invoiceId_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "InvoiceId", true));
            invoiceId_txtBox.Location = new Point(294, 30);
            invoiceId_txtBox.Name = "invoiceId_txtBox";
            invoiceId_txtBox.ReadOnly = true;
            invoiceId_txtBox.Size = new Size(258, 23);
            invoiceId_txtBox.TabIndex = 14;
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(277, 150);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 13;
            label7.Text = "$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(277, 119);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 13;
            label4.Text = "$";
            // 
            // other_numericUpDown1
            // 
            other_numericUpDown1.DataBindings.Add(new Binding("Value", bindingSource1, "Other", true));
            other_numericUpDown1.DecimalPlaces = 2;
            other_numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            other_numericUpDown1.Location = new Point(294, 146);
            other_numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            other_numericUpDown1.Name = "other_numericUpDown1";
            other_numericUpDown1.Size = new Size(258, 23);
            other_numericUpDown1.TabIndex = 12;
            // 
            // shipping_numericUpDown1
            // 
            shipping_numericUpDown1.DataBindings.Add(new Binding("Value", bindingSource1, "Shipping", true));
            shipping_numericUpDown1.DecimalPlaces = 2;
            shipping_numericUpDown1.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            shipping_numericUpDown1.Location = new Point(294, 117);
            shipping_numericUpDown1.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            shipping_numericUpDown1.Name = "shipping_numericUpDown1";
            shipping_numericUpDown1.Size = new Size(258, 23);
            shipping_numericUpDown1.TabIndex = 12;
            // 
            // customerSearch_btn
            // 
            customerSearch_btn.Location = new Point(176, 88);
            customerSearch_btn.Name = "customerSearch_btn";
            customerSearch_btn.Size = new Size(108, 23);
            customerSearch_btn.TabIndex = 11;
            customerSearch_btn.Text = "Customer Name:";
            customerSearch_btn.UseVisualStyleBackColor = true;
            customerSearch_btn.Click += customerSearch_btn_Click;
            // 
            // invoiceDate_dtp
            // 
            invoiceDate_dtp.DataBindings.Add(new Binding("Value", bindingSource1, "InvoiceDate", true));
            invoiceDate_dtp.Format = DateTimePickerFormat.Short;
            invoiceDate_dtp.Location = new Point(294, 59);
            invoiceDate_dtp.Name = "invoiceDate_dtp";
            invoiceDate_dtp.Size = new Size(258, 23);
            invoiceDate_dtp.TabIndex = 10;
            // 
            // comment_txtBox
            // 
            comment_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "Comment", true));
            comment_txtBox.Location = new Point(294, 175);
            comment_txtBox.Name = "comment_txtBox";
            comment_txtBox.Size = new Size(412, 23);
            comment_txtBox.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(176, 179);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 4;
            label9.Text = "Comment:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(176, 150);
            label6.Name = "label6";
            label6.Size = new Size(40, 15);
            label6.TabIndex = 4;
            label6.Text = "Other:";
            // 
            // customerName_txtBox
            // 
            customerName_txtBox.BorderStyle = BorderStyle.FixedSingle;
            customerName_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "CustomerName", true));
            customerName_txtBox.Location = new Point(294, 88);
            customerName_txtBox.Name = "customerName_txtBox";
            customerName_txtBox.ReadOnly = true;
            customerName_txtBox.Size = new Size(258, 23);
            customerName_txtBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(176, 121);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 4;
            label5.Text = "Shipping:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(176, 63);
            label2.Name = "label2";
            label2.Size = new Size(75, 15);
            label2.TabIndex = 4;
            label2.Text = "Invoice Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(176, 34);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 4;
            label1.Text = "Invoice ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(748, 9);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 4;
            label3.Text = "Customer ID:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(customerId_lbl);
            panel1.Controls.Add(reg_time_label);
            panel1.Controls.Add(reg_date_label);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(reg_user_label);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 735);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 34);
            panel1.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(504, 9);
            label12.Name = "label12";
            label12.Size = new Size(59, 15);
            label12.TabIndex = 0;
            label12.Text = "Reg Time:";
            // 
            // customerId_lbl
            // 
            customerId_lbl.DataBindings.Add(new Binding("Text", bindingSource1, "CustomerId", true));
            customerId_lbl.Location = new Point(821, 9);
            customerId_lbl.Name = "customerId_lbl";
            customerId_lbl.Size = new Size(60, 15);
            customerId_lbl.TabIndex = 0;
            customerId_lbl.Text = "0";
            // 
            // reg_time_label
            // 
            reg_time_label.DataBindings.Add(new Binding("Text", bindingSource1, "RegTime", true));
            reg_time_label.Location = new Point(561, 9);
            reg_time_label.Name = "reg_time_label";
            reg_time_label.Size = new Size(90, 15);
            reg_time_label.TabIndex = 0;
            reg_time_label.Text = "-";
            // 
            // reg_date_label
            // 
            reg_date_label.DataBindings.Add(new Binding("Text", bindingSource1, "RegDate", true));
            reg_date_label.Location = new Point(293, 9);
            reg_date_label.Name = "reg_date_label";
            reg_date_label.Size = new Size(90, 15);
            reg_date_label.TabIndex = 0;
            reg_date_label.Text = "-";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(239, 9);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 0;
            label13.Text = "Reg Date:";
            // 
            // reg_user_label
            // 
            reg_user_label.DataBindings.Add(new Binding("Text", bindingSource1, "RegUser", true));
            reg_user_label.Location = new Point(64, 9);
            reg_user_label.Name = "reg_user_label";
            reg_user_label.Size = new Size(90, 15);
            reg_user_label.TabIndex = 0;
            reg_user_label.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(11, 9);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 0;
            label10.Text = "Reg User:";
            // 
            // salesInvoiceTableAdapter1
            // 
            salesInvoiceTableAdapter1.ClearBeforeFill = true;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(productList_btn);
            panel2.Location = new Point(12, 297);
            panel2.Name = "panel2";
            panel2.Size = new Size(865, 43);
            panel2.TabIndex = 5;
            // 
            // productList_btn
            // 
            productList_btn.Location = new Point(3, 4);
            productList_btn.Name = "productList_btn";
            productList_btn.Size = new Size(108, 34);
            productList_btn.TabIndex = 0;
            productList_btn.Text = "Product List";
            productList_btn.UseVisualStyleBackColor = true;
            productList_btn.Click += productList_btn_Click;
            // 
            // bindingSource3
            // 
            bindingSource3.DataMember = "SalesInvoiceProducts";
            bindingSource3.DataSource = accDs1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, qtyDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, unitPriceDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, taxRateDataGridViewTextBoxColumn, taxSumDataGridViewTextBoxColumn, netAmountDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn, regUserDataGridViewTextBoxColumn, regDateDataGridViewTextBoxColumn, regTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource3;
            dataGridView1.Location = new Point(12, 348);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(865, 205);
            dataGridView1.TabIndex = 8;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Width = 60;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            productNameDataGridViewTextBoxColumn.Width = 110;
            // 
            // qtyDataGridViewTextBoxColumn
            // 
            qtyDataGridViewTextBoxColumn.DataPropertyName = "Qty";
            dataGridViewCellStyle1.Format = "N0";
            qtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            qtyDataGridViewTextBoxColumn.HeaderText = "Qty";
            qtyDataGridViewTextBoxColumn.Name = "qtyDataGridViewTextBoxColumn";
            qtyDataGridViewTextBoxColumn.ReadOnly = true;
            qtyDataGridViewTextBoxColumn.Width = 80;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.ReadOnly = true;
            unitDataGridViewTextBoxColumn.Width = 90;
            // 
            // unitPriceDataGridViewTextBoxColumn
            // 
            unitPriceDataGridViewTextBoxColumn.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle2.Format = "C2";
            unitPriceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            unitPriceDataGridViewTextBoxColumn.HeaderText = "Unit Price";
            unitPriceDataGridViewTextBoxColumn.Name = "unitPriceDataGridViewTextBoxColumn";
            unitPriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            dataGridViewCellStyle3.Format = "C2";
            discountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            discountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            dataGridViewCellStyle4.Format = "C2";
            amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            amountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxRateDataGridViewTextBoxColumn
            // 
            taxRateDataGridViewTextBoxColumn.DataPropertyName = "TaxRate";
            dataGridViewCellStyle5.Format = "C2";
            taxRateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            taxRateDataGridViewTextBoxColumn.HeaderText = "Tax Rate";
            taxRateDataGridViewTextBoxColumn.Name = "taxRateDataGridViewTextBoxColumn";
            taxRateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // taxSumDataGridViewTextBoxColumn
            // 
            taxSumDataGridViewTextBoxColumn.DataPropertyName = "TaxSum";
            dataGridViewCellStyle6.Format = "C2";
            taxSumDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            taxSumDataGridViewTextBoxColumn.HeaderText = "Tax Sum";
            taxSumDataGridViewTextBoxColumn.Name = "taxSumDataGridViewTextBoxColumn";
            taxSumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // netAmountDataGridViewTextBoxColumn
            // 
            netAmountDataGridViewTextBoxColumn.DataPropertyName = "NetAmount";
            dataGridViewCellStyle7.Format = "C2";
            netAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            netAmountDataGridViewTextBoxColumn.HeaderText = "Net Amount";
            netAmountDataGridViewTextBoxColumn.Name = "netAmountDataGridViewTextBoxColumn";
            netAmountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            commentDataGridViewTextBoxColumn.HeaderText = "comment";
            commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            commentDataGridViewTextBoxColumn.ReadOnly = true;
            commentDataGridViewTextBoxColumn.Width = 250;
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
            // salesInvoiceProductsTableAdapter1
            // 
            salesInvoiceProductsTableAdapter1.ClearBeforeFill = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label8.Location = new Point(582, 559);
            label8.Name = "label8";
            label8.Size = new Size(66, 19);
            label8.TabIndex = 9;
            label8.Text = "Amount:";
            // 
            // amount_nud
            // 
            amount_nud.DecimalPlaces = 2;
            amount_nud.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            amount_nud.Location = new Point(712, 559);
            amount_nud.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            amount_nud.Name = "amount_nud";
            amount_nud.ReadOnly = true;
            amount_nud.Size = new Size(165, 23);
            amount_nud.TabIndex = 10;
            amount_nud.ThousandsSeparator = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(582, 588);
            label11.Name = "label11";
            label11.Size = new Size(61, 19);
            label11.TabIndex = 9;
            label11.Text = "Tax Sum:";
            // 
            // taxSum_nud
            // 
            taxSum_nud.DecimalPlaces = 2;
            taxSum_nud.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            taxSum_nud.Location = new Point(712, 588);
            taxSum_nud.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            taxSum_nud.Name = "taxSum_nud";
            taxSum_nud.ReadOnly = true;
            taxSum_nud.Size = new Size(165, 23);
            taxSum_nud.TabIndex = 10;
            taxSum_nud.ThousandsSeparator = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label14.Location = new Point(582, 617);
            label14.Name = "label14";
            label14.Size = new Size(94, 19);
            label14.TabIndex = 9;
            label14.Text = "Net Amount:";
            // 
            // netAmount_nud
            // 
            netAmount_nud.DecimalPlaces = 2;
            netAmount_nud.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            netAmount_nud.Location = new Point(712, 617);
            netAmount_nud.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            netAmount_nud.Name = "netAmount_nud";
            netAmount_nud.ReadOnly = true;
            netAmount_nud.Size = new Size(165, 23);
            netAmount_nud.TabIndex = 10;
            netAmount_nud.ThousandsSeparator = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F);
            label15.Location = new Point(582, 646);
            label15.Name = "label15";
            label15.Size = new Size(65, 19);
            label15.TabIndex = 9;
            label15.Text = "Shipping:";
            // 
            // shipping_nud
            // 
            shipping_nud.DecimalPlaces = 2;
            shipping_nud.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            shipping_nud.Location = new Point(712, 646);
            shipping_nud.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            shipping_nud.Name = "shipping_nud";
            shipping_nud.ReadOnly = true;
            shipping_nud.Size = new Size(165, 23);
            shipping_nud.TabIndex = 10;
            shipping_nud.ThousandsSeparator = true;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F);
            label16.Location = new Point(582, 675);
            label16.Name = "label16";
            label16.Size = new Size(48, 19);
            label16.TabIndex = 9;
            label16.Text = "Other:";
            // 
            // other_nud
            // 
            other_nud.DecimalPlaces = 2;
            other_nud.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            other_nud.Location = new Point(712, 675);
            other_nud.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            other_nud.Name = "other_nud";
            other_nud.ReadOnly = true;
            other_nud.Size = new Size(165, 23);
            other_nud.TabIndex = 10;
            other_nud.ThousandsSeparator = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(230, 0, 25);
            label17.Location = new Point(582, 704);
            label17.Name = "label17";
            label17.Size = new Size(46, 19);
            label17.TabIndex = 9;
            label17.Text = "Total:";
            // 
            // total_nud
            // 
            total_nud.DecimalPlaces = 2;
            total_nud.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            total_nud.Location = new Point(712, 704);
            total_nud.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            total_nud.Name = "total_nud";
            total_nud.ReadOnly = true;
            total_nud.Size = new Size(165, 23);
            total_nud.TabIndex = 10;
            total_nud.ThousandsSeparator = true;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 10F);
            label18.Location = new Point(561, 590);
            label18.Name = "label18";
            label18.Size = new Size(19, 19);
            label18.TabIndex = 9;
            label18.Text = "+";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 10F);
            label19.Location = new Point(561, 617);
            label19.Name = "label19";
            label19.Size = new Size(19, 19);
            label19.TabIndex = 9;
            label19.Text = "=";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 10F);
            label20.Location = new Point(561, 646);
            label20.Name = "label20";
            label20.Size = new Size(19, 19);
            label20.TabIndex = 9;
            label20.Text = "+";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 10F);
            label21.Location = new Point(561, 675);
            label21.Name = "label21";
            label21.Size = new Size(19, 19);
            label21.TabIndex = 9;
            label21.Text = "+";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 10F);
            label22.Location = new Point(561, 704);
            label22.Name = "label22";
            label22.Size = new Size(19, 19);
            label22.TabIndex = 9;
            label22.Text = "=";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI", 10F);
            label24.Location = new Point(694, 561);
            label24.Name = "label24";
            label24.Size = new Size(17, 19);
            label24.TabIndex = 9;
            label24.Text = "$";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 10F);
            label23.Location = new Point(694, 590);
            label23.Name = "label23";
            label23.Size = new Size(17, 19);
            label23.TabIndex = 9;
            label23.Text = "$";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI", 10F);
            label25.Location = new Point(694, 619);
            label25.Name = "label25";
            label25.Size = new Size(17, 19);
            label25.TabIndex = 9;
            label25.Text = "$";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("Segoe UI", 10F);
            label26.Location = new Point(694, 648);
            label26.Name = "label26";
            label26.Size = new Size(17, 19);
            label26.TabIndex = 9;
            label26.Text = "$";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("Segoe UI", 10F);
            label27.Location = new Point(694, 677);
            label27.Name = "label27";
            label27.Size = new Size(17, 19);
            label27.TabIndex = 9;
            label27.Text = "$";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI", 10F);
            label28.Location = new Point(694, 706);
            label28.Name = "label28";
            label28.Size = new Size(17, 19);
            label28.TabIndex = 9;
            label28.Text = "$";
            // 
            // SalesInvoiceFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 769);
            Controls.Add(total_nud);
            Controls.Add(label17);
            Controls.Add(other_nud);
            Controls.Add(label16);
            Controls.Add(shipping_nud);
            Controls.Add(label15);
            Controls.Add(netAmount_nud);
            Controls.Add(label14);
            Controls.Add(taxSum_nud);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(label22);
            Controls.Add(label19);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(label26);
            Controls.Add(label25);
            Controls.Add(label23);
            Controls.Add(label24);
            Controls.Add(label18);
            Controls.Add(label11);
            Controls.Add(amount_nud);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "SalesInvoiceFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sales Invoice";
            Load += SalesInvoiceFrm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).EndInit();
            ((System.ComponentModel.ISupportInitialize)other_numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)shipping_numericUpDown1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)amount_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)taxSum_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)netAmount_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)shipping_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)other_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)total_nud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton new_btn;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton edit_btn;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton del_btn;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton save_btn;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton cancel_btn;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton search_btn;
        private ToolStripSeparator toolStripSeparator7;
        private GroupBox groupBox1;
        private TextBox comment_txtBox;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Label label12;
        private Label reg_time_label;
        private Label reg_date_label;
        private Label label13;
        private Label reg_user_label;
        private Label label10;
        private DateTimePicker invoiceDate_dtp;
        private Button customerSearch_btn;
        private TextBox customerName_txtBox;
        private NumericUpDown shipping_numericUpDown1;
        private NumericUpDown other_numericUpDown1;
        private Ds.AccDs accDs1;
        private Ds.AccDsTableAdapters.SalesInvoiceTableAdapter salesInvoiceTableAdapter1;
        private BindingSource bindingSource1;
        private Label label4;
        private Label label7;
        private TextBox invoiceId_txtBox;
        private Panel panel2;
        private Button productList_btn;
        private BindingSource bindingSource3;
        private Label customerId_lbl;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn qtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxRateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn taxSumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn netAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regTimeDataGridViewTextBoxColumn;
        private Ds.AccDsTableAdapters.SalesInvoiceProductsTableAdapter salesInvoiceProductsTableAdapter1;
        private Label label8;
        private NumericUpDown amount_nud;
        private Label label11;
        private NumericUpDown taxSum_nud;
        private Label label14;
        private NumericUpDown netAmount_nud;
        private Label label15;
        private NumericUpDown shipping_nud;
        private Label label16;
        private NumericUpDown other_nud;
        private Label label17;
        private NumericUpDown total_nud;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Label label24;
        private Label label23;
        private Label label25;
        private Label label26;
        private Label label27;
        private Label label28;
    }
}
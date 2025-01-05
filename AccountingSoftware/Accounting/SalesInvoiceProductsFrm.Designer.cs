namespace AccountingSoftware.Accounting
{
    partial class SalesInvoiceProductsFrm
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
            taxRate_btn = new Button();
            id_txtBox = new TextBox();
            bindingSource3 = new BindingSource(components);
            accDs1 = new Ds.AccDs();
            label21 = new Label();
            label19 = new Label();
            label17 = new Label();
            label15 = new Label();
            label11 = new Label();
            label7 = new Label();
            netAmount_nud = new NumericUpDown();
            taxSum_nud = new NumericUpDown();
            taxRate_nud = new NumericUpDown();
            amount_nud = new NumericUpDown();
            discount_nud = new NumericUpDown();
            unitPrice_nud = new NumericUpDown();
            qty_nud = new NumericUpDown();
            label20 = new Label();
            productSearch_btn = new Button();
            label18 = new Label();
            unit_txtBox = new TextBox();
            label16 = new Label();
            label3 = new Label();
            label14 = new Label();
            comment_txtBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            label6 = new Label();
            productName_txtBox = new TextBox();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            label12 = new Label();
            invoiceId_lbl = new Label();
            reg_time_label = new Label();
            reg_date_label = new Label();
            label13 = new Label();
            reg_user_label = new Label();
            label10 = new Label();
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
            label4 = new Label();
            productId_txtBox = new TextBox();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)netAmount_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taxSum_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)taxRate_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amount_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)discount_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unitPrice_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)qty_nud).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { new_btn, toolStripSeparator1, edit_btn, toolStripSeparator2, del_btn, toolStripSeparator3, save_btn, toolStripSeparator4, cancel_btn, toolStripSeparator5, toolStripSeparator6, search_btn, toolStripSeparator7 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(889, 64);
            toolStrip1.TabIndex = 2;
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
            new_btn.Text = "New Product";
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
            del_btn.Click += del_btn_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 64);
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
            groupBox1.Controls.Add(taxRate_btn);
            groupBox1.Controls.Add(id_txtBox);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label17);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(netAmount_nud);
            groupBox1.Controls.Add(taxSum_nud);
            groupBox1.Controls.Add(taxRate_nud);
            groupBox1.Controls.Add(amount_nud);
            groupBox1.Controls.Add(discount_nud);
            groupBox1.Controls.Add(unitPrice_nud);
            groupBox1.Controls.Add(qty_nud);
            groupBox1.Controls.Add(label20);
            groupBox1.Controls.Add(productSearch_btn);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(unit_txtBox);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(comment_txtBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(productName_txtBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(739, 352);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // taxRate_btn
            // 
            taxRate_btn.Location = new Point(489, 225);
            taxRate_btn.Name = "taxRate_btn";
            taxRate_btn.Size = new Size(75, 23);
            taxRate_btn.TabIndex = 14;
            taxRate_btn.Text = "Tax Rate";
            taxRate_btn.UseVisualStyleBackColor = true;
            taxRate_btn.Click += taxRate_btn_Click;
            // 
            // id_txtBox
            // 
            id_txtBox.BorderStyle = BorderStyle.FixedSingle;
            id_txtBox.DataBindings.Add(new Binding("Text", bindingSource3, "ID", true));
            id_txtBox.Location = new Point(226, 22);
            id_txtBox.Name = "id_txtBox";
            id_txtBox.ReadOnly = true;
            id_txtBox.Size = new Size(258, 23);
            id_txtBox.TabIndex = 1;
            // 
            // bindingSource3
            // 
            bindingSource3.AllowNew = true;
            bindingSource3.DataMember = "SalesInvoiceProducts";
            bindingSource3.DataSource = accDs1;
            // 
            // accDs1
            // 
            accDs1.DataSetName = "AccDs";
            accDs1.Namespace = "http://tempuri.org/AccDs.xsd";
            accDs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(207, 287);
            label21.Name = "label21";
            label21.Size = new Size(13, 15);
            label21.TabIndex = 13;
            label21.Text = "$";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(207, 258);
            label19.Name = "label19";
            label19.Size = new Size(13, 15);
            label19.TabIndex = 13;
            label19.Text = "$";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(207, 229);
            label17.Name = "label17";
            label17.Size = new Size(17, 15);
            label17.TabIndex = 13;
            label17.Text = "%";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(207, 200);
            label15.Name = "label15";
            label15.Size = new Size(13, 15);
            label15.TabIndex = 13;
            label15.Text = "$";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(207, 171);
            label11.Name = "label11";
            label11.Size = new Size(13, 15);
            label11.TabIndex = 13;
            label11.Text = "$";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(207, 142);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 13;
            label7.Text = "$";
            // 
            // netAmount_nud
            // 
            netAmount_nud.DataBindings.Add(new Binding("Value", bindingSource3, "NetAmount", true));
            netAmount_nud.DecimalPlaces = 2;
            netAmount_nud.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            netAmount_nud.Location = new Point(226, 283);
            netAmount_nud.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            netAmount_nud.Name = "netAmount_nud";
            netAmount_nud.ReadOnly = true;
            netAmount_nud.Size = new Size(258, 23);
            netAmount_nud.TabIndex = 12;
            // 
            // taxSum_nud
            // 
            taxSum_nud.DataBindings.Add(new Binding("Value", bindingSource3, "TaxSum", true));
            taxSum_nud.DecimalPlaces = 2;
            taxSum_nud.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            taxSum_nud.Location = new Point(226, 254);
            taxSum_nud.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            taxSum_nud.Name = "taxSum_nud";
            taxSum_nud.ReadOnly = true;
            taxSum_nud.Size = new Size(258, 23);
            taxSum_nud.TabIndex = 11;
            // 
            // taxRate_nud
            // 
            taxRate_nud.DataBindings.Add(new Binding("Value", bindingSource3, "TaxRate", true));
            taxRate_nud.DecimalPlaces = 2;
            taxRate_nud.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            taxRate_nud.Location = new Point(226, 225);
            taxRate_nud.Name = "taxRate_nud";
            taxRate_nud.ReadOnly = true;
            taxRate_nud.Size = new Size(258, 23);
            taxRate_nud.TabIndex = 10;
            // 
            // amount_nud
            // 
            amount_nud.DataBindings.Add(new Binding("Value", bindingSource3, "Amount", true));
            amount_nud.DecimalPlaces = 2;
            amount_nud.Increment = new decimal(new int[] { 0, 0, 0, 0 });
            amount_nud.Location = new Point(226, 196);
            amount_nud.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            amount_nud.Name = "amount_nud";
            amount_nud.ReadOnly = true;
            amount_nud.Size = new Size(258, 23);
            amount_nud.TabIndex = 9;
            // 
            // discount_nud
            // 
            discount_nud.DataBindings.Add(new Binding("Value", bindingSource3, "Discount", true));
            discount_nud.DecimalPlaces = 2;
            discount_nud.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            discount_nud.Location = new Point(226, 167);
            discount_nud.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            discount_nud.Name = "discount_nud";
            discount_nud.Size = new Size(258, 23);
            discount_nud.TabIndex = 8;
            discount_nud.ValueChanged += discount_nud_ValueChanged;
            discount_nud.KeyUp += discount_nud_KeyUp;
            // 
            // unitPrice_nud
            // 
            unitPrice_nud.DataBindings.Add(new Binding("Value", bindingSource3, "UnitPrice", true));
            unitPrice_nud.DecimalPlaces = 2;
            unitPrice_nud.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            unitPrice_nud.Location = new Point(226, 138);
            unitPrice_nud.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            unitPrice_nud.Name = "unitPrice_nud";
            unitPrice_nud.Size = new Size(258, 23);
            unitPrice_nud.TabIndex = 7;
            unitPrice_nud.ValueChanged += unitPrice_nud_ValueChanged;
            unitPrice_nud.KeyUp += unitPrice_nud_KeyUp;
            // 
            // qty_nud
            // 
            qty_nud.DataBindings.Add(new Binding("Value", bindingSource3, "Qty", true));
            qty_nud.Location = new Point(226, 80);
            qty_nud.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            qty_nud.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            qty_nud.Name = "qty_nud";
            qty_nud.Size = new Size(258, 23);
            qty_nud.TabIndex = 5;
            qty_nud.Value = new decimal(new int[] { 1, 0, 0, 0 });
            qty_nud.ValueChanged += qty_nud_ValueChanged;
            qty_nud.KeyUp += qty_nud_KeyUp;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(89, 287);
            label20.Name = "label20";
            label20.Size = new Size(76, 15);
            label20.TabIndex = 4;
            label20.Text = "Net Amount:";
            // 
            // productSearch_btn
            // 
            productSearch_btn.Location = new Point(89, 51);
            productSearch_btn.Name = "productSearch_btn";
            productSearch_btn.Size = new Size(112, 23);
            productSearch_btn.TabIndex = 3;
            productSearch_btn.Text = "Products Name:";
            productSearch_btn.UseVisualStyleBackColor = true;
            productSearch_btn.Click += productSearch_btn_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(89, 258);
            label18.Name = "label18";
            label18.Size = new Size(54, 15);
            label18.TabIndex = 4;
            label18.Text = "Tax Sum:";
            // 
            // unit_txtBox
            // 
            unit_txtBox.DataBindings.Add(new Binding("Text", bindingSource3, "Unit", true));
            unit_txtBox.Location = new Point(227, 109);
            unit_txtBox.Name = "unit_txtBox";
            unit_txtBox.Size = new Size(258, 23);
            unit_txtBox.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(89, 229);
            label16.Name = "label16";
            label16.Size = new Size(53, 15);
            label16.TabIndex = 4;
            label16.Text = "Tax Rate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 113);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "Unit:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(89, 200);
            label14.Name = "label14";
            label14.Size = new Size(54, 15);
            label14.TabIndex = 4;
            label14.Text = "Amount:";
            // 
            // comment_txtBox
            // 
            comment_txtBox.DataBindings.Add(new Binding("Text", bindingSource3, "comment", true));
            comment_txtBox.Location = new Point(226, 312);
            comment_txtBox.Name = "comment_txtBox";
            comment_txtBox.Size = new Size(412, 23);
            comment_txtBox.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(89, 171);
            label8.Name = "label8";
            label8.Size = new Size(57, 15);
            label8.TabIndex = 4;
            label8.Text = "Discount:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(89, 316);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 4;
            label9.Text = "Comment:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(89, 142);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 4;
            label6.Text = "Unit Price:";
            // 
            // productName_txtBox
            // 
            productName_txtBox.BorderStyle = BorderStyle.FixedSingle;
            productName_txtBox.DataBindings.Add(new Binding("Text", bindingSource3, "ProductName", true));
            productName_txtBox.Location = new Point(226, 51);
            productName_txtBox.Name = "productName_txtBox";
            productName_txtBox.ReadOnly = true;
            productName_txtBox.Size = new Size(258, 23);
            productName_txtBox.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 84);
            label5.Name = "label5";
            label5.Size = new Size(32, 15);
            label5.TabIndex = 4;
            label5.Text = "QTY:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 26);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(546, 9);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 4;
            label2.Text = "Invoice ID:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(invoiceId_lbl);
            panel1.Controls.Add(reg_time_label);
            panel1.Controls.Add(reg_date_label);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(reg_user_label);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 637);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 34);
            panel1.TabIndex = 5;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(370, 9);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 0;
            label12.Text = "Reg Time:";
            // 
            // invoiceId_lbl
            // 
            invoiceId_lbl.DataBindings.Add(new Binding("Text", bindingSource3, "InvoiceId", true));
            invoiceId_lbl.Location = new Point(606, 9);
            invoiceId_lbl.Name = "invoiceId_lbl";
            invoiceId_lbl.Size = new Size(90, 15);
            invoiceId_lbl.TabIndex = 0;
            invoiceId_lbl.Text = "0";
            // 
            // reg_time_label
            // 
            reg_time_label.DataBindings.Add(new Binding("Text", bindingSource3, "RegTime", true));
            reg_time_label.Location = new Point(427, 9);
            reg_time_label.Name = "reg_time_label";
            reg_time_label.Size = new Size(90, 15);
            reg_time_label.TabIndex = 0;
            reg_time_label.Text = "-";
            // 
            // reg_date_label
            // 
            reg_date_label.DataBindings.Add(new Binding("Text", bindingSource3, "RegDate", true));
            reg_date_label.Location = new Point(251, 9);
            reg_date_label.Name = "reg_date_label";
            reg_date_label.Size = new Size(90, 15);
            reg_date_label.TabIndex = 0;
            reg_date_label.Text = "-";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(197, 9);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 0;
            label13.Text = "Reg Date:";
            // 
            // reg_user_label
            // 
            reg_user_label.DataBindings.Add(new Binding("Text", bindingSource3, "RegUser", true));
            reg_user_label.Location = new Point(75, 9);
            reg_user_label.Name = "reg_user_label";
            reg_user_label.Size = new Size(90, 15);
            reg_user_label.TabIndex = 0;
            reg_user_label.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 9);
            label10.Name = "label10";
            label10.Size = new Size(56, 15);
            label10.TabIndex = 0;
            label10.Text = "Reg User:";
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
            dataGridView1.Location = new Point(12, 425);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(865, 205);
            dataGridView1.TabIndex = 7;
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
            dataGridViewCellStyle5.Format = "N2";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(758, 234);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 4;
            label4.Text = "Product ID:";
            // 
            // productId_txtBox
            // 
            productId_txtBox.BorderStyle = BorderStyle.FixedSingle;
            productId_txtBox.DataBindings.Add(new Binding("Text", bindingSource3, "ProductId", true));
            productId_txtBox.Location = new Point(824, 230);
            productId_txtBox.Name = "productId_txtBox";
            productId_txtBox.ReadOnly = true;
            productId_txtBox.Size = new Size(51, 23);
            productId_txtBox.TabIndex = 1;
            // 
            // SalesInvoiceProductsFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(889, 671);
            Controls.Add(productId_txtBox);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SalesInvoiceProductsFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products List";
            Load += SalesInvoiceProductsFrm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource3).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).EndInit();
            ((System.ComponentModel.ISupportInitialize)netAmount_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)taxSum_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)taxRate_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)amount_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)discount_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)unitPrice_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)qty_nud).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox id_txtBox;
        private Label label7;
        private NumericUpDown unitPrice_nud;
        private NumericUpDown qty_nud;
        private Button productSearch_btn;
        private TextBox comment_txtBox;
        private Label label9;
        private Label label6;
        private TextBox productName_txtBox;
        private Label label5;
        private Label label1;
        private Panel panel1;
        private Label label12;
        private Label reg_time_label;
        private Label reg_date_label;
        private Label label13;
        private Label reg_user_label;
        private Label label10;
        private DataGridView dataGridView1;
        private Ds.AccDs accDs1;
        private Ds.AccDsTableAdapters.SalesInvoiceProductsTableAdapter salesInvoiceProductsTableAdapter1;
        private Label label2;
        private TextBox unit_txtBox;
        private Label label3;
        private Label label21;
        private Label label19;
        private Label label17;
        private Label label15;
        private Label label11;
        private NumericUpDown netAmount_nud;
        private NumericUpDown taxSum_nud;
        private NumericUpDown taxRate_nud;
        private NumericUpDown amount_nud;
        private NumericUpDown discount_nud;
        private Label label20;
        private Label label18;
        private Label label16;
        private Label label14;
        private Label label8;
        private Label invoiceId_lbl;
        private Label label4;
        private TextBox productId_txtBox;
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
        private BindingSource bindingSource3;
        private Button taxRate_btn;
    }
}
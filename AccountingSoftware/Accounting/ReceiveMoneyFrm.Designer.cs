namespace AccountingSoftware.Accounting
{
    partial class ReceiveMoneyFrm
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
            toolStripButton1 = new ToolStripDropDownButton();
            print_toolStripMenuItem2 = new ToolStripMenuItem();
            pdf_toolStripMenuItem1 = new ToolStripMenuItem();
            excel_printToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator7 = new ToolStripSeparator();
            groupBox1 = new GroupBox();
            paymentId_txtBox = new TextBox();
            bindingSource1 = new BindingSource(components);
            accDs1 = new Ds.AccDs();
            label4 = new Label();
            amount_nud = new NumericUpDown();
            customerSearch_btn = new Button();
            paymentDate_dtp = new DateTimePicker();
            comment_txtBox = new TextBox();
            label9 = new Label();
            customerName_txtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cusromerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            payDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cashAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            invoiceIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label12 = new Label();
            reg_time_label = new Label();
            reg_date_label = new Label();
            label13 = new Label();
            reg_user_label = new Label();
            label10 = new Label();
            receiveMoneyTableAdapter1 = new Ds.AccDsTableAdapters.ReceiveMoneyTableAdapter();
            label3 = new Label();
            customerId_txtBox = new TextBox();
            label6 = new Label();
            invoiceId_txtBox = new TextBox();
            prog_panel1 = new Panel();
            progressBar1 = new ProgressBar();
            prog_label9 = new Label();
            label7 = new Label();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)amount_nud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            prog_panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.WhiteSmoke;
            toolStrip1.Items.AddRange(new ToolStripItem[] { new_btn, toolStripSeparator1, edit_btn, toolStripSeparator2, del_btn, toolStripSeparator3, save_btn, toolStripSeparator4, cancel_btn, toolStripSeparator5, toolStripSeparator6, toolStripButton1, toolStripSeparator7 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(866, 64);
            toolStrip1.TabIndex = 2;
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
            new_btn.Size = new Size(100, 58);
            new_btn.Text = "New Payment:";
            new_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            new_btn.Click += new_btn_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.ForeColor = Color.Black;
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 64);
            // 
            // edit_btn
            // 
            edit_btn.AutoSize = false;
            edit_btn.ForeColor = Color.Black;
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
            toolStripSeparator2.ForeColor = Color.Black;
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 64);
            // 
            // del_btn
            // 
            del_btn.AutoSize = false;
            del_btn.ForeColor = Color.Black;
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
            toolStripSeparator3.ForeColor = Color.Black;
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 64);
            // 
            // save_btn
            // 
            save_btn.AutoSize = false;
            save_btn.Enabled = false;
            save_btn.ForeColor = Color.Black;
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
            toolStripSeparator4.ForeColor = Color.Black;
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 64);
            // 
            // cancel_btn
            // 
            cancel_btn.AutoSize = false;
            cancel_btn.Enabled = false;
            cancel_btn.ForeColor = Color.Black;
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
            toolStripSeparator5.ForeColor = Color.Black;
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 64);
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator6.ForeColor = Color.Black;
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new Size(6, 64);
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
            print_toolStripMenuItem2.Size = new Size(188, 30);
            print_toolStripMenuItem2.Text = "Print";
            print_toolStripMenuItem2.Click += print_toolStripMenuItem2_Click;
            // 
            // pdf_toolStripMenuItem1
            // 
            pdf_toolStripMenuItem1.Image = Properties.Resources.pdf;
            pdf_toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            pdf_toolStripMenuItem1.Name = "pdf_toolStripMenuItem1";
            pdf_toolStripMenuItem1.Size = new Size(188, 30);
            pdf_toolStripMenuItem1.Text = "Save as Pdf";
            pdf_toolStripMenuItem1.Click += pdf_toolStripMenuItem1_Click;
            // 
            // excel_printToolStripMenuItem
            // 
            excel_printToolStripMenuItem.Image = Properties.Resources.excel;
            excel_printToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            excel_printToolStripMenuItem.Name = "excel_printToolStripMenuItem";
            excel_printToolStripMenuItem.Size = new Size(188, 30);
            excel_printToolStripMenuItem.Text = "Export to Excel";
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 64);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(paymentId_txtBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(amount_nud);
            groupBox1.Controls.Add(customerSearch_btn);
            groupBox1.Controls.Add(paymentDate_dtp);
            groupBox1.Controls.Add(comment_txtBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(customerName_txtBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(648, 176);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // paymentId_txtBox
            // 
            paymentId_txtBox.BorderStyle = BorderStyle.FixedSingle;
            paymentId_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "Id", true));
            paymentId_txtBox.Location = new Point(189, 23);
            paymentId_txtBox.Name = "paymentId_txtBox";
            paymentId_txtBox.ReadOnly = true;
            paymentId_txtBox.Size = new Size(258, 23);
            paymentId_txtBox.TabIndex = 14;
            // 
            // bindingSource1
            // 
            bindingSource1.DataMember = "ReceiveMoney";
            bindingSource1.DataSource = accDs1;
            // 
            // accDs1
            // 
            accDs1.DataSetName = "AccDs";
            accDs1.Namespace = "http://tempuri.org/AccDs.xsd";
            accDs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(172, 112);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 13;
            label4.Text = "$";
            // 
            // amount_nud
            // 
            amount_nud.DataBindings.Add(new Binding("Value", bindingSource1, "CashAmount", true));
            amount_nud.DecimalPlaces = 2;
            amount_nud.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            amount_nud.Location = new Point(189, 110);
            amount_nud.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            amount_nud.Name = "amount_nud";
            amount_nud.Size = new Size(258, 23);
            amount_nud.TabIndex = 12;
            // 
            // customerSearch_btn
            // 
            customerSearch_btn.ForeColor = Color.Black;
            customerSearch_btn.Location = new Point(71, 81);
            customerSearch_btn.Name = "customerSearch_btn";
            customerSearch_btn.Size = new Size(108, 23);
            customerSearch_btn.TabIndex = 11;
            customerSearch_btn.Text = "Customer Name:";
            customerSearch_btn.UseVisualStyleBackColor = true;
            customerSearch_btn.Click += customerSearch_btn_Click;
            // 
            // paymentDate_dtp
            // 
            paymentDate_dtp.DataBindings.Add(new Binding("Value", bindingSource1, "PayDate", true));
            paymentDate_dtp.Format = DateTimePickerFormat.Short;
            paymentDate_dtp.Location = new Point(189, 52);
            paymentDate_dtp.Name = "paymentDate_dtp";
            paymentDate_dtp.Size = new Size(258, 23);
            paymentDate_dtp.TabIndex = 10;
            // 
            // comment_txtBox
            // 
            comment_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "Comment", true));
            comment_txtBox.Location = new Point(189, 139);
            comment_txtBox.Name = "comment_txtBox";
            comment_txtBox.Size = new Size(412, 23);
            comment_txtBox.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(81, 143);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 4;
            label9.Text = "Comment:";
            // 
            // customerName_txtBox
            // 
            customerName_txtBox.BorderStyle = BorderStyle.FixedSingle;
            customerName_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "CusromerName", true));
            customerName_txtBox.Location = new Point(189, 81);
            customerName_txtBox.Name = "customerName_txtBox";
            customerName_txtBox.ReadOnly = true;
            customerName_txtBox.Size = new Size(258, 23);
            customerName_txtBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(81, 27);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 4;
            label1.Text = "Payment ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(81, 56);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 4;
            label2.Text = "Payment Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(81, 114);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Amount:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(46, 80, 119);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, cusromerNameDataGridViewTextBoxColumn, payDateDataGridViewTextBoxColumn, cashAmountDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn, invoiceIdDataGridViewTextBoxColumn, customerIdDataGridViewTextBoxColumn, regUserDataGridViewTextBoxColumn, regDateDataGridViewTextBoxColumn, regTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(648, 201);
            dataGridView1.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 60;
            // 
            // cusromerNameDataGridViewTextBoxColumn
            // 
            cusromerNameDataGridViewTextBoxColumn.DataPropertyName = "CusromerName";
            cusromerNameDataGridViewTextBoxColumn.HeaderText = "Cusromer Name";
            cusromerNameDataGridViewTextBoxColumn.Name = "cusromerNameDataGridViewTextBoxColumn";
            cusromerNameDataGridViewTextBoxColumn.ReadOnly = true;
            cusromerNameDataGridViewTextBoxColumn.Width = 120;
            // 
            // payDateDataGridViewTextBoxColumn
            // 
            payDateDataGridViewTextBoxColumn.DataPropertyName = "PayDate";
            payDateDataGridViewTextBoxColumn.HeaderText = "Pay Date";
            payDateDataGridViewTextBoxColumn.Name = "payDateDataGridViewTextBoxColumn";
            payDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cashAmountDataGridViewTextBoxColumn
            // 
            cashAmountDataGridViewTextBoxColumn.DataPropertyName = "CashAmount";
            dataGridViewCellStyle1.Format = "C2";
            cashAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            cashAmountDataGridViewTextBoxColumn.HeaderText = "Cash Amount";
            cashAmountDataGridViewTextBoxColumn.Name = "cashAmountDataGridViewTextBoxColumn";
            cashAmountDataGridViewTextBoxColumn.ReadOnly = true;
            cashAmountDataGridViewTextBoxColumn.Width = 130;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            commentDataGridViewTextBoxColumn.ReadOnly = true;
            commentDataGridViewTextBoxColumn.Width = 250;
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceId";
            invoiceIdDataGridViewTextBoxColumn.HeaderText = "InvoiceId";
            invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            invoiceIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId";
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            customerIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regUserDataGridViewTextBoxColumn
            // 
            regUserDataGridViewTextBoxColumn.DataPropertyName = "RegUser";
            regUserDataGridViewTextBoxColumn.HeaderText = "Reg User";
            regUserDataGridViewTextBoxColumn.Name = "regUserDataGridViewTextBoxColumn";
            regUserDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regDateDataGridViewTextBoxColumn
            // 
            regDateDataGridViewTextBoxColumn.DataPropertyName = "RegDate";
            regDateDataGridViewTextBoxColumn.HeaderText = "Reg Date";
            regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
            regDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regTimeDataGridViewTextBoxColumn
            // 
            regTimeDataGridViewTextBoxColumn.DataPropertyName = "RegTime";
            regTimeDataGridViewTextBoxColumn.HeaderText = "Reg Time";
            regTimeDataGridViewTextBoxColumn.Name = "regTimeDataGridViewTextBoxColumn";
            regTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(77, 161, 169);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(reg_time_label);
            panel1.Controls.Add(reg_date_label);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(reg_user_label);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 459);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 34);
            panel1.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(646, 9);
            label12.Name = "label12";
            label12.Size = new Size(63, 15);
            label12.TabIndex = 0;
            label12.Text = "Reg Time:";
            // 
            // reg_time_label
            // 
            reg_time_label.DataBindings.Add(new Binding("Text", bindingSource1, "RegTime", true));
            reg_time_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reg_time_label.ForeColor = Color.White;
            reg_time_label.Location = new Point(710, 9);
            reg_time_label.Name = "reg_time_label";
            reg_time_label.Size = new Size(90, 15);
            reg_time_label.TabIndex = 0;
            reg_time_label.Text = "-";
            // 
            // reg_date_label
            // 
            reg_date_label.DataBindings.Add(new Binding("Text", bindingSource1, "RegDate", true));
            reg_date_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reg_date_label.ForeColor = Color.White;
            reg_date_label.Location = new Point(376, 9);
            reg_date_label.Name = "reg_date_label";
            reg_date_label.Size = new Size(90, 15);
            reg_date_label.TabIndex = 0;
            reg_date_label.Text = "-";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.ForeColor = Color.White;
            label13.Location = new Point(314, 9);
            label13.Name = "label13";
            label13.Size = new Size(62, 15);
            label13.TabIndex = 0;
            label13.Text = "Reg Date:";
            // 
            // reg_user_label
            // 
            reg_user_label.DataBindings.Add(new Binding("Text", bindingSource1, "RegUser", true));
            reg_user_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reg_user_label.ForeColor = Color.White;
            reg_user_label.Location = new Point(73, 9);
            reg_user_label.Name = "reg_user_label";
            reg_user_label.Size = new Size(90, 15);
            reg_user_label.TabIndex = 0;
            reg_user_label.Text = "-";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(11, 9);
            label10.Name = "label10";
            label10.Size = new Size(61, 15);
            label10.TabIndex = 0;
            label10.Text = "Reg User:";
            // 
            // receiveMoneyTableAdapter1
            // 
            receiveMoneyTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(683, 122);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 4;
            label3.Text = "Customer ID:";
            // 
            // customerId_txtBox
            // 
            customerId_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "CustomerId", true));
            customerId_txtBox.Location = new Point(766, 119);
            customerId_txtBox.Name = "customerId_txtBox";
            customerId_txtBox.ReadOnly = true;
            customerId_txtBox.Size = new Size(78, 23);
            customerId_txtBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(683, 152);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 4;
            label6.Text = "Invoice ID:";
            // 
            // invoiceId_txtBox
            // 
            invoiceId_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "InvoiceId", true));
            invoiceId_txtBox.Location = new Point(766, 149);
            invoiceId_txtBox.Name = "invoiceId_txtBox";
            invoiceId_txtBox.ReadOnly = true;
            invoiceId_txtBox.Size = new Size(78, 23);
            invoiceId_txtBox.TabIndex = 9;
            // 
            // prog_panel1
            // 
            prog_panel1.BackColor = Color.FromArgb(77, 161, 169);
            prog_panel1.Controls.Add(progressBar1);
            prog_panel1.Controls.Add(prog_label9);
            prog_panel1.Controls.Add(label7);
            prog_panel1.Location = new Point(323, 200);
            prog_panel1.Name = "prog_panel1";
            prog_panel1.Size = new Size(200, 92);
            prog_panel1.TabIndex = 20;
            prog_panel1.Visible = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(0, 79);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(200, 13);
            progressBar1.TabIndex = 1;
            // 
            // prog_label9
            // 
            prog_label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            prog_label9.Location = new Point(3, 45);
            prog_label9.Name = "prog_label9";
            prog_label9.Size = new Size(194, 15);
            prog_label9.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(65, 12);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 0;
            label7.Text = "Please wait...";
            // 
            // ReceiveMoneyFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 80, 119);
            ClientSize = new Size(866, 493);
            Controls.Add(prog_panel1);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Controls.Add(invoiceId_txtBox);
            Controls.Add(label6);
            Controls.Add(customerId_txtBox);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ReceiveMoneyFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receive Money";
            Load += ReceiveMoneyFrm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).EndInit();
            ((System.ComponentModel.ISupportInitialize)amount_nud).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            prog_panel1.ResumeLayout(false);
            prog_panel1.PerformLayout();
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
        private GroupBox groupBox1;
        private TextBox paymentId_txtBox;
        private Label label4;
        private NumericUpDown amount_nud;
        private Button customerSearch_btn;
        private DateTimePicker paymentDate_dtp;
        private TextBox comment_txtBox;
        private Label label9;
        private TextBox customerName_txtBox;
        private Label label5;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label12;
        private Label reg_time_label;
        private Label reg_date_label;
        private Label label13;
        private Label reg_user_label;
        private Label label10;
        private Ds.AccDs accDs1;
        private BindingSource bindingSource1;
        private Ds.AccDsTableAdapters.ReceiveMoneyTableAdapter receiveMoneyTableAdapter1;
        private Label label3;
        private TextBox customerId_txtBox;
        private Label label6;
        private TextBox invoiceId_txtBox;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cusromerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn payDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cashAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regTimeDataGridViewTextBoxColumn;
        private ToolStripDropDownButton toolStripButton1;
        private ToolStripMenuItem print_toolStripMenuItem2;
        private ToolStripMenuItem pdf_toolStripMenuItem1;
        private ToolStripMenuItem excel_printToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private Panel prog_panel1;
        private ProgressBar progressBar1;
        private Label prog_label9;
        private Label label7;
    }
}
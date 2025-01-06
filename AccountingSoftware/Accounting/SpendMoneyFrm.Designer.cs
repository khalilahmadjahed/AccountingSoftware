namespace AccountingSoftware.Accounting
{
    partial class SpendMoneyFrm
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
            panel1 = new Panel();
            label12 = new Label();
            reg_time_label = new Label();
            bindingSource1 = new BindingSource(components);
            accDs1 = new Ds.AccDs();
            reg_date_label = new Label();
            label13 = new Label();
            reg_user_label = new Label();
            label10 = new Label();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            spendId_txtBox = new TextBox();
            label4 = new Label();
            amount_nud = new NumericUpDown();
            customerSearch_btn = new Button();
            spendDate_dtp = new DateTimePicker();
            comment_txtBox = new TextBox();
            label9 = new Label();
            customerName_txtBox = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
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
            purchaseId_txtBox = new TextBox();
            label6 = new Label();
            customerId_txtBox = new TextBox();
            label3 = new Label();
            spendMoneyTableAdapter1 = new Ds.AccDsTableAdapters.SpendMoneyTableAdapter();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cusromerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            payDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cashAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            purchaseIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)amount_nud).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
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
            panel1.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(646, 9);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 0;
            label12.Text = "Reg Time:";
            // 
            // reg_time_label
            // 
            reg_time_label.DataBindings.Add(new Binding("Text", bindingSource1, "RegTime", true));
            reg_time_label.Location = new Point(703, 9);
            reg_time_label.Name = "reg_time_label";
            reg_time_label.Size = new Size(90, 15);
            reg_time_label.TabIndex = 0;
            reg_time_label.Text = "-";
            // 
            // bindingSource1
            // 
            bindingSource1.DataMember = "SpendMoney";
            bindingSource1.DataSource = accDs1;
            // 
            // accDs1
            // 
            accDs1.DataSetName = "AccDs";
            accDs1.Namespace = "http://tempuri.org/AccDs.xsd";
            accDs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reg_date_label
            // 
            reg_date_label.DataBindings.Add(new Binding("Text", bindingSource1, "RegDate", true));
            reg_date_label.Location = new Point(368, 9);
            reg_date_label.Name = "reg_date_label";
            reg_date_label.Size = new Size(90, 15);
            reg_date_label.TabIndex = 0;
            reg_date_label.Text = "-";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(314, 9);
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, cusromerNameDataGridViewTextBoxColumn, payDateDataGridViewTextBoxColumn, cashAmountDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn, purchaseIdDataGridViewTextBoxColumn, customerIdDataGridViewTextBoxColumn, regUserDataGridViewTextBoxColumn, regDateDataGridViewTextBoxColumn, regTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(12, 249);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(648, 201);
            dataGridView1.TabIndex = 15;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(spendId_txtBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(amount_nud);
            groupBox1.Controls.Add(customerSearch_btn);
            groupBox1.Controls.Add(spendDate_dtp);
            groupBox1.Controls.Add(comment_txtBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(customerName_txtBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(648, 176);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // spendId_txtBox
            // 
            spendId_txtBox.BorderStyle = BorderStyle.FixedSingle;
            spendId_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "Id", true));
            spendId_txtBox.Location = new Point(189, 23);
            spendId_txtBox.Name = "spendId_txtBox";
            spendId_txtBox.ReadOnly = true;
            spendId_txtBox.Size = new Size(258, 23);
            spendId_txtBox.TabIndex = 14;
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
            customerSearch_btn.Location = new Point(71, 81);
            customerSearch_btn.Name = "customerSearch_btn";
            customerSearch_btn.Size = new Size(108, 23);
            customerSearch_btn.TabIndex = 11;
            customerSearch_btn.Text = "Customer Name:";
            customerSearch_btn.UseVisualStyleBackColor = true;
            customerSearch_btn.Click += customerSearch_btn_Click;
            // 
            // spendDate_dtp
            // 
            spendDate_dtp.DataBindings.Add(new Binding("Value", bindingSource1, "PayDate", true));
            spendDate_dtp.Format = DateTimePickerFormat.Short;
            spendDate_dtp.Location = new Point(189, 52);
            spendDate_dtp.Name = "spendDate_dtp";
            spendDate_dtp.Size = new Size(258, 23);
            spendDate_dtp.TabIndex = 10;
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
            label9.Location = new Point(71, 143);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 114);
            label5.Name = "label5";
            label5.Size = new Size(54, 15);
            label5.TabIndex = 4;
            label5.Text = "Amount:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 56);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Spend Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(71, 27);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Spend ID:";
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { new_btn, toolStripSeparator1, edit_btn, toolStripSeparator2, del_btn, toolStripSeparator3, save_btn, toolStripSeparator4, cancel_btn, toolStripSeparator5, toolStripSeparator6, search_btn, toolStripSeparator7 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(866, 64);
            toolStrip1.TabIndex = 11;
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
            new_btn.Text = "New Payment:";
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
            // purchaseId_txtBox
            // 
            purchaseId_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "PurchaseId", true));
            purchaseId_txtBox.Location = new Point(766, 149);
            purchaseId_txtBox.Name = "purchaseId_txtBox";
            purchaseId_txtBox.ReadOnly = true;
            purchaseId_txtBox.Size = new Size(78, 23);
            purchaseId_txtBox.TabIndex = 16;
            purchaseId_txtBox.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(683, 152);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 13;
            label6.Text = "Purchase ID:";
            // 
            // customerId_txtBox
            // 
            customerId_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "CustomerId", true));
            customerId_txtBox.Location = new Point(766, 119);
            customerId_txtBox.Name = "customerId_txtBox";
            customerId_txtBox.ReadOnly = true;
            customerId_txtBox.Size = new Size(78, 23);
            customerId_txtBox.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(683, 122);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 14;
            label3.Text = "Customer ID:";
            // 
            // spendMoneyTableAdapter1
            // 
            spendMoneyTableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
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
            cusromerNameDataGridViewTextBoxColumn.Width = 140;
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
            dataGridViewCellStyle1.Format = "c2";
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
            commentDataGridViewTextBoxColumn.Width = 200;
            // 
            // purchaseIdDataGridViewTextBoxColumn
            // 
            purchaseIdDataGridViewTextBoxColumn.DataPropertyName = "PurchaseId";
            purchaseIdDataGridViewTextBoxColumn.HeaderText = "Purchase Id";
            purchaseIdDataGridViewTextBoxColumn.Name = "purchaseIdDataGridViewTextBoxColumn";
            purchaseIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIdDataGridViewTextBoxColumn
            // 
            customerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId";
            customerIdDataGridViewTextBoxColumn.HeaderText = "Customer Id";
            customerIdDataGridViewTextBoxColumn.Name = "customerIdDataGridViewTextBoxColumn";
            customerIdDataGridViewTextBoxColumn.ReadOnly = true;
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
            // SpendMoneyFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 493);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            Controls.Add(purchaseId_txtBox);
            Controls.Add(label6);
            Controls.Add(customerId_txtBox);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SpendMoneyFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SpendMoneyFrm";
            Load += SpendMoneyFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)amount_nud).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label12;
        private Label reg_time_label;
        private Label reg_date_label;
        private Label label13;
        private Label reg_user_label;
        private Label label10;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox spendId_txtBox;
        private Label label4;
        private NumericUpDown amount_nud;
        private Button customerSearch_btn;
        private DateTimePicker spendDate_dtp;
        private TextBox comment_txtBox;
        private Label label9;
        private TextBox customerName_txtBox;
        private Label label5;
        private Label label2;
        private Label label1;
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
        private TextBox purchaseId_txtBox;
        private Label label6;
        private TextBox customerId_txtBox;
        private Label label3;
        private BindingSource bindingSource1;
        private Ds.AccDs accDs1;
        private Ds.AccDsTableAdapters.SpendMoneyTableAdapter spendMoneyTableAdapter1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cusromerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn payDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cashAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn purchaseIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regTimeDataGridViewTextBoxColumn;
    }
}
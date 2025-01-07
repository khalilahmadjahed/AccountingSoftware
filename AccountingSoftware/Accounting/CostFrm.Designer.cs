namespace AccountingSoftware.Accounting
{
    partial class CostFrm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
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
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costGroupDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            costAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            gn_comboBox1 = new ComboBox();
            costId_txtBox = new TextBox();
            label4 = new Label();
            amount_nud = new NumericUpDown();
            costDate_dtp = new DateTimePicker();
            comment_txtBox = new TextBox();
            label9 = new Label();
            label1 = new Label();
            label7 = new Label();
            label2 = new Label();
            label5 = new Label();
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
            costTableAdapter1 = new Ds.AccDsTableAdapters.CostTableAdapter();
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
            panel1.BackColor = Color.FromArgb(77, 161, 169);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label12);
            panel1.Controls.Add(reg_time_label);
            panel1.Controls.Add(reg_date_label);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(reg_user_label);
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 460);
            panel1.Name = "panel1";
            panel1.Size = new Size(669, 34);
            panel1.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(505, 9);
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
            reg_time_label.Location = new Point(569, 9);
            reg_time_label.Name = "reg_time_label";
            reg_time_label.Size = new Size(90, 15);
            reg_time_label.TabIndex = 0;
            reg_time_label.Text = "-";
            // 
            // bindingSource1
            // 
            bindingSource1.DataMember = "Cost";
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
            reg_date_label.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            reg_date_label.ForeColor = Color.White;
            reg_date_label.Location = new Point(305, 9);
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
            label13.Location = new Point(243, 9);
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(46, 80, 119);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, costGroupDataGridViewTextBoxColumn, costDateDataGridViewTextBoxColumn, costAmountDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn, regUserDataGridViewTextBoxColumn, regDateDataGridViewTextBoxColumn, regTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 251);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(648, 201);
            dataGridView1.TabIndex = 15;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "ID";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 60;
            // 
            // costGroupDataGridViewTextBoxColumn
            // 
            costGroupDataGridViewTextBoxColumn.DataPropertyName = "CostGroup";
            costGroupDataGridViewTextBoxColumn.HeaderText = "Group";
            costGroupDataGridViewTextBoxColumn.Name = "costGroupDataGridViewTextBoxColumn";
            costGroupDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costDateDataGridViewTextBoxColumn
            // 
            costDateDataGridViewTextBoxColumn.DataPropertyName = "CostDate";
            costDateDataGridViewTextBoxColumn.HeaderText = "Date";
            costDateDataGridViewTextBoxColumn.Name = "costDateDataGridViewTextBoxColumn";
            costDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // costAmountDataGridViewTextBoxColumn
            // 
            costAmountDataGridViewTextBoxColumn.DataPropertyName = "CostAmount";
            dataGridViewCellStyle2.Format = "c2";
            costAmountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            costAmountDataGridViewTextBoxColumn.HeaderText = "Amount";
            costAmountDataGridViewTextBoxColumn.Name = "costAmountDataGridViewTextBoxColumn";
            costAmountDataGridViewTextBoxColumn.ReadOnly = true;
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
            // groupBox1
            // 
            groupBox1.Controls.Add(gn_comboBox1);
            groupBox1.Controls.Add(costId_txtBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(amount_nud);
            groupBox1.Controls.Add(costDate_dtp);
            groupBox1.Controls.Add(comment_txtBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 69);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(648, 176);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // gn_comboBox1
            // 
            gn_comboBox1.DataBindings.Add(new Binding("Text", bindingSource1, "CostGroup", true));
            gn_comboBox1.FormattingEnabled = true;
            gn_comboBox1.Items.AddRange(new object[] { "Bills", "Delivery", "Paper", "Pens" });
            gn_comboBox1.Location = new Point(189, 82);
            gn_comboBox1.Name = "gn_comboBox1";
            gn_comboBox1.Size = new Size(258, 23);
            gn_comboBox1.TabIndex = 15;
            // 
            // costId_txtBox
            // 
            costId_txtBox.BorderStyle = BorderStyle.FixedSingle;
            costId_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "Id", true));
            costId_txtBox.Location = new Point(189, 23);
            costId_txtBox.Name = "costId_txtBox";
            costId_txtBox.ReadOnly = true;
            costId_txtBox.Size = new Size(258, 23);
            costId_txtBox.TabIndex = 14;
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
            amount_nud.DataBindings.Add(new Binding("Value", bindingSource1, "CostAmount", true));
            amount_nud.DecimalPlaces = 2;
            amount_nud.Increment = new decimal(new int[] { 5, 0, 0, 65536 });
            amount_nud.Location = new Point(189, 110);
            amount_nud.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            amount_nud.Name = "amount_nud";
            amount_nud.Size = new Size(258, 23);
            amount_nud.TabIndex = 12;
            // 
            // costDate_dtp
            // 
            costDate_dtp.DataBindings.Add(new Binding("Value", bindingSource1, "CostDate", true));
            costDate_dtp.Format = DateTimePickerFormat.Short;
            costDate_dtp.Location = new Point(189, 52);
            costDate_dtp.Name = "costDate_dtp";
            costDate_dtp.Size = new Size(258, 23);
            costDate_dtp.TabIndex = 10;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(81, 27);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Cost ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(81, 86);
            label7.Name = "label7";
            label7.Size = new Size(78, 15);
            label7.TabIndex = 4;
            label7.Text = "Group Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(81, 56);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 4;
            label2.Text = "Cost Date:";
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
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.WhiteSmoke;
            toolStrip1.Items.AddRange(new ToolStripItem[] { new_btn, toolStripSeparator1, edit_btn, toolStripSeparator2, del_btn, toolStripSeparator3, save_btn, toolStripSeparator4, cancel_btn, toolStripSeparator5, toolStripSeparator6, search_btn, toolStripSeparator7 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(669, 64);
            toolStrip1.TabIndex = 11;
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
            new_btn.Text = "New Cost:";
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
            // search_btn
            // 
            search_btn.Alignment = ToolStripItemAlignment.Right;
            search_btn.AutoSize = false;
            search_btn.ForeColor = Color.Black;
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
            // costTableAdapter1
            // 
            costTableAdapter1.ClearBeforeFill = true;
            // 
            // CostFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 80, 119);
            ClientSize = new Size(669, 494);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CostFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CostFrm";
            Load += CostFrm_Load;
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
        private TextBox costId_txtBox;
        private Label label4;
        private NumericUpDown amount_nud;
        private DateTimePicker costDate_dtp;
        private TextBox comment_txtBox;
        private Label label9;
        private Label label1;
        private Label label2;
        private Label label5;
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
        private Ds.AccDs accDs1;
        private Ds.AccDsTableAdapters.CostTableAdapter costTableAdapter1;
        private BindingSource bindingSource1;
        private ComboBox gn_comboBox1;
        private Label label7;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costGroupDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn costAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regTimeDataGridViewTextBoxColumn;
    }
}
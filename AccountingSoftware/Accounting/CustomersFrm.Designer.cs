namespace AccountingSoftware.Accounting
{
    partial class CustomersFrm
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
            gender_comboBox1 = new ComboBox();
            bindingSource1 = new BindingSource(components);
            accDs1 = new Ds.AccDs();
            comment_txtBox = new TextBox();
            label9 = new Label();
            address_txtBox = new TextBox();
            label8 = new Label();
            email_txtBox = new TextBox();
            label7 = new Label();
            cellPhone_txtBox = new TextBox();
            label6 = new Label();
            landLine_txtBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            lastName_txtBox = new TextBox();
            label3 = new Label();
            userName_txtBox = new TextBox();
            label2 = new Label();
            id_txtBox = new TextBox();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            genderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            landLineDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cellNumDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            emailDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            adressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label12 = new Label();
            reg_time_label = new Label();
            reg_date_label = new Label();
            label13 = new Label();
            reg_user_label = new Label();
            label10 = new Label();
            customersTableAdapter1 = new Ds.AccDsTableAdapters.CustomersTableAdapter();
            search_panel2 = new Panel();
            search_lName_button2 = new Button();
            search_id_button1 = new Button();
            search_lName_textBox2 = new TextBox();
            search_id_textBox1 = new TextBox();
            label14 = new Label();
            label11 = new Label();
            toolStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            search_panel2.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.Items.AddRange(new ToolStripItem[] { new_btn, toolStripSeparator1, edit_btn, toolStripSeparator2, del_btn, toolStripSeparator3, save_btn, toolStripSeparator4, cancel_btn, toolStripSeparator5, toolStripSeparator6, search_btn, toolStripSeparator7 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(684, 64);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // new_btn
            // 
            new_btn.AutoSize = false;
            new_btn.Image = Properties.Resources.new_butt;
            new_btn.ImageScaling = ToolStripItemImageScaling.None;
            new_btn.ImageTransparentColor = Color.Magenta;
            new_btn.Name = "new_btn";
            new_btn.Size = new Size(90, 58);
            new_btn.Text = "New";
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
            search_btn.Click += search_btn_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Alignment = ToolStripItemAlignment.Right;
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new Size(6, 64);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gender_comboBox1);
            groupBox1.Controls.Add(comment_txtBox);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(address_txtBox);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(email_txtBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cellPhone_txtBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(landLine_txtBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lastName_txtBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(userName_txtBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(id_txtBox);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 287);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // gender_comboBox1
            // 
            gender_comboBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Gender", true));
            gender_comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            gender_comboBox1.FormattingEnabled = true;
            gender_comboBox1.Items.AddRange(new object[] { "Male", "Female" });
            gender_comboBox1.Location = new Point(246, 104);
            gender_comboBox1.Name = "gender_comboBox1";
            gender_comboBox1.Size = new Size(238, 23);
            gender_comboBox1.TabIndex = 4;
            // 
            // bindingSource1
            // 
            bindingSource1.DataMember = "Customers";
            bindingSource1.DataSource = accDs1;
            // 
            // accDs1
            // 
            accDs1.DataSetName = "AccDs";
            accDs1.Namespace = "http://tempuri.org/AccDs.xsd";
            accDs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comment_txtBox
            // 
            comment_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "Comment", true));
            comment_txtBox.Location = new Point(246, 248);
            comment_txtBox.Name = "comment_txtBox";
            comment_txtBox.Size = new Size(238, 23);
            comment_txtBox.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(167, 251);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 4;
            label9.Text = "Comment:";
            // 
            // address_txtBox
            // 
            address_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "Adress", true));
            address_txtBox.Location = new Point(246, 219);
            address_txtBox.Name = "address_txtBox";
            address_txtBox.Size = new Size(238, 23);
            address_txtBox.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(167, 222);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 4;
            label8.Text = "Address:";
            // 
            // email_txtBox
            // 
            email_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "Email", true));
            email_txtBox.Location = new Point(246, 190);
            email_txtBox.Name = "email_txtBox";
            email_txtBox.Size = new Size(238, 23);
            email_txtBox.TabIndex = 7;
            email_txtBox.TextChanged += email_txtBox_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(167, 193);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 4;
            label7.Text = "Email:";
            // 
            // cellPhone_txtBox
            // 
            cellPhone_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "CellNum", true));
            cellPhone_txtBox.Location = new Point(246, 161);
            cellPhone_txtBox.Name = "cellPhone_txtBox";
            cellPhone_txtBox.Size = new Size(238, 23);
            cellPhone_txtBox.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(167, 164);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 4;
            label6.Text = "Cell Phone";
            // 
            // landLine_txtBox
            // 
            landLine_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "LandLine", true));
            landLine_txtBox.Location = new Point(246, 132);
            landLine_txtBox.Name = "landLine_txtBox";
            landLine_txtBox.Size = new Size(238, 23);
            landLine_txtBox.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(167, 135);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 4;
            label5.Text = "Land Line:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(167, 106);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 4;
            label4.Text = "Gender:";
            // 
            // lastName_txtBox
            // 
            lastName_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "LastName", true));
            lastName_txtBox.Location = new Point(246, 74);
            lastName_txtBox.Name = "lastName_txtBox";
            lastName_txtBox.Size = new Size(238, 23);
            lastName_txtBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 77);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 4;
            label3.Text = "Last Name:";
            // 
            // userName_txtBox
            // 
            userName_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "FirstName", true));
            userName_txtBox.Location = new Point(246, 45);
            userName_txtBox.Name = "userName_txtBox";
            userName_txtBox.Size = new Size(238, 23);
            userName_txtBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(167, 48);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 4;
            label2.Text = "User Name:";
            // 
            // id_txtBox
            // 
            id_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "ID", true));
            id_txtBox.Location = new Point(246, 16);
            id_txtBox.Name = "id_txtBox";
            id_txtBox.ReadOnly = true;
            id_txtBox.Size = new Size(238, 23);
            id_txtBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(167, 16);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 4;
            label1.Text = "ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, landLineDataGridViewTextBoxColumn, cellNumDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, adressDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn, regNameDataGridViewTextBoxColumn, regDateDataGridViewTextBoxColumn, regTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(12, 359);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(660, 125);
            dataGridView1.TabIndex = 2;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Width = 50;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "First Name";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            genderDataGridViewTextBoxColumn.Width = 70;
            // 
            // landLineDataGridViewTextBoxColumn
            // 
            landLineDataGridViewTextBoxColumn.DataPropertyName = "LandLine";
            landLineDataGridViewTextBoxColumn.HeaderText = "Land Line";
            landLineDataGridViewTextBoxColumn.Name = "landLineDataGridViewTextBoxColumn";
            landLineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellNumDataGridViewTextBoxColumn
            // 
            cellNumDataGridViewTextBoxColumn.DataPropertyName = "CellNum";
            cellNumDataGridViewTextBoxColumn.HeaderText = "Cell Number";
            cellNumDataGridViewTextBoxColumn.Name = "cellNumDataGridViewTextBoxColumn";
            cellNumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            adressDataGridViewTextBoxColumn.ReadOnly = true;
            adressDataGridViewTextBoxColumn.Width = 250;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            commentDataGridViewTextBoxColumn.ReadOnly = true;
            commentDataGridViewTextBoxColumn.Width = 300;
            // 
            // regNameDataGridViewTextBoxColumn
            // 
            regNameDataGridViewTextBoxColumn.DataPropertyName = "RegName";
            regNameDataGridViewTextBoxColumn.HeaderText = "Reg Name";
            regNameDataGridViewTextBoxColumn.Name = "regNameDataGridViewTextBoxColumn";
            regNameDataGridViewTextBoxColumn.ReadOnly = true;
            regNameDataGridViewTextBoxColumn.Width = 65;
            // 
            // regDateDataGridViewTextBoxColumn
            // 
            regDateDataGridViewTextBoxColumn.DataPropertyName = "RegDate";
            regDateDataGridViewTextBoxColumn.HeaderText = "Reg Date";
            regDateDataGridViewTextBoxColumn.Name = "regDateDataGridViewTextBoxColumn";
            regDateDataGridViewTextBoxColumn.ReadOnly = true;
            regDateDataGridViewTextBoxColumn.Width = 65;
            // 
            // regTimeDataGridViewTextBoxColumn
            // 
            regTimeDataGridViewTextBoxColumn.DataPropertyName = "RegTime";
            regTimeDataGridViewTextBoxColumn.HeaderText = "Reg Time";
            regTimeDataGridViewTextBoxColumn.Name = "regTimeDataGridViewTextBoxColumn";
            regTimeDataGridViewTextBoxColumn.ReadOnly = true;
            regTimeDataGridViewTextBoxColumn.Width = 65;
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
            panel1.Location = new Point(0, 490);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 34);
            panel1.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(516, 9);
            label12.Name = "label12";
            label12.Size = new Size(59, 15);
            label12.TabIndex = 0;
            label12.Text = "Reg Time:";
            // 
            // reg_time_label
            // 
            reg_time_label.Location = new Point(581, 9);
            reg_time_label.Name = "reg_time_label";
            reg_time_label.Size = new Size(90, 15);
            reg_time_label.TabIndex = 0;
            reg_time_label.Text = "-";
            // 
            // reg_date_label
            // 
            reg_date_label.Location = new Point(320, 9);
            reg_date_label.Name = "reg_date_label";
            reg_date_label.Size = new Size(90, 15);
            reg_date_label.TabIndex = 0;
            reg_date_label.Text = "-";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(257, 9);
            label13.Name = "label13";
            label13.Size = new Size(57, 15);
            label13.TabIndex = 0;
            label13.Text = "Reg Date:";
            // 
            // reg_user_label
            // 
            reg_user_label.Location = new Point(73, 9);
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
            // customersTableAdapter1
            // 
            customersTableAdapter1.ClearBeforeFill = true;
            // 
            // search_panel2
            // 
            search_panel2.BorderStyle = BorderStyle.Fixed3D;
            search_panel2.Controls.Add(search_lName_button2);
            search_panel2.Controls.Add(search_id_button1);
            search_panel2.Controls.Add(search_lName_textBox2);
            search_panel2.Controls.Add(search_id_textBox1);
            search_panel2.Controls.Add(label14);
            search_panel2.Controls.Add(label11);
            search_panel2.Location = new Point(459, 65);
            search_panel2.Name = "search_panel2";
            search_panel2.Size = new Size(220, 86);
            search_panel2.TabIndex = 4;
            search_panel2.Visible = false;
            // 
            // search_lName_button2
            // 
            search_lName_button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_lName_button2.Location = new Point(174, 47);
            search_lName_button2.Name = "search_lName_button2";
            search_lName_button2.Size = new Size(37, 23);
            search_lName_button2.TabIndex = 2;
            search_lName_button2.Text = "Go";
            search_lName_button2.UseVisualStyleBackColor = true;
            search_lName_button2.Click += search_lName_button2_Click;
            // 
            // search_id_button1
            // 
            search_id_button1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_id_button1.Location = new Point(174, 11);
            search_id_button1.Name = "search_id_button1";
            search_id_button1.Size = new Size(37, 23);
            search_id_button1.TabIndex = 2;
            search_id_button1.Text = "Go";
            search_id_button1.UseVisualStyleBackColor = true;
            search_id_button1.Click += search_id_button1_Click;
            // 
            // search_lName_textBox2
            // 
            search_lName_textBox2.Location = new Point(71, 47);
            search_lName_textBox2.Name = "search_lName_textBox2";
            search_lName_textBox2.Size = new Size(100, 23);
            search_lName_textBox2.TabIndex = 1;
            // 
            // search_id_textBox1
            // 
            search_id_textBox1.Location = new Point(71, 11);
            search_id_textBox1.Name = "search_id_textBox1";
            search_id_textBox1.Size = new Size(100, 23);
            search_id_textBox1.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(4, 50);
            label14.Name = "label14";
            label14.Size = new Size(66, 15);
            label14.TabIndex = 0;
            label14.Text = "Last Name:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(4, 13);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 0;
            label11.Text = "ID:";
            // 
            // CustomersFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 524);
            Controls.Add(search_panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "CustomersFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomersFrm";
            Load += CustomersFrm_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            search_panel2.ResumeLayout(false);
            search_panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStrip toolStrip1;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private Panel panel1;
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
        private TextBox address_txtBox;
        private Label label8;
        private TextBox email_txtBox;
        private Label label7;
        private TextBox cellPhone_txtBox;
        private Label label6;
        private TextBox landLine_txtBox;
        private Label label5;
        private Label label4;
        private TextBox lastName_txtBox;
        private Label label3;
        private TextBox userName_txtBox;
        private Label label2;
        private TextBox id_txtBox;
        private Label label1;
        private TextBox comment_txtBox;
        private Label label9;
        private Ds.AccDs accDs1;
        private BindingSource bindingSource1;
        private ComboBox gender_comboBox1;
        private Ds.AccDsTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn landLineDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cellNumDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regTimeDataGridViewTextBoxColumn;
        private Label label12;
        private Label reg_time_label;
        private Label reg_date_label;
        private Label label13;
        private Label reg_user_label;
        private Label label10;
        private ToolStripSeparator toolStripSeparator6;
        private Panel search_panel2;
        private Label label11;
        private Button search_id_button1;
        private TextBox search_lName_textBox2;
        private TextBox search_id_textBox1;
        private Label label14;
        private Button search_lName_button2;
        private ToolStripButton search_btn;
        private ToolStripSeparator toolStripSeparator7;
    }
}
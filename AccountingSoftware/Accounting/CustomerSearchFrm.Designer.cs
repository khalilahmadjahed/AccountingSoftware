namespace AccountingSoftware.Accounting
{
    partial class CustomerSearchFrm
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
            search_panel2 = new Panel();
            search_lName_button2 = new Button();
            search_id_button1 = new Button();
            search_lName_textBox2 = new TextBox();
            search_id_textBox1 = new TextBox();
            label14 = new Label();
            label11 = new Label();
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
            bindingSource1 = new BindingSource(components);
            accDs1 = new Ds.AccDs();
            panel1 = new Panel();
            lastName_lbl = new Label();
            label5 = new Label();
            firstName_lbl = new Label();
            label3 = new Label();
            id_lbl = new Label();
            label2 = new Label();
            ok_btn = new Button();
            button1 = new Button();
            customersTableAdapter1 = new Ds.AccDsTableAdapters.CustomersTableAdapter();
            showAll_btn = new Button();
            search_panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // search_panel2
            // 
            search_panel2.BackColor = Color.WhiteSmoke;
            search_panel2.BorderStyle = BorderStyle.FixedSingle;
            search_panel2.Controls.Add(search_lName_button2);
            search_panel2.Controls.Add(search_id_button1);
            search_panel2.Controls.Add(search_lName_textBox2);
            search_panel2.Controls.Add(search_id_textBox1);
            search_panel2.Controls.Add(label14);
            search_panel2.Controls.Add(label11);
            search_panel2.Location = new Point(12, 12);
            search_panel2.Name = "search_panel2";
            search_panel2.Size = new Size(595, 49);
            search_panel2.TabIndex = 5;
            // 
            // search_lName_button2
            // 
            search_lName_button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_lName_button2.Location = new Point(523, 11);
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
            search_id_button1.Location = new Point(164, 10);
            search_id_button1.Name = "search_id_button1";
            search_id_button1.Size = new Size(37, 23);
            search_id_button1.TabIndex = 2;
            search_id_button1.Text = "Go";
            search_id_button1.UseVisualStyleBackColor = true;
            search_id_button1.Click += search_id_button1_Click;
            // 
            // search_lName_textBox2
            // 
            search_lName_textBox2.Location = new Point(417, 11);
            search_lName_textBox2.Name = "search_lName_textBox2";
            search_lName_textBox2.Size = new Size(100, 23);
            search_lName_textBox2.TabIndex = 1;
            // 
            // search_id_textBox1
            // 
            search_id_textBox1.Location = new Point(58, 11);
            search_id_textBox1.Name = "search_id_textBox1";
            search_id_textBox1.Size = new Size(100, 23);
            search_id_textBox1.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(350, 15);
            label14.Name = "label14";
            label14.Size = new Size(66, 15);
            label14.TabIndex = 0;
            label14.Text = "Last Name:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(35, 15);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 0;
            label11.Text = "ID:";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, genderDataGridViewTextBoxColumn, landLineDataGridViewTextBoxColumn, cellNumDataGridViewTextBoxColumn, emailDataGridViewTextBoxColumn, adressDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn, regNameDataGridViewTextBoxColumn, regDateDataGridViewTextBoxColumn, regTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(10, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(597, 283);
            dataGridView1.TabIndex = 7;
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
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // landLineDataGridViewTextBoxColumn
            // 
            landLineDataGridViewTextBoxColumn.DataPropertyName = "LandLine";
            landLineDataGridViewTextBoxColumn.HeaderText = "LandLine";
            landLineDataGridViewTextBoxColumn.Name = "landLineDataGridViewTextBoxColumn";
            landLineDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cellNumDataGridViewTextBoxColumn
            // 
            cellNumDataGridViewTextBoxColumn.DataPropertyName = "CellNum";
            cellNumDataGridViewTextBoxColumn.HeaderText = "CellNum";
            cellNumDataGridViewTextBoxColumn.Name = "cellNumDataGridViewTextBoxColumn";
            cellNumDataGridViewTextBoxColumn.ReadOnly = true;
            cellNumDataGridViewTextBoxColumn.Width = 110;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            emailDataGridViewTextBoxColumn.HeaderText = "Email";
            emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            adressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // regNameDataGridViewTextBoxColumn
            // 
            regNameDataGridViewTextBoxColumn.DataPropertyName = "RegName";
            regNameDataGridViewTextBoxColumn.HeaderText = "RegName";
            regNameDataGridViewTextBoxColumn.Name = "regNameDataGridViewTextBoxColumn";
            regNameDataGridViewTextBoxColumn.ReadOnly = true;
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
            bindingSource1.DataMember = "Customers";
            bindingSource1.DataSource = accDs1;
            // 
            // accDs1
            // 
            accDs1.DataSetName = "AccDs";
            accDs1.Namespace = "http://tempuri.org/AccDs.xsd";
            accDs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lastName_lbl);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(firstName_lbl);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(id_lbl);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(12, 356);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 38);
            panel1.TabIndex = 8;
            // 
            // lastName_lbl
            // 
            lastName_lbl.DataBindings.Add(new Binding("Text", bindingSource1, "LastName", true));
            lastName_lbl.Location = new Point(492, 11);
            lastName_lbl.Name = "lastName_lbl";
            lastName_lbl.Size = new Size(90, 15);
            lastName_lbl.TabIndex = 0;
            lastName_lbl.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 10);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 0;
            label5.Text = "Last Name:";
            // 
            // firstName_lbl
            // 
            firstName_lbl.DataBindings.Add(new Binding("Text", bindingSource1, "FirstName", true));
            firstName_lbl.Location = new Point(260, 10);
            firstName_lbl.Name = "firstName_lbl";
            firstName_lbl.Size = new Size(102, 15);
            firstName_lbl.TabIndex = 0;
            firstName_lbl.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 10);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 0;
            label3.Text = "First Name:";
            // 
            // id_lbl
            // 
            id_lbl.DataBindings.Add(new Binding("Text", bindingSource1, "ID", true));
            id_lbl.Location = new Point(34, 10);
            id_lbl.Name = "id_lbl";
            id_lbl.Size = new Size(78, 15);
            id_lbl.TabIndex = 0;
            id_lbl.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 10);
            label2.Name = "label2";
            label2.Size = new Size(21, 15);
            label2.TabIndex = 0;
            label2.Text = "ID:";
            // 
            // ok_btn
            // 
            ok_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ok_btn.Image = Properties.Resources.ok;
            ok_btn.Location = new Point(12, 402);
            ok_btn.Name = "ok_btn";
            ok_btn.Size = new Size(147, 45);
            ok_btn.TabIndex = 9;
            ok_btn.Text = "OK";
            ok_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ok_btn.UseVisualStyleBackColor = true;
            ok_btn.Click += ok_btn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.canecl_butt;
            button1.Location = new Point(165, 402);
            button1.Name = "button1";
            button1.Size = new Size(110, 46);
            button1.TabIndex = 9;
            button1.Text = "Cancle";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // customersTableAdapter1
            // 
            customersTableAdapter1.ClearBeforeFill = true;
            // 
            // showAll_btn
            // 
            showAll_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showAll_btn.Image = Properties.Resources.show_all;
            showAll_btn.Location = new Point(460, 400);
            showAll_btn.Name = "showAll_btn";
            showAll_btn.Size = new Size(147, 45);
            showAll_btn.TabIndex = 2;
            showAll_btn.Text = "Show All";
            showAll_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            showAll_btn.UseVisualStyleBackColor = true;
            showAll_btn.Click += showAll_btn_Click;
            // 
            // CustomerSearchFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(619, 462);
            ControlBox = false;
            Controls.Add(showAll_btn);
            Controls.Add(button1);
            Controls.Add(ok_btn);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(search_panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CustomerSearchFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Search";
            Load += CustomerSearchFrm_Load;
            search_panel2.ResumeLayout(false);
            search_panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel search_panel2;
        private Button search_lName_button2;
        private Button search_id_button1;
        private TextBox search_lName_textBox2;
        private TextBox search_id_textBox1;
        private Label label14;
        private Label label11;
        private DataGridView dataGridView1;
        private Panel panel1;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button ok_btn;
        private Button button1;
        private Ds.AccDs accDs1;
        private BindingSource bindingSource1;
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
        public Label lastName_lbl;
        public Label firstName_lbl;
        public Label id_lbl;
        private Button showAll_btn;
    }
}
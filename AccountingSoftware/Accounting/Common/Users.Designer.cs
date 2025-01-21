namespace AccountingSoftware.Accounting.Common
{
    partial class Users
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
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            photo_pictureBox1 = new PictureBox();
            browse_button1 = new Button();
            comment_textBox1 = new TextBox();
            password_repeat_txtBox = new TextBox();
            password_txtBox = new TextBox();
            label4 = new Label();
            label5 = new Label();
            id_txtBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            userName_txtBox = new TextBox();
            label2 = new Label();
            usersTableAdapter1 = new Ds.AccDsTableAdapters.UsersTableAdapter();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)photo_pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.BackColor = Color.WhiteSmoke;
            toolStrip1.Items.AddRange(new ToolStripItem[] { new_btn, toolStripSeparator1, edit_btn, toolStripSeparator2, del_btn, toolStripSeparator3, save_btn, toolStripSeparator4, cancel_btn, toolStripSeparator5 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(684, 64);
            toolStrip1.TabIndex = 12;
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
            new_btn.Text = " New User";
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
            panel1.Location = new Point(0, 456);
            panel1.Name = "panel1";
            panel1.Size = new Size(684, 34);
            panel1.TabIndex = 19;
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
            bindingSource1.DataMember = "Users";
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
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, userNameDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn, regUserDataGridViewTextBoxColumn, regDateDataGridViewTextBoxColumn, regTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.GridColor = Color.Black;
            dataGridView1.Location = new Point(12, 285);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(660, 165);
            dataGridView1.TabIndex = 20;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Width = 60;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            userNameDataGridViewTextBoxColumn.HeaderText = "User Name";
            userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            userNameDataGridViewTextBoxColumn.ReadOnly = true;
            userNameDataGridViewTextBoxColumn.Width = 120;
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
            groupBox1.Controls.Add(photo_pictureBox1);
            groupBox1.Controls.Add(browse_button1);
            groupBox1.Controls.Add(comment_textBox1);
            groupBox1.Controls.Add(password_repeat_txtBox);
            groupBox1.Controls.Add(password_txtBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(id_txtBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(userName_txtBox);
            groupBox1.Controls.Add(label2);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 67);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(660, 212);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "Info";
            // 
            // photo_pictureBox1
            // 
            photo_pictureBox1.DataBindings.Add(new Binding("Image", bindingSource1, "Photo", true));
            photo_pictureBox1.Location = new Point(484, 37);
            photo_pictureBox1.Name = "photo_pictureBox1";
            photo_pictureBox1.Size = new Size(90, 80);
            photo_pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            photo_pictureBox1.TabIndex = 29;
            photo_pictureBox1.TabStop = false;
            // 
            // browse_button1
            // 
            browse_button1.ForeColor = Color.Black;
            browse_button1.Location = new Point(484, 121);
            browse_button1.Name = "browse_button1";
            browse_button1.Size = new Size(90, 23);
            browse_button1.TabIndex = 28;
            browse_button1.Text = "Browse";
            browse_button1.UseVisualStyleBackColor = true;
            browse_button1.Click += browse_button1_Click;
            // 
            // comment_textBox1
            // 
            comment_textBox1.DataBindings.Add(new Binding("Text", bindingSource1, "Comment", true));
            comment_textBox1.Location = new Point(194, 165);
            comment_textBox1.Name = "comment_textBox1";
            comment_textBox1.Size = new Size(385, 23);
            comment_textBox1.TabIndex = 24;
            // 
            // password_repeat_txtBox
            // 
            password_repeat_txtBox.Font = new Font("Segoe UI", 12F);
            password_repeat_txtBox.Location = new Point(194, 130);
            password_repeat_txtBox.MaxLength = 20;
            password_repeat_txtBox.Name = "password_repeat_txtBox";
            password_repeat_txtBox.PasswordChar = '*';
            password_repeat_txtBox.Size = new Size(238, 29);
            password_repeat_txtBox.TabIndex = 24;
            // 
            // password_txtBox
            // 
            password_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "Password", true));
            password_txtBox.Font = new Font("Segoe UI", 12F);
            password_txtBox.Location = new Point(194, 95);
            password_txtBox.MaxLength = 20;
            password_txtBox.Name = "password_txtBox";
            password_txtBox.PasswordChar = '*';
            password_txtBox.Size = new Size(238, 29);
            password_txtBox.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(89, 168);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 25;
            label4.Text = "Comment:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(89, 137);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 25;
            label5.Text = "Password Repeat:";
            // 
            // id_txtBox
            // 
            id_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "ID", true));
            id_txtBox.Location = new Point(194, 37);
            id_txtBox.Name = "id_txtBox";
            id_txtBox.ReadOnly = true;
            id_txtBox.Size = new Size(238, 23);
            id_txtBox.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(89, 102);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 25;
            label3.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 37);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 27;
            label1.Text = "ID:";
            // 
            // userName_txtBox
            // 
            userName_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "UserName", true));
            userName_txtBox.Location = new Point(194, 66);
            userName_txtBox.MaxLength = 50;
            userName_txtBox.Name = "userName_txtBox";
            userName_txtBox.Size = new Size(238, 23);
            userName_txtBox.TabIndex = 23;
            userName_txtBox.Text = " ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(89, 69);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 26;
            label2.Text = "User Name:";
            // 
            // usersTableAdapter1
            // 
            usersTableAdapter1.ClearBeforeFill = true;
            // 
            // Users
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 80, 119);
            ClientSize = new Size(684, 490);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Controls.Add(toolStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Users";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Users";
            Load += Users_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)photo_pictureBox1).EndInit();
            ResumeLayout(false);
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
        private Panel panel1;
        private Label label12;
        private Label reg_time_label;
        private Label reg_date_label;
        private Label label13;
        private Label reg_user_label;
        private Label label10;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox comment_textBox1;
        private TextBox password_txtBox;
        private Label label4;
        private TextBox id_txtBox;
        private Label label3;
        private Label label1;
        private TextBox userName_txtBox;
        private Label label2;
        private TextBox password_repeat_txtBox;
        private Label label5;
        private PictureBox photo_pictureBox1;
        private Button browse_button1;
        private Ds.AccDs accDs1;
        private BindingSource bindingSource1;
        private Ds.AccDsTableAdapters.UsersTableAdapter usersTableAdapter1;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regTimeDataGridViewTextBoxColumn;
    }
}
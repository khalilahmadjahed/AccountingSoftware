namespace AccountingSoftware.Accounting.Common
{
    partial class Login
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
            photo_pictureBox1 = new PictureBox();
            label2 = new Label();
            comboBox1 = new ComboBox();
            password_txtBox = new TextBox();
            label3 = new Label();
            button1 = new Button();
            panel1 = new Panel();
            button2 = new Button();
            accDs1 = new Ds.AccDs();
            usersTableAdapter1 = new Ds.AccDsTableAdapters.UsersTableAdapter();
            bindingSource1 = new BindingSource(components);
            correct_pass_txtBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)photo_pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // photo_pictureBox1
            // 
            photo_pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            photo_pictureBox1.Location = new Point(155, 55);
            photo_pictureBox1.Name = "photo_pictureBox1";
            photo_pictureBox1.Size = new Size(135, 114);
            photo_pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            photo_pictureBox1.TabIndex = 30;
            photo_pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(67, 180);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 31;
            label2.Text = "User Name:";
            // 
            // comboBox1
            // 
            comboBox1.DataSource = bindingSource1;
            comboBox1.DisplayMember = "UserName";
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(154, 179);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(136, 23);
            comboBox1.TabIndex = 32;
            // 
            // password_txtBox
            // 
            password_txtBox.Font = new Font("Segoe UI", 12F);
            password_txtBox.Location = new Point(154, 211);
            password_txtBox.MaxLength = 20;
            password_txtBox.Name = "password_txtBox";
            password_txtBox.PasswordChar = '*';
            password_txtBox.Size = new Size(136, 29);
            password_txtBox.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(67, 215);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 34;
            label3.Text = "Password:";
            // 
            // button1
            // 
            button1.Image = Properties.Resources.ok;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(84, 269);
            button1.Name = "button1";
            button1.Size = new Size(123, 39);
            button1.TabIndex = 35;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(67, 253);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 36;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.canecl_butt;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(233, 269);
            button2.Name = "button2";
            button2.Size = new Size(123, 39);
            button2.TabIndex = 35;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // accDs1
            // 
            accDs1.DataSetName = "AccDs";
            accDs1.Namespace = "http://tempuri.org/AccDs.xsd";
            accDs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter1
            // 
            usersTableAdapter1.ClearBeforeFill = true;
            // 
            // bindingSource1
            // 
            bindingSource1.DataMember = "Users";
            bindingSource1.DataSource = accDs1;
            // 
            // correct_pass_txtBox
            // 
            correct_pass_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "Password", true));
            correct_pass_txtBox.Font = new Font("Segoe UI", 10F);
            correct_pass_txtBox.Location = new Point(444, 106);
            correct_pass_txtBox.MaxLength = 20;
            correct_pass_txtBox.Name = "correct_pass_txtBox";
            correct_pass_txtBox.PasswordChar = '*';
            correct_pass_txtBox.Size = new Size(90, 25);
            correct_pass_txtBox.TabIndex = 37;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(378, 111);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 38;
            label1.Text = "Password:";
            label1.Click += label1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 354);
            ControlBox = false;
            Controls.Add(correct_pass_txtBox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(password_txtBox);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(photo_pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)photo_pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox photo_pictureBox1;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox password_txtBox;
        private Label label3;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private BindingSource bindingSource1;
        private Ds.AccDs accDs1;
        private Ds.AccDsTableAdapters.UsersTableAdapter usersTableAdapter1;
        private TextBox correct_pass_txtBox;
        private Label label1;
    }
}
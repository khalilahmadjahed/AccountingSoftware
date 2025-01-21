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
            bindingSource1 = new BindingSource(components);
            accDs1 = new Ds.AccDs();
            label2 = new Label();
            users_comboBox1 = new ComboBox();
            user_password_txtBox = new TextBox();
            label3 = new Label();
            ok_button1 = new Button();
            panel1 = new Panel();
            cancel_button2 = new Button();
            usersTableAdapter1 = new Ds.AccDsTableAdapters.UsersTableAdapter();
            correct_pass_txtBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)photo_pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).BeginInit();
            SuspendLayout();
            // 
            // photo_pictureBox1
            // 
            photo_pictureBox1.DataBindings.Add(new Binding("Image", bindingSource1, "Photo", true));
            photo_pictureBox1.Location = new Point(155, 55);
            photo_pictureBox1.Name = "photo_pictureBox1";
            photo_pictureBox1.Size = new Size(135, 114);
            photo_pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            photo_pictureBox1.TabIndex = 30;
            photo_pictureBox1.TabStop = false;
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
            // users_comboBox1
            // 
            users_comboBox1.DataSource = bindingSource1;
            users_comboBox1.DisplayMember = "UserName";
            users_comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            users_comboBox1.FormattingEnabled = true;
            users_comboBox1.Location = new Point(154, 179);
            users_comboBox1.Name = "users_comboBox1";
            users_comboBox1.Size = new Size(136, 23);
            users_comboBox1.TabIndex = 32;
            // 
            // user_password_txtBox
            // 
            user_password_txtBox.Font = new Font("Segoe UI", 12F);
            user_password_txtBox.Location = new Point(154, 211);
            user_password_txtBox.MaxLength = 20;
            user_password_txtBox.Name = "user_password_txtBox";
            user_password_txtBox.PasswordChar = '*';
            user_password_txtBox.Size = new Size(136, 29);
            user_password_txtBox.TabIndex = 33;
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
            // ok_button1
            // 
            ok_button1.Image = Properties.Resources.ok;
            ok_button1.ImageAlign = ContentAlignment.MiddleLeft;
            ok_button1.Location = new Point(84, 269);
            ok_button1.Name = "ok_button1";
            ok_button1.Size = new Size(130, 39);
            ok_button1.TabIndex = 35;
            ok_button1.Text = "OK (Enter)";
            ok_button1.UseVisualStyleBackColor = true;
            ok_button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(67, 253);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 36;
            // 
            // cancel_button2
            // 
            cancel_button2.Image = Properties.Resources.canecl_butt;
            cancel_button2.ImageAlign = ContentAlignment.MiddleLeft;
            cancel_button2.Location = new Point(233, 269);
            cancel_button2.Name = "cancel_button2";
            cancel_button2.Size = new Size(107, 39);
            cancel_button2.TabIndex = 35;
            cancel_button2.Text = "Cancel (ESC)";
            cancel_button2.TextAlign = ContentAlignment.MiddleRight;
            cancel_button2.UseVisualStyleBackColor = true;
            cancel_button2.Click += button2_Click;
            // 
            // usersTableAdapter1
            // 
            usersTableAdapter1.ClearBeforeFill = true;
            // 
            // correct_pass_txtBox
            // 
            correct_pass_txtBox.DataBindings.Add(new Binding("Text", bindingSource1, "Password", true));
            correct_pass_txtBox.Font = new Font("Segoe UI", 10F);
            correct_pass_txtBox.Location = new Point(572, 107);
            correct_pass_txtBox.MaxLength = 20;
            correct_pass_txtBox.Name = "correct_pass_txtBox";
            correct_pass_txtBox.Size = new Size(19, 25);
            correct_pass_txtBox.TabIndex = 37;
            correct_pass_txtBox.Text = " ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(506, 112);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 38;
            label1.Text = "Password:";
            // 
            // Login
            // 
            AcceptButton = ok_button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = cancel_button2;
            ClientSize = new Size(426, 319);
            ControlBox = false;
            Controls.Add(correct_pass_txtBox);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(cancel_button2);
            Controls.Add(ok_button1);
            Controls.Add(user_password_txtBox);
            Controls.Add(label3);
            Controls.Add(users_comboBox1);
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
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox user_password_txtBox;
        private Label label3;
        private Button ok_button1;
        private Panel panel1;
        private Button cancel_button2;
        private BindingSource bindingSource1;
        private Ds.AccDs accDs1;
        private Ds.AccDsTableAdapters.UsersTableAdapter usersTableAdapter1;
        private TextBox correct_pass_txtBox;
        private Label label1;
        public ComboBox users_comboBox1;
        public PictureBox photo_pictureBox1;
    }
}
namespace AccountingSoftware.Accounting.Common
{
    partial class SQL_SettingFrm
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
            label1 = new Label();
            rest_button1 = new Button();
            save_exit_button1 = new Button();
            cs_textBox1 = new TextBox();
            test_connection_button2 = new Button();
            accDs1 = new Ds.AccDs();
            usersTableAdapter1 = new Ds.AccDsTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)accDs1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "Connection String:";
            // 
            // rest_button1
            // 
            rest_button1.Location = new Point(565, 24);
            rest_button1.Name = "rest_button1";
            rest_button1.Size = new Size(75, 23);
            rest_button1.TabIndex = 1;
            rest_button1.Text = "Rest";
            rest_button1.UseVisualStyleBackColor = true;
            rest_button1.Click += rest_button1_Click;
            // 
            // save_exit_button1
            // 
            save_exit_button1.Location = new Point(12, 115);
            save_exit_button1.Name = "save_exit_button1";
            save_exit_button1.Size = new Size(91, 23);
            save_exit_button1.TabIndex = 1;
            save_exit_button1.Text = "Save & Exit";
            save_exit_button1.UseVisualStyleBackColor = true;
            save_exit_button1.Click += save_exit_button1_Click;
            // 
            // cs_textBox1
            // 
            cs_textBox1.Location = new Point(12, 53);
            cs_textBox1.Name = "cs_textBox1";
            cs_textBox1.Size = new Size(628, 23);
            cs_textBox1.TabIndex = 2;
            // 
            // test_connection_button2
            // 
            test_connection_button2.Location = new Point(109, 115);
            test_connection_button2.Name = "test_connection_button2";
            test_connection_button2.Size = new Size(105, 23);
            test_connection_button2.TabIndex = 1;
            test_connection_button2.Text = "Test Connection";
            test_connection_button2.UseVisualStyleBackColor = true;
            test_connection_button2.Click += test_connection_button2_Click;
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
            // SQL_SettingFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 150);
            Controls.Add(cs_textBox1);
            Controls.Add(test_connection_button2);
            Controls.Add(save_exit_button1);
            Controls.Add(rest_button1);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SQL_SettingFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SQL_SettingFrm";
            Load += SQL_SettingFrm_Load;
            ((System.ComponentModel.ISupportInitialize)accDs1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button rest_button1;
        private Button save_exit_button1;
        private TextBox cs_textBox1;
        private Button test_connection_button2;
        private Ds.AccDs accDs1;
        private Ds.AccDsTableAdapters.UsersTableAdapter usersTableAdapter1;
    }
}
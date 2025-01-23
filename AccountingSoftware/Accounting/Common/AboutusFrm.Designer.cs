namespace AccountingSoftware.Accounting.Common
{
    partial class AboutusFrm
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
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(128, 29);
            label1.Name = "label1";
            label1.Size = new Size(238, 25);
            label1.TabIndex = 0;
            label1.Text = "Jahed Software Company";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(156, 69);
            label2.Name = "label2";
            label2.Size = new Size(182, 21);
            label2.TabIndex = 0;
            label2.Text = "Pro Accounting Software";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(175, 109);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 0;
            label3.Text = "Version: 01.23.2025.1";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(44, 172);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 1);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(156, 216);
            label4.Name = "label4";
            label4.Size = new Size(205, 20);
            label4.TabIndex = 0;
            label4.Text = "All rights reserved: 2006-2025";
            // 
            // AboutusFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 283);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutusFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About Us";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private Label label4;
    }
}
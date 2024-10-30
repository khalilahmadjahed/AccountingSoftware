namespace AccountingSoftware
{
    partial class MainFrm
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
            top_panel1 = new Panel();
            cls_btn = new Button();
            min_btn = new Button();
            help_btn = new Button();
            tools_btn = new Button();
            report_btn = new Button();
            Accounting_btn = new Button();
            bott_pnl = new Panel();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            dateTime_lbl = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            top_panel1.SuspendLayout();
            bott_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // top_panel1
            // 
            top_panel1.BackgroundImageLayout = ImageLayout.Stretch;
            top_panel1.BorderStyle = BorderStyle.FixedSingle;
            top_panel1.Controls.Add(cls_btn);
            top_panel1.Controls.Add(min_btn);
            top_panel1.Controls.Add(help_btn);
            top_panel1.Controls.Add(tools_btn);
            top_panel1.Controls.Add(report_btn);
            top_panel1.Controls.Add(Accounting_btn);
            top_panel1.Dock = DockStyle.Top;
            top_panel1.Location = new Point(0, 0);
            top_panel1.Name = "top_panel1";
            top_panel1.Size = new Size(800, 75);
            top_panel1.TabIndex = 0;
            // 
            // cls_btn
            // 
            cls_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cls_btn.Image = Properties.Resources.Close_butt;
            cls_btn.Location = new Point(767, 6);
            cls_btn.Name = "cls_btn";
            cls_btn.Size = new Size(24, 24);
            cls_btn.TabIndex = 5;
            cls_btn.UseVisualStyleBackColor = true;
            cls_btn.Click += cls_btn_Click;
            // 
            // min_btn
            // 
            min_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            min_btn.Image = Properties.Resources.min_butt;
            min_btn.Location = new Point(743, 6);
            min_btn.Name = "min_btn";
            min_btn.Size = new Size(24, 24);
            min_btn.TabIndex = 4;
            min_btn.UseVisualStyleBackColor = true;
            min_btn.Click += min_btn_Click;
            // 
            // help_btn
            // 
            help_btn.BackgroundImage = Properties.Resources.butt_background;
            help_btn.BackgroundImageLayout = ImageLayout.Stretch;
            help_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            help_btn.Image = Properties.Resources.top_help;
            help_btn.Location = new Point(316, 6);
            help_btn.Name = "help_btn";
            help_btn.Size = new Size(90, 63);
            help_btn.TabIndex = 3;
            help_btn.Text = "Help F5";
            help_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            help_btn.UseVisualStyleBackColor = true;
            // 
            // tools_btn
            // 
            tools_btn.BackgroundImage = Properties.Resources.butt_background;
            tools_btn.BackgroundImageLayout = ImageLayout.Stretch;
            tools_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tools_btn.Image = Properties.Resources.top_Tools_butt;
            tools_btn.Location = new Point(223, 6);
            tools_btn.Name = "tools_btn";
            tools_btn.Size = new Size(90, 63);
            tools_btn.TabIndex = 2;
            tools_btn.Text = "Tools F4";
            tools_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            tools_btn.UseVisualStyleBackColor = true;
            // 
            // report_btn
            // 
            report_btn.BackgroundImage = Properties.Resources.butt_background;
            report_btn.BackgroundImageLayout = ImageLayout.Stretch;
            report_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            report_btn.Image = Properties.Resources.top_report2;
            report_btn.Location = new Point(130, 6);
            report_btn.Name = "report_btn";
            report_btn.Size = new Size(90, 63);
            report_btn.TabIndex = 1;
            report_btn.Text = "Report F3";
            report_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            report_btn.UseVisualStyleBackColor = true;
            // 
            // Accounting_btn
            // 
            Accounting_btn.BackgroundImage = Properties.Resources.butt_background;
            Accounting_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Accounting_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Accounting_btn.Image = Properties.Resources.top_accounting3;
            Accounting_btn.Location = new Point(7, 6);
            Accounting_btn.Name = "Accounting_btn";
            Accounting_btn.Size = new Size(120, 63);
            Accounting_btn.TabIndex = 0;
            Accounting_btn.Text = "Accounting F2";
            Accounting_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            Accounting_btn.UseVisualStyleBackColor = true;
            // 
            // bott_pnl
            // 
            bott_pnl.BorderStyle = BorderStyle.FixedSingle;
            bott_pnl.Controls.Add(pictureBox1);
            bott_pnl.Controls.Add(comboBox1);
            bott_pnl.Controls.Add(dateTime_lbl);
            bott_pnl.Controls.Add(label3);
            bott_pnl.Controls.Add(label1);
            bott_pnl.Controls.Add(label2);
            bott_pnl.Dock = DockStyle.Bottom;
            bott_pnl.Location = new Point(0, 416);
            bott_pnl.Name = "bott_pnl";
            bott_pnl.Size = new Size(800, 34);
            bott_pnl.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(220, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(46, 34);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Image 1", "Image 2", "Image 3", "Image 4", "Image 5", "Image 6" });
            comboBox1.Location = new Point(83, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // dateTime_lbl
            // 
            dateTime_lbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dateTime_lbl.Location = new Point(376, 0);
            dateTime_lbl.Name = "dateTime_lbl";
            dateTime_lbl.Size = new Size(423, 34);
            dateTime_lbl.TabIndex = 2;
            dateTime_lbl.Text = " -";
            dateTime_lbl.TextAlign = ContentAlignment.MiddleLeft;
            dateTime_lbl.Click += dateTime_lbl_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(349, -1);
            label3.Name = "label3";
            label3.Size = new Size(21, 34);
            label3.TabIndex = 2;
            label3.Text = " -";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(268, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 33);
            label1.TabIndex = 2;
            label1.Text = " -";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(7, 9);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "Background:";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bott_pnl);
            Controls.Add(top_panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainFrm";
            WindowState = FormWindowState.Maximized;
            top_panel1.ResumeLayout(false);
            bott_pnl.ResumeLayout(false);
            bott_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel top_panel1;
        private Button Accounting_btn;
        private Button report_btn;
        private Button help_btn;
        private Button tools_btn;
        private Button min_btn;
        private Button cls_btn;
        private Panel bott_pnl;
        private ComboBox comboBox1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label dateTime_lbl;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
    }
}
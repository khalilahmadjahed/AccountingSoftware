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
            TreeNode treeNode1 = new TreeNode("Customers");
            TreeNode treeNode2 = new TreeNode("Products");
            TreeNode treeNode3 = new TreeNode("Sales Invoice");
            TreeNode treeNode4 = new TreeNode("Purchase Bill");
            TreeNode treeNode5 = new TreeNode("Invoices", new TreeNode[] { treeNode3, treeNode4 });
            TreeNode treeNode6 = new TreeNode("Spend Money");
            TreeNode treeNode7 = new TreeNode("Receive Money");
            TreeNode treeNode8 = new TreeNode("Payments", new TreeNode[] { treeNode6, treeNode7 });
            TreeNode treeNode9 = new TreeNode("Cost");
            TreeNode treeNode10 = new TreeNode("All Tools", new TreeNode[] { treeNode1, treeNode2, treeNode5, treeNode8, treeNode9 });
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            top_panel1 = new Panel();
            cls_btn = new Button();
            min_btn = new Button();
            help_btn = new Button();
            tools_btn = new Button();
            report_btn = new Button();
            Accounting_btn = new Button();
            bott_pnl = new Panel();
            pictureBox1 = new PictureBox();
            background_comBox = new ComboBox();
            dateTime_lbl = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            treeView_panel1 = new Panel();
            collapse_btn = new Button();
            expand_btn = new Button();
            acc_treeView = new TreeView();
            imageList1 = new ImageList(components);
            tools_contextMenu = new ContextMenuStrip(components);
            settings_MenuItem = new ToolStripMenuItem();
            rep_cm = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            purchaseBillListToolStripMenuItem = new ToolStripMenuItem();
            users_toolStripMenuItem2 = new ToolStripMenuItem();
            top_panel1.SuspendLayout();
            bott_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            treeView_panel1.SuspendLayout();
            tools_contextMenu.SuspendLayout();
            rep_cm.SuspendLayout();
            SuspendLayout();
            // 
            // top_panel1
            // 
            top_panel1.BackColor = Color.FromArgb(224, 224, 224);
            top_panel1.BackgroundImage = Properties.Resources.butt_background;
            top_panel1.BackgroundImageLayout = ImageLayout.None;
            top_panel1.BorderStyle = BorderStyle.Fixed3D;
            top_panel1.Controls.Add(cls_btn);
            top_panel1.Controls.Add(min_btn);
            top_panel1.Controls.Add(help_btn);
            top_panel1.Controls.Add(tools_btn);
            top_panel1.Controls.Add(report_btn);
            top_panel1.Controls.Add(Accounting_btn);
            top_panel1.Dock = DockStyle.Top;
            top_panel1.Location = new Point(0, 0);
            top_panel1.Name = "top_panel1";
            top_panel1.Size = new Size(826, 77);
            top_panel1.TabIndex = 0;
            // 
            // cls_btn
            // 
            cls_btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cls_btn.Image = Properties.Resources.Close_butt;
            cls_btn.Location = new Point(791, 6);
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
            min_btn.Location = new Point(767, 6);
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
            help_btn.Cursor = Cursors.Hand;
            help_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            help_btn.Image = Properties.Resources.top_help;
            help_btn.Location = new Point(339, 7);
            help_btn.Name = "help_btn";
            help_btn.Size = new Size(103, 63);
            help_btn.TabIndex = 3;
            help_btn.Text = "Help F5";
            help_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            help_btn.UseVisualStyleBackColor = true;
            // 
            // tools_btn
            // 
            tools_btn.BackgroundImage = Properties.Resources.butt_background;
            tools_btn.BackgroundImageLayout = ImageLayout.Stretch;
            tools_btn.Cursor = Cursors.Hand;
            tools_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tools_btn.Image = Properties.Resources.top_Tools_butt;
            tools_btn.Location = new Point(234, 7);
            tools_btn.Name = "tools_btn";
            tools_btn.Size = new Size(103, 63);
            tools_btn.TabIndex = 2;
            tools_btn.Text = "Tools F4";
            tools_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            tools_btn.UseVisualStyleBackColor = true;
            tools_btn.Click += tools_btn_Click;
            // 
            // report_btn
            // 
            report_btn.BackgroundImage = Properties.Resources.butt_background;
            report_btn.BackgroundImageLayout = ImageLayout.Stretch;
            report_btn.Cursor = Cursors.Hand;
            report_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            report_btn.Image = Properties.Resources.top_report2;
            report_btn.Location = new Point(129, 7);
            report_btn.Name = "report_btn";
            report_btn.Size = new Size(103, 63);
            report_btn.TabIndex = 1;
            report_btn.Text = "Report F3";
            report_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            report_btn.UseVisualStyleBackColor = true;
            report_btn.Click += report_btn_Click;
            // 
            // Accounting_btn
            // 
            Accounting_btn.BackgroundImage = Properties.Resources.butt_background;
            Accounting_btn.BackgroundImageLayout = ImageLayout.Stretch;
            Accounting_btn.Cursor = Cursors.Hand;
            Accounting_btn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Accounting_btn.Image = Properties.Resources.top_accounting3;
            Accounting_btn.Location = new Point(7, 7);
            Accounting_btn.Name = "Accounting_btn";
            Accounting_btn.Size = new Size(120, 63);
            Accounting_btn.TabIndex = 0;
            Accounting_btn.Text = "Accounting F2";
            Accounting_btn.TextImageRelation = TextImageRelation.ImageAboveText;
            Accounting_btn.UseVisualStyleBackColor = true;
            Accounting_btn.Click += Accounting_btn_Click;
            // 
            // bott_pnl
            // 
            bott_pnl.BorderStyle = BorderStyle.FixedSingle;
            bott_pnl.Controls.Add(pictureBox1);
            bott_pnl.Controls.Add(background_comBox);
            bott_pnl.Controls.Add(dateTime_lbl);
            bott_pnl.Controls.Add(label3);
            bott_pnl.Controls.Add(label1);
            bott_pnl.Controls.Add(label2);
            bott_pnl.Dock = DockStyle.Bottom;
            bott_pnl.Location = new Point(0, 498);
            bott_pnl.Name = "bott_pnl";
            bott_pnl.Size = new Size(826, 34);
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
            // background_comBox
            // 
            background_comBox.Cursor = Cursors.Hand;
            background_comBox.DropDownStyle = ComboBoxStyle.DropDownList;
            background_comBox.FormattingEnabled = true;
            background_comBox.Items.AddRange(new object[] { "Image 1", "Image 2", "Image 3", "Image 4", "Image 5", "Image 6" });
            background_comBox.Location = new Point(83, 5);
            background_comBox.Name = "background_comBox";
            background_comBox.Size = new Size(121, 23);
            background_comBox.TabIndex = 3;
            background_comBox.SelectedIndexChanged += background_comBox_SelectedIndexChanged;
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
            // treeView_panel1
            // 
            treeView_panel1.BorderStyle = BorderStyle.FixedSingle;
            treeView_panel1.Controls.Add(collapse_btn);
            treeView_panel1.Controls.Add(expand_btn);
            treeView_panel1.Controls.Add(acc_treeView);
            treeView_panel1.Location = new Point(9, 78);
            treeView_panel1.Name = "treeView_panel1";
            treeView_panel1.Size = new Size(278, 417);
            treeView_panel1.TabIndex = 2;
            treeView_panel1.Visible = false;
            // 
            // collapse_btn
            // 
            collapse_btn.BackgroundImage = Properties.Resources.collapse;
            collapse_btn.BackgroundImageLayout = ImageLayout.Stretch;
            collapse_btn.Cursor = Cursors.Hand;
            collapse_btn.Location = new Point(241, 7);
            collapse_btn.Name = "collapse_btn";
            collapse_btn.Size = new Size(28, 28);
            collapse_btn.TabIndex = 3;
            collapse_btn.UseVisualStyleBackColor = true;
            collapse_btn.Click += collapse_btn_Click;
            // 
            // expand_btn
            // 
            expand_btn.BackgroundImage = Properties.Resources.expand;
            expand_btn.BackgroundImageLayout = ImageLayout.Stretch;
            expand_btn.Cursor = Cursors.Hand;
            expand_btn.Location = new Point(211, 7);
            expand_btn.Name = "expand_btn";
            expand_btn.Size = new Size(28, 28);
            expand_btn.TabIndex = 3;
            expand_btn.UseVisualStyleBackColor = true;
            expand_btn.Click += expand_btn_Click;
            // 
            // acc_treeView
            // 
            acc_treeView.Cursor = Cursors.Hand;
            acc_treeView.Dock = DockStyle.Fill;
            acc_treeView.ImageIndex = 0;
            acc_treeView.ImageList = imageList1;
            acc_treeView.Indent = 40;
            acc_treeView.ItemHeight = 40;
            acc_treeView.Location = new Point(0, 0);
            acc_treeView.Name = "acc_treeView";
            treeNode1.ImageKey = "tree_customers.png";
            treeNode1.Name = "Customers";
            treeNode1.SelectedImageKey = "tree_customers.png";
            treeNode1.Text = "Customers";
            treeNode2.ImageKey = "products.png";
            treeNode2.Name = "products";
            treeNode2.SelectedImageKey = "products.png";
            treeNode2.Text = "Products";
            treeNode3.ImageKey = "tree_sale_invoice.png";
            treeNode3.Name = "Sales_Invoice";
            treeNode3.SelectedImageKey = "tree_sale_invoice.png";
            treeNode3.Text = "Sales Invoice";
            treeNode4.ImageKey = "tree_purchase_bill.png";
            treeNode4.Name = "Purchase_Bill";
            treeNode4.SelectedImageKey = "tree_purchase_bill.png";
            treeNode4.Text = "Purchase Bill";
            treeNode5.ImageKey = "tree_invoice.png";
            treeNode5.Name = "Invoices";
            treeNode5.SelectedImageKey = "tree_invoice.png";
            treeNode5.Text = "Invoices";
            treeNode6.ImageKey = "tree_spend.png";
            treeNode6.Name = "Spend_Money";
            treeNode6.SelectedImageKey = "tree_spend.png";
            treeNode6.Text = "Spend Money";
            treeNode7.ImageKey = "tree_receive.png";
            treeNode7.Name = "Receive_Money";
            treeNode7.SelectedImageKey = "tree_receive.png";
            treeNode7.Text = "Receive Money";
            treeNode8.ImageKey = "tree_payment.png";
            treeNode8.Name = "Payments";
            treeNode8.SelectedImageKey = "tree_payment.png";
            treeNode8.Text = "Payments";
            treeNode9.ImageKey = "tree_expense.png";
            treeNode9.Name = "Cost";
            treeNode9.SelectedImageKey = "tree_expense.png";
            treeNode9.Text = "Cost";
            treeNode10.ImageKey = "tree_root.png";
            treeNode10.Name = "Root";
            treeNode10.SelectedImageKey = "tree_root.png";
            treeNode10.Text = "All Tools";
            acc_treeView.Nodes.AddRange(new TreeNode[] { treeNode10 });
            acc_treeView.SelectedImageIndex = 0;
            acc_treeView.Size = new Size(276, 415);
            acc_treeView.TabIndex = 0;
            acc_treeView.AfterSelect += acc_treeView_AfterSelect;
            acc_treeView.DoubleClick += acc_treeView_DoubleClick;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "collapse.png");
            imageList1.Images.SetKeyName(1, "expand.png");
            imageList1.Images.SetKeyName(2, "products.png");
            imageList1.Images.SetKeyName(3, "tree_customers.png");
            imageList1.Images.SetKeyName(4, "tree_expense.png");
            imageList1.Images.SetKeyName(5, "tree_invoice.png");
            imageList1.Images.SetKeyName(6, "tree_payment.png");
            imageList1.Images.SetKeyName(7, "tree_purchase_bill.png");
            imageList1.Images.SetKeyName(8, "tree_receive.png");
            imageList1.Images.SetKeyName(9, "tree_reports.png");
            imageList1.Images.SetKeyName(10, "tree_root.png");
            imageList1.Images.SetKeyName(11, "tree_sale_invoice.png");
            imageList1.Images.SetKeyName(12, "tree_spend.png");
            // 
            // tools_contextMenu
            // 
            tools_contextMenu.Items.AddRange(new ToolStripItem[] { settings_MenuItem, users_toolStripMenuItem2 });
            tools_contextMenu.Name = "contextMenuStrip1";
            tools_contextMenu.Size = new Size(197, 106);
            // 
            // settings_MenuItem
            // 
            settings_MenuItem.AutoSize = false;
            settings_MenuItem.Image = Properties.Resources.settings;
            settings_MenuItem.ImageScaling = ToolStripItemImageScaling.None;
            settings_MenuItem.Name = "settings_MenuItem";
            settings_MenuItem.Size = new Size(180, 40);
            settings_MenuItem.Text = "Settings";
            settings_MenuItem.Click += settings_MenuItem_Click;
            // 
            // rep_cm
            // 
            rep_cm.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, purchaseBillListToolStripMenuItem });
            rep_cm.Name = "contextMenuStrip1";
            rep_cm.Size = new Size(179, 82);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.AutoSize = false;
            toolStripMenuItem1.Image = Properties.Resources.tree_sale_invoice;
            toolStripMenuItem1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 40);
            toolStripMenuItem1.Text = "Sales Invoice List";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // purchaseBillListToolStripMenuItem
            // 
            purchaseBillListToolStripMenuItem.Image = Properties.Resources.tree_purchase_bill;
            purchaseBillListToolStripMenuItem.ImageScaling = ToolStripItemImageScaling.None;
            purchaseBillListToolStripMenuItem.Name = "purchaseBillListToolStripMenuItem";
            purchaseBillListToolStripMenuItem.Size = new Size(178, 38);
            purchaseBillListToolStripMenuItem.Text = "Purchase Bill List";
            purchaseBillListToolStripMenuItem.Click += purchaseBillListToolStripMenuItem_Click;
            // 
            // users_toolStripMenuItem2
            // 
            users_toolStripMenuItem2.AutoSize = false;
            users_toolStripMenuItem2.Image = Properties.Resources.user_icon;
            users_toolStripMenuItem2.ImageScaling = ToolStripItemImageScaling.None;
            users_toolStripMenuItem2.Name = "users_toolStripMenuItem2";
            users_toolStripMenuItem2.Size = new Size(180, 40);
            users_toolStripMenuItem2.Text = "Users";
            users_toolStripMenuItem2.Click += users_toolStripMenuItem2_Click;
            // 
            // MainFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(826, 532);
            Controls.Add(treeView_panel1);
            Controls.Add(bott_pnl);
            Controls.Add(top_panel1);
            FormBorderStyle = FormBorderStyle.None;
            IsMdiContainer = true;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainFrm";
            WindowState = FormWindowState.Maximized;
            Load += MainFrm_Load;
            top_panel1.ResumeLayout(false);
            bott_pnl.ResumeLayout(false);
            bott_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            treeView_panel1.ResumeLayout(false);
            tools_contextMenu.ResumeLayout(false);
            rep_cm.ResumeLayout(false);
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
        private ComboBox background_comBox;
        private Label label2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label dateTime_lbl;
        private Label label3;
        private System.Windows.Forms.Timer timer1;
        private Panel treeView_panel1;
        private TreeView acc_treeView;
        private ImageList imageList1;
        private Button collapse_btn;
        private Button expand_btn;
        private ContextMenuStrip tools_contextMenu;
        private ToolStripMenuItem settings_MenuItem;
        private ContextMenuStrip rep_cm;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem purchaseBillListToolStripMenuItem;
        private ToolStripMenuItem users_toolStripMenuItem2;
    }
}
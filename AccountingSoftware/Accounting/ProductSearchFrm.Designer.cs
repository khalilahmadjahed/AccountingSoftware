namespace AccountingSoftware.Accounting
{
    partial class ProductSearchFrm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            showAll_btn = new Button();
            cancle_btn = new Button();
            ok_btn = new Button();
            panel1 = new Panel();
            productName_lbl = new Label();
            bindingSource1 = new BindingSource(components);
            accDs1 = new Ds.AccDs();
            label3 = new Label();
            id_lbl = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            productIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            initialQtyDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            discountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regUserDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            regTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            search_panel2 = new Panel();
            search_productId_button2 = new Button();
            search_id_button1 = new Button();
            search_productName_textBox2 = new TextBox();
            search_id_textBox1 = new TextBox();
            label14 = new Label();
            label11 = new Label();
            productsTableAdapter1 = new Ds.AccDsTableAdapters.ProductsTableAdapter();
            label1 = new Label();
            unit_lbl = new Label();
            label5 = new Label();
            price_lbl = new Label();
            label7 = new Label();
            discount_lbl = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            search_panel2.SuspendLayout();
            SuspendLayout();
            // 
            // showAll_btn
            // 
            showAll_btn.BackColor = Color.FromArgb(246, 244, 240);
            showAll_btn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showAll_btn.Image = Properties.Resources.show_all;
            showAll_btn.Location = new Point(459, 402);
            showAll_btn.Name = "showAll_btn";
            showAll_btn.Size = new Size(147, 38);
            showAll_btn.TabIndex = 10;
            showAll_btn.Text = "Show All";
            showAll_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            showAll_btn.UseVisualStyleBackColor = false;
            showAll_btn.Click += showAll_btn_Click;
            // 
            // cancle_btn
            // 
            cancle_btn.BackColor = Color.FromArgb(246, 244, 240);
            cancle_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cancle_btn.Image = Properties.Resources.canecl_butt;
            cancle_btn.Location = new Point(164, 402);
            cancle_btn.Name = "cancle_btn";
            cancle_btn.Size = new Size(110, 38);
            cancle_btn.TabIndex = 14;
            cancle_btn.Text = "Cancle";
            cancle_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            cancle_btn.UseVisualStyleBackColor = false;
            cancle_btn.Click += cancle_btn_Click;
            // 
            // ok_btn
            // 
            ok_btn.BackColor = Color.FromArgb(246, 244, 240);
            ok_btn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ok_btn.Image = Properties.Resources.ok;
            ok_btn.Location = new Point(11, 402);
            ok_btn.Name = "ok_btn";
            ok_btn.Size = new Size(147, 38);
            ok_btn.TabIndex = 15;
            ok_btn.Text = "OK";
            ok_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            ok_btn.UseVisualStyleBackColor = false;
            ok_btn.Click += ok_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(77, 161, 169);
            panel1.Controls.Add(productName_lbl);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(id_lbl);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(11, 356);
            panel1.Name = "panel1";
            panel1.Size = new Size(595, 38);
            panel1.TabIndex = 13;
            // 
            // productName_lbl
            // 
            productName_lbl.DataBindings.Add(new Binding("Text", bindingSource1, "ProductName", true));
            productName_lbl.Location = new Point(280, 10);
            productName_lbl.Name = "productName_lbl";
            productName_lbl.Size = new Size(180, 15);
            productName_lbl.TabIndex = 0;
            productName_lbl.Text = "-";
            // 
            // bindingSource1
            // 
            bindingSource1.DataMember = "Products";
            bindingSource1.DataSource = accDs1;
            // 
            // accDs1
            // 
            accDs1.DataSetName = "AccDs";
            accDs1.Namespace = "http://tempuri.org/AccDs.xsd";
            accDs1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 10);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 0;
            label3.Text = "Product Name:";
            // 
            // id_lbl
            // 
            id_lbl.DataBindings.Add(new Binding("Text", bindingSource1, "ProductId", true));
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
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.CausesValidation = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { productIdDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, initialQtyDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, discountDataGridViewTextBoxColumn, commentDataGridViewTextBoxColumn, regUserDataGridViewTextBoxColumn, regDateDataGridViewTextBoxColumn, regTimeDataGridViewTextBoxColumn });
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.Location = new Point(9, 67);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(597, 283);
            dataGridView1.TabIndex = 12;
            // 
            // productIdDataGridViewTextBoxColumn
            // 
            productIdDataGridViewTextBoxColumn.DataPropertyName = "ProductId";
            productIdDataGridViewTextBoxColumn.HeaderText = "ProductId";
            productIdDataGridViewTextBoxColumn.Name = "productIdDataGridViewTextBoxColumn";
            productIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // initialQtyDataGridViewTextBoxColumn
            // 
            initialQtyDataGridViewTextBoxColumn.DataPropertyName = "InitialQty";
            dataGridViewCellStyle1.Format = "N0";
            initialQtyDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            initialQtyDataGridViewTextBoxColumn.HeaderText = "InitialQty";
            initialQtyDataGridViewTextBoxColumn.Name = "initialQtyDataGridViewTextBoxColumn";
            initialQtyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            dataGridViewCellStyle2.Format = "N0";
            unitDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            unitDataGridViewTextBoxColumn.HeaderText = "Unit";
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle3.Format = "C2";
            priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.ToolTipText = "C2";
            // 
            // discountDataGridViewTextBoxColumn
            // 
            discountDataGridViewTextBoxColumn.DataPropertyName = "Discount";
            dataGridViewCellStyle4.Format = "C2";
            discountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            discountDataGridViewTextBoxColumn.HeaderText = "Discount";
            discountDataGridViewTextBoxColumn.Name = "discountDataGridViewTextBoxColumn";
            discountDataGridViewTextBoxColumn.ReadOnly = true;
            discountDataGridViewTextBoxColumn.ToolTipText = "C2";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            commentDataGridViewTextBoxColumn.HeaderText = "Comment";
            commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            commentDataGridViewTextBoxColumn.ReadOnly = true;
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
            // search_panel2
            // 
            search_panel2.BackColor = Color.FromArgb(77, 161, 169);
            search_panel2.Controls.Add(search_productId_button2);
            search_panel2.Controls.Add(search_id_button1);
            search_panel2.Controls.Add(search_productName_textBox2);
            search_panel2.Controls.Add(search_id_textBox1);
            search_panel2.Controls.Add(label14);
            search_panel2.Controls.Add(label11);
            search_panel2.Location = new Point(11, 12);
            search_panel2.Name = "search_panel2";
            search_panel2.Size = new Size(595, 49);
            search_panel2.TabIndex = 11;
            // 
            // search_productId_button2
            // 
            search_productId_button2.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            search_productId_button2.Location = new Point(523, 11);
            search_productId_button2.Name = "search_productId_button2";
            search_productId_button2.Size = new Size(37, 23);
            search_productId_button2.TabIndex = 2;
            search_productId_button2.Text = "Go";
            search_productId_button2.UseVisualStyleBackColor = true;
            search_productId_button2.Click += search_productId_button2_Click;
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
            // search_productName_textBox2
            // 
            search_productName_textBox2.BackColor = Color.FromArgb(246, 244, 240);
            search_productName_textBox2.Location = new Point(417, 11);
            search_productName_textBox2.Name = "search_productName_textBox2";
            search_productName_textBox2.Size = new Size(100, 23);
            search_productName_textBox2.TabIndex = 1;
            // 
            // search_id_textBox1
            // 
            search_id_textBox1.BackColor = Color.FromArgb(246, 244, 240);
            search_id_textBox1.Location = new Point(58, 11);
            search_id_textBox1.Name = "search_id_textBox1";
            search_id_textBox1.Size = new Size(100, 23);
            search_id_textBox1.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F);
            label14.Location = new Point(328, 15);
            label14.Name = "label14";
            label14.Size = new Size(87, 15);
            label14.TabIndex = 0;
            label14.Text = "Product Name:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F);
            label11.Location = new Point(33, 15);
            label11.Name = "label11";
            label11.Size = new Size(21, 15);
            label11.TabIndex = 0;
            label11.Text = "ID:";
            // 
            // productsTableAdapter1
            // 
            productsTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(644, 67);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 16;
            label1.Text = "Unit:";
            // 
            // unit_lbl
            // 
            unit_lbl.DataBindings.Add(new Binding("Text", bindingSource1, "Unit", true));
            unit_lbl.ForeColor = Color.White;
            unit_lbl.Location = new Point(701, 67);
            unit_lbl.Name = "unit_lbl";
            unit_lbl.Size = new Size(74, 15);
            unit_lbl.TabIndex = 16;
            unit_lbl.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(644, 93);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 16;
            label5.Text = "Price:";
            // 
            // price_lbl
            // 
            price_lbl.DataBindings.Add(new Binding("Text", bindingSource1, "Price", true));
            price_lbl.ForeColor = Color.White;
            price_lbl.Location = new Point(701, 93);
            price_lbl.Name = "price_lbl";
            price_lbl.Size = new Size(74, 15);
            price_lbl.TabIndex = 16;
            price_lbl.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(644, 119);
            label7.Name = "label7";
            label7.Size = new Size(57, 15);
            label7.TabIndex = 16;
            label7.Text = "Discount:";
            // 
            // discount_lbl
            // 
            discount_lbl.DataBindings.Add(new Binding("Text", bindingSource1, "Discount", true));
            discount_lbl.ForeColor = Color.White;
            discount_lbl.Location = new Point(701, 119);
            discount_lbl.Name = "discount_lbl";
            discount_lbl.Size = new Size(74, 15);
            discount_lbl.TabIndex = 16;
            discount_lbl.Text = "0";
            // 
            // ProductSearchFrm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 80, 119);
            ClientSize = new Size(773, 444);
            ControlBox = false;
            Controls.Add(discount_lbl);
            Controls.Add(label7);
            Controls.Add(price_lbl);
            Controls.Add(label5);
            Controls.Add(unit_lbl);
            Controls.Add(label1);
            Controls.Add(showAll_btn);
            Controls.Add(cancle_btn);
            Controls.Add(ok_btn);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Controls.Add(search_panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductSearchFrm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Search";
            Load += ProductSearchFrm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)accDs1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            search_panel2.ResumeLayout(false);
            search_panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button showAll_btn;
        private Button cancle_btn;
        private Button ok_btn;
        private Panel panel1;
        public Label productName_lbl;
        private Label label3;
        public Label id_lbl;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel search_panel2;
        private Button search_productId_button2;
        private Button search_id_button1;
        private TextBox search_productName_textBox2;
        private TextBox search_id_textBox1;
        private Label label14;
        private Label label11;
        private BindingSource bindingSource1;
        private Ds.AccDs accDs1;
        private Ds.AccDsTableAdapters.ProductsTableAdapter productsTableAdapter1;
        private Label label1;
        private Label label5;
        private Label label7;
        public Label unit_lbl;
        public Label price_lbl;
        public Label discount_lbl;
        private DataGridViewTextBoxColumn productIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn initialQtyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn discountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regUserDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn regTimeDataGridViewTextBoxColumn;
    }
}
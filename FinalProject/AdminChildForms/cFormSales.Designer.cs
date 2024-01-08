namespace FinalProject.AdminChildForms
{
    partial class cFormSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.PanelUserInfo = new System.Windows.Forms.Panel();
            this.lblMaxQuantity = new System.Windows.Forms.Label();
            this.lblMaxDiscount = new System.Windows.Forms.Label();
            this.txtSaleDate = new System.Windows.Forms.DateTimePicker();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.NumericUpDown();
            this.txtQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.txtDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtStock = new System.Windows.Forms.NumericUpDown();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnAddSell = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrentPhone = new System.Windows.Forms.Label();
            this.lblCurrentEmail = new System.Windows.Forms.Label();
            this.lblCurrentAddress = new System.Windows.Forms.Label();
            this.dgvAllProductsInfo = new System.Windows.Forms.DataGridView();
            this.clmProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMaxDiscount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.PanelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProductsInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbxSearchBy);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(275, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 53);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Products";
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSearchBy.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Items.AddRange(new object[] {
            "By ProductID",
            "By ProductName",
            "By Brand"});
            this.cbxSearchBy.Location = new System.Drawing.Point(229, 20);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(135, 24);
            this.cbxSearchBy.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtSearch.Location = new System.Drawing.Point(32, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 17);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // PanelUserInfo
            // 
            this.PanelUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelUserInfo.Controls.Add(this.lblMaxQuantity);
            this.PanelUserInfo.Controls.Add(this.lblMaxDiscount);
            this.PanelUserInfo.Controls.Add(this.txtSaleDate);
            this.PanelUserInfo.Controls.Add(this.txtNotes);
            this.PanelUserInfo.Controls.Add(this.label2);
            this.PanelUserInfo.Controls.Add(this.label1);
            this.PanelUserInfo.Controls.Add(this.txtTotal);
            this.PanelUserInfo.Controls.Add(this.txtQuantity);
            this.PanelUserInfo.Controls.Add(this.txtPrice);
            this.PanelUserInfo.Controls.Add(this.txtDiscount);
            this.PanelUserInfo.Controls.Add(this.txtStock);
            this.PanelUserInfo.Controls.Add(this.lblRole);
            this.PanelUserInfo.Controls.Add(this.lblPassword);
            this.PanelUserInfo.Controls.Add(this.btnAddSell);
            this.PanelUserInfo.Controls.Add(this.txtProductName);
            this.PanelUserInfo.Controls.Add(this.lblCurrentUsername);
            this.PanelUserInfo.Controls.Add(this.txtBrand);
            this.PanelUserInfo.Controls.Add(this.label4);
            this.PanelUserInfo.Controls.Add(this.lblCurrentPhone);
            this.PanelUserInfo.Controls.Add(this.lblCurrentEmail);
            this.PanelUserInfo.Controls.Add(this.lblCurrentAddress);
            this.PanelUserInfo.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.PanelUserInfo.Location = new System.Drawing.Point(12, 50);
            this.PanelUserInfo.Name = "PanelUserInfo";
            this.PanelUserInfo.Size = new System.Drawing.Size(257, 344);
            this.PanelUserInfo.TabIndex = 11;
            // 
            // lblMaxQuantity
            // 
            this.lblMaxQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaxQuantity.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxQuantity.ForeColor = System.Drawing.Color.White;
            this.lblMaxQuantity.Location = new System.Drawing.Point(171, 243);
            this.lblMaxQuantity.Name = "lblMaxQuantity";
            this.lblMaxQuantity.Size = new System.Drawing.Size(81, 22);
            this.lblMaxQuantity.TabIndex = 18;
            this.lblMaxQuantity.Text = "Max : ";
            this.lblMaxQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaxDiscount
            // 
            this.lblMaxDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaxDiscount.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxDiscount.ForeColor = System.Drawing.Color.White;
            this.lblMaxDiscount.Location = new System.Drawing.Point(171, 209);
            this.lblMaxDiscount.Name = "lblMaxDiscount";
            this.lblMaxDiscount.Size = new System.Drawing.Size(81, 22);
            this.lblMaxDiscount.TabIndex = 17;
            this.lblMaxDiscount.Text = "Max : ";
            this.lblMaxDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtSaleDate
            // 
            this.txtSaleDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSaleDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtSaleDate.Location = new System.Drawing.Point(104, 70);
            this.txtSaleDate.Name = "txtSaleDate";
            this.txtSaleDate.Size = new System.Drawing.Size(135, 22);
            this.txtSaleDate.TabIndex = 16;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNotes.BackColor = System.Drawing.Color.White;
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotes.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtNotes.Location = new System.Drawing.Point(104, 103);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(135, 36);
            this.txtNotes.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sale Date :";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Sell Notes :";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.DecimalPlaces = 2;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(104, 274);
            this.txtTotal.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(136, 22);
            this.txtTotal.TabIndex = 13;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtQuantity.Location = new System.Drawing.Point(105, 243);
            this.txtQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(60, 22);
            this.txtQuantity.TabIndex = 12;
            this.txtQuantity.ValueChanged += new System.EventHandler(this.txtQuantity_ValueChanged);
            // 
            // txtPrice
            // 
            this.txtPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPrice.DecimalPlaces = 2;
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(106, 179);
            this.txtPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(134, 22);
            this.txtPrice.TabIndex = 11;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiscount.DecimalPlaces = 2;
            this.txtDiscount.Location = new System.Drawing.Point(106, 210);
            this.txtDiscount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(59, 22);
            this.txtDiscount.TabIndex = 10;
            this.txtDiscount.ValueChanged += new System.EventHandler(this.txtDiscount_ValueChanged);
            // 
            // txtStock
            // 
            this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStock.Enabled = false;
            this.txtStock.Location = new System.Drawing.Point(104, 148);
            this.txtStock.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(136, 22);
            this.txtStock.TabIndex = 10;
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(39, 273);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(53, 16);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Total : ";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(33, 243);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(55, 16);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Qntity :";
            // 
            // btnAddSell
            // 
            this.btnAddSell.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddSell.BackColor = System.Drawing.Color.White;
            this.btnAddSell.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSell.Location = new System.Drawing.Point(162, 308);
            this.btnAddSell.Name = "btnAddSell";
            this.btnAddSell.Size = new System.Drawing.Size(77, 31);
            this.btnAddSell.TabIndex = 3;
            this.btnAddSell.Text = "Add Sell";
            this.btnAddSell.UseVisualStyleBackColor = false;
            this.btnAddSell.Click += new System.EventHandler(this.btnAddSell_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Enabled = false;
            this.txtProductName.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtProductName.Location = new System.Drawing.Point(105, 12);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(135, 17);
            this.txtProductName.TabIndex = 2;
            // 
            // lblCurrentUsername
            // 
            this.lblCurrentUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentUsername.AutoSize = true;
            this.lblCurrentUsername.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentUsername.ForeColor = System.Drawing.Color.White;
            this.lblCurrentUsername.Location = new System.Drawing.Point(39, 180);
            this.lblCurrentUsername.Name = "lblCurrentUsername";
            this.lblCurrentUsername.Size = new System.Drawing.Size(49, 16);
            this.lblCurrentUsername.TabIndex = 1;
            this.lblCurrentUsername.Text = "Price :";
            // 
            // txtBrand
            // 
            this.txtBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrand.BackColor = System.Drawing.Color.White;
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrand.Enabled = false;
            this.txtBrand.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtBrand.Location = new System.Drawing.Point(105, 41);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(135, 17);
            this.txtBrand.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Discount :";
            // 
            // lblCurrentPhone
            // 
            this.lblCurrentPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentPhone.AutoSize = true;
            this.lblCurrentPhone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPhone.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPhone.Location = new System.Drawing.Point(37, 148);
            this.lblCurrentPhone.Name = "lblCurrentPhone";
            this.lblCurrentPhone.Size = new System.Drawing.Size(52, 16);
            this.lblCurrentPhone.TabIndex = 1;
            this.lblCurrentPhone.Text = "Stock :";
            // 
            // lblCurrentEmail
            // 
            this.lblCurrentEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentEmail.AutoSize = true;
            this.lblCurrentEmail.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentEmail.ForeColor = System.Drawing.Color.White;
            this.lblCurrentEmail.Location = new System.Drawing.Point(3, 41);
            this.lblCurrentEmail.Name = "lblCurrentEmail";
            this.lblCurrentEmail.Size = new System.Drawing.Size(86, 16);
            this.lblCurrentEmail.TabIndex = 0;
            this.lblCurrentEmail.Text = "Pro. Brand :";
            // 
            // lblCurrentAddress
            // 
            this.lblCurrentAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentAddress.AutoSize = true;
            this.lblCurrentAddress.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAddress.ForeColor = System.Drawing.Color.White;
            this.lblCurrentAddress.Location = new System.Drawing.Point(7, 12);
            this.lblCurrentAddress.Name = "lblCurrentAddress";
            this.lblCurrentAddress.Size = new System.Drawing.Size(83, 16);
            this.lblCurrentAddress.TabIndex = 1;
            this.lblCurrentAddress.Text = "Pro. Name :";
            // 
            // dgvAllProductsInfo
            // 
            this.dgvAllProductsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllProductsInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllProductsInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bodoni MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllProductsInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllProductsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllProductsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmProductId,
            this.clmProductName,
            this.clmBrand,
            this.clmStock,
            this.clmPurchasePrice,
            this.clmRetailPrice,
            this.clmMaxDiscount,
            this.clmNotes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllProductsInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllProductsInfo.EnableHeadersVisualStyles = false;
            this.dgvAllProductsInfo.Location = new System.Drawing.Point(275, 109);
            this.dgvAllProductsInfo.Name = "dgvAllProductsInfo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllProductsInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllProductsInfo.RowTemplate.Height = 35;
            this.dgvAllProductsInfo.Size = new System.Drawing.Size(395, 285);
            this.dgvAllProductsInfo.TabIndex = 10;
            this.dgvAllProductsInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllProductsInfo_CellClick);
            // 
            // clmProductId
            // 
            this.clmProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmProductId.DataPropertyName = "product_id";
            this.clmProductId.HeaderText = "Pro. ID";
            this.clmProductId.Name = "clmProductId";
            this.clmProductId.Width = 86;
            // 
            // clmProductName
            // 
            this.clmProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmProductName.DataPropertyName = "product_name";
            this.clmProductName.HeaderText = "Pro.Name";
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.Width = 104;
            // 
            // clmBrand
            // 
            this.clmBrand.DataPropertyName = "brand";
            this.clmBrand.HeaderText = "Brand";
            this.clmBrand.Name = "clmBrand";
            // 
            // clmStock
            // 
            this.clmStock.DataPropertyName = "stock";
            this.clmStock.HeaderText = "Stock";
            this.clmStock.Name = "clmStock";
            // 
            // clmPurchasePrice
            // 
            this.clmPurchasePrice.DataPropertyName = "purchase_price";
            this.clmPurchasePrice.HeaderText = "PurchasePrice";
            this.clmPurchasePrice.Name = "clmPurchasePrice";
            this.clmPurchasePrice.Visible = false;
            // 
            // clmRetailPrice
            // 
            this.clmRetailPrice.DataPropertyName = "retail_price";
            this.clmRetailPrice.HeaderText = "Price";
            this.clmRetailPrice.Name = "clmRetailPrice";
            // 
            // clmMaxDiscount
            // 
            this.clmMaxDiscount.DataPropertyName = "max_discount";
            this.clmMaxDiscount.HeaderText = "MaxDiscount";
            this.clmMaxDiscount.Name = "clmMaxDiscount";
            // 
            // clmNotes
            // 
            this.clmNotes.DataPropertyName = "product_notes";
            this.clmNotes.HeaderText = "Notes";
            this.clmNotes.Name = "clmNotes";
            this.clmNotes.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel3.Location = new System.Drawing.Point(12, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 37);
            this.panel3.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(262, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manage Sales";
            // 
            // cFormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(682, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PanelUserInfo);
            this.Controls.Add(this.dgvAllProductsInfo);
            this.Controls.Add(this.panel3);
            this.Name = "cFormSales";
            this.Text = "Sales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelUserInfo.ResumeLayout(false);
            this.PanelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProductsInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxSearchBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel PanelUserInfo;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtTotal;
        private System.Windows.Forms.NumericUpDown txtQuantity;
        private System.Windows.Forms.NumericUpDown txtPrice;
        private System.Windows.Forms.NumericUpDown txtStock;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnAddSell;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCurrentUsername;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblCurrentPhone;
        private System.Windows.Forms.Label lblCurrentEmail;
        private System.Windows.Forms.Label lblCurrentAddress;
        private System.Windows.Forms.DataGridView dgvAllProductsInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker txtSaleDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txtDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRetailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaxDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotes;
        private System.Windows.Forms.Label lblMaxDiscount;
        private System.Windows.Forms.Label lblMaxQuantity;
    }
}
namespace FinalProject.AdminChildForms
{
    partial class cFormProducts
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxSearchBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.PanelUserInfo = new System.Windows.Forms.Panel();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxDiscount = new System.Windows.Forms.NumericUpDown();
            this.txtRetailPrice = new System.Windows.Forms.NumericUpDown();
            this.txtPurchasePrice = new System.Windows.Forms.NumericUpDown();
            this.txtStock = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCurrentUsername = new System.Windows.Forms.Label();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.lblCurrentPhone = new System.Windows.Forms.Label();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblCurrentEmail = new System.Windows.Forms.Label();
            this.lblCurrentAddress = new System.Windows.Forms.Label();
            this.lblCurrentname = new System.Windows.Forms.Label();
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
            this.groupBox1.SuspendLayout();
            this.PanelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetailPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchasePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProductsInfo)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbxSearchBy);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(275, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 53);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
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
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(255, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manage Products";
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(14, 270);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(108, 16);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Max Discount : ";
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(26, 240);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(90, 16);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Retail Price :";
            // 
            // PanelUserInfo
            // 
            this.PanelUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PanelUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelUserInfo.Controls.Add(this.txtNotes);
            this.PanelUserInfo.Controls.Add(this.label1);
            this.PanelUserInfo.Controls.Add(this.txtMaxDiscount);
            this.PanelUserInfo.Controls.Add(this.txtRetailPrice);
            this.PanelUserInfo.Controls.Add(this.txtPurchasePrice);
            this.PanelUserInfo.Controls.Add(this.txtStock);
            this.PanelUserInfo.Controls.Add(this.lblRole);
            this.PanelUserInfo.Controls.Add(this.lblPassword);
            this.PanelUserInfo.Controls.Add(this.btnAdd);
            this.PanelUserInfo.Controls.Add(this.btnUpdate);
            this.PanelUserInfo.Controls.Add(this.btnDelete);
            this.PanelUserInfo.Controls.Add(this.txtProductName);
            this.PanelUserInfo.Controls.Add(this.lblCurrentUsername);
            this.PanelUserInfo.Controls.Add(this.txtBrand);
            this.PanelUserInfo.Controls.Add(this.lblCurrentPhone);
            this.PanelUserInfo.Controls.Add(this.txtProductId);
            this.PanelUserInfo.Controls.Add(this.lblCurrentEmail);
            this.PanelUserInfo.Controls.Add(this.lblCurrentAddress);
            this.PanelUserInfo.Controls.Add(this.lblCurrentname);
            this.PanelUserInfo.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.PanelUserInfo.Location = new System.Drawing.Point(12, 46);
            this.PanelUserInfo.Name = "PanelUserInfo";
            this.PanelUserInfo.Size = new System.Drawing.Size(257, 344);
            this.PanelUserInfo.TabIndex = 7;
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNotes.BackColor = System.Drawing.Color.White;
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNotes.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtNotes.Location = new System.Drawing.Point(105, 119);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(135, 41);
            this.txtNotes.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(7, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Pro. Notes :";
            // 
            // txtMaxDiscount
            // 
            this.txtMaxDiscount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaxDiscount.DecimalPlaces = 2;
            this.txtMaxDiscount.Location = new System.Drawing.Point(123, 269);
            this.txtMaxDiscount.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtMaxDiscount.Name = "txtMaxDiscount";
            this.txtMaxDiscount.Size = new System.Drawing.Size(117, 22);
            this.txtMaxDiscount.TabIndex = 13;
            // 
            // txtRetailPrice
            // 
            this.txtRetailPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRetailPrice.DecimalPlaces = 2;
            this.txtRetailPrice.Location = new System.Drawing.Point(123, 239);
            this.txtRetailPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtRetailPrice.Name = "txtRetailPrice";
            this.txtRetailPrice.Size = new System.Drawing.Size(117, 22);
            this.txtRetailPrice.TabIndex = 12;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPurchasePrice.DecimalPlaces = 2;
            this.txtPurchasePrice.Location = new System.Drawing.Point(123, 209);
            this.txtPurchasePrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(117, 22);
            this.txtPurchasePrice.TabIndex = 11;
            // 
            // txtStock
            // 
            this.txtStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtStock.Location = new System.Drawing.Point(123, 178);
            this.txtStock.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(117, 22);
            this.txtStock.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(29, 308);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(100, 308);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(67, 31);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(173, 308);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(67, 31);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductName.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtProductName.Location = new System.Drawing.Point(105, 53);
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
            this.lblCurrentUsername.Location = new System.Drawing.Point(3, 210);
            this.lblCurrentUsername.Name = "lblCurrentUsername";
            this.lblCurrentUsername.Size = new System.Drawing.Size(114, 16);
            this.lblCurrentUsername.TabIndex = 1;
            this.lblCurrentUsername.Text = "Purchase Price :";
            // 
            // txtBrand
            // 
            this.txtBrand.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtBrand.BackColor = System.Drawing.Color.White;
            this.txtBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBrand.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBrand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtBrand.Location = new System.Drawing.Point(105, 85);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(135, 17);
            this.txtBrand.TabIndex = 2;
            // 
            // lblCurrentPhone
            // 
            this.lblCurrentPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentPhone.AutoSize = true;
            this.lblCurrentPhone.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPhone.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPhone.Location = new System.Drawing.Point(64, 179);
            this.lblCurrentPhone.Name = "lblCurrentPhone";
            this.lblCurrentPhone.Size = new System.Drawing.Size(52, 16);
            this.lblCurrentPhone.TabIndex = 1;
            this.lblCurrentPhone.Text = "Stock :";
            // 
            // txtProductId
            // 
            this.txtProductId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductId.BackColor = System.Drawing.Color.White;
            this.txtProductId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtProductId.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtProductId.Location = new System.Drawing.Point(105, 17);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(135, 17);
            this.txtProductId.TabIndex = 2;
            // 
            // lblCurrentEmail
            // 
            this.lblCurrentEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentEmail.AutoSize = true;
            this.lblCurrentEmail.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentEmail.ForeColor = System.Drawing.Color.White;
            this.lblCurrentEmail.Location = new System.Drawing.Point(4, 85);
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
            this.lblCurrentAddress.Location = new System.Drawing.Point(7, 53);
            this.lblCurrentAddress.Name = "lblCurrentAddress";
            this.lblCurrentAddress.Size = new System.Drawing.Size(83, 16);
            this.lblCurrentAddress.TabIndex = 1;
            this.lblCurrentAddress.Text = "Pro. Name :";
            // 
            // lblCurrentname
            // 
            this.lblCurrentname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCurrentname.AutoSize = true;
            this.lblCurrentname.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentname.ForeColor = System.Drawing.Color.White;
            this.lblCurrentname.Location = new System.Drawing.Point(3, 18);
            this.lblCurrentname.Name = "lblCurrentname";
            this.lblCurrentname.Size = new System.Drawing.Size(87, 16);
            this.lblCurrentname.TabIndex = 0;
            this.lblCurrentname.Text = "Product ID :";
            // 
            // dgvAllProductsInfo
            // 
            this.dgvAllProductsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllProductsInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllProductsInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Bodoni MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllProductsInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllProductsInfo.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvAllProductsInfo.EnableHeadersVisualStyles = false;
            this.dgvAllProductsInfo.Location = new System.Drawing.Point(275, 105);
            this.dgvAllProductsInfo.Name = "dgvAllProductsInfo";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllProductsInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvAllProductsInfo.RowTemplate.Height = 35;
            this.dgvAllProductsInfo.Size = new System.Drawing.Size(395, 285);
            this.dgvAllProductsInfo.TabIndex = 6;
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
            this.clmProductName.HeaderText = "Pro. Name";
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.Width = 99;
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
            // 
            // clmRetailPrice
            // 
            this.clmRetailPrice.DataPropertyName = "retail_price";
            this.clmRetailPrice.HeaderText = "RetailPrice";
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
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel3.Location = new System.Drawing.Point(12, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(658, 37);
            this.panel3.TabIndex = 8;
            // 
            // cFormProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(682, 400);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PanelUserInfo);
            this.Controls.Add(this.dgvAllProductsInfo);
            this.Controls.Add(this.panel3);
            this.Name = "cFormProducts";
            this.Text = "Products";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.PanelUserInfo.ResumeLayout(false);
            this.PanelUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaxDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRetailPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPurchasePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllProductsInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxSearchBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel PanelUserInfo;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtMaxDiscount;
        private System.Windows.Forms.NumericUpDown txtRetailPrice;
        private System.Windows.Forms.NumericUpDown txtPurchasePrice;
        private System.Windows.Forms.NumericUpDown txtStock;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCurrentUsername;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label lblCurrentPhone;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblCurrentEmail;
        private System.Windows.Forms.Label lblCurrentAddress;
        private System.Windows.Forms.Label lblCurrentname;
        private System.Windows.Forms.DataGridView dgvAllProductsInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRetailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMaxDiscount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotes;
    }
}
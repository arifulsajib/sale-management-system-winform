namespace FinalProject.UserChildForms
{
    partial class cFormUserAnalysis
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
            this.clmNotes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmRetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSaleId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalSales = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clmSaleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDateTo = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxSearchBy = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAllSalesInfo = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSalesInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // clmNotes
            // 
            this.clmNotes.DataPropertyName = "sale_notes";
            this.clmNotes.HeaderText = "SellNotes";
            this.clmNotes.Name = "clmNotes";
            // 
            // clmTotalPurchasePrice
            // 
            this.clmTotalPurchasePrice.DataPropertyName = "totalPurchasePrice";
            this.clmTotalPurchasePrice.HeaderText = "TotalPurchasePrice";
            this.clmTotalPurchasePrice.Name = "clmTotalPurchasePrice";
            this.clmTotalPurchasePrice.Visible = false;
            // 
            // clmTotalPrice
            // 
            this.clmTotalPrice.DataPropertyName = "total_price";
            this.clmTotalPrice.HeaderText = "TotalPrice";
            this.clmTotalPrice.Name = "clmTotalPrice";
            // 
            // clmQuantity
            // 
            this.clmQuantity.DataPropertyName = "quantity";
            this.clmQuantity.HeaderText = "Quantity";
            this.clmQuantity.Name = "clmQuantity";
            // 
            // clmRetailPrice
            // 
            this.clmRetailPrice.DataPropertyName = "sell_price";
            this.clmRetailPrice.HeaderText = "SalePrice";
            this.clmRetailPrice.Name = "clmRetailPrice";
            // 
            // clmPurchasePrice
            // 
            this.clmPurchasePrice.DataPropertyName = "purchase_price";
            this.clmPurchasePrice.HeaderText = "PurchasePrice";
            this.clmPurchasePrice.Name = "clmPurchasePrice";
            this.clmPurchasePrice.Visible = false;
            // 
            // clmUsername
            // 
            this.clmUsername.DataPropertyName = "username";
            this.clmUsername.HeaderText = "Username";
            this.clmUsername.Name = "clmUsername";
            // 
            // clmBrand
            // 
            this.clmBrand.DataPropertyName = "brand";
            this.clmBrand.HeaderText = "Brand";
            this.clmBrand.Name = "clmBrand";
            // 
            // clmProductName
            // 
            this.clmProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmProductName.DataPropertyName = "product_name";
            this.clmProductName.HeaderText = "Pro.Name";
            this.clmProductName.Name = "clmProductName";
            this.clmProductName.Width = 104;
            // 
            // clmProductId
            // 
            this.clmProductId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.clmProductId.DataPropertyName = "product_id";
            this.clmProductId.HeaderText = "Pro. ID";
            this.clmProductId.Name = "clmProductId";
            this.clmProductId.Width = 86;
            // 
            // clmSaleId
            // 
            this.clmSaleId.DataPropertyName = "sale_id";
            this.clmSaleId.HeaderText = "Sale ID";
            this.clmSaleId.Name = "clmSaleId";
            this.clmSaleId.Visible = false;
            // 
            // lblTotalSales
            // 
            this.lblTotalSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalSales.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSales.ForeColor = System.Drawing.Color.White;
            this.lblTotalSales.Location = new System.Drawing.Point(0, 39);
            this.lblTotalSales.Name = "lblTotalSales";
            this.lblTotalSales.Size = new System.Drawing.Size(121, 44);
            this.lblTotalSales.TabIndex = 1;
            this.lblTotalSales.Text = "140";
            this.lblTotalSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Sales";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.lblTotalSales);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(183, 9);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(121, 83);
            this.panel2.TabIndex = 0;
            // 
            // clmSaleDate
            // 
            this.clmSaleDate.DataPropertyName = "date";
            this.clmSaleDate.HeaderText = "SaleDate";
            this.clmSaleDate.Name = "clmSaleDate";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalAmount.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.White;
            this.lblTotalAmount.Location = new System.Drawing.Point(0, 39);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(121, 44);
            this.lblTotalAmount.TabIndex = 1;
            this.lblTotalAmount.Text = "140";
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Bodoni MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Amount";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel1.Location = new System.Drawing.Point(23, 299);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(636, 97);
            this.panel1.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel4.Controls.Add(this.lblTotalAmount);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(332, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(121, 83);
            this.panel4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(271, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sale Analysis";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.panel3.Location = new System.Drawing.Point(23, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 37);
            this.panel3.TabIndex = 19;
            // 
            // txtDateTo
            // 
            this.txtDateTo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateTo.CalendarFont = new System.Drawing.Font("Bodoni MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTo.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateTo.Location = new System.Drawing.Point(527, 20);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(96, 23);
            this.txtDateTo.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(496, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 15);
            this.label9.TabIndex = 19;
            this.label9.Text = "To :";
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateFrom.CalendarFont = new System.Drawing.Font("Bodoni MT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFrom.Font = new System.Drawing.Font("Bodoni MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtDateFrom.Location = new System.Drawing.Point(390, 21);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(96, 23);
            this.txtDateFrom.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(345, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "From :";
            // 
            // cbxSearchBy
            // 
            this.cbxSearchBy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxSearchBy.Font = new System.Drawing.Font("Britannic Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSearchBy.FormattingEnabled = true;
            this.cbxSearchBy.Items.AddRange(new object[] {
            "By ProductID",
            "By ProductName",
            "By Brand"});
            this.cbxSearchBy.Location = new System.Drawing.Point(222, 20);
            this.cbxSearchBy.Name = "cbxSearchBy";
            this.cbxSearchBy.Size = new System.Drawing.Size(114, 23);
            this.cbxSearchBy.TabIndex = 10;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.txtSearch.Location = new System.Drawing.Point(73, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(130, 17);
            this.txtSearch.TabIndex = 3;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtDateTo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDateFrom);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbxSearchBy);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Font = new System.Drawing.Font("Bodoni MT", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(23, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 53);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Search ";
            // 
            // dgvAllSalesInfo
            // 
            this.dgvAllSalesInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAllSalesInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAllSalesInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SlateBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Bodoni MT", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllSalesInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAllSalesInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllSalesInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmSaleId,
            this.clmProductId,
            this.clmProductName,
            this.clmBrand,
            this.clmUsername,
            this.clmPurchasePrice,
            this.clmRetailPrice,
            this.clmQuantity,
            this.clmTotalPrice,
            this.clmTotalPurchasePrice,
            this.clmSaleDate,
            this.clmNotes});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAllSalesInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAllSalesInfo.EnableHeadersVisualStyles = false;
            this.dgvAllSalesInfo.Location = new System.Drawing.Point(23, 107);
            this.dgvAllSalesInfo.Name = "dgvAllSalesInfo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAllSalesInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAllSalesInfo.RowTemplate.Height = 35;
            this.dgvAllSalesInfo.Size = new System.Drawing.Size(636, 186);
            this.dgvAllSalesInfo.TabIndex = 18;
            // 
            // cFormUserAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(682, 400);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAllSalesInfo);
            this.Name = "cFormUserAnalysis";
            this.Text = "Analysis";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllSalesInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn clmNotes;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmRetailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUsername;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSaleId;
        private System.Windows.Forms.Label lblTotalSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSaleDate;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker txtDateTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker txtDateFrom;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxSearchBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAllSalesInfo;
    }
}
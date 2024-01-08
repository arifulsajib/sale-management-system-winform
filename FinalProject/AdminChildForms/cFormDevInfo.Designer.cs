namespace FinalProject.AdminChildForms
{
    partial class cFormDevInfo
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
            this.pbDevInfo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDevInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbDevInfo
            // 
            this.pbDevInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDevInfo.Image = global::FinalProject.Properties.Resources.developer_info2;
            this.pbDevInfo.Location = new System.Drawing.Point(7, 12);
            this.pbDevInfo.Name = "pbDevInfo";
            this.pbDevInfo.Size = new System.Drawing.Size(663, 376);
            this.pbDevInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDevInfo.TabIndex = 0;
            this.pbDevInfo.TabStop = false;
            // 
            // cFormDevInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(682, 400);
            this.Controls.Add(this.pbDevInfo);
            this.Name = "cFormDevInfo";
            this.Text = "Dev Info";
            ((System.ComponentModel.ISupportInitialize)(this.pbDevInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDevInfo;
    }
}
namespace TZ
{
    partial class Index
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Index));
            this.buttonFirms = new System.Windows.Forms.Button();
            this.buttonDocument = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonFirms
            // 
            this.buttonFirms.Location = new System.Drawing.Point(54, 75);
            this.buttonFirms.Name = "buttonFirms";
            this.buttonFirms.Size = new System.Drawing.Size(107, 51);
            this.buttonFirms.TabIndex = 0;
            this.buttonFirms.Text = "Поиск по фирмам";
            this.buttonFirms.UseVisualStyleBackColor = true;
            this.buttonFirms.Click += new System.EventHandler(this.buttonFirms_Click);
            // 
            // buttonDocument
            // 
            this.buttonDocument.Location = new System.Drawing.Point(266, 75);
            this.buttonDocument.Name = "buttonDocument";
            this.buttonDocument.Size = new System.Drawing.Size(111, 51);
            this.buttonDocument.TabIndex = 1;
            this.buttonDocument.Text = "Поиск по документам";
            this.buttonDocument.UseVisualStyleBackColor = true;
            this.buttonDocument.Click += new System.EventHandler(this.buttonDocument_Click);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(435, 221);
            this.Controls.Add(this.buttonDocument);
            this.Controls.Add(this.buttonFirms);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Index";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonFirms;
        private System.Windows.Forms.Button buttonDocument;
    }
}
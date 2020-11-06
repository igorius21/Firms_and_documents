namespace TZ
{
    partial class Firms
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Firms));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.enterNameFirms = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.enterJurCity = new System.Windows.Forms.TextBox();
            this.enterPostCity = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.enterJurPost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(29, 26);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(602, 221);
            this.dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ввести название фирмы";
            // 
            // enterNameFirms
            // 
            this.enterNameFirms.Location = new System.Drawing.Point(32, 318);
            this.enterNameFirms.Name = "enterNameFirms";
            this.enterNameFirms.Size = new System.Drawing.Size(143, 20);
            this.enterNameFirms.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 374);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ввести город юридического адреса";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 432);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ввести город почтового адреса";
            // 
            // enterJurCity
            // 
            this.enterJurCity.Location = new System.Drawing.Point(35, 398);
            this.enterJurCity.Name = "enterJurCity";
            this.enterJurCity.Size = new System.Drawing.Size(140, 20);
            this.enterJurCity.TabIndex = 5;
            this.enterJurCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterJurCity_KeyPress);
            // 
            // enterPostCity
            // 
            this.enterPostCity.Location = new System.Drawing.Point(35, 459);
            this.enterPostCity.Name = "enterPostCity";
            this.enterPostCity.Size = new System.Drawing.Size(140, 20);
            this.enterPostCity.TabIndex = 6;
            this.enterPostCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterPostCity_KeyPress);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(292, 459);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(131, 52);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "Найти";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ввести город, являющийся и почтовым и юридическим адресом";
            // 
            // enterJurPost
            // 
            this.enterJurPost.Location = new System.Drawing.Point(298, 318);
            this.enterJurPost.Name = "enterJurPost";
            this.enterJurPost.Size = new System.Drawing.Size(125, 20);
            this.enterJurPost.TabIndex = 9;
            this.enterJurPost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enterJurPost_KeyPress);
            // 
            // Firms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(664, 523);
            this.Controls.Add(this.enterJurPost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.enterPostCity);
            this.Controls.Add(this.enterJurCity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enterNameFirms);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Firms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск по фирмам";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox enterNameFirms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enterJurCity;
        private System.Windows.Forms.TextBox enterPostCity;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox enterJurPost;
    }
}


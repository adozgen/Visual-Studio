namespace Proje
{
    partial class kayıtform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayıtform));
            this.cbkkurum = new System.Windows.Forms.ComboBox();
            this.txtkad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtksikayet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtkinceleme = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtktel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbkkurum
            // 
            this.cbkkurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkkurum.FormattingEnabled = true;
            this.cbkkurum.Items.AddRange(new object[] {
            "SASKİ",
            "BÜYÜKŞEHİR"});
            this.cbkkurum.Location = new System.Drawing.Point(88, 64);
            this.cbkkurum.Name = "cbkkurum";
            this.cbkkurum.Size = new System.Drawing.Size(144, 21);
            this.cbkkurum.TabIndex = 24;
            // 
            // txtkad
            // 
            this.txtkad.Location = new System.Drawing.Point(88, 22);
            this.txtkad.Name = "txtkad";
            this.txtkad.Size = new System.Drawing.Size(144, 20);
            this.txtkad.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(21, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Kurum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(21, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ad Soyad";
            // 
            // txtksikayet
            // 
            this.txtksikayet.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtksikayet.Location = new System.Drawing.Point(22, 162);
            this.txtksikayet.Multiline = true;
            this.txtksikayet.Name = "txtksikayet";
            this.txtksikayet.Size = new System.Drawing.Size(324, 69);
            this.txtksikayet.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(19, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Şikayet";
            // 
            // txtkinceleme
            // 
            this.txtkinceleme.Location = new System.Drawing.Point(22, 316);
            this.txtkinceleme.Multiline = true;
            this.txtkinceleme.Name = "txtkinceleme";
            this.txtkinceleme.Size = new System.Drawing.Size(324, 86);
            this.txtkinceleme.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(19, 300);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Sonuc";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(259, 423);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 41);
            this.button1.TabIndex = 29;
            this.button1.Text = "    Raporla";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Telefon";
            // 
            // txtktel
            // 
            this.txtktel.Location = new System.Drawing.Point(88, 107);
            this.txtktel.Name = "txtktel";
            this.txtktel.Size = new System.Drawing.Size(144, 20);
            this.txtktel.TabIndex = 31;
            // 
            // kayıtform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(377, 468);
            this.Controls.Add(this.txtktel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtkinceleme);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtksikayet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbkkurum);
            this.Controls.Add(this.txtkad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "kayıtform";
            this.Text = "kayıtform";
            this.Load += new System.EventHandler(this.kayıtform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox cbkkurum;
        public System.Windows.Forms.TextBox txtkad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtksikayet;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtkinceleme;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtktel;
    }
}
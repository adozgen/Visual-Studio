namespace Proje
{
    partial class adkurumarama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adkurumarama));
            this.txtad = new System.Windows.Forms.TextBox();
            this.cbkurum = new System.Windows.Forms.ComboBox();
            this.checkad = new System.Windows.Forms.CheckBox();
            this.checkkurum = new System.Windows.Forms.CheckBox();
            this.btnara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtad
            // 
            this.txtad.Enabled = false;
            this.txtad.Location = new System.Drawing.Point(135, 73);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(113, 20);
            this.txtad.TabIndex = 10;
            // 
            // cbkurum
            // 
            this.cbkurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkurum.Enabled = false;
            this.cbkurum.FormattingEnabled = true;
            this.cbkurum.Items.AddRange(new object[] {
            "SASKİ",
            "BÜYÜKŞEHİR"});
            this.cbkurum.Location = new System.Drawing.Point(135, 107);
            this.cbkurum.Name = "cbkurum";
            this.cbkurum.Size = new System.Drawing.Size(113, 21);
            this.cbkurum.TabIndex = 13;
            // 
            // checkad
            // 
            this.checkad.AutoSize = true;
            this.checkad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkad.Location = new System.Drawing.Point(49, 73);
            this.checkad.Name = "checkad";
            this.checkad.Size = new System.Drawing.Size(80, 17);
            this.checkad.TabIndex = 11;
            this.checkad.Text = "Ad Soyad";
            this.checkad.UseVisualStyleBackColor = true;
            this.checkad.CheckedChanged += new System.EventHandler(this.checkad_CheckedChanged);
            // 
            // checkkurum
            // 
            this.checkkurum.AutoSize = true;
            this.checkkurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkkurum.Location = new System.Drawing.Point(49, 107);
            this.checkkurum.Name = "checkkurum";
            this.checkkurum.Size = new System.Drawing.Size(61, 17);
            this.checkkurum.TabIndex = 12;
            this.checkkurum.Text = "Kurum\r\n";
            this.checkkurum.UseVisualStyleBackColor = true;
            this.checkkurum.CheckedChanged += new System.EventHandler(this.checkkurum_CheckedChanged);
            // 
            // btnara
            // 
            this.btnara.BackColor = System.Drawing.Color.Transparent;
            this.btnara.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnara.Image = ((System.Drawing.Image)(resources.GetObject("btnara.Image")));
            this.btnara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnara.Location = new System.Drawing.Point(102, 148);
            this.btnara.Name = "btnara";
            this.btnara.Size = new System.Drawing.Size(80, 27);
            this.btnara.TabIndex = 8;
            this.btnara.Text = "    Ara";
            this.btnara.UseVisualStyleBackColor = false;
            this.btnara.Click += new System.EventHandler(this.btnara_Click);
            // 
            // adkurumarama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.cbkurum);
            this.Controls.Add(this.checkad);
            this.Controls.Add(this.checkkurum);
            this.Controls.Add(this.btnara);
            this.Name = "adkurumarama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "adkurumarama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtad;
        public System.Windows.Forms.ComboBox cbkurum;
        public System.Windows.Forms.CheckBox checkad;
        public System.Windows.Forms.CheckBox checkkurum;
        private System.Windows.Forms.Button btnara;
    }
}
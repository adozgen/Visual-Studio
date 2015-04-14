namespace Proje
{
    partial class sifredegistir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sifredegistir));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtdegissifre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsfrdegistr = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 104);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // txtdegissifre
            // 
            this.txtdegissifre.Location = new System.Drawing.Point(214, 54);
            this.txtdegissifre.Name = "txtdegissifre";
            this.txtdegissifre.PasswordChar = '*';
            this.txtdegissifre.Size = new System.Drawing.Size(119, 20);
            this.txtdegissifre.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(146, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Yeni Şifre";
            // 
            // btnsfrdegistr
            // 
            this.btnsfrdegistr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsfrdegistr.Image = ((System.Drawing.Image)(resources.GetObject("btnsfrdegistr.Image")));
            this.btnsfrdegistr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsfrdegistr.Location = new System.Drawing.Point(214, 86);
            this.btnsfrdegistr.Name = "btnsfrdegistr";
            this.btnsfrdegistr.Size = new System.Drawing.Size(119, 30);
            this.btnsfrdegistr.TabIndex = 6;
            this.btnsfrdegistr.Text = "     Şifreyi değiştir";
            this.btnsfrdegistr.UseVisualStyleBackColor = true;
            this.btnsfrdegistr.Click += new System.EventHandler(this.btnsfrdegistr_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(214, 9);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(40, 20);
            this.txtID.TabIndex = 13;
            this.txtID.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID";
            this.label3.Visible = false;
            // 
            // sifredegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(343, 163);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtdegissifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnsfrdegistr);
            this.Name = "sifredegistir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "sifredegistir";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsfrdegistr;
        public System.Windows.Forms.TextBox txtdegissifre;
        public System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label3;
    }
}
namespace Proje
{
    partial class mainform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtAraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kullanıcıİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniKayıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şifreDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtAraToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tariheGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adVeKurumaGöreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblKullaniciID = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtToolStripMenuItem,
            this.kayıtAraToolStripMenuItem1,
            this.kullanıcıİşlemleriToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kayıtToolStripMenuItem
            // 
            this.kayıtToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.kayıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtEkleToolStripMenuItem,
            this.kayıtAraToolStripMenuItem});
            this.kayıtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kayıtToolStripMenuItem.Image")));
            this.kayıtToolStripMenuItem.Name = "kayıtToolStripMenuItem";
            this.kayıtToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.kayıtToolStripMenuItem.Text = "Kayıt";
            // 
            // kayıtEkleToolStripMenuItem
            // 
            this.kayıtEkleToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.kayıtEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kayıtEkleToolStripMenuItem.Image")));
            this.kayıtEkleToolStripMenuItem.Name = "kayıtEkleToolStripMenuItem";
            this.kayıtEkleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kayıtEkleToolStripMenuItem.Text = "Kayıt ekle";
            this.kayıtEkleToolStripMenuItem.Click += new System.EventHandler(this.kayıtEkleToolStripMenuItem_Click);
            // 
            // kayıtAraToolStripMenuItem
            // 
            this.kayıtAraToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.kayıtAraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kayıtAraToolStripMenuItem.Image")));
            this.kayıtAraToolStripMenuItem.Name = "kayıtAraToolStripMenuItem";
            this.kayıtAraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kayıtAraToolStripMenuItem.Text = "Kayıt listesi";
            this.kayıtAraToolStripMenuItem.Click += new System.EventHandler(this.kayıtAraToolStripMenuItem_Click);
            // 
            // kullanıcıİşlemleriToolStripMenuItem
            // 
            this.kullanıcıİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniKayıtToolStripMenuItem,
            this.şifreDeğiştirToolStripMenuItem});
            this.kullanıcıİşlemleriToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kullanıcıİşlemleriToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kullanıcıİşlemleriToolStripMenuItem.Image")));
            this.kullanıcıİşlemleriToolStripMenuItem.Name = "kullanıcıİşlemleriToolStripMenuItem";
            this.kullanıcıİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.kullanıcıİşlemleriToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // yeniKayıtToolStripMenuItem
            // 
            this.yeniKayıtToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.yeniKayıtToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("yeniKayıtToolStripMenuItem.Image")));
            this.yeniKayıtToolStripMenuItem.Name = "yeniKayıtToolStripMenuItem";
            this.yeniKayıtToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.yeniKayıtToolStripMenuItem.Text = "Yeni Kayıt";
            this.yeniKayıtToolStripMenuItem.Click += new System.EventHandler(this.yeniKayıtToolStripMenuItem_Click);
            // 
            // şifreDeğiştirToolStripMenuItem
            // 
            this.şifreDeğiştirToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.şifreDeğiştirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("şifreDeğiştirToolStripMenuItem.Image")));
            this.şifreDeğiştirToolStripMenuItem.Name = "şifreDeğiştirToolStripMenuItem";
            this.şifreDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            this.şifreDeğiştirToolStripMenuItem.Text = "Şifre Değiştir";
            this.şifreDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.şifreDeğiştirToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.çıkışToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("çıkışToolStripMenuItem.Image")));
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // kayıtAraToolStripMenuItem1
            // 
            this.kayıtAraToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tariheGöreToolStripMenuItem,
            this.adVeKurumaGöreToolStripMenuItem});
            this.kayıtAraToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayıtAraToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("kayıtAraToolStripMenuItem1.Image")));
            this.kayıtAraToolStripMenuItem1.Name = "kayıtAraToolStripMenuItem1";
            this.kayıtAraToolStripMenuItem1.Size = new System.Drawing.Size(85, 20);
            this.kayıtAraToolStripMenuItem1.Text = "Kayıt Ara";
            // 
            // tariheGöreToolStripMenuItem
            // 
            this.tariheGöreToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.tariheGöreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tariheGöreToolStripMenuItem.Image")));
            this.tariheGöreToolStripMenuItem.Name = "tariheGöreToolStripMenuItem";
            this.tariheGöreToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tariheGöreToolStripMenuItem.Text = "Tarihe göre";
            this.tariheGöreToolStripMenuItem.Click += new System.EventHandler(this.tariheGöreToolStripMenuItem_Click);
            // 
            // adVeKurumaGöreToolStripMenuItem
            // 
            this.adVeKurumaGöreToolStripMenuItem.BackColor = System.Drawing.Color.LavenderBlush;
            this.adVeKurumaGöreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("adVeKurumaGöreToolStripMenuItem.Image")));
            this.adVeKurumaGöreToolStripMenuItem.Name = "adVeKurumaGöreToolStripMenuItem";
            this.adVeKurumaGöreToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.adVeKurumaGöreToolStripMenuItem.Text = "Ad ve Kuruma göre";
            this.adVeKurumaGöreToolStripMenuItem.Click += new System.EventHandler(this.adVeKurumaGöreToolStripMenuItem_Click);
            // 
            // lblKullaniciID
            // 
            this.lblKullaniciID.AutoSize = true;
            this.lblKullaniciID.Location = new System.Drawing.Point(653, 396);
            this.lblKullaniciID.Name = "lblKullaniciID";
            this.lblKullaniciID.Size = new System.Drawing.Size(0, 13);
            this.lblKullaniciID.TabIndex = 3;
            this.lblKullaniciID.Visible = false;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(708, 430);
            this.Controls.Add(this.lblKullaniciID);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "mainform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mainform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtAraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kullanıcıİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yeniKayıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şifreDeğiştirToolStripMenuItem;
        public System.Windows.Forms.Label lblKullaniciID;
        private System.Windows.Forms.ToolStripMenuItem tariheGöreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adVeKurumaGöreToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem kayıtAraToolStripMenuItem1;
    }
}
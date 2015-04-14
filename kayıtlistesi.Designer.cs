namespace Proje
{
    partial class kayıtlistesi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayıtlistesi));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.kayıtSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kayıtEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kayıtSilToolStripMenuItem,
            this.kayıtGüncelleToolStripMenuItem,
            this.kayıtEkleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(150, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // kayıtSilToolStripMenuItem
            // 
            this.kayıtSilToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kayıtSilToolStripMenuItem.Image")));
            this.kayıtSilToolStripMenuItem.Name = "kayıtSilToolStripMenuItem";
            this.kayıtSilToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.kayıtSilToolStripMenuItem.Text = "Kayıt Sil";
            this.kayıtSilToolStripMenuItem.Click += new System.EventHandler(this.kayıtSilToolStripMenuItem_Click_1);
            // 
            // kayıtGüncelleToolStripMenuItem
            // 
            this.kayıtGüncelleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kayıtGüncelleToolStripMenuItem.Image")));
            this.kayıtGüncelleToolStripMenuItem.Name = "kayıtGüncelleToolStripMenuItem";
            this.kayıtGüncelleToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.kayıtGüncelleToolStripMenuItem.Text = "Kayıt Güncelle";
            this.kayıtGüncelleToolStripMenuItem.Click += new System.EventHandler(this.kayıtGüncelleToolStripMenuItem_Click_1);
            // 
            // kayıtEkleToolStripMenuItem
            // 
            this.kayıtEkleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kayıtEkleToolStripMenuItem.Image")));
            this.kayıtEkleToolStripMenuItem.Name = "kayıtEkleToolStripMenuItem";
            this.kayıtEkleToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.kayıtEkleToolStripMenuItem.Text = "Kayıt Ekle";
            this.kayıtEkleToolStripMenuItem.Click += new System.EventHandler(this.kayıtEkleToolStripMenuItem_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(77, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "raporla";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(588, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 20;
            this.button3.Text = "raporla1";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.DarkTurquoise;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.Location = new System.Drawing.Point(3, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(673, 208);
            this.dataGridView1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(320, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Tüm liste";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // kayıtlistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(675, 328);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Name = "kayıtlistesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kayıtlistesi";
            this.Load += new System.EventHandler(this.kayıtlistesi_Load_1);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kayıtSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kayıtEkleToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
    }
}
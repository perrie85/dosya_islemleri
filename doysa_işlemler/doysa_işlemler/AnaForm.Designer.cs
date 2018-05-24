namespace doysa_işlemler
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.görünümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelKayıtEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelAramaEkranıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.görünümToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // görünümToolStripMenuItem
            // 
            this.görünümToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelKayıtEkranıToolStripMenuItem,
            this.personelAramaEkranıToolStripMenuItem});
            this.görünümToolStripMenuItem.Name = "görünümToolStripMenuItem";
            this.görünümToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.görünümToolStripMenuItem.Text = "Görünüm";
            // 
            // personelKayıtEkranıToolStripMenuItem
            // 
            this.personelKayıtEkranıToolStripMenuItem.Name = "personelKayıtEkranıToolStripMenuItem";
            this.personelKayıtEkranıToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.personelKayıtEkranıToolStripMenuItem.Text = "Personel Kayıt Ekranı";
            this.personelKayıtEkranıToolStripMenuItem.Click += new System.EventHandler(this.personelKayıtEkranıToolStripMenuItem_Click);
            // 
            // personelAramaEkranıToolStripMenuItem
            // 
            this.personelAramaEkranıToolStripMenuItem.Name = "personelAramaEkranıToolStripMenuItem";
            this.personelAramaEkranıToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.personelAramaEkranıToolStripMenuItem.Text = "Personel Arama Ekranı";
            this.personelAramaEkranıToolStripMenuItem.Click += new System.EventHandler(this.personelAramaEkranıToolStripMenuItem_Click);
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem görünümToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelKayıtEkranıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelAramaEkranıToolStripMenuItem;
    }
}




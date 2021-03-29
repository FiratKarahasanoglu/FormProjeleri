
namespace MovieApp
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hızlıErişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzayYolcularıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korkuSeansıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aynıYıldızınAltındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.psILoveYouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.madMaxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilimKurguToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korkuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.romantikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turuncuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.griToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renklerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aksiyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // hızlıErişimToolStripMenuItem
            // 
            this.hızlıErişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.hızlıErişimToolStripMenuItem.Name = "hızlıErişimToolStripMenuItem";
            this.hızlıErişimToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.hızlıErişimToolStripMenuItem.Text = "Hızlı Erişim";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // uzayYolcularıToolStripMenuItem
            // 
            this.uzayYolcularıToolStripMenuItem.Name = "uzayYolcularıToolStripMenuItem";
            this.uzayYolcularıToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.uzayYolcularıToolStripMenuItem.Text = "Uzay Yolcuları";
            this.uzayYolcularıToolStripMenuItem.Click += new System.EventHandler(this.uzayYolcularıToolStripMenuItem_Click);
            // 
            // korkuSeansıToolStripMenuItem
            // 
            this.korkuSeansıToolStripMenuItem.Name = "korkuSeansıToolStripMenuItem";
            this.korkuSeansıToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.korkuSeansıToolStripMenuItem.Text = "Korku Seansı";
            this.korkuSeansıToolStripMenuItem.Click += new System.EventHandler(this.korkuSeansıToolStripMenuItem_Click);
            // 
            // aynıYıldızınAltındaToolStripMenuItem
            // 
            this.aynıYıldızınAltındaToolStripMenuItem.Name = "aynıYıldızınAltındaToolStripMenuItem";
            this.aynıYıldızınAltındaToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.aynıYıldızınAltındaToolStripMenuItem.Text = "Aynı Yıldızın Altında";
            this.aynıYıldızınAltındaToolStripMenuItem.Click += new System.EventHandler(this.aynıYıldızınAltındaToolStripMenuItem_Click);
            // 
            // psILoveYouToolStripMenuItem
            // 
            this.psILoveYouToolStripMenuItem.Name = "psILoveYouToolStripMenuItem";
            this.psILoveYouToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.psILoveYouToolStripMenuItem.Text = "Ps: I love You";
            this.psILoveYouToolStripMenuItem.Click += new System.EventHandler(this.psILoveYouToolStripMenuItem_Click);
            // 
            // madMaxToolStripMenuItem
            // 
            this.madMaxToolStripMenuItem.Name = "madMaxToolStripMenuItem";
            this.madMaxToolStripMenuItem.Size = new System.Drawing.Size(154, 26);
            this.madMaxToolStripMenuItem.Text = "Mad Max";
            this.madMaxToolStripMenuItem.Click += new System.EventHandler(this.madMaxToolStripMenuItem_Click);
            // 
            // bilimKurguToolStripMenuItem
            // 
            this.bilimKurguToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uzayYolcularıToolStripMenuItem});
            this.bilimKurguToolStripMenuItem.Name = "bilimKurguToolStripMenuItem";
            this.bilimKurguToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.bilimKurguToolStripMenuItem.Text = "Bilim Kurgu";
            // 
            // korkuToolStripMenuItem
            // 
            this.korkuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.korkuSeansıToolStripMenuItem});
            this.korkuToolStripMenuItem.Name = "korkuToolStripMenuItem";
            this.korkuToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.korkuToolStripMenuItem.Text = "Korku";
            // 
            // romantikToolStripMenuItem
            // 
            this.romantikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.psILoveYouToolStripMenuItem,
            this.aynıYıldızınAltındaToolStripMenuItem});
            this.romantikToolStripMenuItem.Name = "romantikToolStripMenuItem";
            this.romantikToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.romantikToolStripMenuItem.Text = "Romantik";
            // 
            // turuncuToolStripMenuItem
            // 
            this.turuncuToolStripMenuItem.Name = "turuncuToolStripMenuItem";
            this.turuncuToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.turuncuToolStripMenuItem.Text = "Turuncu";
            this.turuncuToolStripMenuItem.Click += new System.EventHandler(this.turuncuToolStripMenuItem_Click);
            // 
            // griToolStripMenuItem
            // 
            this.griToolStripMenuItem.Name = "griToolStripMenuItem";
            this.griToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.griToolStripMenuItem.Text = "Gri";
            this.griToolStripMenuItem.Click += new System.EventHandler(this.griToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // renklerToolStripMenuItem
            // 
            this.renklerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blueToolStripMenuItem,
            this.griToolStripMenuItem,
            this.turuncuToolStripMenuItem});
            this.renklerToolStripMenuItem.Name = "renklerToolStripMenuItem";
            this.renklerToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.renklerToolStripMenuItem.Text = "Renkler";
            // 
            // aksiyonToolStripMenuItem
            // 
            this.aksiyonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.madMaxToolStripMenuItem});
            this.aksiyonToolStripMenuItem.Name = "aksiyonToolStripMenuItem";
            this.aksiyonToolStripMenuItem.Size = new System.Drawing.Size(169, 26);
            this.aksiyonToolStripMenuItem.Text = "Aksiyon";
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aksiyonToolStripMenuItem,
            this.romantikToolStripMenuItem,
            this.korkuToolStripMenuItem,
            this.bilimKurguToolStripMenuItem});
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorilerToolStripMenuItem,
            this.renklerToolStripMenuItem,
            this.hızlıErişimToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(17, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(904, 34);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(37, 106);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(8);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(55, 48);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(822, 347);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.webBrowser1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "MovieApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hızlıErişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uzayYolcularıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korkuSeansıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aynıYıldızınAltındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem psILoveYouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem madMaxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilimKurguToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korkuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem romantikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turuncuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem griToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renklerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aksiyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}


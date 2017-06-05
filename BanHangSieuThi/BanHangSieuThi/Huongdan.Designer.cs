namespace BanHangSieuThi
{
    partial class Huongdan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Huongdan));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hướngDẫnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhânViênThêmSửaXóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểmTraKhoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wbw_huongdan = new System.Windows.Forms.WebBrowser();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hướngDẫnToolStripMenuItem,
            this.quảnLýNhânViênThêmSửaXóaToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.bánHàngToolStripMenuItem,
            this.thêmHàngToolStripMenuItem,
            this.kiểmTraKhoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1062, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hướngDẫnToolStripMenuItem
            // 
            this.hướngDẫnToolStripMenuItem.Name = "hướngDẫnToolStripMenuItem";
            this.hướngDẫnToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.hướngDẫnToolStripMenuItem.Text = "Hướng dẫn";
            this.hướngDẫnToolStripMenuItem.Click += new System.EventHandler(this.hướngDẫnToolStripMenuItem_Click);
            // 
            // quảnLýNhânViênThêmSửaXóaToolStripMenuItem
            // 
            this.quảnLýNhânViênThêmSửaXóaToolStripMenuItem.Name = "quảnLýNhânViênThêmSửaXóaToolStripMenuItem";
            this.quảnLýNhânViênThêmSửaXóaToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.quảnLýNhânViênThêmSửaXóaToolStripMenuItem.Text = "Nhân viên";
            this.quảnLýNhânViênThêmSửaXóaToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhânViênThêmSửaXóaToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.bánHàngToolStripMenuItem.Text = "Bán hàng";
            this.bánHàngToolStripMenuItem.Click += new System.EventHandler(this.bánHàngToolStripMenuItem_Click);
            // 
            // thêmHàngToolStripMenuItem
            // 
            this.thêmHàngToolStripMenuItem.Name = "thêmHàngToolStripMenuItem";
            this.thêmHàngToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.thêmHàngToolStripMenuItem.Text = "Thêm hàng";
            this.thêmHàngToolStripMenuItem.Click += new System.EventHandler(this.thêmHàngToolStripMenuItem_Click);
            // 
            // kiểmTraKhoToolStripMenuItem
            // 
            this.kiểmTraKhoToolStripMenuItem.Name = "kiểmTraKhoToolStripMenuItem";
            this.kiểmTraKhoToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.kiểmTraKhoToolStripMenuItem.Text = "Kiểm tra kho";
            this.kiểmTraKhoToolStripMenuItem.Click += new System.EventHandler(this.kiểmTraKhoToolStripMenuItem_Click);
            // 
            // wbw_huongdan
            // 
            this.wbw_huongdan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbw_huongdan.Location = new System.Drawing.Point(0, 24);
            this.wbw_huongdan.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbw_huongdan.Name = "wbw_huongdan";
            this.wbw_huongdan.Size = new System.Drawing.Size(1062, 495);
            this.wbw_huongdan.TabIndex = 1;
            // 
            // Huongdan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 519);
            this.Controls.Add(this.wbw_huongdan);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Huongdan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hướng dẫn sử dụng";
            this.Load += new System.EventHandler(this.Huongdan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hướngDẫnToolStripMenuItem;
        private System.Windows.Forms.WebBrowser wbw_huongdan;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhânViênThêmSửaXóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểmTraKhoToolStripMenuItem;
    }
}
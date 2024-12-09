namespace PersediaanBarang
{
    partial class FormMenuUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupDataBarang = new System.Windows.Forms.ToolStripMenuItem();
            this.setupDatasSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pembelian = new System.Windows.Forms.ToolStripMenuItem();
            this.penjualan = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem,
            this.transaksiToolStripMenuItem,
            this.keluarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(767, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupDataBarang,
            this.setupDatasSupplier});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.setupToolStripMenuItem.Text = "Setup";
            // 
            // setupDataBarang
            // 
            this.setupDataBarang.Name = "setupDataBarang";
            this.setupDataBarang.Size = new System.Drawing.Size(272, 34);
            this.setupDataBarang.Text = "Setup Data Barang";
            this.setupDataBarang.Click += new System.EventHandler(this.setupDataBarangToolStripMenuItem_Click);
            // 
            // setupDatasSupplier
            // 
            this.setupDatasSupplier.Name = "setupDatasSupplier";
            this.setupDatasSupplier.Size = new System.Drawing.Size(272, 34);
            this.setupDatasSupplier.Text = "Setup Data Supplier";
            this.setupDatasSupplier.Click += new System.EventHandler(this.setupDataSupplierToolStripMenuItem_Click);
            // 
            // transaksiToolStripMenuItem
            // 
            this.transaksiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pembelian,
            this.penjualan});
            this.transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            this.transaksiToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // pembelian
            // 
            this.pembelian.Name = "pembelian";
            this.pembelian.Size = new System.Drawing.Size(195, 34);
            this.pembelian.Text = "Pembelian";
            this.pembelian.Click += new System.EventHandler(this.pembelianToolStripMenuItem_Click);
            // 
            // penjualan
            // 
            this.penjualan.Name = "penjualan";
            this.penjualan.Size = new System.Drawing.Size(195, 34);
            this.penjualan.Text = "Penjualan";
            this.penjualan.Click += new System.EventHandler(this.penjualanToolStripMenuItem_Click);
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // FormMenuUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PersediaanBarang.Properties.Resources.wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(767, 486);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenuUtama";
            this.Text = "Sistem Informasi Persediaan Barang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupDataBarang;
        private System.Windows.Forms.ToolStripMenuItem setupDatasSupplier;
        private System.Windows.Forms.ToolStripMenuItem transaksiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pembelian;
        private System.Windows.Forms.ToolStripMenuItem penjualan;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
    }
}
namespace PersediaanBarang
{
    partial class FormCariBarang
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
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lblCari = new System.Windows.Forms.Label();
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.kodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(210, 12);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(483, 26);
            this.txtCari.TabIndex = 0;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(8, 15);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(186, 20);
            this.lblCari.TabIndex = 1;
            this.lblCari.Text = "Nama Barang yang dicari";
            // 
            // dgvBarang
            // 
            this.dgvBarang.AllowUserToAddRows = false;
            this.dgvBarang.AllowUserToDeleteRows = false;
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeBarang,
            this.namaBarang,
            this.stok,
            this.satuan});
            this.dgvBarang.Location = new System.Drawing.Point(6, 50);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.ReadOnly = true;
            this.dgvBarang.RowHeadersWidth = 62;
            this.dgvBarang.RowTemplate.Height = 28;
            this.dgvBarang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBarang.Size = new System.Drawing.Size(687, 394);
            this.dgvBarang.TabIndex = 2;
            this.dgvBarang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvBarang_KeyDown);
            // 
            // kodeBarang
            // 
            this.kodeBarang.DataPropertyName = "kodeBarang";
            this.kodeBarang.HeaderText = "Kode Barang";
            this.kodeBarang.MinimumWidth = 8;
            this.kodeBarang.Name = "kodeBarang";
            this.kodeBarang.ReadOnly = true;
            this.kodeBarang.Width = 70;
            // 
            // namaBarang
            // 
            this.namaBarang.DataPropertyName = "namaBarang";
            this.namaBarang.HeaderText = "Nama Barang";
            this.namaBarang.MinimumWidth = 8;
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.ReadOnly = true;
            this.namaBarang.Width = 175;
            // 
            // stok
            // 
            this.stok.DataPropertyName = "stok";
            this.stok.HeaderText = "Stok";
            this.stok.MinimumWidth = 8;
            this.stok.Name = "stok";
            this.stok.ReadOnly = true;
            this.stok.Width = 50;
            // 
            // satuan
            // 
            this.satuan.DataPropertyName = "satuan";
            this.satuan.HeaderText = "Satuan";
            this.satuan.MinimumWidth = 8;
            this.satuan.Name = "satuan";
            this.satuan.ReadOnly = true;
            this.satuan.Width = 80;
            // 
            // FormCariBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.dgvBarang);
            this.Controls.Add(this.lblCari);
            this.Controls.Add(this.txtCari);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCariBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCariBarang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn stok;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan;
    }
}
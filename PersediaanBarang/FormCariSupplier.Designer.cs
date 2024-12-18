namespace PersediaanBarang
{
    partial class FormCariSupplier
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
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.kodeSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telpon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCari = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSupplier
            // 
            this.dgvSupplier.AllowUserToAddRows = false;
            this.dgvSupplier.AllowUserToDeleteRows = false;
            this.dgvSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeSupplier,
            this.namaSupplier,
            this.alamat,
            this.telpon,
            this.kota});
            this.dgvSupplier.Location = new System.Drawing.Point(12, 56);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersWidth = 62;
            this.dgvSupplier.RowTemplate.Height = 28;
            this.dgvSupplier.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSupplier.Size = new System.Drawing.Size(1048, 394);
            this.dgvSupplier.TabIndex = 5;
            this.dgvSupplier.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSupplier_KeyDown);
            // 
            // kodeSupplier
            // 
            this.kodeSupplier.DataPropertyName = "kodeSupplier";
            this.kodeSupplier.HeaderText = "Kode Supplier";
            this.kodeSupplier.MinimumWidth = 8;
            this.kodeSupplier.Name = "kodeSupplier";
            this.kodeSupplier.ReadOnly = true;
            this.kodeSupplier.Width = 50;
            // 
            // namaSupplier
            // 
            this.namaSupplier.DataPropertyName = "namaSupplier";
            this.namaSupplier.HeaderText = "Nama Supplier";
            this.namaSupplier.MinimumWidth = 8;
            this.namaSupplier.Name = "namaSupplier";
            this.namaSupplier.ReadOnly = true;
            this.namaSupplier.Width = 175;
            // 
            // alamat
            // 
            this.alamat.DataPropertyName = "alamat";
            this.alamat.HeaderText = "Alamat";
            this.alamat.MinimumWidth = 8;
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            this.alamat.Width = 200;
            // 
            // telpon
            // 
            this.telpon.DataPropertyName = "telpon";
            this.telpon.HeaderText = "Telpon";
            this.telpon.MinimumWidth = 8;
            this.telpon.Name = "telpon";
            this.telpon.ReadOnly = true;
            this.telpon.Width = 150;
            // 
            // kota
            // 
            this.kota.DataPropertyName = "kota";
            this.kota.HeaderText = "Kota";
            this.kota.MinimumWidth = 8;
            this.kota.Name = "kota";
            this.kota.ReadOnly = true;
            this.kota.Width = 150;
            // 
            // lblCari
            // 
            this.lblCari.AutoSize = true;
            this.lblCari.Location = new System.Drawing.Point(14, 21);
            this.lblCari.Name = "lblCari";
            this.lblCari.Size = new System.Drawing.Size(192, 20);
            this.lblCari.TabIndex = 4;
            this.lblCari.Text = "Nama Supplier yang dicari";
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(216, 18);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(844, 26);
            this.txtCari.TabIndex = 3;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // FormCariSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 473);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.lblCari);
            this.Controls.Add(this.txtCari);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCariSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Cari Supplier";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.Label lblCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn telpon;
        private System.Windows.Forms.DataGridViewTextBoxColumn kota;
    }
}
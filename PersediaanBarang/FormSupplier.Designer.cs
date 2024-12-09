namespace PersediaanBarang
{
    partial class FormSupplier
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
            this.lblkodeSupplier = new System.Windows.Forms.Label();
            this.lblNamaSupplier = new System.Windows.Forms.Label();
            this.lblAlamat = new System.Windows.Forms.Label();
            this.lblTelpon = new System.Windows.Forms.Label();
            this.lblKota = new System.Windows.Forms.Label();
            this.txtKodeSupplier = new System.Windows.Forms.TextBox();
            this.txtNamaSupplier = new System.Windows.Forms.TextBox();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.dgvSupplier = new System.Windows.Forms.DataGridView();
            this.kodeSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telpon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTelpon = new System.Windows.Forms.TextBox();
            this.txtKota = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).BeginInit();
            this.SuspendLayout();
            // 
            // lblkodeSupplier
            // 
            this.lblkodeSupplier.AutoSize = true;
            this.lblkodeSupplier.Location = new System.Drawing.Point(22, 43);
            this.lblkodeSupplier.Name = "lblkodeSupplier";
            this.lblkodeSupplier.Size = new System.Drawing.Size(108, 20);
            this.lblkodeSupplier.TabIndex = 0;
            this.lblkodeSupplier.Text = "Kode Supplier";
            // 
            // lblNamaSupplier
            // 
            this.lblNamaSupplier.AutoSize = true;
            this.lblNamaSupplier.Location = new System.Drawing.Point(22, 76);
            this.lblNamaSupplier.Name = "lblNamaSupplier";
            this.lblNamaSupplier.Size = new System.Drawing.Size(113, 20);
            this.lblNamaSupplier.TabIndex = 0;
            this.lblNamaSupplier.Text = "Nama Supplier";
            // 
            // lblAlamat
            // 
            this.lblAlamat.AutoSize = true;
            this.lblAlamat.Location = new System.Drawing.Point(22, 113);
            this.lblAlamat.Name = "lblAlamat";
            this.lblAlamat.Size = new System.Drawing.Size(59, 20);
            this.lblAlamat.TabIndex = 0;
            this.lblAlamat.Text = "Alamat";
            // 
            // lblTelpon
            // 
            this.lblTelpon.AutoSize = true;
            this.lblTelpon.Location = new System.Drawing.Point(500, 40);
            this.lblTelpon.Name = "lblTelpon";
            this.lblTelpon.Size = new System.Drawing.Size(57, 20);
            this.lblTelpon.TabIndex = 0;
            this.lblTelpon.Text = "Telpon";
            // 
            // lblKota
            // 
            this.lblKota.AutoSize = true;
            this.lblKota.Location = new System.Drawing.Point(500, 73);
            this.lblKota.Name = "lblKota";
            this.lblKota.Size = new System.Drawing.Size(42, 20);
            this.lblKota.TabIndex = 0;
            this.lblKota.Text = "Kota";
            // 
            // txtKodeSupplier
            // 
            this.txtKodeSupplier.Location = new System.Drawing.Point(148, 43);
            this.txtKodeSupplier.Name = "txtKodeSupplier";
            this.txtKodeSupplier.Size = new System.Drawing.Size(98, 26);
            this.txtKodeSupplier.TabIndex = 1;
            // 
            // txtNamaSupplier
            // 
            this.txtNamaSupplier.Location = new System.Drawing.Point(148, 76);
            this.txtNamaSupplier.Name = "txtNamaSupplier";
            this.txtNamaSupplier.Size = new System.Drawing.Size(329, 26);
            this.txtNamaSupplier.TabIndex = 1;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Location = new System.Drawing.Point(148, 110);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(761, 26);
            this.txtAlamat.TabIndex = 1;
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
            this.dgvSupplier.Location = new System.Drawing.Point(22, 202);
            this.dgvSupplier.Name = "dgvSupplier";
            this.dgvSupplier.ReadOnly = true;
            this.dgvSupplier.RowHeadersWidth = 62;
            this.dgvSupplier.RowTemplate.Height = 28;
            this.dgvSupplier.Size = new System.Drawing.Size(887, 274);
            this.dgvSupplier.TabIndex = 2;
            // 
            // kodeSupplier
            // 
            this.kodeSupplier.DataPropertyName = "kodeSupplier";
            this.kodeSupplier.HeaderText = "Kode Supplier";
            this.kodeSupplier.MinimumWidth = 8;
            this.kodeSupplier.Name = "kodeSupplier";
            this.kodeSupplier.ReadOnly = true;
            this.kodeSupplier.Width = 70;
            // 
            // namaSupplier
            // 
            this.namaSupplier.DataPropertyName = "namaSupplier";
            this.namaSupplier.HeaderText = "Nama Supplier";
            this.namaSupplier.MinimumWidth = 8;
            this.namaSupplier.Name = "namaSupplier";
            this.namaSupplier.ReadOnly = true;
            this.namaSupplier.Width = 150;
            // 
            // alamat
            // 
            this.alamat.DataPropertyName = "alamat";
            this.alamat.HeaderText = "Alamat";
            this.alamat.MinimumWidth = 8;
            this.alamat.Name = "alamat";
            this.alamat.ReadOnly = true;
            this.alamat.Width = 150;
            // 
            // telpon
            // 
            this.telpon.DataPropertyName = "telpon";
            this.telpon.HeaderText = "Telpon";
            this.telpon.MinimumWidth = 8;
            this.telpon.Name = "telpon";
            this.telpon.ReadOnly = true;
            this.telpon.Width = 70;
            // 
            // kota
            // 
            this.kota.DataPropertyName = "kota";
            this.kota.HeaderText = "Kota";
            this.kota.MinimumWidth = 8;
            this.kota.Name = "kota";
            this.kota.ReadOnly = true;
            this.kota.Width = 70;
            // 
            // txtTelpon
            // 
            this.txtTelpon.Location = new System.Drawing.Point(563, 37);
            this.txtTelpon.Name = "txtTelpon";
            this.txtTelpon.Size = new System.Drawing.Size(346, 26);
            this.txtTelpon.TabIndex = 1;
            // 
            // txtKota
            // 
            this.txtKota.Location = new System.Drawing.Point(563, 73);
            this.txtKota.Name = "txtKota";
            this.txtKota.Size = new System.Drawing.Size(346, 26);
            this.txtKota.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Image = global::PersediaanBarang.Properties.Resources._12_Close;
            this.btnClose.Location = new System.Drawing.Point(844, 142);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::PersediaanBarang.Properties.Resources._08_EditDocument;
            this.btnEdit.Location = new System.Drawing.Point(546, 144);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(65, 40);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnEnd
            // 
            this.btnEnd.Image = global::PersediaanBarang.Properties.Resources._04_DataContainer_MoveLastHS;
            this.btnEnd.Location = new System.Drawing.Point(235, 145);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEnd.Size = new System.Drawing.Size(65, 40);
            this.btnEnd.TabIndex = 5;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PersediaanBarang.Properties.Resources._10_Save;
            this.btnSave.Location = new System.Drawing.Point(617, 144);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 40);
            this.btnSave.TabIndex = 6;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::PersediaanBarang.Properties.Resources._06_PrintArea;
            this.btnPrint.Location = new System.Drawing.Point(475, 145);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(65, 40);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Image = global::PersediaanBarang.Properties.Resources._03_DataContainer_MoveNextHS;
            this.btnNext.Location = new System.Drawing.Point(164, 145);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(65, 40);
            this.btnNext.TabIndex = 8;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = global::PersediaanBarang.Properties.Resources._05_Find;
            this.btnFind.Location = new System.Drawing.Point(404, 145);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(65, 40);
            this.btnFind.TabIndex = 9;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::PersediaanBarang.Properties.Resources._02_DataContainer_MovePreviousHS;
            this.btnBack.Location = new System.Drawing.Point(93, 145);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 40);
            this.btnBack.TabIndex = 10;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTop
            // 
            this.btnTop.Image = global::PersediaanBarang.Properties.Resources._01_DataContainer_MoveFirstHS;
            this.btnTop.Location = new System.Drawing.Point(22, 145);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(65, 40);
            this.btnTop.TabIndex = 11;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::PersediaanBarang.Properties.Resources._11_Undo;
            this.btnUndo.Location = new System.Drawing.Point(688, 146);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(65, 40);
            this.btnUndo.TabIndex = 12;
            this.btnUndo.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::PersediaanBarang.Properties.Resources._09_Delete;
            this.btnDelete.Location = new System.Drawing.Point(617, 146);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 40);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Image = global::PersediaanBarang.Properties.Resources._07_New;
            this.btnNew.Location = new System.Drawing.Point(688, 146);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(65, 40);
            this.btnNew.TabIndex = 14;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FormSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 495);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTop);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvSupplier);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.txtKota);
            this.Controls.Add(this.txtTelpon);
            this.Controls.Add(this.txtNamaSupplier);
            this.Controls.Add(this.txtKodeSupplier);
            this.Controls.Add(this.lblKota);
            this.Controls.Add(this.lblTelpon);
            this.Controls.Add(this.lblAlamat);
            this.Controls.Add(this.lblNamaSupplier);
            this.Controls.Add(this.lblkodeSupplier);
            this.Name = "FormSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSupplier";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSupplier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkodeSupplier;
        private System.Windows.Forms.Label lblNamaSupplier;
        private System.Windows.Forms.Label lblAlamat;
        private System.Windows.Forms.Label lblTelpon;
        private System.Windows.Forms.Label lblKota;
        private System.Windows.Forms.TextBox txtKodeSupplier;
        private System.Windows.Forms.TextBox txtNamaSupplier;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.DataGridView dgvSupplier;
        private System.Windows.Forms.TextBox txtTelpon;
        private System.Windows.Forms.TextBox txtKota;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamat;
        private System.Windows.Forms.DataGridViewTextBoxColumn telpon;
        private System.Windows.Forms.DataGridViewTextBoxColumn kota;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
    }
}
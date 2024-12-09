namespace PersediaanBarang
{
    partial class FormNotaJual
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtKodeBarang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNoNotaJual = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetailJual = new System.Windows.Forms.DataGridView();
            this.idItemNotaJual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noNotaJual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTgl = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailJual)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Image = global::PersediaanBarang.Properties.Resources._12_Close;
            this.btnClose.Location = new System.Drawing.Point(712, 494);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(68, 54);
            this.btnClose.TabIndex = 43;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::PersediaanBarang.Properties.Resources._08_EditDocument;
            this.btnEdit.Location = new System.Drawing.Point(473, 494);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 54);
            this.btnEdit.TabIndex = 44;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Image = global::PersediaanBarang.Properties.Resources._04_DataContainer_MoveLastHS;
            this.btnEnd.Location = new System.Drawing.Point(234, 494);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnEnd.Size = new System.Drawing.Size(68, 54);
            this.btnEnd.TabIndex = 45;
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::PersediaanBarang.Properties.Resources._10_Save;
            this.btnSave.Location = new System.Drawing.Point(547, 527);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(68, 54);
            this.btnSave.TabIndex = 46;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = global::PersediaanBarang.Properties.Resources._06_PrintArea;
            this.btnPrint.Location = new System.Drawing.Point(399, 494);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(68, 54);
            this.btnPrint.TabIndex = 47;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Image = global::PersediaanBarang.Properties.Resources._03_DataContainer_MoveNextHS;
            this.btnNext.Location = new System.Drawing.Point(160, 494);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(68, 54);
            this.btnNext.TabIndex = 48;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFind
            // 
            this.btnFind.Image = global::PersediaanBarang.Properties.Resources._05_Find;
            this.btnFind.Location = new System.Drawing.Point(325, 494);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(68, 54);
            this.btnFind.TabIndex = 49;
            this.btnFind.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Image = global::PersediaanBarang.Properties.Resources._02_DataContainer_MovePreviousHS;
            this.btnBack.Location = new System.Drawing.Point(86, 494);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 54);
            this.btnBack.TabIndex = 50;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTop
            // 
            this.btnTop.Image = global::PersediaanBarang.Properties.Resources._01_DataContainer_MoveFirstHS;
            this.btnTop.Location = new System.Drawing.Point(12, 494);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(68, 54);
            this.btnTop.TabIndex = 51;
            this.btnTop.UseVisualStyleBackColor = true;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::PersediaanBarang.Properties.Resources._11_Undo;
            this.btnUndo.Location = new System.Drawing.Point(621, 527);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(68, 54);
            this.btnUndo.TabIndex = 52;
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Image = global::PersediaanBarang.Properties.Resources._09_Delete;
            this.btnDelete.Location = new System.Drawing.Point(547, 494);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 54);
            this.btnDelete.TabIndex = 53;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnNew
            // 
            this.btnNew.Image = global::PersediaanBarang.Properties.Resources._07_New;
            this.btnNew.Location = new System.Drawing.Point(621, 494);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(68, 54);
            this.btnNew.TabIndex = 54;
            this.btnNew.UseVisualStyleBackColor = true;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(610, 453);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(170, 26);
            this.txtTotal.TabIndex = 40;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtKodeBarang
            // 
            this.txtKodeBarang.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKodeBarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKodeBarang.Location = new System.Drawing.Point(17, 58);
            this.txtKodeBarang.Name = "txtKodeBarang";
            this.txtKodeBarang.Size = new System.Drawing.Size(763, 62);
            this.txtKodeBarang.TabIndex = 36;
            this.txtKodeBarang.TextChanged += new System.EventHandler(this.txtKodeBarang_TextChanged);
            this.txtKodeBarang.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtKodeBarang_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(535, 456);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Total Rp";
            // 
            // txtNoNotaJual
            // 
            this.txtNoNotaJual.Enabled = false;
            this.txtNoNotaJual.Location = new System.Drawing.Point(133, 12);
            this.txtNoNotaJual.Name = "txtNoNotaJual";
            this.txtNoNotaJual.Size = new System.Drawing.Size(100, 26);
            this.txtNoNotaJual.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(402, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tanggal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "No Nota Jual";
            // 
            // dgvDetailJual
            // 
            this.dgvDetailJual.AllowUserToAddRows = false;
            this.dgvDetailJual.AllowUserToDeleteRows = false;
            this.dgvDetailJual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetailJual.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idItemNotaJual,
            this.noNotaJual,
            this.kodeBarang,
            this.namaBarang,
            this.qty,
            this.harga,
            this.jumlah});
            this.dgvDetailJual.Location = new System.Drawing.Point(17, 138);
            this.dgvDetailJual.Name = "dgvDetailJual";
            this.dgvDetailJual.ReadOnly = true;
            this.dgvDetailJual.RowHeadersWidth = 62;
            this.dgvDetailJual.RowTemplate.Height = 28;
            this.dgvDetailJual.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetailJual.Size = new System.Drawing.Size(763, 300);
            this.dgvDetailJual.TabIndex = 41;
            this.dgvDetailJual.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDetailJual_KeyUp);
            // 
            // idItemNotaJual
            // 
            this.idItemNotaJual.DataPropertyName = "idItemNotaJual";
            this.idItemNotaJual.HeaderText = "Id Item Nota Jual";
            this.idItemNotaJual.MinimumWidth = 8;
            this.idItemNotaJual.Name = "idItemNotaJual";
            this.idItemNotaJual.ReadOnly = true;
            this.idItemNotaJual.Visible = false;
            this.idItemNotaJual.Width = 150;
            // 
            // noNotaJual
            // 
            this.noNotaJual.DataPropertyName = "noNotaJual";
            this.noNotaJual.HeaderText = "No Nota Jual";
            this.noNotaJual.MinimumWidth = 8;
            this.noNotaJual.Name = "noNotaJual";
            this.noNotaJual.ReadOnly = true;
            this.noNotaJual.Visible = false;
            this.noNotaJual.Width = 50;
            // 
            // kodeBarang
            // 
            this.kodeBarang.DataPropertyName = "kodeBarang";
            this.kodeBarang.HeaderText = "Kode Barang";
            this.kodeBarang.MinimumWidth = 8;
            this.kodeBarang.Name = "kodeBarang";
            this.kodeBarang.ReadOnly = true;
            this.kodeBarang.Width = 50;
            // 
            // namaBarang
            // 
            this.namaBarang.DataPropertyName = "namaBarang";
            this.namaBarang.HeaderText = "Nama Barang";
            this.namaBarang.MinimumWidth = 8;
            this.namaBarang.Name = "namaBarang";
            this.namaBarang.ReadOnly = true;
            this.namaBarang.Width = 140;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.qty.DefaultCellStyle = dataGridViewCellStyle4;
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 8;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 80;
            // 
            // harga
            // 
            this.harga.DataPropertyName = "harga";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = null;
            this.harga.DefaultCellStyle = dataGridViewCellStyle5;
            this.harga.HeaderText = "Harga";
            this.harga.MinimumWidth = 8;
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            this.harga.Width = 80;
            // 
            // jumlah
            // 
            this.jumlah.DataPropertyName = "jumlah";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.Format = "N0";
            dataGridViewCellStyle6.NullValue = null;
            this.jumlah.DefaultCellStyle = dataGridViewCellStyle6;
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.MinimumWidth = 8;
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            this.jumlah.Width = 80;
            // 
            // txtTgl
            // 
            this.txtTgl.Enabled = false;
            this.txtTgl.Location = new System.Drawing.Point(484, 12);
            this.txtTgl.Name = "txtTgl";
            this.txtTgl.Size = new System.Drawing.Size(296, 26);
            this.txtTgl.TabIndex = 34;
            // 
            // FormNotaJual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 592);
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
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtKodeBarang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNoNotaJual);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDetailJual);
            this.Controls.Add(this.txtTgl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNotaJual";
            this.Text = "Form Nota Penjualan";
            this.Load += new System.EventHandler(this.FormNotaJual_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetailJual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtKodeBarang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNoNotaJual;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDetailJual;
        private System.Windows.Forms.TextBox txtTgl;
        private System.Windows.Forms.DataGridViewTextBoxColumn idItemNotaJual;
        private System.Windows.Forms.DataGridViewTextBoxColumn noNotaJual;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
    }
}
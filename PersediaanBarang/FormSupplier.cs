using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersediaanBarang
{
    public partial class FormSupplier : Form
    {
        public FormSupplier()
        {
            InitializeComponent();
            dgvSupplier.DataSource = supplier.getBS();
            saveMode();
        }
        Tabel supplier = new Tabel("supplier");
        private bool baru;
        private string kodeLama;

        private void ikatTextBox()
        {
            txtKodeSupplier.DataBindings.Add("Text", supplier.getBS(), "kodeSupplier");
            txtNamaSupplier.DataBindings.Add("Text", supplier.getBS(), "namaSupplier");
            txtAlamat.DataBindings.Add("Text", supplier.getBS(), "alamat");
            txtTelpon.DataBindings.Add("Text", supplier.getBS(), "telpon");
            txtKota.DataBindings.Add("Text", supplier.getBS(), "kota");
        }
        private void lepasTextBox()
        {
            txtKodeSupplier.DataBindings.Clear();
            txtNamaSupplier.DataBindings.Clear();
            txtAlamat.DataBindings.Clear();
            txtTelpon.DataBindings.Clear();
            txtKota.DataBindings.Clear();
        }

        private void saveMode()
        {
            dgvSupplier.Enabled = true;
            //textbox
            txtKodeSupplier.Enabled = false;
            txtNamaSupplier.Enabled = false;
            txtAlamat.Enabled = false;
            txtTelpon.Enabled = false;
            txtKota.Enabled = false;

            //navigasi
            btnTop.Enabled = true;
            btnBack.Enabled = true;
            btnEnd.Enabled = true;
            btnNext.Enabled = true;

            //controller
            btnFind.Enabled = true;
            btnPrint.Enabled = true;
            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            btnNew.Enabled = true;

            //save dan undo
            btnSave.Visible = false;
            btnUndo.Visible = false;

            //close
            btnClose.Enabled = true;
            ikatTextBox();
        }
        private void editMode()
        {
            dgvSupplier.Enabled = false;
            //textbox
            txtKodeSupplier.Enabled = true;
            txtNamaSupplier.Enabled = true;
            txtAlamat.Enabled = true;
            txtTelpon.Enabled = true;
            txtKota.Enabled = true;

            //navigasi
            btnTop.Enabled = false;
            btnBack.Enabled = false;
            btnEnd.Enabled = false;
            btnNext.Enabled = false;

            //controller
            btnFind.Enabled = false;
            btnPrint.Enabled = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            btnNew.Enabled = false;

            //save dan undo
            btnSave.Visible = true;
            btnUndo.Visible = true;

            //close
            btnClose.Enabled = false;
            lepasTextBox();
        }
        private void btnSave_Click_1(object sender, EventArgs e)
        {
            string stringSQL, kodeSupplier, namaSupplier, alamat, telpon, kota;
            kodeSupplier = txtKodeSupplier.Text;
            namaSupplier = txtNamaSupplier.Text;
            alamat = txtAlamat.Text;
            telpon = txtTelpon.Text;
            kota = txtKota.Text;
            if (baru)
            {
                stringSQL = "INSERT INTO supplier VALUES('{0}','{1}','{2}','{3}','{4}')";
                stringSQL = String.Format(stringSQL, kodeSupplier, namaSupplier, alamat, telpon, kota);
            }
            else
            {
                stringSQL = "UPDATE supplier SET kodeSupplier='{0}', namaSupplier='{1}', alamat='{2}', telpon='{3}', kota='{4}'";
                stringSQL += " WHERE kodeSupplier='{5}'";
                stringSQL = String.Format(stringSQL, kodeSupplier, namaSupplier, alamat, telpon, kota, this.kodeLama);
            }
            this.supplier.eksekusiSQL(stringSQL);
            saveMode();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.DialogResult jawab;
            jawab = MessageBox.Show("yakin ingin menghapus data ini?", "konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(jawab==System.Windows.Forms.DialogResult.Yes)
            {
                string stringSQL = "DELETE FROM supplier WHERE kodeSupplier='{0}'";
                stringSQL = string.Format(stringSQL, txtKodeSupplier.Text);
                MessageBox.Show("mohon dicek dahulu : " + stringSQL);
                this.supplier.eksekusiSQL(stringSQL);
                MessageBox.Show("penghapusan berhasil");
            }
            else
            {
                MessageBox.Show("penghapusan gagal");
            }

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            editMode();
            baru = true;
            txtKodeSupplier.Clear();
            txtNamaSupplier.Clear();
            txtAlamat.Clear();
            txtTelpon.Clear();
            txtKota.Clear();

            //tambah focus
            txtKodeSupplier.Focus();
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            this.supplier.getBS().MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.supplier.getBS().MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.supplier.getBS().MoveNext();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.supplier.getBS().MoveLast();
        }

        
    }
}

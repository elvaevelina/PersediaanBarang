using MySql.Data.MySqlClient;
using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

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
            if (string.IsNullOrWhiteSpace(txtKodeSupplier.Text))
            {
                MessageBox.Show("Kode Supplier tidak boleh kosong");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNamaSupplier.Text))
            {
                MessageBox.Show("Nama Supplier tidak boleh kosong");
                return;
            }
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
                //MessageBox.Show("Menambahkan data supplier = " + stringSQL);

            }
            else
            {
                stringSQL = "UPDATE supplier SET kodeSupplier='{0}', namaSupplier='{1}', alamat='{2}', telpon='{3}', kota='{4}'";
                stringSQL += " WHERE kodeSupplier='{5}'";
                stringSQL = String.Format(stringSQL, kodeSupplier, namaSupplier, alamat, telpon, kota, this.kodeLama);
                //MessageBox.Show("Supplier akan diupdate = " + stringSQL);
            }
            
            try
            {
                this.supplier.eksekusiSQL(stringSQL);
                if (baru)
                {
                    MessageBox.Show("penambahan berhasil, silahkan periksa tabel supplier");
                }
                else
                {
                    MessageBox.Show("pengubahan berhasil, silahkan periksa tabel supplier");
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Substring(0, 15) == "Duplicate entry")
                {
                    MessageBox.Show("Kode Supplier = " + kodeSupplier + " sudah digunakan\n" +
                        "Silahkan menggunakan kode yang lain");
                }
                else
                    MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message);
                txtKodeSupplier.Focus();
                return;
            }
            finally
            {
                txtKodeSupplier.Clear();
                txtKodeSupplier.Focus();
            }
            saveMode();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.DialogResult jawab;
            //jawab = MessageBox.Show("yakin ingin menghapus data ini?", "konfirmasi",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            //if(jawab==System.Windows.Forms.DialogResult.Yes)
            //{
            //    string stringSQL = "DELETE FROM supplier WHERE kodeSupplier='{0}'";
            //    stringSQL = string.Format(stringSQL, txtKodeSupplier.Text);
            //    MessageBox.Show("mohon dicek dahulu : " + stringSQL);
            //    this.supplier.eksekusiSQL(stringSQL);
            //    MessageBox.Show("penghapusan berhasil");
            //}
            //else
            //{
            //    MessageBox.Show("penghapusan gagal");
            //}
            DialogResult jawaban = MessageBox.Show("Apakah anda yakin menghapus?", "Konfirmasi menghapus",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawaban == DialogResult.Yes)
            {
                string strSQL = $"DELETE FROM supplier WHERE kodeSupplier='{txtKodeSupplier.Text.Trim()}'";
                try
                {
                    this.supplier.eksekusiSQL(strSQL);
                    MessageBox.Show("penghapusan berhasil");

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Cannot delete"))
                    {
                        MessageBox.Show("Kode Supplier = " + txtKodeSupplier.Text.Trim() + "sedang digunakan\n" +
                            "Kode ini tidak boleh dihapus");
                    }
                    else
                        MessageBox.Show(ex.Message);
                    return;
                }
                finally
                {
                    txtKodeSupplier.Clear();
                    txtNamaSupplier.Clear();
                    txtAlamat.Clear();
                    txtTelpon.Clear();
                    txtKota.Clear();
                  
                }
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTelpon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            saveMode();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FormCariSupplier fcs = new FormCariSupplier();
            fcs.ShowDialog();
            //MessageBox.Show("Kodenya = " + frm.kodeCari);
            int baris = supplier.getBS().Find("kodeSupplier", fcs.ks);
            supplier.getBS().Position = baris;
            fcs.Dispose();


        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editMode();
            baru = false;
            txtKodeSupplier.Focus();
            kodeLama = txtKodeSupplier.Text;
        }
    }
}

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
    public partial class FormNotaBeli : Form
    {
        public FormNotaBeli()
        {
            InitializeComponent();
            ikat();
            dgvDetailBeli.DataSource = detailBeli.getBS();
            CalculateTotal();
        }
        Tabel masterBeli = new Tabel("viewMasterBeli");
        Tabel detailBeli = new Tabel("view_detailBeli");
        Tabel barang = new Tabel("barang");

        void modeOutput()
        {
            dgvDetailBeli.Height = 172;
            dgvDetailBeli.Top = 120;
            txtTgl.Enabled = false;
            txtKodeSupplier.Enabled = false;
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
        }
        void modeInput()
        {
            txtTgl.Enabled = true;
            txtKodeSupplier.Enabled = true;
            dgvDetailBeli.Height = 115;
            dgvDetailBeli.Top = 172;
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
            txtKodeBarang.Focus();
            txtKodeSupplier.Focus();
           
        }

        void ikat()
        {
            txtKodeSupplier.DataBindings.Add("Text", masterBeli.getBS(), "kodeSupplier");
            txtNoNotaBeli.DataBindings.Add("Text", masterBeli.getBS(), "noNotaBeli");
            txtTgl.DataBindings.Add("Text", masterBeli.getBS(), "tgl");
            txtNamaSupplier.DataBindings.Add("Text", masterBeli.getBS(), "namaSupplier");
            txtAlamat.DataBindings.Add("Text", masterBeli.getBS(), "alamat");
            txtTelpon.DataBindings.Add("Text", masterBeli.getBS(), "telpon");
            txtKota.DataBindings.Add("Text", masterBeli.getBS(), "kota");
        }

        void tampil() //error karena ada data kosong(?)
        {
            // Mengecek apakah txtNoNotaBeli kosong
            if (string.IsNullOrEmpty(txtNoNotaBeli.Text))
            {
                // Jika kosong, hapus filter
                detailBeli.getBS().Filter = string.Empty;
            }
            else
            {
                // Jika tidak kosong, terapkan filter
                detailBeli.getBS().Filter = "noNotaBeli=" + txtNoNotaBeli.Text;
            }
        }

        private void CalculateTotal()
        {
            decimal total = 0;

            foreach (DataGridViewRow row in dgvDetailBeli.Rows)
            {
                if (row.Cells["Jumlah"].Value != null)
                {
                    decimal jumlah;
                    if (decimal.TryParse(row.Cells["Jumlah"].Value.ToString(), out jumlah))
                    {
                        total += jumlah;
                    }
                }
            }
            txtTotal.Text = total.ToString("N0");
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            masterBeli.getBS().MoveFirst();
            tampil() ;
            CalculateTotal();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            masterBeli.getBS().MovePrevious();
            tampil();
            CalculateTotal();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            masterBeli.getBS().MoveNext();
            tampil();
            CalculateTotal();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            masterBeli.getBS().MoveLast();
            tampil();
            CalculateTotal();
        }

        private void FormNotaBeli_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeInput();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            modeOutput();
            //dgvDetailBeli.AutoSizeColumnsMode = DataGridViewAutoSizeColumnMode.None();
        }

        private void txtKodeBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if(txtKodeBarang.Text.Length == 5)
            {
               //MessageBox.Show("cek ada barang atau tidak");
               int nobrs = barang.getBS().Find("kodeBarang", txtKodeBarang.Text);
                if(nobrs == -1)
                {
                    //MessageBox.Show("kode barang tidak ada");
                    FormCariBarang fcb = new FormCariBarang();
                    fcb.ShowDialog();
                    txtKodeBarang.Text = fcb.kodeCari;
                }
                else
                {
                    //MessageBox.Show("ada kode barang");
                    barang.getBS().Position = nobrs; //<-- menuju kode baris
                    txtNamaBarang.Text = ((DataRowView)barang.getBS().Current).Row["namaBarang"].ToString();
                    txtHarga.Text = ((DataRowView)barang.getBS().Current).Row["hargaBeli"].ToString();
                    txtQty.Focus();


                }
            }
        }


        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (decimal.TryParse(txtQty.Text, out decimal qtyValue))
                {
                    if (qtyValue < 0)
                    {
                        txtQty.Text = "0";
                    }
                }

                txtHarga.Focus();
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar)&&e.KeyChar!=8)
            {
                e.Handled = true;
            }
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }



        private void txtHarga_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string noNotaBeli, kodeBarang, qty, harga, strSql;
                noNotaBeli = txtNoNotaBeli.Text;
                kodeBarang = txtKodeBarang.Text;
                qty = txtQty.Text;
                harga = txtHarga.Text;
                strSql = "INSERT INTO itemNotaBeli(noNotaBeli, kodeBarang, qty, harga)" +
                    $"VALUES('{noNotaBeli}','{kodeBarang}','{qty}','{harga}')";
                detailBeli.eksekusiSQL(strSql);
                txtKodeBarang.Clear();
                txtNamaBarang.Clear();
                txtQty.Clear();
                txtHarga.Clear();
                txtKodeBarang.Focus();
            }

        }

        private void dgvDetailBeli_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Back && btnSave.Visible)
            {
                txtKodeBarang.Text = dgvDetailBeli.CurrentRow.Cells["kodeBarang"].Value.ToString();
                txtNamaBarang.Text = dgvDetailBeli.CurrentRow.Cells["namaBarang"].Value.ToString();
                txtQty.Text = dgvDetailBeli.CurrentRow.Cells["qty"].Value.ToString();
                txtHarga.Text = dgvDetailBeli.CurrentRow.Cells["harga"].Value.ToString();
                txtQty.Focus();
                txtNamaBarang.Enabled = false;
            }

            if ((e.KeyCode == Keys.Delete || e.KeyCode==Keys.Back) && btnSave.Visible )
            {
                DialogResult jwb=DialogResult.Yes;
                if (e.KeyCode == Keys.Delete)
                {
                     jwb = MessageBox.Show("anda yakin menghapus baris ini?",
                        "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                if (jwb == DialogResult.Yes)
                {
                    string idHapus = dgvDetailBeli.CurrentRow.Cells[0].Value.ToString();
                    string strSql = $"DELETE FROM itemNotaBeli WHERE idItemNotaBeli = '{idHapus}'";
                    detailBeli.eksekusiSQL(strSql);
                }
                else
                {
                    MessageBox.Show("Penghapusan dibatalkan");
                }
            }
        }

        Tabel supplier = new Tabel("supplier");
        private void txtKodeSupplier_KeyUp(object sender, KeyEventArgs e)
        {
            if(txtKodeSupplier.Text.Length == 3)
            {
                string noSkrg = txtNoNotaBeli.Text;
                int nobrs = supplier.getBS().Find("kodeSupplier",txtKodeSupplier.Text);
                if (nobrs == -1)
                {
                    //MessageBox.Show("Kode = " +txtKodeSupplier.Text + " tidak ada");
                    //txtKodeSupplier.Clear();
                    //txtKodeSupplier.Focus();
                    FormCariSupplier fcs = new FormCariSupplier();
                    fcs.ShowDialog();
                    txtKodeSupplier.Text = fcs.ks;

                }
                else
                {
                    string strSql = $"UPDATE notaBeli SET kodeSupplier='{txtKodeSupplier.Text}'" +
                        $"WHERE noNotaBeli = '{txtNoNotaBeli.Text}'";
                    masterBeli.eksekusiSQL(strSql);
                    masterBeli.getBS().Position = masterBeli.getBS().Find("noNotaBeli", noSkrg);
                    txtKodeBarang.Focus();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string tglSekarang = DateTime.Now.ToString("yyyy-MM-dd");
            string strSql = $"INSERT INTO notaBeli(tgl) VALUES('{tglSekarang}')";
            long noNotanya = masterBeli.eksekusiSQL_getId(strSql);
            masterBeli.getBS().Position = masterBeli.getBS().Find("noNotaBeli", noNotanya);
            tampil();
            modeInput();
            txtKodeSupplier.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult jwb = MessageBox.Show("yakin menghapus nota ini?", 
                "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jwb == DialogResult.Yes)
            {
                string strSql = $"DELETE FROM notaBeli WHERE noNotaBeli='{txtNoNotaBeli.Text}'";
                masterBeli.eksekusiSQL(strSql);
                masterBeli.getBS().MoveLast();  
                MessageBox.Show("pengahpusan berhasil");
            }
            else
            {
                MessageBox.Show("penghapusan dibatalkan");
            }
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
    }
}

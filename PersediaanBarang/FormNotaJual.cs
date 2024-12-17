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
    public partial class FormNotaJual : Form
    {
        public FormNotaJual()
        {
            InitializeComponent();
            dgvDetailJual.DataSource = detail.getBS(); //nampilin ke dgv
            modeOutput();
        }
        Tabel master = new Tabel("notaJual");
        Tabel detail = new Tabel("view_itemjual");

        void modeOutput()
        {
            txtKodeBarang.Enabled = false;
            txtTgl.Enabled = false;
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
            txtKodeBarang.Enabled = true;
            txtTgl.Enabled = true;

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

        }

        void ikat()
        {
            txtNoNotaJual.DataBindings.Add("Text", master.getBS(), "noNotaJual");
            txtTgl.DataBindings.Add("Text", master.getBS(), "tgl");
        }

        private void FormNotaJual_Load(object sender, EventArgs e)
        {
            ikat();
            tampil();
            dgvDetailJual.DataSource = detail.getBS();

        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            master.getBS().MoveFirst();
            tampil();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            master.getBS().MovePrevious();
            tampil();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            master.getBS().MoveNext();
            tampil();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            master.getBS().MoveLast();
            tampil();
        }

        void tampil() //error karena ada data kosong(?) || filter buat masing masing nota
        {
            // Mengecek apakah txtNoNotaBeli kosong
            if (string.IsNullOrEmpty(txtNoNotaJual.Text))
            {
                // Jika kosong, hapus filter
                detail.getBS().Filter = string.Empty;
            }
            else
            {
                // Jika tidak kosong, terapkan filter
                detail.getBS().Filter = "noNotaJual=" + txtNoNotaJual.Text;
            }
            decimal total = 0;

            foreach (DataGridViewRow row in dgvDetailJual.Rows)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            modeInput();
        }

        Tabel barang = new Tabel("barang");
        private void txtKodeBarang_TextChanged(object sender, EventArgs e)
        {
            if (txtKodeBarang.Text.Length == 5)
            {
                //MessageBox.Show("cek ada barang atau tidak");
                int nobrs = barang.getBS().Find("kodeBarang", txtKodeBarang.Text);
                if (nobrs == -1)
                {
                    //MessageBox.Show("kode barang tidak ada");
                    FormCariBarang fcb = new FormCariBarang();
                    fcb.ShowDialog();
                    txtKodeBarang.Text = fcb.kodeCari;
                    fcb.Dispose();
                }
                else
                {
                    //MessageBox.Show("ada kode barang");
                    string noNotaJual, kodeBarang, qty, harga;
                    noNotaJual = txtNoNotaJual.Text;
                    kodeBarang = txtKodeBarang.Text;
                    qty = "1";
                    barang.getBS().Position = nobrs;
                    harga = ((DataRowView)barang.getBS().Current).Row["hargaJual"].ToString();
                    string strSql = "INSERT INTO itemNotaJual(noNotaJual, kodeBarang, qty, harga)" +
                        $"VALUES('{noNotaJual}','{kodeBarang}','{qty}','{harga}')";
                    detail.eksekusiSQL(strSql);
                    txtKodeBarang.Clear();
                    txtKodeBarang.Focus();
                    //barang.getBS().Position = nobrs; //<-- menuju kode baris
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            modeOutput();
        }

        private void txtKodeBarang_KeyUp(object sender, KeyEventArgs e) //PERBAIKIII!!!
        {
            if (e.KeyCode == Keys.Enter && txtKodeBarang.Text.Length > 0)
            {
                string idnya = ((DataRowView)detail.getBS().Current).Row["idItemNotaJual"].ToString();
                // MessageBox.Show(idnya);

                if (txtKodeBarang.Text.Substring(0, 1) == "+")
                {
                    int tambah = int.Parse(txtKodeBarang.Text.Substring(1));

                    // Tambahan kode mulai
                    int stokTersedia = int.Parse(((DataRowView)barang.getBS().Current).Row["stok"].ToString());
                    if (tambah > stokTersedia)
                    {
                        MessageBox.Show($"Stok tidak mencukupi. Hanya {stokTersedia} yang dapat dijual. Qty akan diubah menjadi 0",
                            "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        string strSql = $"UPDATE itemNotaJual SET qty = 0 WHERE idItemNotaJual = '{idnya}'";
                        detail.eksekusiSQL(strSql);
                        txtKodeBarang.Clear();
                        txtKodeBarang.Focus();
                        return;
                    }
                    // Tambahan kode selesai

                    string strSqlTambah = $"UPDATE itemNotaJual SET qty = qty+{tambah} WHERE idItemNotaJual = '{idnya}'";
                    detail.eksekusiSQL(strSqlTambah);
                    txtKodeBarang.Clear();
                    txtKodeBarang.Focus();
                }
                else if (txtKodeBarang.Text.Substring(0, 1) == "-")
                {
                    int kurang = int.Parse(txtKodeBarang.Text.Substring(1));
                    string strSqlKurang = $"UPDATE itemNotaJual SET qty = qty-{kurang} WHERE idItemNotaJual = '{idnya}'";
                    detail.eksekusiSQL(strSqlKurang);
                    txtKodeBarang.Clear();
                    txtKodeBarang.Focus();
                }
            }
        }

        private void dgvDetailJual_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && btnSave.Visible)
            {
                DialogResult jwb = MessageBox.Show("yakin menghapus item penjualan ini?", "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (jwb == DialogResult.Yes)
                {
                    string idnya = dgvDetailJual.CurrentRow.Cells[0].Value.ToString(); // ngambil id
                    string strSql = $"DELETE FROM itemNotaJual WHERE idItemNotaJual = '{idnya}'";
                    detail.eksekusiSQL(strSql);
                    txtKodeBarang.Clear();
                }


            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            string tglSekarang = DateTime.Now.ToString("yyyy-MM-dd");
            string strSql = $"INSERT INTO notaJual(tgl) VALUES('{tglSekarang}')";
            long noNotanya = master.eksekusiSQL_getId(strSql);
            master.getBS().Position = master.getBS().Find("noNotaJual", noNotanya);
            tampil();
            modeInput();
            txtKodeBarang.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult jwb = MessageBox.Show("yakin menghapus nota ini?",
                "konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jwb == DialogResult.Yes)
            {
                string strSql = $"DELETE FROM notaJual WHERE noNotaJual='{txtNoNotaJual.Text}'";
                master.eksekusiSQL(strSql);
                master.getBS().MoveLast();
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
    }
}

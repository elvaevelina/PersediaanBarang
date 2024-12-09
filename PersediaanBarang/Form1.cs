using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace PersediaanBarang
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveMode(); // <-- sdh memanggil ikat
            sambungDataBase();
            isiDataTable(); //<-- DataTable diisi
            dgvBarang.DataSource = this.bs; // <-- ganti sumber datanya menjadi BindingSource 
            //tampilTextBoxManual(5); //<-- tampilkan baris ke 5
            //ikatTextBox(); //<-- semua textbox diikatkan ke binding source
        }
        private DataTable dt = new DataTable(); //  <-- struktur data bentuk tabel 
        private BindingSource bs = new BindingSource(); // <-- objek binding source

        private void ikatTextBox()
        {
            txtKode.DataBindings.Add("Text", this.bs, "kodeBarang");
            txtNamaBarang.DataBindings.Add("Text", this.bs, "namaBarang"); 
            txtHargaBeli.DataBindings.Add("Text", this.bs, "hargaBeli");
            txtHargaJual.DataBindings.Add("Text", this.bs, "hargaJual");
            txtStok.DataBindings.Add("Text", this.bs, "stok");
            txtSatuan.DataBindings.Add("Text", this.bs, "satuan");
        }
        private void lepasTextBox()
        {
            txtKode.DataBindings.Clear();
            txtNamaBarang.DataBindings.Clear();
            txtHargaBeli.DataBindings.Clear();
            txtHargaJual.DataBindings.Clear();
            txtStok.DataBindings.Clear();
            txtSatuan.DataBindings.Clear();
        }

        private void tampilTextBoxManual(int baris)
        {
            txtKode.Text = this.dt.Rows[baris]["KodeBarang"].ToString();
            txtNamaBarang.Text = this.dt.Rows[baris]["NamaBarang"].ToString();
            txtHargaBeli.Text = this.dt.Rows[baris]["HargaBeli"].ToString();
            txtHargaJual.Text = this.dt.Rows[baris]["HargaJual"].ToString();
            txtStok.Text = this.dt.Rows[baris]["stok"].ToString();
            txtSatuan.Text = this.dt.Rows[baris]["satuan"].ToString();

        }
        private void isiDataTable()
        {
            this.sambungan.Open();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM barang", this.sambungan);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            this.dt.Clear();
            da.Fill(this.dt);
            this.bs.DataSource = this.dt; //<-- sambungkan binding source ke datatable
            this.sambungan.Close();
        }
        private void sambungDataBase()
        {
            string parameterKoneksi = "server=localhost;user id=root;password='';database=inv";
            this.sambungan = new MySqlConnection(parameterKoneksi);
        }
        private Boolean baru = false;
        private String kodeLama = null;
        private MySqlConnection sambungan;

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void saveMode()
        {
            dgvBarang.Enabled = true;
            //textbox
            txtKode.Enabled = false;
            txtNamaBarang.Enabled = false;
            txtHargaBeli.Enabled = false; 
            txtHargaJual.Enabled = false;  
            txtSatuan.Enabled = false;

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
            dgvBarang.Enabled = false;
            //textbox
            txtKode.Enabled = true;
            txtNamaBarang.Enabled = true;
            txtHargaBeli.Enabled = true;
            txtHargaJual.Enabled = true;
            txtSatuan.Enabled = true;

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            editMode();
            baru = false;
            kodeLama = txtKode.Text;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            editMode();
            baru = true;
            txtKode.Clear();
            txtNamaBarang.Clear();
            txtHargaBeli.Text = "0";
            txtHargaJual.Text = "0";
            txtSatuan.Text="pcs";
            txtStok.Text = "0";

            //tambah focus
            txtKode.Focus();

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            saveMode();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string kode, nama, hargaBeli, hargaJual, satuan, querySQL;
            kode=txtKode.Text.Trim();
            nama=txtNamaBarang.Text.Trim();
            hargaBeli=txtHargaBeli.Text.Trim();
            hargaJual=txtHargaJual.Text.Trim();
            satuan=txtSatuan.Text.Trim();

            if (baru == true)
            {
                //insert query data baru
                querySQL = "INSERT INTO barang(kodeBarang, namaBarang, hargaBeli, hargaJual, satuan) " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')";
                querySQL = string.Format(querySQL, kode, nama, hargaBeli, hargaJual, satuan);
            }
            else
            {
                // update data barang lama
                querySQL = "UPDATE barang SET kodeBarang='{0}', namaBarang='{1}', hargaBeli='{2}', hargaJual='{3}', satuan='{4}'"+
                    "WHERE kodeBarang = '{5}'";
                querySQL=string.Format(querySQL, kode,nama, hargaBeli,hargaJual, satuan, kodeLama);
            }
            MessageBox.Show("query berikut akan di eksekusi " + querySQL);
            try
            {
                this.sambungan.Open();
                MySqlCommand cmd = new MySqlCommand(querySQL, this.sambungan);
                cmd.ExecuteNonQuery();
                if (baru)
                {
                    MessageBox.Show("penambahan berhasil, silahkan periksa tabel barang");
                }
                else
                {
                    MessageBox.Show("pengubahan berhasil, silahkan periksa tabel barang");
                }
            }
            catch(Exception ex) 
            {
                if(ex.Message.Substring(0,15) == "Duplicate entry")
                {
                    MessageBox.Show("Kode Barang = " + kode + "sudah digunakan\n" +
                        "Silahkan menggunakan kode yang lain");
                }
                else 
                    MessageBox.Show(ex.Message);
                MessageBox.Show(ex.Message);
                txtKode.Focus();
                return;
            }
            finally
            {
                this.sambungan.Close();
                this.isiDataTable();
            }
            saveMode();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //string kode, querySQL;
            //kode = txtKode.Text.Trim();
            //querySQL = "DELETE barang WHERE kodeBarang = '{0}'";
            //querySQL = string.Format(querySQL, kode);
            DialogResult jawaban = MessageBox.Show("Apakah anda yakin nmenghapus?", "Konfirmasi menghapus", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (jawaban == DialogResult.Yes)
            {
                string strSQL = $"DELETE FROM barang WHERE kodeBarang='{txtKode.Text.Trim()}'";
                try
                {
                    this.sambungan.Open();
                    MySqlCommand cmd = new MySqlCommand(strSQL, this.sambungan);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("penghapusan berhasil");

                }
                catch (Exception ex)
                {
                    if (ex.Message.Contains("Cannot delete"))
                    {
                        MessageBox.Show("Kode Barang = " + txtKode.Text.Trim() + "sudah digunakan\n" +
                            "Silahkan menggunakan kode yang lain");
                    }
                    else
                        MessageBox.Show(ex.Message);
                    return;
                }
                finally
                {
                    this.sambungan.Close();
                    this.isiDataTable();
                }
                //strSQL = string.Format(strSQL,txtKode.Text.Trim());
                Console.WriteLine(strSQL);
            }
            else
            {
                MessageBox.Show("penghapusan gagal");
            }
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            this.bs.MoveFirst();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.bs.MovePrevious();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.bs.MoveNext();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.bs.MoveLast();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            FormCariBarang frm = new FormCariBarang();
            frm.ShowDialog();
            //MessageBox.Show("kode = " + frm.kodeCari);
            int baris = bs.Find("kodeBarang", frm.kodeCari);
            bs.Position = baris;
            frm.Dispose();
        }
    }
}

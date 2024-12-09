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
    public partial class FormMenuUtama : Form
    {
        public FormMenuUtama(string username)
        {
            InitializeComponent();
            Tabel pemakai = new Tabel("pemakai");
            pemakai.getBS().Position = pemakai.getBS().Find("user_name", username);
            bool sb, ss, beli, jual;
            sb = bool.Parse(((DataRowView)pemakai.getBS().Current).Row["barang"].ToString());
            ss = bool.Parse(((DataRowView)pemakai.getBS().Current).Row["supplier"].ToString());
            beli = bool.Parse(((DataRowView)pemakai.getBS().Current).Row["beli"].ToString());
            jual = bool.Parse(((DataRowView)pemakai.getBS().Current).Row["jual"].ToString());

            setupDataBarang.Enabled= sb;
            setupDatasSupplier.Enabled= ss;
            pembelian.Enabled= beli;
            penjualan.Enabled= jual; 
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void setupDataBarangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 fb =  new Form1();
            fb.ShowDialog();
            fb.Dispose();
        }

        private void setupDataSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSupplier fs = new FormSupplier();
            fs.ShowDialog();
            fs.Dispose();
        }

        private void pembelianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNotaBeli fnb = new FormNotaBeli();
            fnb.ShowDialog();
            fnb.Dispose();
        }

        private void penjualanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("maaf belum dibuat");
        }
    }
}

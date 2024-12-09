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

namespace PersediaanBarang
{
    public partial class FormCariBarang : Form
    {
        public FormCariBarang()
        {
            InitializeComponent();
            isiDataTable();
            dgvBarang.DataSource = bs;

        }

        DataTable dt = new DataTable();
        BindingSource bs = new BindingSource();
        public string kodeCari;
      
        void isiDataTable()
        {
            string strCon = "server=127.0.0.1;user id=root;password='';database=inv";
            MySqlConnection conn = new MySqlConnection(strCon);
            MySqlCommand cmd = new MySqlCommand("SELECT kodeBarang, namaBarang, stok, satuan FROM barang", conn);
            try
            {
                conn.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(dt);
                bs.DataSource = dt;
            }
            catch (Exception ex)  
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            bs.Filter = "namaBarang LIKE '%" + txtCari.Text + "%'";
        }

        private void dgvBarang_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                kodeCari = dgvBarang.CurrentRow.Cells["kodeBarang"].Value.ToString();
                //MessageBox.Show(kodeCari);
                Close();
            }
        }
    }
}

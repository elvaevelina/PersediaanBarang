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
    public partial class FormCariSupplier : Form
    {
        public FormCariSupplier()
        {
            InitializeComponent();
            dgvSupplier.DataSource = supplier.getBS();

        }
        Tabel supplier = new Tabel("supplier");
        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            supplier.getBS().Filter = $"namaSupplier LIKE '%{txtCari.Text}%'";          
        }

        public string ks;
        private void dgvSupplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ks = dgvSupplier.CurrentRow.Cells["kodeSupplier"].Value.ToString();
                Close();
            }
        }
    }
}

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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private int loginAttempts = 0;
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Tabel pemakai = new Tabel("pemakai");
            string username, password;
            username = txtUserName.Text;
            password = txtPassword.Text;

            if (pemakai.login(username, password))
            {
                MessageBox.Show("Silahkan masuk");
                FormMenuUtama fmu = new FormMenuUtama(username);
                fmu.ShowDialog();
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();

                loginAttempts = 0; // Reset percobaan login jika berhasil.
            }
            else
            {
                loginAttempts++; // Tambah percobaan login yang gagal.
                MessageBox.Show("Access denied");

                if (loginAttempts >= 3) // Periksa apakah sudah 3 kali gagal login.
                {
                    MessageBox.Show("Anda telah gagal login 3 kali. Program akan keluar.");
                    Application.Exit(); // Keluar dari program.
                }
            }



        }
    }
}

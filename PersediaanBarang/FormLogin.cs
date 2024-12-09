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
                MessageBox.Show("silahkan masuk");
                FormMenuUtama fmu = new FormMenuUtama(username);
                fmu.ShowDialog();
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
            else
            {
                MessageBox.Show("access denied");
            }



        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersediaanBarang
{
    internal class Tabel
    {
        string namaTabel;
        DataTable dt;
        BindingSource bs;
        MySqlConnection conn;


        public Tabel(string namaTabel) //
        {
            this.namaTabel = namaTabel;
            this.dt = new DataTable();
            this.bs = new BindingSource();
            string conStr = "server=localhost;user id=root;password='';database=inv";
            this.conn = new MySqlConnection(conStr);
            isiDataTable();
        }
        public BindingSource getBS()
        {
            return bs; 
        }
        void isiDataTable()
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + this.namaTabel,conn);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                dt.Clear();
                da.Fill(this.dt);
                bs.DataSource = dt;
                cmd.Dispose();
                da.Dispose();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        public void eksekusiSQL(String stringSQL)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(stringSQL,conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            this.isiDataTable();
        }
        public long eksekusiSQL_getId(String stringSQL)
        {
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(stringSQL, conn);
            cmd.ExecuteNonQuery();
            long noBaru = cmd.LastInsertedId;
            conn.Close();
            this.isiDataTable();
            return noBaru;
        }
        public bool login(String username, String password)
        {
            string strSql = $"SELECT COUNT(*) FROM {namaTabel} WHERE " +
                $"user_name = '{username}' AND password=PASSWORD('{password}')";
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(strSql,conn);
            bool valid = cmd.ExecuteScalar().ToString() == "1";
            return valid;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class Logare : Form
    {
        public Logare()
        {
            InitializeComponent();
        }

        private void creeazaBtn_Click(object sender, EventArgs e)
        {
            CreeazaCont frms = new CreeazaCont();
            frms.Show();
            this.Hide();
        }

        private void logareBtn_Click(object sender, EventArgs e)
        {
            try { 
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM dbo.Utilizatori WHERE Email ='" + emailTxt.Text + "' AND Parola ='" + parolaTxt.Text + "'", utile.sqlCon);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                string nickname = dt.Rows[0].ItemArray[3].ToString();
                utile.sqlCon.Close();
                AlegeJoc frmS = new AlegeJoc(nickname);
                frmS.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Date de autentificare invalide!,");
                emailTxt.Clear();
                parolaTxt.Clear();
            }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            utile.sqlCon.Close();
        }

        private void Logare_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Logare_Load(object sender, EventArgs e)
        {

        }
    }
}

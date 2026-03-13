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
    public partial class CreeazaCont : Form
    {
        public CreeazaCont()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Minigames frms = new Minigames();
            frms.Show();
            this.Hide();

        }

        private void creeazaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (parolaTxt.Text == confirmTxt.Text)
                {
                    utile.sqlCon.Open();
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * from dbo.Utilizatori WHERE Email ='" + emailTxt.Text + "'", utile.sqlCon);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Utilizatorul exista deja");
                    }
                    else
                    {
                        SqlDataAdapter da1 = new SqlDataAdapter("SELECT * from dbo.Utilizatori WHERE Nickname ='" + nicknameTxt.Text + "'", utile.sqlCon);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);
                        if (dt1.Rows.Count > 0)
                        {
                            MessageBox.Show("Nickname-ul este deja folosit");
                        }
                        else
                        {           
                            string sql = "INSERT INTO dbo.Utilizatori (Email,Nume,Prenume, Nickname, Parola) VALUES (@email,@nume,@prenume, @nickname, @parola)";
                            SqlCommand cmd = new SqlCommand(sql, utile.sqlCon);
                            cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = emailTxt.Text;
                            cmd.Parameters.Add("@nume", SqlDbType.NVarChar).Value = numeTxt.Text;
                            cmd.Parameters.Add("@parola", SqlDbType.NVarChar).Value = parolaTxt.Text;
                            cmd.Parameters.Add("@prenume", SqlDbType.NVarChar).Value = prenumeTxt.Text;
                            cmd.Parameters.Add("@nickname", SqlDbType.NVarChar).Value = nicknameTxt.Text;
                            cmd.ExecuteNonQuery();

                            Logare frmS = new Logare();
                            utile.sqlCon.Close();
                            frmS.Show();
                            this.Hide();
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Parola nu corespunde!");
                }
                utile.sqlCon.Close();
            }
            catch (Exception ex) { }

        }

        private void CreeazaCont_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

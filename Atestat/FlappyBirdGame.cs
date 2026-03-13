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
using System;
using System.Security.Cryptography.X509Certificates;

namespace Atestat
{
    public partial class FlappyBirdGame : Form
    {

        int pipeSpeed = 8; 
        int gravity = 15; 
        int score = 0; 
        string nickname;
        string highscore;
        int HS;
        public FlappyBirdGame(string _nickname)
        {
            InitializeComponent();

            nickname = _nickname;
            restartBtn.Enabled = false;
            restartBtn.Visible = false;
            backBtn.Enabled = false;
            backBtn.Visible = false;
            
            utile.sqlCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT FlappyBirdHS from dbo.Utilizatori WHERE Nickname ='" + nickname + "'", utile.sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string scor = score.ToString();
            string HighS = dt.Rows[0].ItemArray[0].ToString();
            utile.sqlCon.Close();

            highScoreLbl.Text = "HighScore: " + HighS;
        }


        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;
            }
        }

        private void endGame()
        {
            gameTimer.Stop(); 
            scoreText.Text += " Game over!!!"; 
            restartBtn.Enabled = true;
            restartBtn.Visible = true;
            backBtn.Enabled = true;
            backBtn.Visible = true;

            utile.sqlCon.Open();
            SqlDataAdapter da = new SqlDataAdapter("SELECT FlappyBirdHS from dbo.Utilizatori WHERE Nickname ='" + nickname + "'", utile.sqlCon);
            DataTable dt = new DataTable();
            da.Fill(dt);
            string scor = score.ToString();
            string HighS = dt.Rows[0].ItemArray[0].ToString();
            int ceva = String.Compare(scor, HighS);
            if (ceva == 1 || scor.Length>HighS.Length)
            {
                SqlCommand cmd = new SqlCommand("UPDATE  dbo.Utilizatori SET FlappyBirdHS = @scor WHERE Nickname= '" + nickname + "'", utile.sqlCon);
                cmd.Parameters.AddWithValue("scor", SqlDbType.Int).Value = score;
                cmd.ExecuteNonQuery();
                highScoreLbl.Text = "HighScore: " + scor;
            }
            utile.sqlCon.Close();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity; 
            pipeBottom.Left -= pipeSpeed; 
            pipeTop.Left -= pipeSpeed; 
            scoreText.Text = "Score: " + score; 

            if (pipeBottom.Left < -150)
            {                
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {

                pipeTop.Left = 950;
                score++;
            }

            if (score >= 1)
            {
                helpLbl.Visible = false;
            }

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25)
            {
                endGame();
            }

            if (score > 5)
            {
                pipeSpeed = 15;
            }

        }

        private void restartBtn_Click(object sender, EventArgs e)
        {
            FlappyBirdGame frms = new FlappyBirdGame(nickname);
            frms.Show();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            AlegeJoc frms = new AlegeJoc(nickname);
            frms.Show();
            this.Hide();
        }

        private void FlappyBirdGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FlappyBirdGame_Load(object sender, EventArgs e)
        {

        }
    }
}

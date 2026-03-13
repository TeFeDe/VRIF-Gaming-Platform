using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat
{
    public partial class AlegeJoc : Form
    {
        string nickname;
        public AlegeJoc(string _nickname)
        {
            InitializeComponent();
            nickname = _nickname;
            welcomeLbl.Text = "Bine ai venit " + nickname + "!";
        }

        private void snakeBtn_Click(object sender, EventArgs e)
        {
            JocSnake frms = new JocSnake(nickname);
            frms.Show();
            this.Hide();
        }

        private void flappyBirdBtn_Click(object sender, EventArgs e)
        {
            FlappyBirdGame frms = new FlappyBirdGame(nickname);
            frms.Show();
            this.Hide();
        }

        private void disconnectBtn_Click(object sender, EventArgs e)
        {
            Minigames frms = new Minigames();
            frms.Show();
            this.Hide();
        }

        private void AlegeJoc_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void creeazaBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

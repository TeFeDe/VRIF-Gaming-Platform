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
    public partial class Minigames : Form
    {
        public Minigames()
        {
            InitializeComponent();
        }

        private void log_Btn_Click(object sender, EventArgs e)
        {
            Logare frms = new Logare();
            frms.Show();
            this.Hide();
        }

        private void regist_Btn_Click(object sender, EventArgs e)
        {
            CreeazaCont frms = new CreeazaCont();
            frms.Show();
            this.Hide();
        }

        private void Minigames_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Minigames_Load(object sender, EventArgs e)
        {

        }
    }
}

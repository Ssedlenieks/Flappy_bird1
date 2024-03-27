using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_bird1
{
    public partial class GameStart : Form
    {
        public GameStart()
        {
            InitializeComponent();
        }

        private void GameStart_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void LoadGame(object sender, EventArgs e)
        {
            Form1 gameWindow = new Form1();

            gameWindow.Show();
            this.Hide();

        }

        private void LoadScore(object sender, EventArgs e)
        {
            ScoreTable scoretable = new ScoreTable();

            scoretable.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SkinChoosing_Click(object sender, EventArgs e)
        {
            SkinChoosingScreen skinWindow = new SkinChoosingScreen();

            skinWindow.Show();
            this.Hide();
        }
    }
}

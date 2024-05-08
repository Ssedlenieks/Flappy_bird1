using System;
using System.Windows.Forms;
namespace Flappy_bird1
{

    public partial class GameOver : Form
    {
        public GameOver()
        {
            InitializeComponent();
        }

        private void GameOver_Load(object sender, EventArgs e)
        {

        }

        private void resetgame(object sender, EventArgs e)
        {
            this.Close();
            Form1 game = new Form1();
            game.ShowDialog();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            GameStart gameStart = new GameStart();
            gameStart.ShowDialog();
        }
    }
}

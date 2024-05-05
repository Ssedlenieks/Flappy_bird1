using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Flappy_bird1.Registration_Window;

namespace Flappy_bird1
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 8;
        int Gravity = 10;
        bool gameOVER = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Pipe_upper_Click(object sender, EventArgs e)
        {

        }

        private void Ground_Click(object sender, EventArgs e)
        {

        }

        private void Pipe_lower_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void gameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += Gravity;
            Pipe_lower.Left -= pipeSpeed;
            Pipe_upper.Left -= pipeSpeed;


            if (Pipe_lower.Left < -130)
            {
                Pipe_lower.Left = 800;
                ScoreText.Text = Score.ToString();
            
            }
            if (Pipe_upper.Left < -140)
            {
                Pipe_upper.Left = 850;
                Score++;
                ScoreText.Text = Score.ToString();
            }

            
            if (FlappyBird.Bounds.IntersectsWith(Pipe_lower.Bounds) || FlappyBird.Bounds.IntersectsWith(Pipe_upper.Bounds) || FlappyBird.Bounds.IntersectsWith(Ground.Bounds) || FlappyBird.Top < -25)
            {
                endGame();
            }

        }
        public int Score { get; set; } 

        private void GameKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                Gravity = -9;
            }
        }

        private void GameKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                Gravity = 10;
            
            }
            if (gameOVER)
            {
                RestartGame();
            
            }

        }
        private void endGame()
        {
            GameTimer.Stop();
            gameOVER = true;
        }
        public void RestartGame()
        {
            gameOVER = false;
            GameOver gameOver = new GameOver();
            gameOver.Show();

            this.Hide();
        }
        
        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }


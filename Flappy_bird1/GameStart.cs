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
            this.Close ();

        }

        private void LoadScore(object sender, EventArgs e)
        {
            ScoreTable scoretable = new ScoreTable(); 

            scoretable.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Registration_Window registration_window = new Registration_Window();
            registration_window.Show();

            if (this == Application.OpenForms[0]) // Check if the current form is the main form
            {
                this.Hide(); // Hide the current form instead of closing it
            }
            else
            {
                this.Close(); // Close the current form if it's not the main form
            }
        }
    }
}

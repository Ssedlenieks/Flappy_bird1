using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using static Flappy_bird1.Player;
using static Flappy_bird1.Registration_Window;

namespace Flappy_bird1
{
    public partial class GameStart : Form

    {
        public List<Player> players { get; set; }        
        public GameStart()
        {
            players = GetPlayers();
            InitializeComponent();
        }

        /*private List<Player> GetPlayers()
        {
            /*var list = new List<Player>();
            for (int x = 0; x < PlayerCount; x++)
            {
                
            }
            return list;        }
        */
        private void GameStart_Load(object sender, EventArgs e)
        {
            var players = this.players;
            dataGridView1.DataSource = players;

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

        /*private void LoadScore(object sender, EventArgs e)
        {
            ScoreTable scoretable = new ScoreTable(); 

            scoretable.Show();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        */
        
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Registration_Window registration_window = new Registration_Window();
            registration_window.Show();

            /*if (this == Application.OpenForms[0]) // Check if the current form is the main form
            {
                this.Hide(); // Hide the current form instead of closing it
            }
            else
            {
                this.Close(); // Close the current form if it's not the main form
            }*/
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void scoretab_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
    }
}

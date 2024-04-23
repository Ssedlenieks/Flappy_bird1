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
using Flappy_bird1;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Flappy_bird1
{
    public partial class GameStart : Form

    {
        public int ID = 0;
        private List<Player> players = new List<Player>();
        public class Player
        {
            public Player(int score, string nameoutput, int ID)
            {
                this.ID = ID;
                ID++;
            }
            public int ID { get; set; }
            public string Nameoutput { get; set; }
            public int Score { get; set; }
        }

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
            /*DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Score");
            string filepath = listView1.Text;
            StreamReader reader = new StreamReader(filepath);
            string[] totalData = new string[File.ReadAllLines(filepath).Length];
            totalData = reader.ReadLine().Split(',');
            while (!reader.EndOfStream)
            {
                totalData = reader.ReadLine().Split(',');
                dataTable.Rows.Add(totalData[0], totalData[1], totalData[2]);
            }

            listView1.DataSource = dataTable;
            */


            foreach (Player player in players)
            {
                Console.WriteLine(player.ID + "" + player.Nameoutput + " " + player.Score);
            }
        }
    }
}

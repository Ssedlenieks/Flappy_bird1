using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using static Flappy_bird1.Form1;

namespace Flappy_bird1
{

    public partial class GameStart : Form
    {
        public int Player_ID = 1;
        public void Get_Name() 
        {

            string filePath = "users.csv";

            DataTable table = new DataTable();

            //table.Columns[0].Add("ID");
            table.Columns.Add("Name");
            //table.Columns[2].Add("Score");
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int x = 1; x < lines.Length; x++)
                {
                    string[] columns = lines[x].Split(',');
                    //table.Rows.Add(Player_ID.ToString());
                    table.Rows.Add(columns[0]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading file: " + ex.Message);
            }
            dataGridView1.DataSource = table;
        }

        public GameStart()
        {
            InitializeComponent();
            Get_Name();
        }

        public void GameStart_Load(object sender, EventArgs e)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void scoretab_Click(object sender, EventArgs e)
        {
            
        }

        private void GameStartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 gameWindow = new Form1();
            gameWindow.Show();
        }

        private void RegisterButton_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Registration_Window registration_window = new Registration_Window();
            registration_window.Show();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
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

        public string GetCsvFolderPath()
        {
            return Path.Combine(Application.StartupPath, "Csv_Files");
        }

        public void LoadCSV()
        {
            try 
            { 
                string filePath = Path.Combine(GetCsvFolderPath(), "registration.csv");

                if (!File.Exists(filePath))
                {
                    MessageBox.Show("File not found");
                    return;
                }
                DataTable dataTable = new DataTable();
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line = sr.ReadLine();
                    string[] headers = sr.ReadLine().Split(',');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    while (!sr.EndOfStream)
                    {
                        string[] rows = sr.ReadLine().Split(',');
                        dataTable.Rows.Add(rows);
                    }
                }

                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        public List<Player> GetPlayers()
        {
            var list = new List<Player>();
            if (Player_Count > 0)
            {
                LoadCSV();
            }
            return list;        
        }
        
        public void GameStart_Load(object sender, EventArgs e)
        {
            var Players = this.players;
            dataGridView1.DataSource = Players;

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

        
        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Registration_Window registration_window = new Registration_Window();
            registration_window.Show();
           
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

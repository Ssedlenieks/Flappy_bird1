using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
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

        public List<Player> GetPlayers()
        {
            var list = new List<Player>();
            if (Player_Count > 0)
            {
                //LoadCSV()
            }
            return list;
        }
        

        /*public DataTable LoadCSV(string filePath)
        {
            var dt = new DataTable(); 
            File.ReadLines(filePath).Take(1)
                .SelectMany(x => x.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries))
                .ToList()
                .ForEach(x => dt.Columns.Add(x.Trim()));
            File.ReadLines(filePath).Skip(1)
                .Select(x => x.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                .ToList()
                .ForEach(line => dt.Rows.Add(line));
            return dt;
        }
        */
        
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

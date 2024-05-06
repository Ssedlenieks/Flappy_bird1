using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static Flappy_bird1.Player;
using static Flappy_bird1.Registration_Window;

namespace Flappy_bird1
{

    public partial class GameStart : Form
    {
        string filepath = "users.csv";
        public List<Player> players { get; set; }

        public GameStart()
        {
            players = GetPlayers();
            InitializeComponent();
        }

        public void LoadCSV()
        {

        }

        public List<Player> GetPlayers()
        {
            var list = new List<Player>();
            if (Player_Count > 0)
            {
                LoadCSV();
            }

            // Assuming the Player class has a property called "Username"
            var usernames = list.Select(player => player).ToList();

            // Set the DataSource property of the dataGridView1 control


            return list;
        }

        public void GameStart_Load(object sender, EventArgs e)
        {
            var Players = this.players;
            dataGridView1.DataSource = Players;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Handle button click event
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
            // Handle picture box click event
        }

        private void scoretab_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = dataGridView1.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[dataGridView1.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += dataGridView1.Columns[i].HeaderText.ToString() + ",";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += dataGridView1.Rows[i - 1].Cells[j].Value.ToString() + ",";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Data Exported Successfully !!!", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No Record To Export !!!", "Info");
            }


        }

        private void GameStartButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 gameWindow = new Form1();
            gameWindow.Show();
        }
    }
}
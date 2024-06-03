using System;
using System.Data;
using System.IO;
using System.Reflection.Emit;
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

            table.Columns.Add("ID");
            table.Columns.Add("Name");
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                for (int x = 1; x < lines.Length; x++)
                {
                    string[] columns = lines[x].Split(',');                    
                    table.Rows.Add(Player_ID, columns[0]);
                    Player_ID++;
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text.Trim();

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {               
                if (!row.IsNewRow)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null && cell.Value.ToString().Contains(searchValue))
                        {
                            row.Selected = true;
                            dataGridView1.CurrentCell = cell;
                            return;
                        }
                    }
                }
            }

            dataGridView1.ClearSelection();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Registration_Window registrationWindow = new Registration_Window();
            string myString = "Hello, " + registrationWindow.GetCharacterName() + "!";
            label2.Text = myString;
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
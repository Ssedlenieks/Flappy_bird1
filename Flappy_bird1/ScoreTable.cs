using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static Flappy_bird1.Registration_Window;
using Flappy_bird1;

namespace Flappy_bird1
{    
public partial class ScoreTable : Form
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
            public string Nameoutput { get; set; } // Add Nameoutput property
            public int Score { get; set; } // Add Score property
        }

        public ScoreTable()
        {
            InitializeComponent();
        }

        private void ScoreTable_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable DataTable = new DataTable();

            for (int x = 0; x < players.Count; x++)
            {
                DataTable.Columns.Add("ID", typeof(int));
                DataTable.Columns.Add("Name", typeof(string));
                DataTable.Columns.Add("Score", typeof(int));

                DataTable.Rows.Add(players[x].ID, players[x].Nameoutput, players[x].Score);
            }

            dataGridView1.DataSource = DataTable;
        }

        private void registrationWindowBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}


   


    
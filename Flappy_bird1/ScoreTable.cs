using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static Flappy_bird1.Registration_Window;

namespace Flappy_bird1
{    
    public partial class ScoreTable : Form
    {   
        public int ID = 0;
        private List<Player> players = new List<Player>();
        public class Player : Player_Data
        {
            public Player(int score, string nameoutput, int ID) : base(score, nameoutput)
            {
                this.ID = ID;
                ID++;
            }

            public int ID { get; set; }
            public override string ToString()
            {
            }
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

                DataTable.Rows.Add(players[x].ID, players[x].nameoutput, players[x].score);
            }


            dataGridView1.DataSource = DataTable;
        }

        private void registrationWindowBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}


   

    
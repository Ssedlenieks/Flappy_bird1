using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing; 
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Flappy_bird1.Registration_Window;
using Flappy_bird1;
using System.IO;

namespace Flappy_bird1
{    
public partial class ScoreTable : Form
    {
        public int ID = 0;
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

        public ScoreTable()
        {
            InitializeComponent();
        }

        private void ScoreTable_Load(object sender, EventArgs e)
        {
        }

        private void registrationWindowBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*DataTable dataTable = new DataTable();
            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Score");
            string filepath = listBox1.Text;
            StreamReader reader = new StreamReader(filepath);
            string[] totalData = new string[File.ReadAllLines(filepath).Length];
            totalData = reader.ReadLine().Split(',');
            while (!reader.EndOfStream)
            {
                totalData = reader.ReadLine().Split(',');
                dataTable.Rows.Add(totalData[0], totalData[1], totalData[2]);
            }

            listBox1.DataSource = dataTable;
            */
        }
    }
}


   


    
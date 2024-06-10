using System;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Flappy_bird1
{
    public partial class GameStart : Form
    {
        
        public int Player_ID = 1;
        private ListViewColumnSorter lvwColumnSorter;

        public void Get_Name() 
        {
     
            string filePath = "users.csv";

            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 100, HorizontalAlignment.Left);
            listView1.Columns.Add("Name", 200, HorizontalAlignment.Left);
            listView1.Columns.Add("Score", 100, HorizontalAlignment.Left);
            listView1.Items.Clear();

            try
            {
                if (File.Exists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    for (int x = 1; x < lines.Length; x++)
                    {
                        string[] columns = lines[x].Split(',');

                        ListViewItem item = new ListViewItem(Player_ID.ToString());
                        item.SubItems.Add(columns[0]);

                        listView1.Items.Add(item);

                        Player_ID++;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while reading file: " + ex.Message);
            }
        }

        public GameStart()
        {
            InitializeComponent();
            Get_Name(); 

            lvwColumnSorter = new ListViewColumnSorter();
            listView1.ListViewItemSorter = lvwColumnSorter;
            listView1.ColumnClick += new ColumnClickEventHandler(ClickCol);
        }

        private void ClickCol(object o, ColumnClickEventArgs e)
        {
            if (e.Column == lvwColumnSorter.SortColumn)
            {
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            listView1.Sort();
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
            string searchText = textBox1.Text;

            foreach (ListViewItem item in listView1.Items) 
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems) 
                {
                    if (subItem.Text.Contains(searchText) && !string.IsNullOrEmpty(searchText) && searchText == subItem.Text)
                    {
                        item.EnsureVisible();
                        item.BackColor = Color.LightGray;
                    }
                    else
                    {
                        item.BackColor = Color.White;
                    }
                }
            }
        }

        public class ListViewColumnSorter : IComparer
        {
            public int SortColumn { get; set; }
            public SortOrder Order { get; set; }

            private CaseInsensitiveComparer ObjectCompare;

            public ListViewColumnSorter()
            {
                SortColumn = 0;
                Order = SortOrder.None;
                ObjectCompare = new CaseInsensitiveComparer();
            }

            public int Compare(object x, object y)
            {
                int compareResult;
                ListViewItem listviewX = (ListViewItem)x;
                ListViewItem listviewY = (ListViewItem)y;

                compareResult = ObjectCompare.Compare(listviewX.SubItems[SortColumn].Text, listviewY.SubItems[SortColumn].Text);

                if (Order == SortOrder.Ascending)
                {
                    return compareResult;
                }
                else if (Order == SortOrder.Descending)
                {
                    return (-compareResult);
                }
                else
                {
                    return 0;
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
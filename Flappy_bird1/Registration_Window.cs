using CsvHelper;
using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Flappy_bird1.Player; 
using System.Collections.Generic;
using static Flappy_bird1.GameStart;

namespace Flappy_bird1
{
    public partial class Registration_Window : Form
    {
        public string nameoutput = "";
        public string passwordoutput = "";
        public List<Player> players = new List<Player>(); 

        Regex sPasswordAllowedRegEx = new Regex(@"^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{6,30}$", RegexOptions.Compiled);

        public Registration_Window()
        {
            InitializeComponent();
            CreateCsvFolder();
            CreateCsvFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameoutput = CharacterNameInput.Text;
            passwordoutput = PasswordInput.Text;

            if (!string.IsNullOrEmpty(nameoutput) && sPasswordAllowedRegEx.IsMatch(passwordoutput))
            {
                Player player = new Player(0,"",0); 
                players.Add(player); 

                string csvFilePath = Path.Combine(GetCsvFolderPath(), "registration.csv");
                using (var writer = new StreamWriter(csvFilePath, true)) // Open the file in append mode
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteField(nameoutput);
                    csv.WriteField(passwordoutput);
                    csv.NextRecord();
                }
            }

            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void CharacterNameInput_TextChanged(object sender, EventArgs e)
        {
            nameoutput = CharacterNameInput.Text;
        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
            passwordoutput = PasswordInput.Text;
        }

        private void Registration_Window_Load(object sender, EventArgs e)
        {
            tabPage1_Click(sender, e); // Call the tabPage1_Click method when the form loads
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            nameoutput = CharacterNameInput.Text;
            passwordoutput = PasswordInput.Text;

            if (!string.IsNullOrEmpty(nameoutput) && sPasswordAllowedRegEx.IsMatch(passwordoutput))
            {
                Player player = new Player(0,"",0); // Create a new player object
                players.Add(player); // Add the player to the list

                string csvFilePath = Path.Combine(GetCsvFolderPath(), "registration.csv");
                using (var writer = new StreamWriter(csvFilePath, true))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteField(nameoutput);
                    csv.WriteField(passwordoutput);
                    csv.NextRecord();
                }
            }
        }

        private void CreateCsvFolder()
        {
            string folderPath = GetCsvFolderPath();
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        private string GetCsvFolderPath()
        {
            return Path.Combine(Application.StartupPath, "Csv_Files");
        }

        private string CreateCsvFile()
        {
            string csvFilePath = Path.Combine(GetCsvFolderPath(), "registration.csv");
            if (!File.Exists(csvFilePath))
            {
                using (var writer = new StreamWriter(csvFilePath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                { }
            }
            return csvFilePath;
        }

        private void LoginTab_Click(object sender, EventArgs e)
        {


        }

        private void RegistrationTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void login_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_pass_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
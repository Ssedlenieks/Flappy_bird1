using System;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using CsvHelper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Flappy_bird1.Properties;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using static Flappy_bird1.Form1;

namespace Flappy_bird1
{
    public partial class Registration_Window : Form
    {
        public string nameoutput = "";
        public string passwordoutput = "";
        Regex sPasswordAllowedRegEx = new Regex(@"^(?=.*[0-9])(?=.*[!@#$%^&*])[a-zA-Z0-9!@#$%^&*]{6,30}$", RegexOptions.Compiled);

        public Registration_Window()
        {
            InitializeComponent();
            CreateCsvFolder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameoutput = "";
            passwordoutput = "";
            if (UserExists(CharacterNameInput.Text, PasswordInput.Text) == true && string.IsNullOrEmpty(nameoutput) == false && sPasswordAllowedRegEx.IsMatch(passwordoutput) == true)
            {
                string csvFilePath = Path.Combine(GetCsvFolderPath(), "registration.csv");
                using (var writer = new StreamWriter(csvFilePath, true))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteField("Name");
                    csv.WriteField("Password");
                    csv.NextRecord();

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
        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
        }

        private void Registration_Window_Load(object sender, EventArgs e)
        {

        }

        public class Player_Data : Player_Score
        {
            public Player_Data(int score, string nameoutput) : base(score)
            {
                this.score = score;
                this.nameoutput = nameoutput;

            }

            public string nameoutput { get; set; }

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
        private bool UserExists(string username, string password)
        {
            string csvFilePath = Path.Combine(GetCsvFolderPath(), "registration.csv");
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader();
                while (csv.Read())
                {
                    string name = csv.GetField("Name");
                    
                    if (name == username)
                    {
                        return true;
                    }
                }
            }
            return false;
        }


    }
}
using CsvHelper;
using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
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
            CreateCsvFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nameoutput = CharacterNameInput.Text;
            passwordoutput = PasswordInput.Text;

            if (UserExists(nameoutput, passwordoutput) && !string.IsNullOrEmpty(nameoutput) && sPasswordAllowedRegEx.IsMatch(passwordoutput))
            {
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
            if (!File.Exists(csvFilePath))
            {
                return false;
            }

            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read();
                csv.ReadHeader(); // Add this line to read the header

                while (csv.Read())
                {
                    string name = csv.GetField("name");
                    if (name == username)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private string CreateCsvFile()
        {
            string csvFilePath = Path.Combine(GetCsvFolderPath(), "registration.csv");
            if (!File.Exists(csvFilePath))
            {
                using (var writer = new StreamWriter(csvFilePath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteField("name ");
                    csv.WriteField("Password ");
                    csv.NextRecord();
                }
            }
            return csvFilePath;
            // nestrada registration lidz galam, vajag izveidot lidz galam log in , score table lidz galam
            
        }
    }
}
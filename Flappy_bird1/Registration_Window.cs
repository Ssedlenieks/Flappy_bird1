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
using System.Runtime.CompilerServices;


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
            
            string csvfilepath = Path.Combine(GetCsvFolderPath(), "registration.csv");
            using (var writer = new StreamWriter(csvfilepath, true))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                nameoutput = CharacterNameInput.Text;
                passwordoutput = PasswordInput.Text;
                csv.WriteField("name" + nameoutput);
                csv.WriteField("password" + passwordoutput);
                    
                csv.NextRecord();
            }
            

            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void CharacterNameInput_TextChanged(object sender, EventArgs e)
        {
            //string csvFilePath = Path.Combine(GetCsvFolderPath(), "registration.csv");
            //using (var writer = new StreamWriter(csvFilePath, true))
            //using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            //{
                
            //    nameoutput = CharacterNameInput.Text;
            //    csv.WriteField("Name" + nameoutput);
            //    csv.NextRecord();
            //}
        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
            // Save the password to the registration.csv file
            //string csvFilePath = Path.Combine(GetCsvFolderPath(), "registration.csv");
            //using (var writer = new StreamWriter(csvFilePath, true))
            //using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            //{
            //    passwordoutput = PasswordInput.Text;
            //    csv.WriteField("Password" + passwordoutput);
            //    csv.NextRecord();
            //}
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
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                while (csv.Read())
                {
                    string name = csv.GetField(0); // Read the first field (index 0) as the username

                    if (name == username)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        

        private void tabPage1_Click(object sender, EventArgs e)
        {


        }
        //private void Registration_Window_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    if (Application.OpenForms.Count == )
        //    {
        //        Application.Exit();
        //    }
        //}
          
    }
}
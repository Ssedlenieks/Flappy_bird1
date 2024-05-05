using CsvHelper;
using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using static Flappy_bird1.Form1; 

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
            //CreateCsvFolder();
            //CreateCsvFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(nameoutput) || string.IsNullOrEmpty(passwordoutput))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            Registration registration = new Registration();
            registration.RegisterUser(nameoutput, passwordoutput);

            this.Close();

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
            tabPage1_Click(sender, e); 
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {/*
            nameoutput = CharacterNameInput.Text;
            passwordoutput = PasswordInput.Text;
            

            if (!string.IsNullOrEmpty(nameoutput) && sPasswordAllowedRegEx.IsMatch(passwordoutput))
            {
                string Name = nameoutput;
                string password = passwordoutput;
                int id = GetNextId();
                Form1.score score = new Form1.score();


                string csvFilePath = Path.Combine(GetCsvFolderPath(), "registration.csv");
                using (var writer = new StreamWriter(csvFilePath, true))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    
                    writer.WriteLine(string.Format("{0},{1},{2},{3}", id, Name, password, score));
                }
            }*/
        }
        class Registration
        {
            private List<User> users = new List<User>();
            private string filePath = "users.csv";

            public void RegisterUser(string username, string password)
            {
                if (!File.Exists(filePath))
                {
                    using (var writer = new StreamWriter(filePath))
                    using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                    {
                        csv.WriteHeader<User>();
                        csv.NextRecord();
                    }
                }

                users = ReadUsersFromCsv();

                if (!users.Exists(user => user.Username == username))
                {
                    users.Add(new User { Username = username, Password = password });
                    WriteUsersToCsv(users);
                    Console.WriteLine("Registration successful!");
                }
                else
                {
                    Console.WriteLine("Username already exists.");
                }
            }

            private void WriteUsersToCsv(IEnumerable<User> users)
            {
                using (var writer = new StreamWriter(filePath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(users);
                }
            }

            private List<User> ReadUsersFromCsv()
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return csv.GetRecords<User>().ToList();
                }
            }
        }

        public class User : Form1
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public int userScore { get; set; }
            public User(string username, string password, int Score) 
            {
                Username = username;
                Password = password;
                userScore = Score;
            }
        }

        class Login
        {
            private List<User> users = new List<User>();
            private string filePath = "users.csv";

            public bool LoginUser(string username, string password)
            {
                if (!File.Exists(filePath))
                {
                    return false;
                }

                users = ReadUsersFromCsv();

                if (users.Exists(user => user.Username == username && user.Password == password))
                {
                    Console.WriteLine("Login successful!");
                    return true;
                }
                else
                {
                    Console.WriteLine("Invalid username or password.");
                    return false;
                }
            }

            private List<User> ReadUsersFromCsv()
            {
                using (var reader = new StreamReader(filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return csv.GetRecords<User>().ToList();
                }
            }
        }

        /*private int GetNextId()
        {
            int nextId = 1;

            if (File.Exists("output.csv"))
            {
                string[] lines = File.ReadAllLines("output.csv");
                int lastId = int.Parse(lines[lines.Length - 1].Split(',')[0]);
                nextId = lastId + 1;
            }

            return nextId;
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
        */
        private void LoginTab_Click(object sender, EventArgs e)
        {
            RegistrationTab.Enabled = false;


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

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(login_name.Text) || string.IsNullOrEmpty(login_pass.Text))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }

            Login login = new Login();
            if (login.LoginUser(login_name.Text, login_pass.Text))
            {
                Form1 form = new Form1();
                form.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}
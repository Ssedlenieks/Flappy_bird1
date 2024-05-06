using CsvHelper;
using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static Flappy_bird1.Player;
using System.Collections.Generic;
using static Flappy_bird1.GameStart;
using System.Linq;
using CsvHelper.Configuration.Attributes;

namespace Flappy_bird1
{
    public partial class Registration_Window : Form
    {
        readonly string filePath = "users.csv";
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
            if ((string.IsNullOrEmpty(nameoutput) || string.IsNullOrEmpty(passwordoutput)))
            {
                MessageBox.Show("Please enter a username and password.");
                return;
            }
            Registration_Window.Registration registration = new Registration_Window.Registration();
            if (registration.UserExists(nameoutput))
            {
                MessageBox.Show("Username already exists. Please choose a different username.");
                return;
            }

            registration.RegisterUser(nameoutput, passwordoutput);

            this.Close();

            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        internal void CharacterNameInput_TextChanged(object sender, EventArgs e)
        {
            nameoutput = this.CharacterNameInput.Text;
        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
            passwordoutput = this.PasswordInput.Text;
        }

        private void Registration_Window_Load(object sender, EventArgs e)
        {
            tabPage1_Click(sender, e);
        }

        class Registration
        {
            private readonly string _filePath = "users.csv";

            public void RegisterUser(string username, string password)
            {
                try
                {
                    if (UserExists(username))
                    {
                        
                        MessageBox.Show("Username already exists. Please choose a different username.");
                        return;

                    }

                    var users = ReadUsersFromCsv();
                    users.Add(new User { Username = username, Password = password });
                    WriteUsersToCsv(users);
                    MessageBox.Show("Registration successful!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            internal bool UserExists(string username)
            {
                return ReadUsersFromCsv().Any(user => user.Username == username);
            }

            public List<User> ReadUsersFromCsv()
            {
                if (!File.Exists(_filePath))
                {
                    CreateCsvFile();
                    return new List<User>();
                }

                using (var reader = new StreamReader(_filePath))
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    return csv.GetRecords<User>().ToList();
                }
            }

            private void WriteUsersToCsv(List<User> users)
            {
                using (var writer = new StreamWriter(_filePath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteRecords(users);
                }
            }

            private void CreateCsvFile()
            {
                using (var writer = new StreamWriter(_filePath))
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    csv.WriteHeader<User>();
                    csv.NextRecord();
                }
            }
        }

        class User
        {
            public string Username { get; set; }
            public string Password { get; set; }
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

        private void LoginTab_Click(object sender, EventArgs e)
        {
            RegistrationTab.Enabled = false;

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

        private void RegistrationTab_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void login_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_pass_TextChanged(object sender, EventArgs e)
        {

        }
        private void tabPage1_Click(object sender, EventArgs e)
        {
        }
    }
}
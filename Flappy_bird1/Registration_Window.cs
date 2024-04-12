using System;
using System.IO;
using System.Windows.Forms;
using System.Globalization;
using CsvHelper;

namespace Flappy_bird1
{
    public partial class Registration_Window : Form
    {
        public string output = "";

        public Registration_Window()
        {
            InitializeComponent();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPath = Path.Combine(desktopPath, "Csv_Files");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(output))
            {
                MessageBox.Show("Please enter a character name and password.");
                return;
            }
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string folderPath = Path.Combine(desktopPath, "Csv_Files");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string csvFilePath = Path.Combine(folderPath, "registration.csv");
            File.AppendAllText(csvFilePath, output + Environment.NewLine);

            output = "";

            Form1 form = new Form1();
            form.Show();
            this.Close();
        }

        private void CharacterNameInput_TextChanged(object sender, EventArgs e)
        {
            output += "Name," + CharacterNameInput.Text + "\n";
        }

        private void PasswordInput_TextChanged(object sender, EventArgs e)
        {
            output += "Password," + PasswordInput.Text + "\n";
        }
    }
}
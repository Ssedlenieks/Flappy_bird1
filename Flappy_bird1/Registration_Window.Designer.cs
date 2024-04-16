namespace Flappy_bird1
{
    partial class Registration_Window
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StartGameReg = new System.Windows.Forms.Button();
            this.CharacterNameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.RegistrationTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LoginTab = new System.Windows.Forms.TabPage();
            this.RegistrationTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartGameReg
            // 
            this.StartGameReg.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameReg.Location = new System.Drawing.Point(53, 252);
            this.StartGameReg.Name = "StartGameReg";
            this.StartGameReg.Size = new System.Drawing.Size(222, 91);
            this.StartGameReg.TabIndex = 0;
            this.StartGameReg.Text = "Start the game";
            this.StartGameReg.UseVisualStyleBackColor = true;
            this.StartGameReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // CharacterNameInput
            // 
            this.CharacterNameInput.Location = new System.Drawing.Point(175, 150);
            this.CharacterNameInput.Name = "CharacterNameInput";
            this.CharacterNameInput.Size = new System.Drawing.Size(100, 22);
            this.CharacterNameInput.TabIndex = 1;
            this.CharacterNameInput.TextChanged += new System.EventHandler(this.CharacterNameInput_TextChanged);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(175, 98);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(100, 22);
            this.PasswordInput.TabIndex = 2;
            this.PasswordInput.TextChanged += new System.EventHandler(this.PasswordInput_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(95, 98);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(56, 22);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(78, 150);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(88, 22);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
<<<<<<< HEAD
=======
            // 
            // RegistrationTab
            // 
            this.RegistrationTab.Controls.Add(this.tabPage1);
            this.RegistrationTab.Controls.Add(this.LoginTab);
            this.RegistrationTab.Location = new System.Drawing.Point(0, 0);
            this.RegistrationTab.Name = "RegistrationTab";
            this.RegistrationTab.SelectedIndex = 0;
            this.RegistrationTab.Size = new System.Drawing.Size(368, 448);
            this.RegistrationTab.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CharacterNameInput);
            this.tabPage1.Controls.Add(this.StartGameReg);
            this.tabPage1.Controls.Add(this.NameLabel);
            this.tabPage1.Controls.Add(this.PasswordLabel);
            this.tabPage1.Controls.Add(this.PasswordInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(360, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registration";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // LoginTab
            // 
            this.LoginTab.Location = new System.Drawing.Point(4, 25);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Padding = new System.Windows.Forms.Padding(3);
            this.LoginTab.Size = new System.Drawing.Size(360, 419);
            this.LoginTab.TabIndex = 1;
            this.LoginTab.Text = "Login";
            this.LoginTab.UseVisualStyleBackColor = true;
>>>>>>> b31d1b8f12da85bace5fd4bd42713036c9458714
            // 
            // Registration_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.CharacterNameInput);
            this.Controls.Add(this.StartGameReg);
            this.Name = "Registration_Window";
            this.Text = "Register your character !";
            this.Load += new System.EventHandler(this.Registration_Window_Load);
=======
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.RegistrationTab);
            this.Name = "Registration_Window";
            this.Text = "Register your character !";
            this.Load += new System.EventHandler(this.Registration_Window_Load);
            this.RegistrationTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
>>>>>>> b31d1b8f12da85bace5fd4bd42713036c9458714
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGameReg;
        private System.Windows.Forms.TextBox CharacterNameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TabControl RegistrationTab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage LoginTab;
    }
}
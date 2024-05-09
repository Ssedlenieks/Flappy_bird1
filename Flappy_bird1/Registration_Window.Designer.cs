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
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.login_pass = new System.Windows.Forms.TextBox();
            this.login_name = new System.Windows.Forms.TextBox();
            this.userdelete = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.Deleteuserconfirm = new System.Windows.Forms.Button();
            this.delete_confirm_text_box = new System.Windows.Forms.TextBox();
            this.RegistrationTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.LoginTab.SuspendLayout();
            this.userdelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartGameReg
            // 
            this.StartGameReg.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameReg.Location = new System.Drawing.Point(59, 229);
            this.StartGameReg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StartGameReg.Name = "StartGameReg";
            this.StartGameReg.Size = new System.Drawing.Size(221, 91);
            this.StartGameReg.TabIndex = 0;
            this.StartGameReg.Text = "Register";
            this.StartGameReg.UseVisualStyleBackColor = true;
            this.StartGameReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // CharacterNameInput
            // 
            this.CharacterNameInput.Location = new System.Drawing.Point(171, 73);
            this.CharacterNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CharacterNameInput.Name = "CharacterNameInput";
            this.CharacterNameInput.Size = new System.Drawing.Size(100, 22);
            this.CharacterNameInput.TabIndex = 1;
            this.CharacterNameInput.TextChanged += new System.EventHandler(this.CharacterNameInput_TextChanged);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(171, 126);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(100, 22);
            this.PasswordInput.TabIndex = 2;
            this.PasswordInput.TextChanged += new System.EventHandler(this.PasswordInput_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(247)))));
            this.NameLabel.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(85, 66);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(54, 28);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(247)))));
            this.PasswordLabel.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(63, 119);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(91, 28);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // RegistrationTab
            // 
            this.RegistrationTab.Controls.Add(this.tabPage1);
            this.RegistrationTab.Controls.Add(this.LoginTab);
            this.RegistrationTab.Controls.Add(this.userdelete);
            this.RegistrationTab.Location = new System.Drawing.Point(0, 0);
            this.RegistrationTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegistrationTab.Name = "RegistrationTab";
            this.RegistrationTab.SelectedIndex = 0;
            this.RegistrationTab.Size = new System.Drawing.Size(368, 448);
            this.RegistrationTab.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(247)))));
            this.tabPage1.Controls.Add(this.StartGameReg);
            this.tabPage1.Controls.Add(this.NameLabel);
            this.tabPage1.Controls.Add(this.PasswordLabel);
            this.tabPage1.Controls.Add(this.PasswordInput);
            this.tabPage1.Controls.Add(this.CharacterNameInput);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(360, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registration";
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // LoginTab
            // 
            this.LoginTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(247)))));
            this.LoginTab.Controls.Add(this.button1);
            this.LoginTab.Controls.Add(this.label2);
            this.LoginTab.Controls.Add(this.label1);
            this.LoginTab.Controls.Add(this.login_pass);
            this.LoginTab.Controls.Add(this.login_name);
            this.LoginTab.Location = new System.Drawing.Point(4, 25);
            this.LoginTab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginTab.Name = "LoginTab";
            this.LoginTab.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginTab.Size = new System.Drawing.Size(360, 419);
            this.LoginTab.TabIndex = 1;
            this.LoginTab.Text = "Login";
            this.LoginTab.Click += new System.EventHandler(this.LoginTab_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(59, 229);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(221, 91);
            this.button1.TabIndex = 6;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(247)))));
            this.label2.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(247)))));
            this.label1.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // login_pass
            // 
            this.login_pass.Location = new System.Drawing.Point(171, 126);
            this.login_pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_pass.Name = "login_pass";
            this.login_pass.Size = new System.Drawing.Size(100, 22);
            this.login_pass.TabIndex = 1;
            // 
            // login_name
            // 
            this.login_name.Location = new System.Drawing.Point(171, 71);
            this.login_name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_name.Name = "login_name";
            this.login_name.Size = new System.Drawing.Size(100, 22);
            this.login_name.TabIndex = 0;
            // 
            // userdelete
            // 
            this.userdelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(247)))));
            this.userdelete.Controls.Add(this.label3);
            this.userdelete.Controls.Add(this.Deleteuserconfirm);
            this.userdelete.Controls.Add(this.delete_confirm_text_box);
            this.userdelete.Location = new System.Drawing.Point(4, 25);
            this.userdelete.Name = "userdelete";
            this.userdelete.Size = new System.Drawing.Size(360, 419);
            this.userdelete.TabIndex = 2;
            this.userdelete.Text = "Delete user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 13.8F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(84, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // Deleteuserconfirm
            // 
            this.Deleteuserconfirm.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold);
            this.Deleteuserconfirm.Location = new System.Drawing.Point(59, 229);
            this.Deleteuserconfirm.Name = "Deleteuserconfirm";
            this.Deleteuserconfirm.Size = new System.Drawing.Size(221, 91);
            this.Deleteuserconfirm.TabIndex = 1;
            this.Deleteuserconfirm.Text = "Delete ";
            this.Deleteuserconfirm.UseVisualStyleBackColor = true;
            this.Deleteuserconfirm.Click += new System.EventHandler(this.Deleteuserconfirm_Click);
            // 
            // delete_confirm_text_box
            // 
            this.delete_confirm_text_box.Location = new System.Drawing.Point(164, 126);
            this.delete_confirm_text_box.Name = "delete_confirm_text_box";
            this.delete_confirm_text_box.Size = new System.Drawing.Size(100, 22);
            this.delete_confirm_text_box.TabIndex = 0;
            this.delete_confirm_text_box.TextChanged += new System.EventHandler(this.delete_confirm_text_box_TextChanged);
            // 
            // Registration_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 450);
            this.Controls.Add(this.RegistrationTab);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Registration_Window";
            this.Text = "Register your character !";
            this.RegistrationTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.LoginTab.ResumeLayout(false);
            this.LoginTab.PerformLayout();
            this.userdelete.ResumeLayout(false);
            this.userdelete.PerformLayout();
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
        private System.Windows.Forms.TextBox login_pass;
        private System.Windows.Forms.TextBox login_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage userdelete;
        private System.Windows.Forms.Button Deleteuserconfirm;
        private System.Windows.Forms.TextBox delete_confirm_text_box;
        private System.Windows.Forms.Label label3;
    }
}
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
            this.SuspendLayout();
            // 
            // StartGameReg
            // 
            this.StartGameReg.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameReg.Location = new System.Drawing.Point(42, 243);
            this.StartGameReg.Name = "StartGameReg";
            this.StartGameReg.Size = new System.Drawing.Size(222, 91);
            this.StartGameReg.TabIndex = 0;
            this.StartGameReg.Text = "Start the game";
            this.StartGameReg.UseVisualStyleBackColor = true;
            this.StartGameReg.Click += new System.EventHandler(this.button1_Click);
            // 
            // CharacterNameInput
            // 
            this.CharacterNameInput.Location = new System.Drawing.Point(164, 83);
            this.CharacterNameInput.Name = "CharacterNameInput";
            this.CharacterNameInput.Size = new System.Drawing.Size(100, 22);
            this.CharacterNameInput.TabIndex = 1;
            this.CharacterNameInput.TextChanged += new System.EventHandler(this.CharacterNameInput_TextChanged);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(185, 159);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(100, 22);
            this.PasswordInput.TabIndex = 2;
            this.PasswordInput.TextChanged += new System.EventHandler(this.PasswordInput_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(71, 82);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(56, 22);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Name";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(71, 159);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(88, 22);
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "Password";
            // 
            // Registration_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.CharacterNameInput);
            this.Controls.Add(this.StartGameReg);
            this.Name = "Registration_Window";
            this.Text = "Register your character !";
            this.Load += new System.EventHandler(this.Registration_Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGameReg;
        private System.Windows.Forms.TextBox CharacterNameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PasswordLabel;
    }
}
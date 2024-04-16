namespace Flappy_bird1
{
    partial class GameStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameStart));
            this.GameStartButton = new System.Windows.Forms.Button();
            this.GoToScoreButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.StartGameTab = new System.Windows.Forms.TabControl();
            this.StartScreen = new System.Windows.Forms.TabPage();
            this.scoretab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StartGameTab.SuspendLayout();
            this.StartScreen.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameStartButton
            // 
            this.GameStartButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStartButton.Location = new System.Drawing.Point(34, 136);
            this.GameStartButton.Name = "GameStartButton";
            this.GameStartButton.Size = new System.Drawing.Size(274, 87);
            this.GameStartButton.TabIndex = 0;
            this.GameStartButton.Text = "Start Game !";
            this.GameStartButton.UseVisualStyleBackColor = true;
            this.GameStartButton.Click += new System.EventHandler(this.LoadGame);
            // 
            // GoToScoreButton
            // 
            this.GoToScoreButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoToScoreButton.Location = new System.Drawing.Point(34, 394);
            this.GoToScoreButton.Name = "GoToScoreButton";
            this.GoToScoreButton.Size = new System.Drawing.Size(274, 87);
            this.GoToScoreButton.TabIndex = 2;
            this.GoToScoreButton.Text = "Score";
            this.GoToScoreButton.UseVisualStyleBackColor = true;
            this.GoToScoreButton.Click += new System.EventHandler(this.LoadScore);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Flappy Bird";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(34, 261);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(274, 97);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // StartGameTab
            // 
            this.StartGameTab.Controls.Add(this.StartScreen);
            this.StartGameTab.Controls.Add(this.scoretab);
            this.StartGameTab.Location = new System.Drawing.Point(0, 0);
            this.StartGameTab.Name = "StartGameTab";
            this.StartGameTab.SelectedIndex = 0;
            this.StartGameTab.Size = new System.Drawing.Size(333, 575);
            this.StartGameTab.TabIndex = 7;
            // 
            // StartScreen
            // 
            this.StartScreen.BackColor = System.Drawing.Color.SkyBlue;
            this.StartScreen.Controls.Add(this.label1);
            this.StartScreen.Controls.Add(this.RegisterButton);
            this.StartScreen.Controls.Add(this.GameStartButton);
            this.StartScreen.Controls.Add(this.GoToScoreButton);
            this.StartScreen.Controls.Add(this.pictureBox1);
            this.StartScreen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartScreen.Location = new System.Drawing.Point(4, 25);
            this.StartScreen.Name = "StartScreen";
            this.StartScreen.Padding = new System.Windows.Forms.Padding(3);
            this.StartScreen.Size = new System.Drawing.Size(325, 546);
            this.StartScreen.TabIndex = 0;
            this.StartScreen.Text = "Game Menu";
            // 
            // scoretab
            // 
            this.scoretab.Location = new System.Drawing.Point(4, 25);
            this.scoretab.Name = "scoretab";
            this.scoretab.Padding = new System.Windows.Forms.Padding(3);
            this.scoretab.Size = new System.Drawing.Size(325, 546);
            this.scoretab.TabIndex = 1;
            this.scoretab.Text = "Score";
            this.scoretab.UseVisualStyleBackColor = true;
            // 
            // GameStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(327, 568);
            this.Controls.Add(this.StartGameTab);
            this.Name = "GameStart";
            this.Text = "Game Start";
            this.Load += new System.EventHandler(this.GameStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StartGameTab.ResumeLayout(false);
            this.StartScreen.ResumeLayout(false);
            this.StartScreen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GameStartButton;
        private System.Windows.Forms.Button GoToScoreButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TabControl StartGameTab;
        private System.Windows.Forms.TabPage StartScreen;
        private System.Windows.Forms.TabPage scoretab;
    }
}
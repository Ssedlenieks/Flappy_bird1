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
            this.GameStartButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.StartGameTab = new System.Windows.Forms.TabControl();
            this.StartScreen = new System.Windows.Forms.TabPage();
            this.scoretab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Score = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StartGameTab.SuspendLayout();
            this.StartScreen.SuspendLayout();
            this.scoretab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameStartButton
            // 
            this.GameStartButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStartButton.Location = new System.Drawing.Point(34, 212);
            this.GameStartButton.Name = "GameStartButton";
            this.GameStartButton.Size = new System.Drawing.Size(274, 87);
            this.GameStartButton.TabIndex = 0;
            this.GameStartButton.Text = "Start Game !";
            this.GameStartButton.UseVisualStyleBackColor = true;
            this.GameStartButton.Click += new System.EventHandler(this.LoadGame);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Flappy_bird1.Properties.Resources.photo1711521563;
            this.pictureBox1.Location = new System.Drawing.Point(34, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 58);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 37);
            this.label1.TabIndex = 5;
            this.label1.Text = "Flappy Bird";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(34, 344);
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
            this.StartGameTab.Location = new System.Drawing.Point(-7, 0);
            this.StartGameTab.Name = "StartGameTab";
            this.StartGameTab.SelectedIndex = 0;
            this.StartGameTab.Size = new System.Drawing.Size(340, 575);
            this.StartGameTab.TabIndex = 7;
            // 
            // StartScreen
            // 
            this.StartScreen.BackColor = System.Drawing.Color.SkyBlue;
            this.StartScreen.Controls.Add(this.label1);
            this.StartScreen.Controls.Add(this.RegisterButton);
            this.StartScreen.Controls.Add(this.GameStartButton);
            this.StartScreen.Controls.Add(this.pictureBox1);
            this.StartScreen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartScreen.Location = new System.Drawing.Point(4, 25);
            this.StartScreen.Name = "StartScreen";
            this.StartScreen.Padding = new System.Windows.Forms.Padding(3);
            this.StartScreen.Size = new System.Drawing.Size(332, 546);
            this.StartScreen.TabIndex = 0;
            this.StartScreen.Text = "Game Menu";
            // 
            // scoretab
            // 
            this.scoretab.BackColor = System.Drawing.Color.SkyBlue;
            this.scoretab.Controls.Add(this.dataGridView1);
            this.scoretab.Location = new System.Drawing.Point(4, 25);
            this.scoretab.Name = "scoretab";
            this.scoretab.Padding = new System.Windows.Forms.Padding(3);
            this.scoretab.Size = new System.Drawing.Size(332, 546);
            this.scoretab.TabIndex = 1;
            this.scoretab.Text = "Score";
            this.scoretab.Click += new System.EventHandler(this.scoretab_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerID,
            this.Name,
            this.Score});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(329, 540);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // PlayerID
            // 
            this.PlayerID.HeaderText = "Player ID";
            this.PlayerID.MinimumWidth = 6;
            this.PlayerID.Name = "PlayerID";
            this.PlayerID.Width = 125;
            // 
            // Name
            // 
            this.Name.HeaderText = "Player Name";
            this.Name.MinimumWidth = 6;
            this.Name.Name = "Name";
            this.Name.Width = 125;
            // 
            // Score
            // 
            this.Score.HeaderText = "Player Score";
            this.Score.MinimumWidth = 6;
            this.Score.Name = "Score";
            this.Score.ReadOnly = true;
            this.Score.Width = 125;
            // 
            // GameStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(327, 566);
            this.Controls.Add(this.StartGameTab);
            this.Name = "GameStart";
            this.Text = "Game Start";
            this.Load += new System.EventHandler(this.GameStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StartGameTab.ResumeLayout(false);
            this.StartScreen.ResumeLayout(false);
            this.StartScreen.PerformLayout();
            this.scoretab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GameStartButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TabControl StartGameTab;
        private System.Windows.Forms.TabPage StartScreen;
        private System.Windows.Forms.TabPage scoretab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Score;
    }
}
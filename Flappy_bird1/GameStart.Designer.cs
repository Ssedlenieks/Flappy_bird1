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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.scoretab = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Player_ID_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player_name_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Player_Score_Colummn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StartGameTab.SuspendLayout();
            this.StartScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.scoretab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GameStartButton
            // 
            this.GameStartButton.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameStartButton.Location = new System.Drawing.Point(88, 183);
            this.GameStartButton.Name = "GameStartButton";
            this.GameStartButton.Size = new System.Drawing.Size(274, 87);
            this.GameStartButton.TabIndex = 0;
            this.GameStartButton.Text = "Start Game";
            this.GameStartButton.UseVisualStyleBackColor = true;
            this.GameStartButton.Click += new System.EventHandler(this.GameStartButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Flappy_bird1.Properties.Resources.photo1711521563;
            this.pictureBox1.Location = new System.Drawing.Point(78, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 72);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(189, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Flappy Bird";
            // 
            // RegisterButton
            // 
            this.RegisterButton.Font = new System.Drawing.Font("Agency FB", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.Location = new System.Drawing.Point(88, 312);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(274, 97);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // StartGameTab
            // 
            this.StartGameTab.Controls.Add(this.StartScreen);
            this.StartGameTab.Controls.Add(this.scoretab);
            this.StartGameTab.Location = new System.Drawing.Point(-7, 0);
            this.StartGameTab.Name = "StartGameTab";
            this.StartGameTab.SelectedIndex = 0;
            this.StartGameTab.Size = new System.Drawing.Size(456, 570);
            this.StartGameTab.TabIndex = 7;
            // 
            // StartScreen
            // 
            this.StartScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(247)))));
            this.StartScreen.Controls.Add(this.label1);
            this.StartScreen.Controls.Add(this.RegisterButton);
            this.StartScreen.Controls.Add(this.GameStartButton);
            this.StartScreen.Controls.Add(this.pictureBox1);
            this.StartScreen.Controls.Add(this.pictureBox2);
            this.StartScreen.Controls.Add(this.pictureBox3);
            this.StartScreen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartScreen.Location = new System.Drawing.Point(4, 25);
            this.StartScreen.Name = "StartScreen";
            this.StartScreen.Padding = new System.Windows.Forms.Padding(3);
            this.StartScreen.Size = new System.Drawing.Size(448, 541);
            this.StartScreen.TabIndex = 0;
            this.StartScreen.Text = "Game Menu";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Flappy_bird1.Properties.Resources.clouds;
            this.pictureBox2.Location = new System.Drawing.Point(6, 350);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(593, 188);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Flappy_bird1.Properties.Resources.clouds;
            this.pictureBox3.Location = new System.Drawing.Point(-326, 131);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(793, 196);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // scoretab
            // 
            this.scoretab.BackColor = System.Drawing.Color.SkyBlue;
            this.scoretab.Controls.Add(this.dataGridView1);
            this.scoretab.Location = new System.Drawing.Point(4, 25);
            this.scoretab.Name = "scoretab";
            this.scoretab.Padding = new System.Windows.Forms.Padding(3);
            this.scoretab.Size = new System.Drawing.Size(448, 541);
            this.scoretab.TabIndex = 1;
            this.scoretab.Text = "Score";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(247)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Player_ID_column,
            this.Player_name_column,
            this.Player_Score_Colummn});
            this.dataGridView1.GridColor = System.Drawing.Color.White;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(449, 540);
            this.dataGridView1.TabIndex = 0;
            // 
            // Player_ID_column
            // 
            this.Player_ID_column.HeaderText = "ID";
            this.Player_ID_column.MinimumWidth = 6;
            this.Player_ID_column.Name = "Player_ID_column";
            this.Player_ID_column.Width = 125;
            // 
            // Player_name_column
            // 
            this.Player_name_column.HeaderText = "Name";
            this.Player_name_column.MinimumWidth = 6;
            this.Player_name_column.Name = "Player_name_column";
            this.Player_name_column.Width = 125;
            // 
            // Player_Score_Colummn
            // 
            this.Player_Score_Colummn.HeaderText = "Score";
            this.Player_Score_Colummn.MinimumWidth = 6;
            this.Player_Score_Colummn.Name = "Player_Score_Colummn";
            this.Player_Score_Colummn.Width = 125;
            // 
            // GameStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(449, 566);
            this.Controls.Add(this.StartGameTab);
            this.Name = "GameStart";
            this.Text = "Game Start";
            this.Load += new System.EventHandler(this.GameStart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.StartGameTab.ResumeLayout(false);
            this.StartScreen.ResumeLayout(false);
            this.StartScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player_ID_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player_name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Player_Score_Colummn;
    }
}
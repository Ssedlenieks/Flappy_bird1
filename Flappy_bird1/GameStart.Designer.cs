﻿namespace Flappy_bird1
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
            this.players = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.StartGameTab.SuspendLayout();
            this.StartScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.players.SuspendLayout();
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
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click_1);
            // 
            // StartGameTab
            // 
            this.StartGameTab.Controls.Add(this.StartScreen);
            this.StartGameTab.Controls.Add(this.players);
            this.StartGameTab.Location = new System.Drawing.Point(-7, 0);
            this.StartGameTab.Name = "StartGameTab";
            this.StartGameTab.SelectedIndex = 0;
            this.StartGameTab.Size = new System.Drawing.Size(456, 570);
            this.StartGameTab.TabIndex = 7;
            // 
            // StartScreen
            // 
            this.StartScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(247)))));
            this.StartScreen.Controls.Add(this.label2);
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
            // players
            // 
            this.players.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(247)))));
            this.players.Controls.Add(this.listView1);
            this.players.Controls.Add(this.textBox1);
            this.players.Location = new System.Drawing.Point(4, 25);
            this.players.Name = "players";
            this.players.Padding = new System.Windows.Forms.Padding(3);
            this.players.Size = new System.Drawing.Size(448, 541);
            this.players.TabIndex = 1;
            this.players.Text = "Players";
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-4, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(460, 531);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(452, 22);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 10;
            this.label2.Click += new System.EventHandler(this.label2_Click);
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
            this.players.ResumeLayout(false);
            this.players.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GameStartButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TabControl StartGameTab;
        private System.Windows.Forms.TabPage StartScreen;
        private System.Windows.Forms.TabPage players;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
    }
}
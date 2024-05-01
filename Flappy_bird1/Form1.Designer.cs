namespace Flappy_bird1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ScoreText = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.FlappyBird = new System.Windows.Forms.PictureBox();
            this.Pipe_lower = new System.Windows.Forms.PictureBox();
            this.Pipe_upper = new System.Windows.Forms.PictureBox();
            this.Ground = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe_lower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe_upper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreText
            // 
            this.ScoreText.AutoSize = true;
            this.ScoreText.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreText.Location = new System.Drawing.Point(12, 9);
            this.ScoreText.Name = "ScoreText";
            this.ScoreText.Size = new System.Drawing.Size(158, 45);
            this.ScoreText.TabIndex = 2;
            this.ScoreText.Text = "SCORE";
            this.ScoreText.Click += new System.EventHandler(this.label1_Click);
            // 
            // GameTimer
            // 
            this.GameTimer.Enabled = true;
            this.GameTimer.Interval = 20;
            this.GameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // FlappyBird
            // 
            this.FlappyBird.Image = global::Flappy_bird1.Properties.Resources.photo1711521563;
            this.FlappyBird.Location = new System.Drawing.Point(149, 193);
            this.FlappyBird.Name = "FlappyBird";
            this.FlappyBird.Size = new System.Drawing.Size(85, 59);
            this.FlappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.FlappyBird.TabIndex = 5;
            this.FlappyBird.TabStop = false;
            this.FlappyBird.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // Pipe_lower
            // 
            this.Pipe_lower.Image = ((System.Drawing.Image)(resources.GetObject("Pipe_lower.Image")));
            this.Pipe_lower.Location = new System.Drawing.Point(449, 345);
            this.Pipe_lower.Name = "Pipe_lower";
            this.Pipe_lower.Size = new System.Drawing.Size(94, 244);
            this.Pipe_lower.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pipe_lower.TabIndex = 4;
            this.Pipe_lower.TabStop = false;
            this.Pipe_lower.Click += new System.EventHandler(this.Pipe_lower_Click);
            // 
            // Pipe_upper
            // 
            this.Pipe_upper.Image = ((System.Drawing.Image)(resources.GetObject("Pipe_upper.Image")));
            this.Pipe_upper.Location = new System.Drawing.Point(449, -78);
            this.Pipe_upper.Name = "Pipe_upper";
            this.Pipe_upper.Size = new System.Drawing.Size(94, 262);
            this.Pipe_upper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pipe_upper.TabIndex = 1;
            this.Pipe_upper.TabStop = false;
            this.Pipe_upper.Click += new System.EventHandler(this.Pipe_upper_Click);
            // 
            // Ground
            // 
            this.Ground.Image = ((System.Drawing.Image)(resources.GetObject("Ground.Image")));
            this.Ground.Location = new System.Drawing.Point(-8, 513);
            this.Ground.Name = "Ground";
            this.Ground.Size = new System.Drawing.Size(795, 76);
            this.Ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ground.TabIndex = 0;
            this.Ground.TabStop = false;
            this.Ground.Click += new System.EventHandler(this.Ground_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Flappy_bird1.Properties.Resources.clouds;
            this.pictureBox1.Location = new System.Drawing.Point(-43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 187);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(745, 583);
            this.Controls.Add(this.FlappyBird);
            this.Controls.Add(this.Pipe_lower);
            this.Controls.Add(this.ScoreText);
            this.Controls.Add(this.Pipe_upper);
            this.Controls.Add(this.Ground);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Flappy Bird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GameKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.FlappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe_lower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pipe_upper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Ground;
        private System.Windows.Forms.PictureBox Pipe_upper;
        private System.Windows.Forms.Label ScoreText;
        private System.Windows.Forms.PictureBox Pipe_lower;
        private System.Windows.Forms.PictureBox FlappyBird;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


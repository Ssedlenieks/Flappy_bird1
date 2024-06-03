namespace Flappy_bird1
{
    partial class GameOver
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
            this.GOver_Text = new System.Windows.Forms.Label();
            this.resetbutotn = new System.Windows.Forms.Button();
            this.Return_to_ms = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // GOver_Text
            // 
            this.GOver_Text.AutoSize = true;
            this.GOver_Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(247)))));
            this.GOver_Text.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GOver_Text.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GOver_Text.Location = new System.Drawing.Point(239, 149);
            this.GOver_Text.Name = "GOver_Text";
            this.GOver_Text.Size = new System.Drawing.Size(200, 72);
            this.GOver_Text.TabIndex = 0;
            this.GOver_Text.Text = "You Lost";
            this.GOver_Text.Click += new System.EventHandler(this.label1_Click);
            // 
            // resetbutotn
            // 
            this.resetbutotn.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetbutotn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.resetbutotn.Location = new System.Drawing.Point(158, 235);
            this.resetbutotn.Name = "resetbutotn";
            this.resetbutotn.Size = new System.Drawing.Size(163, 92);
            this.resetbutotn.TabIndex = 2;
            this.resetbutotn.Text = "Try Again";
            this.resetbutotn.UseVisualStyleBackColor = true;
            this.resetbutotn.Click += new System.EventHandler(this.resetgame);
            // 
            // Return_to_ms
            // 
            this.Return_to_ms.Font = new System.Drawing.Font("Agency FB", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_to_ms.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Return_to_ms.Location = new System.Drawing.Point(348, 235);
            this.Return_to_ms.Name = "Return_to_ms";
            this.Return_to_ms.Size = new System.Drawing.Size(162, 92);
            this.Return_to_ms.TabIndex = 3;
            this.Return_to_ms.Text = "Return to main screen";
            this.Return_to_ms.UseVisualStyleBackColor = true;
            this.Return_to_ms.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Flappy_bird1.Properties.Resources.clouds;
            this.pictureBox1.Location = new System.Drawing.Point(0, -90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(680, 222);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Flappy_bird1.Properties.Resources.clouds;
            this.pictureBox2.Location = new System.Drawing.Point(-353, 267);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1033, 194);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(247)))));
            this.ClientSize = new System.Drawing.Size(679, 456);
            this.Controls.Add(this.Return_to_ms);
            this.Controls.Add(this.resetbutotn);
            this.Controls.Add(this.GOver_Text);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(128)))), ((int)(((byte)(247)))));
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "e";
            this.Load += new System.EventHandler(this.GameOver_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GOver_Text;
        private System.Windows.Forms.Button resetbutotn;
        private System.Windows.Forms.Button Return_to_ms;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
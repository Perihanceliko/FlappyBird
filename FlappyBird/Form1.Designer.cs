namespace FlappyBird
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            FlappyBird_pictureBox1 = new PictureBox();
            Flying_timer1 = new System.Windows.Forms.Timer(components);
            Fall_down_timer1 = new System.Windows.Forms.Timer(components);
            Moving_Pipes_timer1 = new System.Windows.Forms.Timer(components);
            GameOver_label1 = new Label();
            NewGame_label1 = new Label();
            FinalScore_label1 = new Label();
            Score_label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)FlappyBird_pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // FlappyBird_pictureBox1
            // 
            FlappyBird_pictureBox1.BackColor = Color.Yellow;
            FlappyBird_pictureBox1.Image = Properties.Resources.FlappyBird2;
            FlappyBird_pictureBox1.Location = new Point(120, 280);
            FlappyBird_pictureBox1.Name = "FlappyBird_pictureBox1";
            FlappyBird_pictureBox1.Size = new Size(170, 120);
            FlappyBird_pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            FlappyBird_pictureBox1.TabIndex = 0;
            FlappyBird_pictureBox1.TabStop = false;
            // 
            // Flying_timer1
            // 
            Flying_timer1.Enabled = true;
            Flying_timer1.Tick += Flying_timer1_Tick;
            // 
            // Fall_down_timer1
            // 
            Fall_down_timer1.Enabled = true;
            Fall_down_timer1.Tick += Fall_down_timer1_Tick;
            // 
            // Moving_Pipes_timer1
            // 
            Moving_Pipes_timer1.Enabled = true;
            Moving_Pipes_timer1.Interval = 50;
            Moving_Pipes_timer1.Tick += Moving_Pipes_timer1_Tick;
            // 
            // GameOver_label1
            // 
            GameOver_label1.AutoSize = true;
            GameOver_label1.BackColor = Color.White;
            GameOver_label1.Font = new Font("Onyx", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GameOver_label1.ForeColor = Color.Black;
            GameOver_label1.Location = new Point(423, 200);
            GameOver_label1.Name = "GameOver_label1";
            GameOver_label1.Size = new Size(201, 67);
            GameOver_label1.TabIndex = 1;
            GameOver_label1.Text = "GAME OVER";
            GameOver_label1.Visible = false;
            // 
            // NewGame_label1
            // 
            NewGame_label1.AutoSize = true;
            NewGame_label1.BackColor = Color.OrangeRed;
            NewGame_label1.BorderStyle = BorderStyle.FixedSingle;
            NewGame_label1.Font = new Font("Onyx", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NewGame_label1.ForeColor = Color.White;
            NewGame_label1.Location = new Point(428, 339);
            NewGame_label1.Name = "NewGame_label1";
            NewGame_label1.Size = new Size(190, 69);
            NewGame_label1.TabIndex = 2;
            NewGame_label1.Text = "NEW GAME";
            NewGame_label1.Visible = false;
            NewGame_label1.Click += NewGame_label1_Click;
            NewGame_label1.MouseLeave += NewGame_label1_MouseLeave;
            NewGame_label1.MouseHover += NewGame_label1_MouseHover;
            // 
            // FinalScore_label1
            // 
            FinalScore_label1.AutoSize = true;
            FinalScore_label1.BackColor = Color.White;
            FinalScore_label1.Font = new Font("Onyx", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FinalScore_label1.ForeColor = Color.Black;
            FinalScore_label1.Location = new Point(423, 267);
            FinalScore_label1.Name = "FinalScore_label1";
            FinalScore_label1.Size = new Size(246, 67);
            FinalScore_label1.TabIndex = 3;
            FinalScore_label1.Text = "YOUR SCORE:0";
            FinalScore_label1.Visible = false;
            // 
            // Score_label1
            // 
            Score_label1.AutoSize = true;
            Score_label1.BackColor = Color.Transparent;
            Score_label1.Font = new Font("Onyx", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Score_label1.ForeColor = Color.Black;
            Score_label1.Location = new Point(934, 9);
            Score_label1.Name = "Score_label1";
            Score_label1.Size = new Size(47, 67);
            Score_label1.TabIndex = 4;
            Score_label1.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(997, 753);
            Controls.Add(Score_label1);
            Controls.Add(FinalScore_label1);
            Controls.Add(NewGame_label1);
            Controls.Add(GameOver_label1);
            Controls.Add(FlappyBird_pictureBox1);
            KeyPreview = true;
            Name = "Form1";
            Text = "FlappyBird";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown_1;
            MouseClick += Form1_MouseClick_1;
            ((System.ComponentModel.ISupportInitialize)FlappyBird_pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox FlappyBird_pictureBox1;
        private System.Windows.Forms.Timer Flying_timer1;
        private System.Windows.Forms.Timer Fall_down_timer1;
        private System.Windows.Forms.Timer Moving_Pipes_timer1;
        private Label GameOver_label1;
        private Label NewGame_label1;
        private Label FinalScore_label1;
        private Label Score_label1;
    }
}

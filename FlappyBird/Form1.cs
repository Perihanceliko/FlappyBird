using System;
using System.Drawing;
using System.Windows.Forms;


namespace FlappyBird
{
    public partial class Form1 : Form
    {
        bool Fly_Boolean = false;

        int Target_Y_Location = 800;
        


        Random rnd = new Random();

        int Pipe_Timer_Counter = 39;

        bool isGameOver = false;

        int Score = 0;
        int Pipe_Passed = 0;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Flying_timer1.Start();
            Fall_down_timer1.Start();
            Moving_Pipes_timer1.Start();
            this.KeyPreview = true;
        }
        private void Flying_timer1_Tick(object sender, EventArgs e)
        {
            if (Fly_Boolean)
            {
                FlappyBird_pictureBox1.Image = Properties.Resources.FlappyBird1;
                Fly_Boolean = false;
            }
            else
            {
                FlappyBird_pictureBox1.Image = Properties.Resources.FlappyBird2;
                Fly_Boolean = true;
            }
        }

        private void Fall_down_timer1_Tick(object sender, EventArgs e)
        {
            if (FlappyBird_pictureBox1.Top != Target_Y_Location)
            {
                if (FlappyBird_pictureBox1.Top > Target_Y_Location)
                {
                    FlappyBird_pictureBox1.Top = FlappyBird_pictureBox1.Top - 10;
                }
                else if (FlappyBird_pictureBox1.Top < Target_Y_Location)
                {
                    FlappyBird_pictureBox1.Top = FlappyBird_pictureBox1.Top + 10;
                }
            }
            else
            {
                if (Target_Y_Location != 800)
                {
                    Target_Y_Location = 800;
                }
                else
                {
                    NewGame_label1.Visible = true;
                    GameOver_label1.Visible = true;

                    FinalScore_label1.Text = "YOUR SCORE: " + Score.ToString();
                    FinalScore_label1.Visible = true;

                    NewGame_label1.BringToFront() ;
                    GameOver_label1.BringToFront();
                    FinalScore_label1.BringToFront();

                    Flying_timer1.Enabled = false;
                    Fall_down_timer1.Enabled = false;
                    Moving_Pipes_timer1.Enabled = false;
                }
            }
        }
        // kuþun zýplamasý için mouse týklamasý 
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isGameOver)
            {
                int jumpHeight = 80;
                int newTarget = FlappyBird_pictureBox1.Top - jumpHeight;

                Target_Y_Location = newTarget < 0 ? 0 : newTarget;


            }
        }
        // kuþun zýplamasý için boþluk tuþu
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isGameOver && e.KeyCode == Keys.Space)
            {
                int jumpHeight = 80;
                int newTarget = FlappyBird_pictureBox1.Top - jumpHeight;

                Target_Y_Location = newTarget < 0 ? 0 : newTarget;


            }
        }

        private void FlappyBird_pictureBox1_Click(object sender,EventArgs e)
        {
            if (!isGameOver)
            {
                int jumpHeight = 80;
                int newTarget = FlappyBird_pictureBox1.Top - jumpHeight;

                Target_Y_Location = newTarget < 0 ? 0 : newTarget;
            }
        }

        public void Create_Upper_n_Lower_Pipes()
        {
            
            var p = new PictureBox();
            p.BackColor = Color.DarkGreen;
            p.BorderStyle = BorderStyle.None;
            p.Size = new Size(170, 100);
            int random_Y = rnd.Next(5, 27);
            int random_Y_multiple_10 = random_Y * 10;
            p.Location = new Point(1000, random_Y_multiple_10);
            p.Image = Properties.Resources.PipeHead;
            p.Visible = true;
            this.Controls.Add(p);

            var p2 = new PictureBox();

            p2.BackColor = Color.DarkGreen;
            p2.BorderStyle = BorderStyle.None;
            p2.Size = new Size(150, random_Y_multiple_10);
            p2.Location = new Point(1010, 0);
            p2.BackgroundImage = Properties.Resources.PipeBody;
            p2.BackgroundImageLayout = ImageLayout.Tile;
            p2.Visible = true;
            this.Controls.Add(p2);

            var p3 = new PictureBox();

            p3.BackColor = Color.DarkGreen;
            p3.BorderStyle = BorderStyle.None;
            p3.Size = new Size(170, 100);
            p3.Location = new Point(1000, random_Y_multiple_10 + 340);
            p3.Image = Properties.Resources.PipeHead;
            p3.Visible = true;
            this.Controls.Add(p3);

            var p4 = new PictureBox();

            p4.BackColor = Color.DarkGreen;
            p4.BorderStyle = BorderStyle.None;
            p4.Size = new Size(150, 800 - (random_Y_multiple_10 + 340));
            p4.Location = new Point(1010, (random_Y_multiple_10 + 340) + 100);
            p4.BackgroundImage = Properties.Resources.PipeBody;
            p4.BackgroundImageLayout = ImageLayout.Tile;
            p4.Visible = true;
            this.Controls.Add(p4);


            p.BringToFront();
            p2.BringToFront();
            p3.BringToFront();
            p4.BringToFront();
        }

        private void Moving_Pipes_timer1_Tick(object sender, EventArgs e)
        {
            Pipe_Timer_Counter++;

            if (Pipe_Timer_Counter == 40)
            {
                Create_Upper_n_Lower_Pipes();
                Pipe_Timer_Counter = 0;
            }

            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    

                    if (c is PictureBox pipes && pipes.BackColor == Color.DarkGreen)
                    {
                        pipes.Left = pipes.Left - 10;

                        if(FlappyBird_pictureBox1.Bounds.IntersectsWith(pipes.Bounds))
                        {

                            Check_Pipe_Crush(pipes);
                        }

                        if (pipes.Left < -170)
                        {
                            pipes.Dispose();
                        }

                        if(pipes.Left == -50 && pipes.Visible)
                        {
                            Pipe_Passed++;

                            if(Pipe_Passed == 4)
                            {
                                Score = Score + 10;
                                Score_label1.Text = Score.ToString();
                                Pipe_Passed = 0;
                            }
                        }

                    }
                }
            }
        }
        public void GameOver()
        {
            Target_Y_Location = 800;
            isGameOver = true;
            Moving_Pipes_timer1.Enabled = false;
            Flying_timer1.Stop();
            Moving_Pipes_timer1.Stop();
            Fall_down_timer1.Start();// kuþ düþmeye devam etsin
            GameOver_label1.Visible = true;
            NewGame_label1.Visible = true;

            GameOver_label1.BringToFront();
            NewGame_label1.BringToFront();
        }

        private void Check_Pipe_Crush(PictureBox pipes)
        {
            
            if (pipes.BackColor == Color.DarkGreen && pipes.Visible)
            {
                if (FlappyBird_pictureBox1.Bounds.IntersectsWith(pipes.Bounds))
                {
                    GameOver(); // Oyun durdurulsun
                }
            }

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (!isGameOver)
            {
                int jumpHeight = 80;
                int newTarget = FlappyBird_pictureBox1.Top - jumpHeight;

                Target_Y_Location = newTarget < 0 ? 0 : newTarget;
            }

        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (!isGameOver && e.KeyCode == Keys.Space)
            {
                int jumpHeight = 80;
                int newTarget = FlappyBird_pictureBox1.Top - jumpHeight;

                Target_Y_Location = newTarget < 0 ? 0 : newTarget;
            }
        }

        private void NewGame_label1_MouseHover(object sender, EventArgs e)
        {
            NewGame_label1.BackColor = Color.Violet;
        }

        private void NewGame_label1_MouseLeave(object sender, EventArgs e)
        {
            NewGame_label1.BackColor = Color.OrangeRed;
        }

        private void NewGame_label1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(PictureBox))
                {
                    PictureBox? pipes = c as PictureBox;
                    if (pipes !=null && pipes.BackColor == Color.DarkGreen)
                    {
                        pipes.Visible = false;
                    }
                }
            }

            Target_Y_Location = 800;
            Pipe_Timer_Counter = 39;
            isGameOver = false;
            FlappyBird_pictureBox1.Location = new Point(120, 280);
            GameOver_label1.Visible = false;
            NewGame_label1.Visible = false;
            Score_label1.Text = "0";
            FinalScore_label1.Text = "YOUR SCORE: 0";
            FinalScore_label1.Visible = false;
            Score = 0;
            Pipe_Passed = 0;
            Flying_timer1.Enabled = true;
            Moving_Pipes_timer1.Enabled = true;
            Fall_down_timer1.Enabled = true;
        }
    }
}

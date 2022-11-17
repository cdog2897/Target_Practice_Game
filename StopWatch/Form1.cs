using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public static Stopwatch watch = new Stopwatch();
        private Random random = new Random();
        public int Countdown { get; set; }
        public int Lives { get; set; }
        public int Hits { get; set; }
        public bool TargetShow { get; set; }
        public Form1()
        {
            InitializeComponent();
            Lives = 3;
            Hits = 0;
            TargetShow = false;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Countdown = 30 - ((int)watch.ElapsedMilliseconds / 1000);
            if (Countdown == 0)
            {
                gameOver();
            }
            label1.Text = Countdown.ToString();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(TargetShow)
            {
                btnTarget.Left = random.Next(0, panel1.Width);
                btnTarget.Top = random.Next(0, panel1.Height);
                btnTarget.Visible = true;
            }
            else
            {
                btnTarget.Visible = false;
            }
            TargetShow = !TargetShow;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer2.Enabled = true;
            tmrBomb.Enabled = true;
            watch.Start();
        }

        // restart
        private void button3_Click(object sender, EventArgs e)
        {
            watch.Restart();
            timer1.Enabled = true;
            timer2.Enabled = true;
            tmrBomb.Enabled = true;
            lblCurrentScore.Text = "0";
            Lives = 3;
            Hits = 0;

            heart1.Visible = true;
            heart2.Visible = true;
            heart3.Visible = true;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Lives--;
            updateLives();
        }

        private void gameOver()
        {
            watch.Stop();
            timer1.Enabled = false;
            timer2.Enabled = false;
            tmrBomb.Enabled = false;
            btnTarget.Visible = false;
            // update high score
            if(Int32.Parse(lblCurrentScore.Text) > Int32.Parse(lblHighScore.Text))
            {
                lblHighScore.Text = lblCurrentScore.Text.ToString();
            }
            button1.Enabled = false;

            MessageBox.Show("Game over!");
            btnReset.Enabled = true;

        }


        private void Target_ClickEvent_Down(object sender, MouseEventArgs e)
        {
            btnTarget.Visible = false;
            Hits++;
            lblCurrentScore.Text = Hits.ToString();
        }

        private void Bomb_ClickEvent(object sender, MouseEventArgs e)
        {
            Lives--;
            updateLives();
        }

        private void updateLives()
        {
            switch (Lives)
            {
                case 0:
                    heart1.Visible = false;
                    heart2.Visible = false;
                    heart3.Visible = false;
                    gameOver();
                    break;
                case 1:
                    heart1.Visible = false;
                    heart2.Visible = false;
                    heart3.Visible = true;
                    break;
                case 2:
                    heart1.Visible = false;
                    heart2.Visible = true;
                    heart3.Visible = true;
                    break;
                case 3:
                    heart1.Visible = true;
                    heart2.Visible = true;
                    heart3.Visible = true;
                    break;
            }
        }

        private void tmrBomb_Tick(object sender, EventArgs e)
        {
            if(random.Next(0, 10) > 7)
            {
                picBomb.Visible = !picBomb.Visible;

            }
        }
    }
}

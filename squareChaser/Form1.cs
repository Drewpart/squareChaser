using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace squareChaser
{
    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(165, 120, 40, 40);
        Rectangle player2 = new Rectangle(360, 120, 40, 40);
        Rectangle ball = new Rectangle(295, 195, 10, 10);
        Rectangle speed = new Rectangle(170, 200, 10, 10);

        int player1Score = 0;
        int player2Score = 0;

        int playerSpeed2 = 2;
        int playerSpeed1 = 2;
        int ballSpot;
        int speedSpot;

        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftArrow = false;
        bool rightArrow = false;

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush SolidBrush = new SolidBrush(Color.Orange);
        SolidBrush YellowBrush = new SolidBrush(Color.Yellow);

        Random ballLoca = new Random();
        Random speedMvmt = new Random();

        


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftArrow = true;
                    break;
                case Keys.Right:
                    rightArrow = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftArrow = false;
                    break;
                case Keys.Right:
                    rightArrow = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= playerSpeed1;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += playerSpeed1;
            }
            if (aDown == true && player1.X > 0)
            {
                player1.X -= playerSpeed1;
            }
            if (dDown == true && player1.X < this.Height - player1.Height)
            {
                player1.X += playerSpeed1;
            }

            //move player 2 
            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= playerSpeed2;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += playerSpeed2;

            }
            if (leftArrow == true && player2.X > 0)
            {
                player2.X -= playerSpeed2;
            }
            if (rightArrow == true && player2.X < this.Height - player2.Height)
            {
                player2.X += playerSpeed2;
            }

            // make it so when the players interact with the ball it changes the location and adds a point

            if (player1.IntersectsWith(ball))
            {
                ballSpot = ballLoca.Next(1, 11);
                p1Score.Text = $"{player1Score++}";
                SoundPlayer bitNoise = new SoundPlayer(Properties.Resources._238283__meroleroman7__8_bit_noise);
                bitNoise.Play();


                // play sound

                // move ball to random spot
                if (ballSpot == 1)
                {
                    ball.X = 180;
                    ball.Y = 265;
                }
                else if (ballSpot == 2)
                {
                    ball.X = 129;
                    ball.Y = 170;
                }
                else if (ballSpot == 3)
                {
                    ball.X = 92;
                    ball.Y = 350;
                }
                else if (ballSpot == 4)
                {
                    ball.X = 35;
                    ball.Y = 105;
                }
                else if (ballSpot == 5)
                {
                    ball.X = 159;
                    ball.Y = 95;
                }
                else if (ballSpot == 6)
                {
                    ball.X = 295;
                    ball.Y = 321;
                }
                else if (ballSpot == 7)
                {
                    ball.X = 299;
                    ball.Y = 299;
                }
                else if (ballSpot == 8)
                {
                    ball.X = 21;
                    ball.Y = 420;
                }
                else if (ballSpot == 9)
                {
                    ball.X = 12;
                    ball.Y = 198;
                }
                else if (ballSpot == 10)
                {
                    ball.X = 10;
                    ball.Y = 23;
                }
            }
            if (player2.IntersectsWith(ball))
            {
                ballSpot = ballLoca.Next(1, 11);
                p2Score.Text = $"{player2Score++}";
                SoundPlayer bitNoise = new SoundPlayer(Properties.Resources._238283__meroleroman7__8_bit_noise);
                bitNoise.Play();

                if (ballSpot == 1)
                {
                    ball.X = 180;
                    ball.Y = 265;
                }
                else if (ballSpot == 2)
                {
                    ball.X = 129;
                    ball.Y = 170;
                }
                else if (ballSpot == 3)
                {
                    ball.X = 92;
                    ball.Y = 350;
                }
                else if (ballSpot == 4)
                {
                    ball.X = 35;
                    ball.Y = 105;
                }
                else if (ballSpot == 5)
                {
                    ball.X = 159;
                    ball.Y = 95;
                }
                else if (ballSpot == 6)
                {
                    ball.X = 295;
                    ball.Y = 321;
                }
                else if (ballSpot == 7)
                {
                    ball.X = 299;
                    ball.Y = 299;
                }
                else if (ballSpot == 8)
                {
                    ball.X = 21;
                    ball.Y = 420;
                }
                else if (ballSpot == 9)
                {
                    ball.X = 12;
                    ball.Y = 198;
                }
                else if (ballSpot == 10)
                {
                    ball.X = 10;
                    ball.Y = 23;
                }

            }

            if (player1.IntersectsWith(speed))
            {
                playerSpeed1++;
                SoundPlayer bitNoise = new SoundPlayer(Properties.Resources._238283__meroleroman7__8_bit_noise);
                bitNoise.Play();
                speedSpot = speedMvmt.Next(1, 11);


                if (speedSpot == 1)
                {
                    speed.X = 120;
                    speed.Y = 215;
                }
                else if (speedSpot == 2)
                {
                    speed.X = 62;
                    speed.Y = 234;
                }
                else if (speedSpot == 3)
                {
                    speed.X = 292;
                    speed.Y = 150;
                }
                else if (speedSpot == 4)
                {
                    speed.X = 76;
                    speed.Y = 203;
                }
                else if (speedSpot == 5)
                {
                    speed.X = 100;
                    speed.Y = 265;
                }
                else if (speedSpot == 6)
                {
                    speed.X = 154;
                    speed.Y = 213;
                }
                else if (speedSpot == 7)
                {
                    speed.X = 199;
                    speed.Y = 199;
                }
                else if (speedSpot == 8)
                {
                    speed.X = 34;
                    speed.Y = 342;
                }
                else if (speedSpot == 9)
                {
                    speed.X = 345;
                    speed.Y = 355;
                }
                else if (speedSpot == 10)
                {
                    speed.X = 23;
                    speed.Y = 27;
                }
            }
            if (player2.IntersectsWith(speed))
            {
                playerSpeed2++;
                SoundPlayer bitNoise = new SoundPlayer(Properties.Resources._238283__meroleroman7__8_bit_noise);
                bitNoise.Play();
                speedSpot = speedMvmt.Next(1, 11);

                if (speedSpot == 1)
                {
                    speed.X = 120;
                    speed.Y = 215;
                }
                else if (speedSpot == 2)
                {
                    speed.X = 62;
                    speed.Y = 234;
                }
                else if (speedSpot == 3)
                {
                    speed.X = 292;
                    speed.Y = 150;
                }
                else if (speedSpot == 4)
                {
                    speed.X = 76;
                    speed.Y = 203;
                }
                else if (speedSpot == 5)
                {
                    speed.X = 100;
                    speed.Y = 265;
                }
                else if (speedSpot == 6)
                {
                    speed.X = 154;
                    speed.Y = 213;
                }
                else if (speedSpot == 7)
                {
                    speed.X = 199;
                    speed.Y = 199;
                }
                else if (speedSpot == 8)
                {
                    speed.X = 34;
                    speed.Y = 342;
                }
                else if (speedSpot == 9)
                {
                    speed.X = 345;
                    speed.Y = 355;
                }
                else if (speedSpot == 10)
                {
                    speed.X = 23;
                    speed.Y = 27;
                }
            }



            //Check player score and determine the winner
            if (player1Score == 8)
            {
                endLabel.Text = $"Would You Like To Play Again?";
                noButton.Visible = true;
                yesButton.Visible = true;
                SoundPlayer vivtoryNoise = new SoundPlayer(Properties.Resources._462250__silverillusionist__victory_sound_1);
                vivtoryNoise.Play();
            }
            if (player2Score == 8)
            {
                endLabel.Text = $"Would You Like To Play Again?";
                noButton.Visible = true;
                yesButton.Visible = true;
                SoundPlayer vivtoryNoise = new SoundPlayer(Properties.Resources._462250__silverillusionist__victory_sound_1);
                vivtoryNoise.Play();
            }
            Refresh();


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(blueBrush, player1);
            e.Graphics.FillRectangle(SolidBrush, player2);
            e.Graphics.FillRectangle(whiteBrush, ball);
            e.Graphics.FillRectangle(YellowBrush, speed);

            // p1Score.Text = $"speed:{speed.X}, {speed.Y}, {speed.Width}, {speed.Height}";
            //  p2Score.Text = $"p1:{player1.X}, {player1.Y}, {player1.Width}, {player1.Height}";
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }

}

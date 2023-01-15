using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake
{
    public partial class Gameplay : Form
    {

        private List<Object> Snake = new List<Object>();
        private Object food = new Object();
        private List<NotSnake> Obstacle = new List<NotSnake>();

        int maxWidth;
        int maxHeight;
        int score;
        Random rand = new Random();
        bool goLeft, goRight, goDown, goUp;


        public Gameplay()
        {
            InitializeComponent();

            Settings2.LoadSettings2();

            picCanvas.BackColor = Settings2.BackgroundColor;
            GameTimer.Interval = Settings2.Velocity;


            RestartGame();
        }

        private void Gameplay_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                Scoreboard scoreboardForm = new Scoreboard();
                scoreboardForm.Show();
            }
            else
            {
                Leaderboard.Temp = 0;
                Leaderboard.Player = null;
                Application.Exit();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left && Settings2.Directions != "right")
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right && Settings2.Directions != "left")
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up && Settings2.Directions != "down")
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down && Settings2.Directions != "up")
            {
                goDown = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

            if (goLeft)
            {
                Settings2.Directions = "left";
            }
            if (goRight) 
            {
                Settings2.Directions = "right";
            }
            if (goDown)
            {
                Settings2.Directions = "down";
            }
            if (goUp) 
            {
                Settings2.Directions = "up";
            }

            for (int i = Snake.Count - 1; i >=0; i--)
            {
                if (i == 0)
                {
                    switch (Settings2.Directions)
                    {
                        case"left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                    }

                    if (Settings2.GameplayType)
                    {
                        if (Snake[i].X < 0)
                        {
                            Snake[i].X = maxWidth;
                        }

                        if (Snake[i].X > maxWidth)
                        {
                            Snake[i].X = 0;
                        }

                        if (Snake[i].Y < 0)
                        {
                            Snake[i].Y = maxHeight;
                        }

                        if (Snake[i].Y > maxHeight)
                        {
                            Snake[i].Y = 0;
                        }
                    }
                    else
                    {
                        if (Snake[i].X < 0)
                        {
                            GameOver();
                        }

                        if (Snake[i].X > maxWidth)
                        {
                            GameOver();
                        }

                        if (Snake[i].Y < 0)
                        {
                            GameOver();
                        }

                        if (Snake[i].Y > maxHeight)
                        {
                            GameOver();
                        }
                    }
                        if (Snake[i].X == food.X && Snake[i].Y == food.Y)
                    {
                        EatFood();
                    }

                    for (int j = 2; j < Snake.Count; j++)
                    {
                        if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            GameOver();
                        }
                        if (Snake[j].X == food.X && Snake[j].Y == food.Y)
                        {
                            EatFood();
                        }
                    }
                    for (int k = 0; k < Obstacle.Count; k++)
                    {
                        if (Snake[i].X == Obstacle[k].X && Snake[i].Y == Obstacle[k].Y)
                        {
                            GameOver();
                        }
                    }
                }
            else
            {
                Snake[i].X = Snake[i - 1].X;
                Snake[i].Y = Snake[i - 1].Y;
            }
            }

            picCanvas.Invalidate();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            Brush snakeColor;

            for (int i = 0; i < Snake.Count; i++)
            {
                if( i%2 == 0)
                    snakeColor= Settings2.HeadColor;
                else
                    snakeColor = Settings2.BodyColor;

                canvas.FillRectangle(snakeColor, new Rectangle
                   (
                    Snake[i].X * Settings2.Width,
                    Snake[i].Y * Settings2.Height,
                    Settings2.Width, Settings2.Height
                    ));
            }

                canvas.FillRectangle(Settings2.FoodColor, new Rectangle
                   (
                    food.X * Settings2.Width,
                    food.Y * Settings2.Height,
                    Settings2.Width, Settings2.Height
                    ));

            for (int j = 0; j < Obstacle.Count; j++)
            {
                canvas.FillRectangle(Settings2.ObstacleColor, new Rectangle
                   (
                    Obstacle[j].X * Settings2.Width,
                    Obstacle[j].Y * Settings2.Height,
                    Settings2.Width, Settings2.Height
                    ));
            }

        }

        private void RestartGame()
        {
            GameTimer.Start();
            maxWidth = picCanvas.Width / Settings2.Width - 1;
            maxHeight = picCanvas.Height / Settings2.Height - 1;

            Snake.Clear();
            Obstacle.Clear();
            score = 0;
            ScoreText.Text = "PUNKTY: " + score;

            Object head = new Object { X = maxWidth/2, Y = maxHeight/2 };
            Snake.Add(head);

            if(Settings2.Obstacles)
            {
                for (int i = 0; i < 200/Settings2.Width; i++)
                {
                    NotSnake obst = new NotSnake
                    {
                        X = rand.Next(1, maxWidth),
                        Y = rand.Next(1, maxHeight)
                    };
                   obst.ObstPrevent(maxWidth, maxHeight, rand);

                    Obstacle.Add(obst);
                }
            }



            food = GenerateFood();



        }

        private void EatFood()
        {
            score += 1;
            ScoreText.Text = "PUNKTY: " + score;
            Object body = new Object
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(body);

            food = GenerateFood();
        }

        private Object GenerateFood()
        {
            
            food = new Object { X = rand.Next(2, maxWidth), Y =rand.Next(2, maxWidth) };
            for (int k = 0; k < Obstacle.Count; k++)
            {
                while (food.X == Obstacle[k].X && food.Y == Obstacle[k].Y)
                {
                    food = new Object { X = rand.Next(1, maxWidth), Y = rand.Next(1, maxWidth) };
                }
            }
            return food;
        }

        private void GameOver()
        {
            GameTimer.Stop();
            Settings2.Directions = null;
            Leaderboard.Temp = score;
            if (score > 0)
            {
                GameOver gameover = new GameOver();
                gameover.Show();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }

        }

    }
}

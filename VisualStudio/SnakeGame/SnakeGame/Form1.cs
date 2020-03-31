using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakeGame
{
    public partial class Form1 : Form
    {

        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();
        public Form1()
        {
            InitializeComponent();

            // Set settings to default
            new Settings();

            // Set game speed and start timer
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();

            // Start New game
            StartGame();
        }


        private void StartGame()
        {
            LabelGameOver.Visible = false;
            // Reset the game settings the first time

            new Settings();

            Settings.GameOver = false;

            Snake.Clear(); // Don't let any other snakes appear from the prev game
            Circle head = new Circle();
            head.X = 10;
            head.Y = 5;
            Snake.Add(head);

            LabelScore.Text = Settings.Score.ToString();
            GenerateFood();
        }

        // Place random food game
        private void GenerateFood()
        {
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            Random random = new Random();
            food = new Circle();
            food.X = random.Next(0, maxXPos);
            food.Y = random.Next(0, maxYPos);
        }

        private void UpdateScreen(object sender, EventArgs e)
        {
            // Check for Game Over
            if (Settings.GameOver == true)
            {
                // Check if Enter is pressed
                if (Input.KeyPressed(Keys.Enter))
                {
                    StartGame();
                }
            }

            else
            {
                if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
                    Settings.direction = Direction.Right;
                else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
                    Settings.direction = Direction.Left;
                else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
                    Settings.direction = Direction.Up;
                else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
                    Settings.direction = Direction.Down;

                MovePlayer();
            }

            pbCanvas.Invalidate(); // Refreshes the whole canvas
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if (!Settings.GameOver)
            {
                /*
                 We make sure that food and the snake will be created every time the pbCanvas method is triggered
                 */
                // Set color of snake
                Brush snakeColor;
                // Draw snake
                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                        snakeColor = Brushes.Black;
                    else
                        snakeColor = Brushes.Green;

                    // Draw snake
                    canvas.FillEllipse(snakeColor,
                        new Rectangle(Snake[i].X * Settings.Width,
                                      Snake[i].Y * Settings.Height,
                                      Settings.Width, Settings.Height));

                    // Draw Food
                    canvas.FillEllipse(Brushes.Red,
                        new Rectangle(food.X * Settings.Width,
                                      food.Y * Settings.Height,
                                      Settings.Width, Settings.Height));
                }
            }

            else
            {
                string gameOver = "Game over\nYour final score is:" + Settings.Score + "\nPress ENTER to try again";
                LabelGameOver.Text = gameOver;
                LabelGameOver.Visible = true;
            }
        }

        private void MovePlayer()
        {

            int i = 0;
            int ii = Snake.Count - 1;

            switch (Settings.direction)
            {
                case Direction.Right:
                    Snake[i].X++;
                    break;
                case Direction.Left:
                    Snake[i].X--;
                    break;
                case Direction.Up:
                    Snake[i].Y--;
                    break;
                case Direction.Down:
                    Snake[i].Y++;
                    break;
            }


            // Get maximum X and Y Pos
            int maxXPos = pbCanvas.Size.Width / Settings.Width;
            int maxYPos = pbCanvas.Size.Height / Settings.Height;

            // Detect colision with the game borders
            if (Snake[i].X < 0 || Snake[i].Y < 0 || Snake[i].X >= maxXPos || Snake[i].Y > maxYPos)
            {
                Die();
            }

            // Detect collision with the body
            for (int j = 1; j < Snake.Count; j++)
            {
                if (Snake[i].X == Snake[j].X && Snake[i].Y == Snake[j].Y)
                {
                    Die();
                }
            }

            // Detect collision with food piece
            if (Snake[0].X == food.X && Snake[0].Y == food.Y)
            {
                Eat();
            }

            for (ii = Snake.Count - 1; ii > 0; ii--)
            {             


                // Move body
                Snake[ii].X = Snake[ii - 1].X;
                Snake[ii].Y = Snake[ii - 1].Y;
            }
        }

        private void Die()
        {
            Settings.GameOver = true;
        }

        private void Eat()
        {
            Circle food = new Circle();
            food.X = Snake[Snake.Count - 1].X;
            food.Y = Snake[Snake.Count - 1].Y;

            Snake.Add(food);

            // Update Score
            Settings.Score += Settings.Points;
            LabelScore.Text = Settings.Score.ToString();

            GenerateFood();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, true);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Input.ChangeState(e.KeyCode, false);
        }
    }
}

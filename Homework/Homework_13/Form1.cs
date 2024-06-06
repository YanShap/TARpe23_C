namespace Homework_13
{
    public partial class Form1 : Form
    {
        private Rectangle player;
        private List<Rectangle> bonusBalls;
        private Random random = new Random();
        private Rectangle redBall;
        private int playerSpeed = 10;
        private int redBallSpeed = 5;
        private int score = 0;
        private int lives = 3;
        private int bonusCount = 0;
        private int redBallSize = 20;
        private bool isGameOver = false;

        private string scoresFilePath = Path.Combine(Application.StartupPath, "scores.txt");
        public Form1()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            player = new Rectangle(50, 50, 30, 30);

            redBall = new Rectangle(random.Next(Width - redBallSize), random.Next(Height - redBallSize), redBallSize, redBallSize);

            bonusBalls = new List<Rectangle>();

            gameTimer.Interval = 20;
            gameTimer.Tick += new EventHandler(GameTimer_Tick);
            gameTimer.Start();

            bonusTimer.Interval = 3000;
            bonusTimer.Tick += new EventHandler(BonusTimer_Tick);
            bonusTimer.Start();

            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            this.KeyUp += new KeyEventHandler(Form1_KeyUp);

            this.DoubleBuffered = true;
        }


        private bool goLeft, goRight, goUp, goDown;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = true;
            if (e.KeyCode == Keys.Right) goRight = true;
            if (e.KeyCode == Keys.Up) goUp = true;
            if (e.KeyCode == Keys.Down) goDown = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) goLeft = false;
            if (e.KeyCode == Keys.Right) goRight = false;
            if (e.KeyCode == Keys.Up) goUp = false;
            if (e.KeyCode == Keys.Down) goDown = false;
        }
        private void MovePlayer()
        {
            if (goLeft && player.X > 0) player.X -= playerSpeed;
            if (goRight && player.X < Width - player.Width) player.X += playerSpeed;
            if (goUp && player.Y > 0) player.Y -= playerSpeed;
            if (goDown && player.Y < Height - player.Height) player.Y += playerSpeed;
        }

        private void MoveRedBall()
        {
            int redBallDirectionX = random.Next(-1, 2) * redBallSpeed;
            int redBallDirectionY = random.Next(-1, 2) * redBallSpeed;

            redBall.X += redBallDirectionX;
            redBall.Y += redBallDirectionY;

            if (redBall.X < 0 || redBall.X > Width - redBall.Width) redBallDirectionX = -redBallDirectionX;
            if (redBall.Y < 0 || redBall.Y > Height - redBall.Height) redBallDirectionY = -redBallDirectionY;
        }

        private void CheckCollisions()
        {
            if (player.IntersectsWith(redBall))
            {
                lives--;
                if (lives <= 0)
                {
                    GameOver();
                }
                else
                {
                    ResetPositions();
                }
            }

            if (bonusBalls != null)
            {
                foreach (var bonus in bonusBalls.ToList())
                {
                    if (player.IntersectsWith(bonus))
                    {
                        score += 10;
                        bonusCount++;
                        bonusBalls.Remove(bonus);
                        if (bonusCount % 5 == 0) lives++;
                    }
                }
            }
        }


        private void ResetPositions()
        {
            player.Location = new Point(50, 50);
            redBall.Location = new Point(random.Next(Width - redBallSize), random.Next(Height - redBallSize));
        }

        private void BonusTimer_Tick(object sender, EventArgs e)
        {
            if (bonusBalls == null)
            {
                bonusBalls = new List<Rectangle>();
            }

            if (bonusBalls.Count < 1)
            {
                Rectangle bonus = new Rectangle(random.Next(Width - 20), random.Next(Height - 20), 20, 20);
                bonusBalls.Add(bonus);
            }
            else
            {
                bonusBalls.Clear();
            }

            Invalidate();
        }


        private void GameTimer_Tick(object sender, EventArgs e)
        {
            if (!isGameOver)
            {
                MovePlayer();
                MoveRedBall();
                CheckCollisions();
                Invalidate();
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.FillRectangle(Brushes.Black, player);
            g.FillEllipse(Brushes.Red, redBall);

            if (bonusBalls != null)
            {
                foreach (var bonus in bonusBalls)
                {
                    g.FillEllipse(Brushes.Green, bonus);
                }
            }

            g.DrawString($"Score: {score}", this.Font, Brushes.Black, 10, 10);
            g.DrawString($"Lives: {lives}", this.Font, Brushes.Black, 10, 30);

            base.OnPaint(e);
        }

        private void GameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            bonusTimer.Stop();
            SaveHighScore();
            DisplayHighScores();
        }

        private void SaveHighScore()
        {
            var scores = new List<int>();

            if (File.Exists(scoresFilePath))
            {
                var scoreLines = File.ReadAllLines(scoresFilePath);
                scores = scoreLines.Select(int.Parse).ToList();
            }

            scores.Add(score);
            scores = scores.OrderByDescending(s => s).Take(3).ToList();
            File.WriteAllLines(scoresFilePath, scores.Select(s => s.ToString()).ToArray());
        }

        private void DisplayHighScores()
        {
            if (File.Exists(scoresFilePath))
            {
                var scoreLines = File.ReadAllLines(scoresFilePath);
                MessageBox.Show("Game Over!\nHigh Scores:\n" + string.Join("\n", scoreLines), "Game Over");
            }
        }
    }
}
}

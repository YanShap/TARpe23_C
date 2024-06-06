namespace Homework_12_3
{
    public partial class Form1 : Form
    {

        private int x, y;
        private int moveX, moveY;
        private Pen pen;

        public Form1()
        {
            InitializeComponent();
            InitializePen();
            InitializeTimer();
        }

        private Bitmap _bitmap = new Bitmap(10000, 10000);


        private void InitializeTimer()
        {
            timer.Interval = 5;
        }

        private void InitializePen()
        {
            Random random = new Random();
            pen = new Pen(Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255)), 10);

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            x += moveX;
            y += moveY;

            if (y <= 0 || y >= ClientSize.Height)
            {
                moveY *= -1;
                x += 10;
            }

            if (x <= 0 || x >= ClientSize.Width)
            {
                moveX *= -1;
                y += 10 * Math.Sign(moveY);


            }
            Random random = new Random();
            pen.Color = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));

            Refresh();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            x = 0;
            y = 0;
            moveX = 0;
            moveY = 10;
            timer.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            using (var graphics = Graphics.FromImage(_bitmap))
                graphics.DrawLine(pen, x, y, x + moveX, y + moveY);
            pictureBox1.Image = _bitmap;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
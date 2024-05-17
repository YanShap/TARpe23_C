namespace Homework_w11_3
{
    public partial class Form1 : Form
    {
        private int step;
        private int direction;

        private Random random;

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 400;
            random = new Random();
            step = 15;
            direction = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            switch (direction)
            {
                case 0:
                    label1.Left += step;
                    if (label1.Right >= ClientSize.Width)
                    {
                        direction = 1;
                        label1.Left = ClientSize.Width - label1.Width;
                    }
                    break;
                case 1:
                    label1.Top += step;
                    if (label1.Bottom >= ClientSize.Height)
                    {
                        direction = 2;
                        label1.Top = ClientSize.Height - label1.Height;
                    }
                    break;
                case 2: // Left
                    label1.Left -= step;
                    if (label1.Left <= 0)
                    {
                        direction = 3;
                        label1.Left = 0;
                    }
                    break;
                case 3: // Up
                    label1.Top -= step;
                    if (label1.Top <= 0)
                    {
                        direction = 0;
                        label1.Top = 0;
                    }
                    break;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
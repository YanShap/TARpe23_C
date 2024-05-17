namespace Homework_w11_4
{
    public partial class Form1 : Form
    {

        private int totalSeconds;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            string[] input = txtInput.Text.Split(':');

            if (input.Length == 2 && int.TryParse(input[0], out int minutes) && int.TryParse(input[1], out int seconds) && minutes >= 0 && seconds >= 0 && seconds <= 59)
            {
                totalSeconds = minutes * 60 + seconds;

                timer.Start();
                lblTimer.ForeColor = Color.Black;
            }
            else
            {
                MessageBox.Show("Invalid input format. Please enter time in mm:ss format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            totalSeconds--;

            if (totalSeconds >= 0)
            {
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds % 60;

                lblTimer.Text = $"{minutes:00}:{seconds:00}";

                if (totalSeconds == 0)
                    lblTimer.ForeColor = Color.Red;
            }
            else
            {
                timer.Stop();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            timer.Stop();
            lblTimer.Text = "00:00";
            lblTimer.ForeColor = Color.Black;
        }
    }
}
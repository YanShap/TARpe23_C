namespace Homework_w11_1
{
    public partial class Form1 : Form
    {
        public partial class Form1 : Form
        {
            private DateTime returnDate = new DateTime(2024, 6, 1, 12, 0, 0);

            public Form1()
            {
                InitializeComponent();
            }

            private void timer1_Tick(object sender, EventArgs e)
            {
                TimeSpan remainingTime = returnDate - DateTime.Now;
                if (remainingTime.TotalSeconds <= 0)
                {
                    timer1.Stop();
                    MessageBox.Show("Su sõber on tagasi jõudnud!");
                    return;
                }

                int years = remainingTime.Days / 365;
                int months = (remainingTime.Days % 365) / 30;
                int days = remainingTime.Days % 30;
                int hours = remainingTime.Hours;
                int minutes = remainingTime.Minutes;
                int seconds = remainingTime.Seconds;

                labelCountdown.Text = $"{years} Year(s), {months} Month(s), {days} Day(s), {hours} Hour(s), {minutes} Minute(s), {seconds} Second(s)";
            }
        }
    }
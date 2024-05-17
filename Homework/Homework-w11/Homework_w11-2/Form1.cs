namespace Homework_w11_2
{
    public partial class Form1 : Form
    {

        private string username = "user123";
        private string password = "password";
        private string maskedPassword = "";

        public Form1()
        {
            InitializeComponent();
            textBoxPassword.PasswordChar = '*';
        }


        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxUsername.Text == username && maskedPassword == password)
            {
                MessageBox.Show("Correct!");
            }
            else
            {
                MessageBox.Show("Wrong password!");
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            maskedPassword = new string('*', textBoxPassword.Text.Length);
        }
    }
}
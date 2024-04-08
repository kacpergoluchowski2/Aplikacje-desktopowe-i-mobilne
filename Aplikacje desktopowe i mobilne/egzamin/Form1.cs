using System.Windows.Forms;

namespace egzamin
{
    public partial class Form1 : Form
    {

        private void showMessage(string message_text)
        {
            string myData = message_text;
            MessageBox.Show(message_text, "Hello", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public Form1()
        {
            InitializeComponent();
            showMessage("Kacper Go³uchowski");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            if (password_input.Text == password_input_again.Text && e_mail_input.Text.Contains("@"))
                result_label.Text = "Witaj " + e_mail_input.Text;
            else if (!e_mail_input.Text.Contains("@"))
                showMessage("E-mail jest b³êdny");
            else if (password_input.Text != password_input_again.Text)
                showMessage("Has³a siê róŸniA");
        }

        private void password_input_again_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
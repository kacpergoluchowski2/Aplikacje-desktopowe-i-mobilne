namespace FirstAplicationWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            string message = "Witaj w tym programie\n";
            message += "Tw�j ulubiony przedmiot to: ";

            if (checkBoxMath.Checked)
            {
                message += "Matematyka, ";
            }
            if (checkBoxGerman.Checked)
            {
                message += "J�zyk niemiecki";
            }
            if (radioButtonPizzaYes.Checked)
            {
                message += ". Lubi� pizze z ananasem";
            }
            if (radioButtonPizzaNo.Checked)
            {
                message += ". Nie lubi� pizzy z ananasem";
            }
            message += "Twoje imie to: " + textBoxName.Text;

            if (comboBoxFavGame.SelectedIndex != -1)
            {
                message += "\nTwoja ulubona gra to: " + comboBoxFavGame.Text;
            }


            MessageBox.Show(message, "Hello", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

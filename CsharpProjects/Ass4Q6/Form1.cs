namespace Ass4Q6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gender = " ";
            string langualge = " ";

            if (radioButton1.Checked)
            {
                gender = "Male";
            }

            if (radioButton2.Checked)
            {
                gender = "Female";
            }

            if (radioButton3.Checked)
            {
                langualge = "English";
            }

            if (radioButton4.Checked)
            {
                langualge = "Sinhala";
            }

            if (radioButton5.Checked)
            {
                langualge = "Tamil";
            }

            label1.Text = $"Your Gender is {gender} and language is {langualge}";
        }
    }
}

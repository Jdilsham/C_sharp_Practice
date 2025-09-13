namespace Ass5Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            double z = (b * b) - (4 * a * c);

            if (z > 0)
            {
                double X = ((-b) + Math.Sqrt(z)) / (2 * a);

                double Y = ((-b) - Math.Sqrt(z)) / (2 * a);


                textBox4.Text = "2";
                textBox5.Text = X.ToString();
                textBox6.Text = Y.ToString();
            }else if (z == 0)
            {
                double X = ((-b) + Math.Sqrt(z)) / (2 * a);

                textBox4.Text = "1";
                textBox5.Text = X.ToString();
            }
            else
            {
                textBox4.Text = "0";
            }
        }
    }
}

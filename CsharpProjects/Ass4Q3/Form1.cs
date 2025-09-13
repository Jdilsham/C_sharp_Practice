namespace Ass4Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text1 = textBox1.Text;
            string text2 = textBox2.Text;

            string text = text1 + " " + text2;

            textBox3.Text = text;



            string textlable = textBox4.Text + " " + textBox5.Text;

            label1.Text = textlable;

            listBox1.Items.Add(textlable);
        }
    }
}

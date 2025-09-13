namespace Ass4Q4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            updateBill();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updateBill();
        }

        private void updateBill()
        {
            double total = 0;
            listBox1.Items.Clear();

            if (checkBox1.Checked)
            {
                total += 500;
                listBox1.Items.Add("Internet");
            }

            if (checkBox2.Checked)
            {
                total += 450;
                listBox1.Items.Add("Lunch");
            }

            if (checkBox3.Checked)
            {
                total += 30;
                listBox1.Items.Add("News Paper");
            }

            if (checkBox4.Checked)
            {
                total += 1000;
                listBox1.Items.Add("Swimming");
            }

            label1.Text = "Total Bill = " + total.ToString();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            updateBill();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            updateBill();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            updateBill();
        }
    }
}

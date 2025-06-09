using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Calculator : Form
    {
        
        string operation = "";
        double result = 0;
        bool isOperationPerformed = false;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || (isOperationPerformed))
            {
                txtDisplay.Clear();

                isOperationPerformed = false;
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || (isOperationPerformed))
            {
                txtDisplay.Clear();

                isOperationPerformed = false;
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || (isOperationPerformed))
            {
                txtDisplay.Clear();

                isOperationPerformed = false;
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out result))
            {
                MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDisplay.Text = "0";
                return;
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(txtDisplay.Text);
            isOperationPerformed = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out result))
            {
                MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDisplay.Text = "0";
                return;
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(txtDisplay.Text);
            isOperationPerformed = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || (isOperationPerformed))
            {
                txtDisplay.Clear();

                isOperationPerformed = false;
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || (isOperationPerformed))
            {
                txtDisplay.Clear();

                isOperationPerformed = false;
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void vtn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || (isOperationPerformed))
            {
                txtDisplay.Clear();

                isOperationPerformed = false;
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || (isOperationPerformed))
            {
                txtDisplay.Clear();

                isOperationPerformed = false;
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || (isOperationPerformed))
            {
                txtDisplay.Clear();

                isOperationPerformed = false;
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void bbtn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || (isOperationPerformed))
            {
                txtDisplay.Clear();

                isOperationPerformed = false;
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0" || (isOperationPerformed))
            {
                txtDisplay.Clear();

                isOperationPerformed = false;
                Button button = (Button)sender;
                txtDisplay.Text += button.Text;
            }
        }

        private void btn13_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out result))
            {
                MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDisplay.Text = "0";
                return;
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(txtDisplay.Text);
            isOperationPerformed = true;
        }

        private void btn10_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtDisplay.Text, out result))
            {
                MessageBox.Show("Invalid input. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDisplay.Text = "0";
                return;
            }

            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(txtDisplay.Text);
            isOperationPerformed = true;
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            switch (operation) {

                case "+":
                    txtDisplay.Text = (result + double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "-":
                    txtDisplay.Text = (result - double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "*":
                    txtDisplay.Text = (result * double.Parse(txtDisplay.Text)).ToString();
                    break;

                case "/":
                    txtDisplay.Text = (result / double.Parse(txtDisplay.Text)).ToString();
                    break;
            }
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            result = 0;
        }
    }
}

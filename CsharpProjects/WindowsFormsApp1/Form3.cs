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
    public partial class timeTable : Form
    {
        public timeTable()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int mul = int.Parse(comboBox1.Text);

            for (int i = num1; i <= num2; i++) { 
            
                int ans = i * mul;
                string display = $"{i} x {mul} = {ans}";
                listBox1.Items.Add(display);

            }

        }
    }
}

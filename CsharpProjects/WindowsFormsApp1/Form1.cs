using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); // Clear previous items
            int total = 0;

            foreach (var item in checkedListBox1.CheckedItems)
            {
                string service = item.ToString();
                listBox1.Items.Add(service);

                // Get the price from the text (last word after space)
                string[] parts = service.Split(' ');
                if (int.TryParse(parts.Last(), out int price))
                {
                    total += price;
                }
            }
            label1.Text = "Total Bill  = " + total.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;

            string type = null;

            Coffee coffee = null;

            if (checkBox1.Checked)
            {
                type = "Espresso";
                coffee = new Espresso();

            }else if (checkBox2.Checked)
            {
                type = "Latte";
                coffee = new Latte();

            }else if (checkBox3.Checked)
            {
                type = "Cappuccino";
                coffee = new Cappuccino();
            }

            string size = null;

            if (radioButton1.Checked)
            {
                size = "Small";
            }else if (radioButton2.Checked)
            {
                size = "Medium";
            }else if (radioButton3.Checked)
            {
                size = "Large";
            }

            string AddOns = null;

            if (checkBox7.Checked)
            {
                coffee = new Milk(coffee);
                AddOns = AddOns + "Milk";
            }
            if (checkBox8.Checked)
            {
                coffee = new Suger(coffee);
                AddOns = AddOns + "," + "Suger";
            }

            int quntity = Convert.ToInt32(textBox2.Text);

            double netCost = coffee.getCost() * quntity;

            DateTime date = new DateTime();
            string today = date.ToString("dd/MM/yyyy");

            order order = new order(name,today,type,size,quntity,AddOns,netCost);
            OrderStore.orders.Add(order);

            MessageBox.Show(text:"Success");

            textBox1.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

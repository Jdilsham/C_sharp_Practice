using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorRight
{
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string roomType = null;
            HotelBilling room = null;

            if (checkBox1.Checked)
            {
                roomType = "Standard";
                room = new StandardRoom();
            }
            if (checkBox2.Checked)
            {
                roomType = "Double";
                room = new DoubleRoom();
            }
            if (checkBox3.Checked)
            {
                roomType = "Deluxe";
                room = new DeluxeRoom();
            }

            double barCost = Convert.ToDouble(textBox2.Text);
            double diningCost = Convert.ToDouble(textBox3.Text);
            double wellnessCost = Convert.ToDouble(textBox4.Text);
            double airportCost  = Convert.ToDouble(textBox5.Text);

            room = new Bar(room,barCost);
            room = new Dining(room,diningCost);
            room = new Wellness(room,wellnessCost);
            room = new Airport(room,airportCost); 

            double netCost = room.getCost();

            DateTime date = new DateTime();
            string today = date.ToString("dd/MM/yyyy");

            Customer customer = new Customer(name,today,roomType,barCost,diningCost,wellnessCost,airportCost,netCost);

            CustomerStore.Customers.Add(customer);

            MessageBox.Show(text:"Successfull");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispaly dispaly = new Dispaly();
            dispaly.Show();

        }
    }
}

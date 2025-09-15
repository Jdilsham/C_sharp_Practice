using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decorator
{
    public partial class Add_Customer_Form : Form
    {
        public Add_Customer_Form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Add_Customer_Form_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //List<Customer> CustomerList = new List<Customer>();

            string name = textBox1.Text;

            string roomtype = " ";

            HotelBilling room = new StandardRoom();

            if (checkBox1.Checked)
            {
                roomtype = "Standard";
                room = new StandardRoom();

            }else if (checkBox2.Checked)
            {
                roomtype = "Double";
                room = new DoubleRoom();

            }else if (checkBox3.Checked)
            {
                roomtype = "Deluxe";
                room = new DeluxeRoom();
            }
            else
            {
                MessageBox.Show(text : "Room Type Not Selected");
            }

            double barinput = Convert.ToDouble(textBox2.Text);
            double resturentinput = Convert.ToDouble(textBox3.Text);
            double wellnessinput = Convert.ToDouble(textBox4.Text);
            double airportinput = Convert.ToDouble(textBox5.Text);

            HotelBilling barCharge = new Bar(room,barinput);
            HotelBilling resturentCharge = new RDining(room, resturentinput);
            HotelBilling wellnessCharge = new Wellness(room,wellnessinput);
            HotelBilling airportCharge = new Airport(room,airportinput);

            double NetPrice = room.getCost() + barCharge.getCost() + resturentCharge.getCost() + wellnessCharge.getCost() + airportCharge.getCost();

            DateTime today = DateTime.Today;
            string todaydate = today.ToString("dd/MM/yyyy");
            MessageBox.Show(text: "Success");

            Customer customer = new Customer(name,todaydate,roomtype,barinput,resturentinput,wellnessinput,airportinput,NetPrice);
            //CustomerList.Add(customer);
            CustomerStore.Customers.Add(customer);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        
    }
}

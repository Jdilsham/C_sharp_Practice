using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPractice
{
    public partial class DisplayCusomer : Form
    {
        public DisplayCusomer()
        {
            InitializeComponent();
        }

        private void DisplayCusomer_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = CustomerStore.Customers;
        }
    }
}

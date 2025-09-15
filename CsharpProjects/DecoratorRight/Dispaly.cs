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
    public partial class Dispaly : Form
    {
        public Dispaly()
        {
            InitializeComponent();
        }

        private void Dispaly_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = CustomerStore.Customers;
        }
    }
}

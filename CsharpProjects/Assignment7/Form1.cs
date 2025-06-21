using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=DESKTOP-MP7IKAK\SQLEXPRESS;Initial Catalog=University;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Successfully Connected");

                    Form2 form2 = new Form2(connectionString);
                    form2.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex.Message);
                }
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class StudentManagement : Form
    {
        public StudentManagement()
        {
            InitializeComponent();

        }

        List<Student> students = new List<Student>();


        private void id_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            int ID;
            double GPA;
            if (!int.TryParse(id_txt.Text,out _)) {
                MessageBox.Show("Please enter Integer Value!");
            }
            else
            {
               ID = int.Parse(id_txt.Text);
            }

            string Name = name_txt.Text;
            string Course = course_txt.Text;

            if (!double.TryParse(gpa_txt.Text,out _)) {
                MessageBox.Show("Please Enter valid Double Value!");
            }
            else
            {
                GPA = double.Parse(gpa_txt.Text);
            }



        }
    }
}

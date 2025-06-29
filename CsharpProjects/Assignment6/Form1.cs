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
         

            if (!int.TryParse(id_txt.Text,out _)) {
                MessageBox.Show("Please enter Integer Value!");
            }

            if (!double.TryParse(gpa_txt.Text, out _))
            {
                MessageBox.Show("Please Enter valid Double Value!");
            }

            int ID = int.Parse(id_txt.Text);
            string Name = name_txt.Text;
            string Course = course_txt.Text;
            double GPA = double.Parse(gpa_txt.Text);

            Student student = new Student(ID,Name,Course,GPA);
            students.Add(student);
            RefreshList();
            ClearInputs();
        }

        private void RefreshList() {
            listView1.Items.Clear();
            foreach(Student s in students)
            {
                listView1.Items.Add(s);
            }
        }

        private void ClearInputs() {
            id_txt.Clear();
            name_txt.Clear();
            course_txt.Clear();
            gpa_txt.Clear();
        }
    }
}

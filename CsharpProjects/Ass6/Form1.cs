using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass6
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        List <Student> students = new List <Student>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                students.RemoveAt(listBox1.SelectedIndex);
                RefreshList();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id;
            string name;
            string course;
            double gpa;

            if (int.TryParse(textBox1.Text, out id))
            {
                id = int.Parse(textBox1.Text);
                
            }
            else {
                MessageBox.Show("Invalid ID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            if (textBox2.Text != "" && textBox3.Text != "")
            {
                name = textBox2.Text;
                course = textBox3.Text;
                
            }
            else {
                MessageBox.Show("Invalid Name or Course", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            if (!double.TryParse(textBox4.Text.Trim(), out gpa) || gpa < 0 || gpa > 4)
            {
                  
                MessageBox.Show("Invalid GPA","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
                
            


            Student student = new Student(id, name, course, gpa);
            students.Add(student);
            RefreshList();
            ClearInputs();
        }

        private void RefreshList() { 
            
            listBox1.Items.Clear();
            foreach (Student student in students) { 
                listBox1.Items.Add(student);
            }
        }

        private void ClearInputs() { 
            
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

namespace Ass6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Student> students = new List<Student>();

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ids = textBox1.Text;
            string name= textBox2.Text;
            string course = textBox3.Text;
            double gpa = double.Parse(textBox4.Text);

            if (gpa < 0 || gpa > 4)
            {
                MessageBox.Show(text: "GPA not valid");
            }else if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show(text:"Name Invalid");

            }else if (string.IsNullOrEmpty(course))
            {
                MessageBox.Show(text: "Course Invalid");
            }else if (!int.TryParse(ids,out int id))
            {
                MessageBox.Show(text: "ID Invalid");
                return;
            }
            else
            {
                Student student = new Student(id, name, course, gpa);
                students.Add(student);
                RefreshList();
                ClearInput();
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                students.RemoveAt(listBox1.SelectedIndex);
                RefreshList();
            }
        }

        private void RefreshList()
        {
            listBox1.Items.Clear();
            foreach (Student s in students)
            {
                listBox1.Items.Add(s);
            }
        }

        private void ClearInput()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}

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
    public partial class Form2 : Form
    {
        string connStr;
        public Form2(string connectionString)
        {
            InitializeComponent();
            connStr = connectionString;
            //LoadData();

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        public void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Students", conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "INSERT INTO Students (Name, Age, Email) VALUES (@Name, @Age, @Email)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name",txtName.Text);
                cmd.Parameters.AddWithValue("@Age",int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@Email",txtEmail.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Inserted Successfully");
                LoadData();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr)) 
            {
                string sql = "UPDATE Students SET Name=@Name, Age=@Age,Email=@Email WHERE Name=@Name";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@Name",txtName.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(txtAge.Text));
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Updated Successfully");
                LoadData();

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string sql = "DELETE FROM Students WHERE Name=@Name";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Name",txtName.Text);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Deleted successfully");
                LoadData();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string createTableQuery = @"
            IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Students')
            BEGIN
                CREATE TABLE Students (
                    StudentID INT IDENTITY(1,1) PRIMARY KEY,
                    Name NVARCHAR(100) NOT NULL,
                    Age INT NOT NULL,
                    Email NVARCHAR(100) NOT NULL
                )
            END";

                SqlCommand cmd = new SqlCommand(createTableQuery, conn);
                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Students table created (if not already existing).");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error creating table: " + ex.Message);
                }
            }
        }
    }

   
}

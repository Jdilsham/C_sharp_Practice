using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public double GPA {  get; set; }

        public Student(int id, string name, string course, double gpa) { 
            Id = id;
            Name = name;
            Course = course;
            GPA = gpa;
        }

        public override string ToString()
        {
            return $"{Id} - {Name} - {Course} - GPA: {GPA}";
        }

    }
}

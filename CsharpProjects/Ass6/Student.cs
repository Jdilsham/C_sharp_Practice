using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass6
{
    internal class Student
    {

        public int ID { get; set; }
        public string FullName { get; set; }
        public string Course { get; set; }
        public double GPA { get; set; }


        public Student(int id, string name, string course, double gpa) { 
            ID = id;
            FullName = name;
            Course = course;
            GPA = gpa;
        }

        public override string ToString() {
            return $"{ID} - {FullName} ({Course}) - GPA: {GPA}";
        }
    }
}

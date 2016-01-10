using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndTextManipulation
{
    class Student
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string facultyNumber;
        public string FacultyNumber
        {
            get { return facultyNumber; }
            set { facultyNumber = value; }
        }

        public override string ToString()
        {
            return string.Format("Student " + this.name + " and his faculty number is " + this.facultyNumber);
        }
    }
}

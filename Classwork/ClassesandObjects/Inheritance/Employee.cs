using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Employee
    {
        private int hours;

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        private int salary;

        public int Salary
        {
            get { return Salary; }
            set { Salary = value; }
        }

            public Employee(int hours, int salary)
        {
            this.Hours = hours;
            this.Salary = Salary;
        }
    }
}

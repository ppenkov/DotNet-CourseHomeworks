using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Doctor : Employee
    {
        private int night;

        public int Night
        {
            get { return night; }
            set { night = value; }
        }

        private int day;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public Doctor(int hours, int salary, int night, int day)
            : base(hours, salary)
        {
            this.Night = night;
            this.Day = day;
        }
    }
}

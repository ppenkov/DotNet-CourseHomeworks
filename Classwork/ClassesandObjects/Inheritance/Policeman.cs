using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Policeman : Employee
    {
        private int rang;
        public int Rang
        {
            get { return rang; }
            set { rang = value; }
        }

        public Policeman(int hours, int salary,int rang)
            : base(hours, salary)
        {
            this.Rang = rang;
        }
    }
}

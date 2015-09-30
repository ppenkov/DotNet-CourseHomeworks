using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ExamProject
{
    public class Country
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string capital;
        public string Capital
        {
            get { return capital; }
            set { capital = value; }
        }

        private long population;
        public long Population
        {
            get { return population; }
            set { population = value; }
        }

        public override string ToString()
        {
            return string.Format("{0}|{1}|{2}", this.name, this.capital, this.population);
        }
    }
}
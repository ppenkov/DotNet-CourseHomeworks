using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeworkMultithreading
{
    class Threads
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int sleep;
        public int Sleep
        {
            get { return sleep; }
            set { sleep = value; }
        }


        public Threads(string name, Random rand)
        {
            this.name = name;
            this.sleep = rand.Next(1000,10000);
        }

        public void PrintInfo()
        {
            Console.WriteLine("The thread {0} is started!", Name);
            Thread.Sleep(sleep);
            Console.WriteLine("The thread {0} is completed, after {1} miliseconds sleep", Name, sleep);

        }
    }
}

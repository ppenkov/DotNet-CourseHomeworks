using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeworkMultithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Thread thread1 = new Thread(new Threads("ONE", rand).PrintInfo);

            Thread thread2 = new Thread(new Threads("TWO", rand).PrintInfo);

            Thread thread3 = new Thread(new Threads("THREE", rand).PrintInfo);

            Thread thread4 = new Thread(new Threads("FOUR", rand).PrintInfo);

            Thread thread5 = new Thread(new Threads("FIVE", rand).PrintInfo);

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            thread5.Start();
        }
    }
}

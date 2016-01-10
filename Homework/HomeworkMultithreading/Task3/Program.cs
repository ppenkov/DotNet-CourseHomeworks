using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        private static Thread thread1, thread2;

        private const string message = "Running...";

        static void Main(string[] args)
        {
            thread1 = new Thread(new ThreadStart(PrintStart));
            thread2 = new Thread(new ThreadStart(PrintMessages));

            thread1.Start();
            thread2.Start();
        }

        private static void PrintStart()
        {
            for (int i = 0; i <= 50000; i++)
            {
                Console.WriteLine(i);

                if (i == 25000)
                {
                    thread1.Suspend();
                }
            }
        }

        private static void PrintMessages()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(message);
                Thread.Sleep(500);
            } thread1.Resume();
        }
    }
}

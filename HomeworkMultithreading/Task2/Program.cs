using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        public static void ThreadsInfo(object name)
        {
            Random seconds = new Random();

            Console.WriteLine("The thread {0} is started!", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(seconds.Next(1000, 10000));
            Console.WriteLine("The thread {0} is completed!", Thread.CurrentThread.ManagedThreadId);
        }

        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                ThreadPool.QueueUserWorkItem(new
                    WaitCallback(ThreadsInfo));
            }

            Console.WriteLine("Press [Enter] to exit!");
            Console.ReadLine();
        }
    }
}
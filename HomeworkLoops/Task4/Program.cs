using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of N:");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of K:");
            int K = int.Parse(Console.ReadLine());

            if (K > 1 && N > K)
            {
                long factorialN = 1;
                for (int counter = 1; counter <= N; counter++)
                {
                    factorialN *= counter;
                }
                Console.WriteLine("N! = " + factorialN);

                long factorialK = 1;
                for (int counter = 1; counter <= K; counter++)
                {
                    factorialK *= counter;
                }
                Console.WriteLine("K! = " + factorialK);

                long result = (factorialN / factorialK);
                Console.WriteLine("N!/K! = " + result);
            }

            else
            {
                Console.WriteLine("Try with other numbers!");
            }
        }
    }
}

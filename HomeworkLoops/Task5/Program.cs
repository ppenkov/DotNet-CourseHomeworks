using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
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

                int result = N - K;
                long factorialNK = 1;
                for (int counter = 1; counter <= result; counter++)
                {
                    factorialNK *= counter;
                }
                Console.WriteLine("(N - K)! = " + factorialNK);

                long finalresult = (factorialN * factorialK) / factorialNK;
                Console.WriteLine("N! * K! / (N-K)! = " + finalresult);
            }

            else
            {
                Console.WriteLine("Try with other numbers!");
            }
        }
    }
}

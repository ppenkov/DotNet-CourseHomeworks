using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkStringsAndTextManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word: ");
            string A = Console.ReadLine();

            for (int i = A.Length - 1; i >= 0; i--)
            {
                Console.Write(A[i]);
            }

            Console.WriteLine();
        }
    }
}

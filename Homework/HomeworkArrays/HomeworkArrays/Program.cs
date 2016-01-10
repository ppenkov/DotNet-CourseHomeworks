using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array:");
            int n = int.Parse(Console.ReadLine());
            
            int [] N = new int [n];
            for (int i = 0; i < N.Length; i++)
            {
                Console.WriteLine("Enter a number:");
                N[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0;
            for (int i = 0; i < N.Length; i++)
			{
                if (N[i] % 2 == 0)
                {
                    sum = sum + N[i];
                }
            } 
                    Console.WriteLine("The Sum of the even numbers is: " + sum);
            }
        }
}

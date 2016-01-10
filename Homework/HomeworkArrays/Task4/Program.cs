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
            Console.WriteLine("Enter the length of the array:");
            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter a number:");
                array[i] = int.Parse(Console.ReadLine());
            }
           
            Console.WriteLine(array[0]);
        }
    }
}

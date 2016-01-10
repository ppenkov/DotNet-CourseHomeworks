using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the array:");
            int length = int.Parse(Console.ReadLine());
            int[] array = new int[length];
            int x = 0;
            int y = 1;
            int z;
            for (int i = 0; i < length; i++)
            {
                z = x + y;
                y = x;
                x = z;
                Console.WriteLine("The fibonacci numbers are:" + z);
            }
        }
    }
}

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
            Console.WriteLine("Enter the length ofte array:");
            int x = int.Parse(Console.ReadLine());
            int[] myArray = new int[x];

            int c = x-1;
            for (int i = 0; i < x; i ++)
            {
                Console.WriteLine("Enter a number:");
                int a = int.Parse(Console.ReadLine());
                myArray [i] = a;        
                c = a;
                

                Console.WriteLine(myArray[i]);
            }
        }
    }
}

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
            Console.WriteLine("Enter the length of the first array:");
            int length = int.Parse(Console.ReadLine());

            int[] array = new int[length];
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine("Enter a number:");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the length of the second array:");
            int length2 = int.Parse(Console.ReadLine());

            int[] array2 = new int[length2];
            for (int i = 0; i < length2; i++)
            {
                Console.WriteLine("Enter a number:");
                array2[i] = int.Parse(Console.ReadLine());
            }

            bool compare = array.SequenceEqual(array2);
            Console.WriteLine("First array = second array?: " + compare);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] MyArray = new int[] { 1, 2, 3, 4, 5 };
            Print(MyArray);

        }
        private static void Print(int[] numbers)
        {
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }

    }
}

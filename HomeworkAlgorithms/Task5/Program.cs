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
            Random random = new Random();
            int[] array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 1000);
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int highValue = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = highValue;
                    }
                }
            }

            Console.WriteLine("Bubble Sort of the elements:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            } 
        }
    }
}

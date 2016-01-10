using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter a number: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("Enter a number to search in the array: ");
            int a = int.Parse(Console.ReadLine());

            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            int index = Array.BinarySearch(array, a);

            if (index == -1)
            {
                Console.WriteLine("The number is not in the array!");
            }
            else
            {
                while (a == array[index])
                {
                    index++;
                }
                Console.WriteLine("The next bigger number in the array is: " + array[index]);
            }
        }
    }
}

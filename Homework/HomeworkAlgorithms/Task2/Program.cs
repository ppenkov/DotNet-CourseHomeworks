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
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Enter a number: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            QuicksortArray(array, 0, 9);

            Console.WriteLine("The sorted array is:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.WriteLine();
        }

        public static void QuicksortArray(int[] array, int left, int right)
        {
            int temp = 0;
            int i = left, j = right;
            int pivot = array[(left + right) / 2];

            while (i <= j)
            {
                while (array[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (array[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    i++;
                    j--;
                }

                if (left < j)
                {
                    QuicksortArray(array, left, j);
                }

                if (i < right)
                {
                    QuicksortArray(array, i, right);
                }
            }
        }
    }
}

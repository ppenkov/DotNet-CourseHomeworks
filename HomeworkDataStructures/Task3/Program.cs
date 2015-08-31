using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());

            int number;
            int numberOfOccurrences = 0;
            int[] array = new int[n];
            List<int> list = new List<int>();
            List<int> occurrences = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter a number: ");
                number = int.Parse(Console.ReadLine());

                if (number >= 0 && number <= 1000)
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine("Enter a number in the range of 0 - 1000!");
                    i--;
                }
            }

            for (int i = 0; i < n; i++)
            {
                numberOfOccurrences = 1;

                for (int j = 0; j < n; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        numberOfOccurrences += 1;
                    }
                }

                if (list.Contains(array[i]))
                {
                    continue;
                }
                else
                {
                    list.Add(array[i]);
                    occurrences.Add(numberOfOccurrences);
                }
            }

            for (int l = 0; l < list.Count; l++)
            {
                Console.WriteLine(" The number " + list[l] + " occurs " + occurrences[l] + " time/s.");
            }
        }
    }
}

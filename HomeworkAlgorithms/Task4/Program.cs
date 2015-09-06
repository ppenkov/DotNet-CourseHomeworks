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
            Random random = new Random();
            int[] array = new int[100];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 1000);
            }

            int maxValue = array[0];
            int minValue = array[0];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }

                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            List<int>[] bucket = new List<int>[maxValue - minValue + 1];

            for (int i = 0; i < bucket.Length; i++)
            {
                bucket[i] = new List<int>();
            }

            for (int i = 0; i < array.Length; i++)
            {
                bucket[array[i] - minValue].Add(array[i]);
            }

            int index = 0;

            for (int i = 0; i < bucket.Length; i++)
            {
                if (bucket[i].Count > 0)
                {
                    for (int j = 0; j < bucket[i].Count; j++)
                    {
                        array[index] = bucket[i][j];
                        index++;
                    }
                }
            }

            Console.WriteLine("Bucket Sort of the elements:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            } 
        }
    }
}

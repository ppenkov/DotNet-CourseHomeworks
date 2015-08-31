using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkDataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            string number;

            for (int i = 0; i < int.MaxValue; i++)
            {
                Console.Write("Enter a number: ");
                number = Console.ReadLine();

                if (number != string.Empty)
                {
                    numbers.Add(int.Parse(number));
                }
                else
                {
                    break;
                }
            }
                Console.WriteLine("The sum of the numbers is: " + numbers.Sum());
                Console.WriteLine("The average value is: " + numbers.Average());
        }
    }
}

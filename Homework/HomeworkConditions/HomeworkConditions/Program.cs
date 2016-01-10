using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkConditions
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("For 'integer' press 1, for 'double' press 2, for 'string' press 3:");
            int A = int.Parse(Console.ReadLine());  

            if (A == 1)
            {
                Console.WriteLine("Enter a number:");
                int B = int.Parse(Console.ReadLine());
                Console.WriteLine("The result is: " + (B + 1));
            }
            else if (A == 2)
            {
                Console.WriteLine("Enter a real number:");
                double C = double.Parse(Console.ReadLine());
                Console.WriteLine("The result is: " + (C + 1));
            }
            else if (A == 3)
            {
                Console.WriteLine("Enter a phrase:");
                string D = Console.ReadLine();
                Console.WriteLine("The result is: " + D + "*");
            }
        }
    }
}

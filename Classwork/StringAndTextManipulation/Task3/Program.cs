using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("Countries.txt"))
            {
                string line = reader.ReadToEnd();
                Console.WriteLine(line);
            }

            string[] cities = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the capitals of the countries:");
                cities [i] = Console.ReadLine();
                 
            }
            using (StreamWriter writer = new StreamWriter("cities.txt"))
            {
                for (int i = 0; i < 5; i++)
                {
                    writer.WriteLine(cities[i]);
                }
            }
        }
    }
}

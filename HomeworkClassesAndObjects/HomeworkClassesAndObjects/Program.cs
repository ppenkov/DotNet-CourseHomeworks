using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cats = new string[10];

            for (int i = 0; i < cats.Length; i++)
            {
                Console.Write("Enter cat's name: ");
                cats[i] = Console.ReadLine();
            } Console.WriteLine();

            int[] age = new int[10];

            for (int i = 0; i < age.Length; i++)
            {
                Console.Write("Enter cat's age: ");
                age[i] = int.Parse(Console.ReadLine());
            } Console.WriteLine();

            Console.WriteLine("Cats Info:");

            for (int i = 0; i < 10; i++)
            {
                Cat catInfo = new Cat();
                catInfo.Name = cats[i];
                catInfo.Age = age[i];
                catInfo.Say();
            }
        }
    }
}

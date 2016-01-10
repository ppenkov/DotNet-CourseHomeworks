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
            List<int> list = new List<int>();
            List<int> temp = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Add number: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            int ocurence;

            for (int i = 0; i < list.Count; i++)
            {
                int number = list[i];
                ocurence = 1;

                for (int j = 0; j < list.Count; j++)
                {
                    if (list[i] == list[j] && i != j)
                    {
                        ocurence += 1;
                    }
                }

                if (ocurence % 2 == 1)
                {
                    if (temp.Contains(number))
                    {
                        continue;
                    }
                    else
                    {
                        temp.Add(number);
                    }
                }
            }

            for (int j = 0; j < temp.Count; j++)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] == temp[j])
                    {
                        list.Remove(list[i]);
                        i--;
                    }
                }
            }

            if (list.Count == 0)
            {
                Console.WriteLine("The list is empty!");
            }
            else
            {
                Console.WriteLine("The list without the numbers, occuring odd times:");

                foreach (var item in list)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

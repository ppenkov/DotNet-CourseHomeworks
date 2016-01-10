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
            Console.Write("Enter cathetus A of the triangle: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter cathetus B of the triangle: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine();
            Triangle rightTriangle = new Triangle(a, b);
            rightTriangle.CathetusA = a;
            rightTriangle.CathetusB = b;
            rightTriangle.CalculateHypotenuse(a, b);
            rightTriangle.CalculateAngles(a, b);
        }
    }
}

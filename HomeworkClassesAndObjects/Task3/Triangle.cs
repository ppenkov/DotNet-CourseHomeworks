using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        private double cathetusA;
        public double CathetusA
        {
            get { return cathetusA; }
            set { cathetusA = value; }
        }

        private double cathetusB;
        public double CathetusB
        {
            get { return cathetusB; }
            set { cathetusB = value; }
        }

        public Triangle(double cathetusA, double cathetusB)
        {
            this.cathetusA = cathetusA;
            this.cathetusB = cathetusB;
        }

        public void CalculateHypotenuse(double cathetusA, double cathetusB)
        {
            double tempHypotenuse = 0;
            double squaredHypotenuse = tempHypotenuse * tempHypotenuse;

            squaredHypotenuse = (cathetusA * cathetusA) + (cathetusB * cathetusB);
            tempHypotenuse = Math.Sqrt(squaredHypotenuse);

            float hypotenuse = Convert.ToSingle(tempHypotenuse);
            Console.WriteLine("The hypotenuse of the right triangle is: " + hypotenuse + "cm.");
        }

        public void CalculateAngles(double cathetusA, double cathetusB)
        {
            double tempHypotenuse = 0;
            double squaredHypotenuse = tempHypotenuse * tempHypotenuse;

            squaredHypotenuse = (cathetusA * cathetusA) + (cathetusB * cathetusB);
            tempHypotenuse = Math.Sqrt(squaredHypotenuse);

            float hypotenuse = Convert.ToSingle(tempHypotenuse);
            double tempAngle1 = Math.Atan(cathetusA / cathetusB) * (180 / Math.PI);
            double tempAngle2 = Math.Atan(cathetusA / cathetusB) * (180 / Math.PI);
            tempAngle1 = Math.Asin(cathetusA / hypotenuse) * (180 / Math.PI);
            tempAngle2 = Math.Asin(cathetusB / hypotenuse) * (180 / Math.PI);

            int angle1 = Convert.ToInt32(tempAngle1);
            int angle2 = Convert.ToInt32(tempAngle2);
            Console.WriteLine("The right triangle has two acute angles with degrees: " + angle1 + " and " + angle2);
        }
    }
}
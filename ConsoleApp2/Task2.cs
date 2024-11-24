using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    namespace Pr1
    {
        public class Task2 : ITask
        {
            private double side1 = 5;
            private double side2 = 8;
            private double side3 = 10;

            private double CalculatePerimeter(double s1, double s2, double s3) => s1 + s2 + s3;

            private double CalculateArea(double semiPerimeter, double s1, double s2, double s3)
                => Math.Sqrt(semiPerimeter * (semiPerimeter - s1) * (semiPerimeter - s2) * (semiPerimeter - s3));

            private void DetermineTriangleType(double s1, double s2, double s3)
            {
                if (s1 == s2 && s2 == s3)
                    Console.WriteLine("Triangle is equilateral.");
                else if (s1 == s2 || s2 == s3 || s1 == s3)
                    Console.WriteLine("Triangle is isosceles.");
                else
                    Console.WriteLine("Triangle is versatile.");
            }

            private bool IsValidTriangle(double s1, double s2, double s3)
                => (s1 + s2 > s3 && s2 + s3 > s1 && s3 + s1 > s2) && (s1 > 0 && s2 > 0 && s3 > 0);

            public void Execute()
            {
                if (!IsValidTriangle(side1, side2, side3))
                {
                    Console.WriteLine("The triangle is not valid.");
                    return;
                }

                double perimeter = CalculatePerimeter(side1, side2, side3);
                Console.WriteLine($"Perimeter of triangle: {perimeter}");

                double semiPerimeter = perimeter / 2;
                double area = CalculateArea(semiPerimeter, side1, side2, side3);
                Console.WriteLine($"Area of triangle: {area}");

                DetermineTriangleType(side1, side2, side3);
            }
        }
    }
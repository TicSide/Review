using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review.Exercise
{
    internal class AreaCalculator
    {
        public void CalculateArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of the circle with radius {radius} is: {area}");
        }
        public void CalculateArea(double length, double width)
        {
            double area = length * width;
            Console.WriteLine($"The area of the rectangle with length {length} and width {width} is: {area}");
        }
        public void CalculateArea(double side1,double side2,double side)
        {
            double area = side * side;
            Console.WriteLine("$The area of the square with the sides is: {area}", area);
        }

    }
}

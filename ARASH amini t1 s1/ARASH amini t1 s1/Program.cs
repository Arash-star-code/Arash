using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double r, area, perimeter;
            const double pi = 3.14;

            Console.Write("Please enter the radius of the circle: ");
            r = Convert.ToDouble(Console.ReadLine());

            area = pi * r * r;
            perimeter = 2 * pi * r;

            Console.WriteLine("Area of the circle = " + area);
            Console.WriteLine("Perimeter of the circle = " + perimeter);

            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
        }
    }
}

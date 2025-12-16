using System;

namespace tamrin1_s2
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius, fahrenheit;

            Console.Write("Please enter the temperature in Celsius: ");
            celsius = Convert.ToDouble(Console.ReadLine());

            fahrenheit = (celsius * 9 / 5) + 32;

            Console.WriteLine("Equivalent temperature in Fahrenheit = " + fahrenheit);

            Console.ReadKey();
        }
    }
}

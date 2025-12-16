using System;

class Program
{
    static void Main()
    {
        int number;
        int product = 1;

        while (true)
        {
            Console.Write("Enter a number (0 to stop): ");
            number = int.Parse(Console.ReadLine());

            if (number == 0)
                break;

            product *= number;
        }

        Console.WriteLine("Product = " + product);
    }
}
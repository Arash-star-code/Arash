using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 7 == 0)
        {
            Console.WriteLine("YES!");
        }
        else
        {
            int result = number * 3;
            Console.WriteLine(result);
        }
    }
}
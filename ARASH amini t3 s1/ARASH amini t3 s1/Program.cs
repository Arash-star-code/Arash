using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1-7): ");
        int day = int.Parse(Console.ReadLine());

        if (day == 1)
            Console.WriteLine("Saturday");
        else if (day == 2)
            Console.WriteLine("Sunday");
        else if (day == 3)
            Console.WriteLine("Monday");
        else if (day == 4)
            Console.WriteLine("Tuesday");
        else if (day == 5)
            Console.WriteLine("Wednesday");
        else if (day == 6)
            Console.WriteLine("Thursday");
        else if (day == 7)
            Console.WriteLine("Friday");
        else
            Console.WriteLine("END!");
    }
}
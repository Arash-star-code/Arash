using System;
class Program
{
    static void Main()
    {
        int even = 0, odd = 0;
        Console.WriteLine("10 enter num:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"adad {i}: ");
            if (int.TryParse(Console.ReadLine(), out int n))
            {
                if (n % 2 == 0) even++;
                else odd++;
            }
            else
            {
                Console.WriteLine("dubare talash kon.");
                i--;
            }
        }
        Console.WriteLine($"tedad adade zoj: {even}");
        Console.WriteLine($"tedad adade fard: {odd}");
    }
}


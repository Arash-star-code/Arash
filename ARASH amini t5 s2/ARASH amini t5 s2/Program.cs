using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        int result = Multiply(a, b);
        Console.WriteLine($"Result = {result}");
    }

    static int Multiply(int a, int b)
    {
        if (b == 0)
            return 0;

        return a + Multiply(a, b - 1);
    }
}

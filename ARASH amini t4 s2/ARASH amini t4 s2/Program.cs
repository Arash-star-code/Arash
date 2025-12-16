using System;

class Program
{
    static void Main()
    {
        bool found = false;
        string positions = "";

        for (int i = 1; i <= 5; i++)
        {
            Console.Write($"adad ro bede {i}: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 2)
            {
                found = true;
                positions += i + " ";
            }
        }

        if (found)
        {
            Console.WriteLine("adad 2 hast.");
            Console.WriteLine("adad 2 tu pele haye : " + positions);
        }
        else
        {
            Console.WriteLine("adad 2 nist.");
        }
    }
}

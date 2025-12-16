using System;

class Program
{
    static void Main()
    {
        Console.Write("Which letter do you want to print (E / H / I): ");
        string choice = Console.ReadLine().ToUpper();

        int size = 7;

        switch (choice)
        {
            case "E":
                PrintE(size);
                break;

            case "H":
                PrintH(size);
                break;

            case "I":
                PrintI(size);
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    static void PrintE(int size)
    {
        for (int r = 0; r < size; r++)
        {
            for (int c = 0; c < size; c++)
            {
                bool top = (r == 0);
                bool mid = (r == size / 2);
                bool bot = (r == size - 1);
                bool left = (c == 0);

                Console.Write((left || top || mid || bot) ? 'E' : ' ');
            }
            Console.WriteLine();
        }
    }

    static void PrintH(int size)
    {
        for (int r = 0; r < size; r++)
        {
            for (int c = 0; c < size; c++)
            {
                bool left = (c == 0);
                bool right = (c == size - 1);
                bool mid = (r == size / 2);

                Console.Write((left || right || mid) ? 'H' : ' ');
            }
            Console.WriteLine();
        }
    }

    static void PrintI(int size)
    {
        for (int r = 0; r < size; r++)
        {
            for (int c = 0; c < size; c++)
            {
                bool top = (r == 0);
                bool bot = (r == size - 1);
                bool center = (c == size / 2);

                Console.Write((top || bot || center) ? 'I' : ' ');
            }
            Console.WriteLine();
        }
    }
}

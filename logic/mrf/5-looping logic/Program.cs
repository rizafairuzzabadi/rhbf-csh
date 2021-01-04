using System;

namespace _5_looping_logic
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int current = 0;
            do
            {
                current = random.Next(1, 11);
                if (current >= 8) continue;
                Console.WriteLine(current);
            } while (current != 7);

            while (current >= 3)
            {
                Console.WriteLine(current);
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current}");
        }
    }
}

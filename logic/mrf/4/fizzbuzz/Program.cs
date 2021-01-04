using System;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i < 100; i++)
            {
                bool f = i % 3 == 0;
                bool b = i % 5 == 0;
                Console.Write(i);
                if (f && b)
                    Console.Write(" - FizzBuzz");
                else if (f)
                    Console.Write(" - Fizz");
                else if (b)
                    Console.Write(" - Buzz");
                Console.Write("\n");
            }
        }
    }
}

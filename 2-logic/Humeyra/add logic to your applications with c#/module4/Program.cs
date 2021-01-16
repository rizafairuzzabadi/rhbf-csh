using System;

namespace module4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] names = { "Alex", "Eddie", "David", "Michael" };
            for (int i = 0; i < names.Length; i++)
                if (names[i] == "David") names[i] = "Sammy";

            foreach (var name in names) Console.WriteLine(name);
  */
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0)) Console.WriteLine("FizzBuzz");
                else if (i % 3 == 0) Console.WriteLine("Fizz");
                else if (i % 5 == 0) Console.WriteLine("Buzz");
                else Console.WriteLine("");
            }
        }
    }
}

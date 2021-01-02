using System;

namespace _5_clsnmet
{
    class Program
    {
        static void Main(string[] args)
        {
            Random dice = new Random(); //new class instance
            int roll = dice.Next(1, 7);
            Console.WriteLine(roll);

            int roll1 = dice.Next(); //return values ranging from 0 to 2,147,483,647
            int roll2 = dice.Next(101);
            int roll3 = dice.Next(50, 101);
            Console.WriteLine($"First roll: {roll1}");
            Console.WriteLine($"Second roll: {roll2}");
            Console.WriteLine($"Third roll: {roll3}");

            int firstValue = 500;
            int secondValue = 600;
            int largerValue;
            largerValue = Math.Max(firstValue, secondValue);
            Console.WriteLine(largerValue);

        }
    }
}

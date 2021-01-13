using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            int value = 0;
            if (flag)
            {
                value = 10;
                Console.WriteLine($"Inside of code block: {value}");
            }
            Console.WriteLine("Outside of code block: " + value);

            string words = "Microsoft Learn";
            string reversedValue = Utility.Reverse(words);
            Console.WriteLine($"Secret message: {reversedValue}");

        }
    }
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

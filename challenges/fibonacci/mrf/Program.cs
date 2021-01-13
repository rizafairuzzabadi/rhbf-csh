using System;

namespace mrf
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Enter a number  ");
            string n = Console.ReadLine();
            bool Next = Int32.TryParse(n, out number);
            Console.Write(String.Format("fibonacci({0}) = ", n));
            Console.Write(fibonacci(number));
        }

        static long fibonacci(int n)
        {
            long[] result = new long[n + 2];
            result[0] = 0;
            result[1] = 1;
            for (int i = 2; i <= n; i++)
            {
                result[i] = result[i - 1] + result[i - 2];
            }
            return result[n];
        }
    }
}

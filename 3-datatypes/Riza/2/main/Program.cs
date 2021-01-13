using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 2;
            string second = "4";
            string result = first + second;
            Console.WriteLine(result);

            int myInt = 3;
            Console.WriteLine($"int: {myInt}");

            decimal myDecimal = myInt;
            Console.WriteLine($"decimal: {myDecimal}");

            myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");

            myInt = (int)myDecimal; //conversion to integer
            Console.WriteLine($"int: {myInt}");

            myDecimal = 1.23456789m;
            float myFloat = (float)myDecimal;   //narrowing conv

            Console.WriteLine($"Decimal: {myDecimal}");
            Console.WriteLine($"Float: {myFloat}");

            first = 5;
            second = "7";
            string message = first.ToString() + second;
            Console.WriteLine(message);

            string a = "5";
            string b = "7";
            int sum = int.Parse(a) + int.Parse(b);
            Console.WriteLine(sum);

            string value1 = "5";
            string value2 = "7";
            int result2 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(result2);

            int value3 = (int)1.5m; // casting truncates
            Console.WriteLine(value3);

            int value23 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(value3);

            //TryParse()
            string valuep = "102"; //or chars for bad value
            int resultp = 0;
            if (int.TryParse(valuep, out resultp))
            {
                Console.WriteLine($"Measurement: {resultp}");
            }
            else
            {
                Console.WriteLine("Unable to report the measurement.");
            }
            // Since it is defined outside of the if statement, 
            // it can be accessed later in your code.
            Console.WriteLine($"Measurement (w/ offset): {50 + resultp}");
        }
    }
}

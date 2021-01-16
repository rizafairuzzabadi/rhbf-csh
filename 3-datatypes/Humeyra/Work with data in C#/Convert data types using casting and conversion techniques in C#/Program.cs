using System;

namespace Convert_data_types_using_casting_and_conversion_techniques_in_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string[] values = { "12.3", "45", "ABC", "11", "DEF" };

            decimal sum = 0m;
            string hum = "";

            foreach (string item in values)
            {
                decimal number;
                if (decimal.TryParse(item, out number))
                {
                    sum = sum + number;
                }
                else
                {
                    hum = hum + item;  
                }
            }
            Console.WriteLine($"Total: {sum}");
            Console.WriteLine($"Message: {hum}"); */
            int value1 = 12;
            decimal value2 = 6.2m;
            float value3 = 4.3f; 

            decimal result = value1 /value2;
            int result1 = (int)result;
            Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

            decimal result2 = value2 / (decimal)value3; 
            Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

            float result3 = value3 / value1;
            Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}"); 
        }
    }
}

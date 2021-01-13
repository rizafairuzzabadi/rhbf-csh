using System;

namespace _4_basicop
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber);

            string firstName = "Hum";
            int widgetsSold = 7;
            Console.WriteLine(firstName + " sold " + widgetsSold + " widgets.");
            Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets.");
            Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); //clearer

            int sum = 7 + 5;
            int difference = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            decimal decimalQuotient = 7.0m / 5;
            Console.WriteLine("Decimal quotient: " + decimalQuotient);

            int first = 7;
            int second = 5;
            decimal quotient2 = (decimal)first / (decimal)second;
            Console.WriteLine(quotient);

            Console.WriteLine("Modulus of 200 / 5 : " + (200 % 5));
            Console.WriteLine("Modulus of 7 / 5: " + (7 % 5));

            int value1 = 3 + 4 * 5;
            int value2 = (3 + 4) * 5;
            Console.WriteLine(value1); //23
            Console.WriteLine(value2); //35

            int value = 1;

            value = value + 1;
            Console.WriteLine("First increment: " + value);
            value += 1;
            Console.WriteLine("Second increment: " + value);
            value++;
            Console.WriteLine("Third increment: " + value);
            value = value - 1;
            Console.WriteLine("First decrement: " + value);
            value -= 1;
            Console.WriteLine("Second decrement: " + value);
            value--;
            Console.WriteLine("Third decrement: " + value);

            value = 1;
            value++;
            Console.WriteLine("First: " + value);
            Console.WriteLine("Second: " + value++);
            Console.WriteLine("Third: " + value);
            Console.WriteLine("Fourth: " + (++value));

            int fahrenheit = 94;
            decimal celsius = ((decimal)fahrenheit - 32m) * 5m / 9m;
            Console.WriteLine("The temperature is " + celsius + " Celsius");
        }
    }
}

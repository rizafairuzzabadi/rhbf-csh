using System;

namespace _2_ltrvaluesIOvar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine('b');
            //Console.WriteLine('Hello World!'); single-quotes are only for alphanumeric char
            Console.WriteLine(123);
            Console.WriteLine(12.3);
            Console.WriteLine(true);
            Console.WriteLine(false);

            Console.WriteLine("123");
            Console.WriteLine(123);
            Console.WriteLine("true");
            Console.WriteLine(true);

            string firstName;
            firstName = "Riza";
            Console.WriteLine(firstName);
            firstName = "Humeyra";
            Console.WriteLine(firstName);
            string surname = "Boz-Fairuzzabadi";
            Console.WriteLine(surname);

            var message = "Hello world!";
            Console.WriteLine(message);

            int mail = 3;
            decimal temperature = 34.4m;
            Console.Write("Hello, ");
            Console.Write(firstName);
            Console.Write("! You have ");
            Console.Write(mail);
            Console.Write(" in your inbox. The temperature is ");
            Console.Write(temperature);
            Console.Write(" celsius.");

            /* char userOption;
            int gameScore;
            decimal particlesPerMillion;
            bool processedCustomer; */

        }
    }
}

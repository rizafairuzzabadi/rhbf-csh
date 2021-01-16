using System;

namespace dorduncuasama
{
    class Program
    {
        static void Main(string[] args)
        {
            int fahrenheit = 94;
            decimal celc= (fahrenheit - 32m)*5m/9m;
            Console.WriteLine("The temperature is " + celc + " Celcius.");
        }
    }
}

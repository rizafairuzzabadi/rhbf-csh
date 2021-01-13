﻿using System;

namespace _4_FormatAlphaNumeric
{
    class Program
    {
        static void Main(string[] args)
        {
            //Composite Formatting
            string first = "Hello";
            string second = "World";
            Console.WriteLine("{1} {0}!", first, second);
            Console.WriteLine("{0} {0} {0}!", first, second);
            //String Interpolation
            Console.WriteLine($"{first} {second}!");
            Console.WriteLine($"{second} {first}!");
            Console.WriteLine($"{first} {first} {first}!");

            decimal price = 123.45m;
            int discount = 50;
            Console.WriteLine($"Price: {price:C} (Save {discount:C})");

            decimal measurement = 123456.78912m;
            Console.WriteLine($"Measurement: {measurement:N} units");
            // display four digits after the decimal point
            Console.WriteLine($"Measurement: {measurement:N4} units");

            decimal tax = .36785m;
            Console.WriteLine($"Tax rate: {tax:P2}");//percentages

            int invoiceNumber = 1201;
            decimal productMeasurement = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            Console.WriteLine($"Invoice Number: {invoiceNumber}");
            Console.WriteLine($"   Measurement: {productMeasurement:N3} mg");
            Console.WriteLine($"     Sub Total: {subtotal:C}");
            Console.WriteLine($"           Tax: {taxPercentage:P2}");
            Console.WriteLine($"     Total Due: {total:C}");

            string input = "Pad this"; //add blank spaces to the left-hand side
            Console.WriteLine(input.PadLeft(12));

            Console.WriteLine(input.PadLeft(12, '-')); //----Pad this
            Console.WriteLine(input.PadRight(12, '-'));

            string paymentId = "769";
            string payeeName = "Mr. Stephen Ortega";
            string paymentAmount = "$5,000.00";

            var formattedLine = paymentId.PadRight(6);
            formattedLine += payeeName.PadRight(24);
            formattedLine += paymentAmount.PadLeft(10);

            Console.WriteLine("1234567890123456789012345678901234567890");
            Console.WriteLine(formattedLine);

        }
    }
}

using System;

namespace mrf
{
    class Program
    {
        static void Main(string[] args)
        {
            /*          Console.WriteLine("a" == "a");
                        Console.WriteLine("a" == "A");
                        Console.WriteLine(1 == 2);
                        string myValue = "a";
                        Console.WriteLine(myValue == "a");
                        string value1 = " a";
                        string value2 = "A ";
                        Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
                        Console.WriteLine("a" != "a");
                        Console.WriteLine("a" != "A");
                        Console.WriteLine(1 != 2);
                        Console.WriteLine(myValue != "a");
                        Console.WriteLine(1 > 2);
                        Console.WriteLine(1 < 2);
                        Console.WriteLine(1 >= 1);
                        Console.WriteLine(1 <= 1); */
            string pangram = "The quick brown fox jumps over the lazy dog.";
            Console.WriteLine(pangram.Contains("fox"));
            Console.WriteLine(!pangram.Contains("cow")); //Contains

            int saleAmount = 1000;
            int discount = saleAmount > 1000 ? 100 : 50;    //true : false
            //Console.WriteLine($"Discount: {discount}");
            Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

            //Challenge
            Random toss = new Random();
            int grnd = toss.Next(0, 2);
            Console.WriteLine((grnd == 1) ? "heads" : "tails");
            //Challenge 2
            string permission = "Admin|Manager";
            int level = 55;
            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Console.WriteLine("Welcome, Super Admin user.");
                }
                else
                {
                    Console.WriteLine("Welcome, Admin user.");
                }
            }
            else if (permission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Console.WriteLine("Contact an Admin for access.");
                }
                else
                {
                    Console.WriteLine("You do not have sufficient privileges.");
                }
            }
            else
            {
                Console.WriteLine("You do not have sufficient privileges.");
            }
        }
    }
}

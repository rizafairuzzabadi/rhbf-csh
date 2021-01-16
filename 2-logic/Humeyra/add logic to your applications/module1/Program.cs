using System;

namespace module1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("a" == "a");
            Console.WriteLine("a" == "A");
            
            string myValue=" a";
            string yourValue="A ";
            Console.WriteLine(myValue.Trim().ToLower()==yourValue.Trim().ToLower());
            */
            Random coin= new Random();
            int roll=coin.Next(1,3);
            Console.WriteLine($"Result: {(roll == 1 ?  "tails": "heads")}");
        }
    }

}

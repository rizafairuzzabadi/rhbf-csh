using System;

namespace yedinciasama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] fraudulentOrderIDs = new string[3];
            fraudulentOrderIDs[0] = "A123";
            fraudulentOrderIDs[1] = "B456";
            fraudulentOrderIDs[2] = "C789";
            Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
            Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
            Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
            
            int[] inventory = {10,20,30,40,50};
            int sum = 0;
            foreach (int item in inventory)
            {
                sum =sum + item;
            }
            Console.WriteLine($"Total sum is {sum}.");
            */
            string[] orderIDs = {"B123","C234","A345","C15","B177","G3003","C235","B179"};
            foreach (string ID in orderIDs)
            {
                if (ID.StartsWith("B"))
                {
                    Console.WriteLine($"{ID}");
                }

            }

        }
    }
}

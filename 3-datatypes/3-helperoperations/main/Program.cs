using System;

namespace _3_helperoperations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Console.WriteLine("Reversed...");
            Array.Reverse(pallets);
            foreach (var pallete in pallets)
            {
                Console.WriteLine($"-- {pallete}");
            }

            Array.Clear(pallets, 0, 2);
            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            Console.WriteLine($"After: {pallets[0]}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }
            if (pallets[0] != null)
                Console.WriteLine($"After: {pallets[0].ToLower()}");
            Console.WriteLine("");
            Array.Resize(ref pallets, 6);
            Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Console.WriteLine("");
            Array.Resize(ref pallets, 3);
            Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);
            string result = new string(valueArray);
            Console.WriteLine(result);
            string result2 = String.Join(",", valueArray);
            Console.WriteLine(result2);
            string[] items = result2.Split(',');
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

    }
}

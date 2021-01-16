using System;

namespace Perform_operations_on_arrays_using_helper_methods_in_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string pangram = "The quick brown fox jumps over the lazy dog";
            char[] valueArray = pangram.ToCharArray();
            foreach (var val in valueArray)
            {
                Console.Write(val);
                Array.Reverse(valueArray);
            }
            string result = String.Join(" ", valueArray);
            Console.WriteLine(result); */
            string pangram = "The quick brown fox jumps over the lazy dog";
            string[] items =pangram.Split(" ");
            
            foreach (string item in items)
            {
                char[] valueArray = item.ToCharArray();
                Array.Reverse(valueArray); 
                string result = String.Join(" ",valueArray);
                Console.Write(result); 
            }
            
        }
    }
}

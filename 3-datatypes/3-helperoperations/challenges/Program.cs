using System;

namespace challenges
{
    class Program
    {
        static void Main(string[] args)
        {
            string pangram = "The quick brown fox jumps over the lazy dog";

            string[] message = pangram.Split(' ');
            string[] newMessage = new string[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(newMessage);
                newMessage[i] = new string(letters);
            }
            string result = String.Join(" ", newMessage);
            Console.WriteLine(result);

            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] words = orderStream.Split(',');
            foreach (var item in words)
            {
                if (item.StartsWith("B"))
                {
                    Console.WriteLine(item);
                }
            }
            // Your code here
        }
    }
}

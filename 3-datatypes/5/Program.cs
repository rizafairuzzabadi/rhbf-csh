using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Find what is (inside the parentheses)";

            int openingPosition = message.IndexOf('(');
            int closingPosition = message.IndexOf(')');

            // Console.WriteLine(openingPosition);
            // Console.WriteLine(closingPosition);

            int length = closingPosition - openingPosition - 1;
            Console.WriteLine(message.Substring(openingPosition + 1, length));

            message = "What is the value <span>between the tags</span>?";

            const string openSpan = "<span>";
            const string closeSpan = "</span>";

            openingPosition = message.IndexOf(openSpan);
            closingPosition = message.IndexOf(closeSpan);

            openingPosition += openSpan.Length;
            length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));

            message = "(What if) I am (only interested) in the last (set of parentheses)?";
            openingPosition = message.LastIndexOf('(');
            openingPosition += 1;
            closingPosition = message.LastIndexOf(')');
            length = closingPosition - openingPosition;
            Console.WriteLine(message.Substring(openingPosition, length));
        }
    }
}

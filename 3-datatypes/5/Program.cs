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

            string data = "12345John Smith          5000  3  ";
            string updatedData = data.Remove(5, 20);
            Console.WriteLine(updatedData);

            message = "This--is--ex-amp-le--da-ta";
            message = message.Replace("--", " ");
            message = message.Replace("-", "");
            Console.WriteLine(message);

            //Challenge
            const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

            string quantity = "";
            string output = "";

            // Your work here
            quantity = input.Substring(input.IndexOf("<span>") + "<span>".Length, (input.IndexOf("</span>") - (input.IndexOf("<span>") + "<span>".Length)));

            output = input.Remove(input.IndexOf("<div>"), "<div>".Length);
            output = output.Remove(output.IndexOf("</div>"), "</div>".Length);
            output = output.Replace("&trade;", "&reg;");
            Console.WriteLine(quantity);
            Console.WriteLine(output);
        }
    }
}

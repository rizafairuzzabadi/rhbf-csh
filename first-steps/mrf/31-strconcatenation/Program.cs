using System;

namespace _31_strconcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Humeyra";
            string message = "Hello " + firstName;
            Console.WriteLine(message);

            firstName = "Riza";
            string greeting = "Hello";
            Console.WriteLine(greeting + " " + firstName + "!");

            message = greeting + " " + firstName + "!";
            Console.WriteLine(message);
            Console.WriteLine($"{greeting} {firstName}!");
            Console.WriteLine($"Hello {firstName}!");

            string projectName = "First-Project";
            Console.WriteLine($@"C:\Output\{projectName}\Data");

            projectName = "ACME";
            string englishLocation = $@"c:\Exercise\{projectName}\data.txt";
            Console.WriteLine($"View English output:\n\t\t{englishLocation}\n");
                        
            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            string russianLocation = $@"c:\Exercise\{projectName}\ru-RU\data.txt";
            Console.WriteLine($"{russianMessage}:\n\t\t{russianLocation}\n");
        }
    }
}

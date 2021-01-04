using System;

namespace extra
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            if (flag) Console.WriteLine(flag);
            string name = "Riza";
            if (name == "Humeyra")
                Console.WriteLine("Found Hum");
            else if (name == "Riza")
                Console.WriteLine("Found Riza");
            else Console.WriteLine("Found Chuck");
        }
    }
}

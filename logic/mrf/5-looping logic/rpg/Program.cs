using System;

namespace rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            int hero = 10;
            int monster = 10;

            Random dice = new Random();

            do
            {
                int damage = dice.Next(1, 11);
                monster -= damage;
                Console.WriteLine($"Monster was damaged and lost {damage} health and now has {monster} health.");

                if (monster <= 0) continue;

                damage = dice.Next(1, 11);
                hero -= damage;
                Console.WriteLine($"Hero was damaged and lost {damage} health and now has {hero} health.");

            } while (hero > 0 && monster > 0);

            Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
        }
    }
}

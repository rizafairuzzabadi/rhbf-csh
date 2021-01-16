using System;

namespace module5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Random random = new Random();
            int current = random.Next(1, 11);

            
            do
            {
                current = random.Next(1, 11);
                Console.WriteLine(current);
            } while (current != 7);
            

            while (current >= 3)
            {
                Console.WriteLine(current);
                current = random.Next(1, 11);
            }
            Console.WriteLine($"Last number: {current}");
            */
            
            Random random = new Random();
            int herohealth = 10;
            int monsterhealth = 10;
            
            do
            {
                int hero = random.Next(1,11);
                monsterhealth = monsterhealth-hero;
                Console.WriteLine($"Monster was damaged and lost {hero} health and now has {monsterhealth} health.");
                
                if (monsterhealth <= 0) continue;
                
                int monster = random.Next(1,11);
                herohealth = herohealth-monster;
                Console.WriteLine($"Hero was damaged and lost {monster} health and now has {herohealth} health.");
            } while ((monsterhealth > 0) && (herohealth > 0));

            
        }
    }
}

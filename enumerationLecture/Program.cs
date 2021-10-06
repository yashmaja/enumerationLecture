using System;

namespace enumerationLecture
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(Defcon.Defcon0);

            Defcon dc = Defcon.Defcon0;
            int enemies = 5;

            //Console.WriteLine("How many people are attacking? ");
            //int enemies = int.Parse(Console.ReadLine());
            if (enemies == 0)
            {
                dc = Defcon.Defcon0;
            }
            else if (enemies <= 5)
            {
                dc = Defcon.Defcon1;
            }
            else if (enemies <= 10)
            {
                dc = Defcon.Defcon2;
            }
            else if (enemies <= 15)
            {
                dc = Defcon.Defcon3;
            }
            else if (enemies <= 20)
            {
                dc = Defcon.Defcon4;
            }
            else if (enemies <= 25)
            {
                dc = Defcon.Defcon5;
            }

            //repurpose
            Console.WriteLine($"We are under attack by {enemies}. We are at {dc}\n\n");

            //Cards
            Random rand = new Random();
            int value = rand.Next(1, 10);
            int suitValue = rand.Next(0, 3);

            Suites suit = (Suites)suitValue;
            
            Console.WriteLine($"Your random card is {value} of {suit}");
        }

        enum Defcon
        {
            Defcon0,
            Defcon1,
            Defcon2,
            Defcon3,
            Defcon4,
            Defcon5
        }
    }
}

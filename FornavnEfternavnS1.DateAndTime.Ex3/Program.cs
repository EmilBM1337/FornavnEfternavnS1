using System;

namespace FornavnEfternavnS1.DateAndTime.Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 1

            /*
            Console.WriteLine("Skriv et årstal, og jeg fortæller hvornår det næste skudår er.");

            int userInput = int.Parse(Console.ReadLine());

            if (DateTime.MinValue.Year >= userInput || userInput >= DateTime.MaxValue.Year)
            {
                Console.WriteLine("Forkert årstal!");
            }
            else
            {
                if (DateTime.IsLeapYear(userInput))
                {
                    Console.WriteLine("Det er skudår!");
                }
                else
                {
                    while (!DateTime.IsLeapYear(userInput))
                    {
                        Console.WriteLine(userInput + " Det er ikke skudår!");
                        userInput++;
                    }
                    Console.WriteLine(userInput + " Det er skudår!");
                }
            }
            */

            //Opgave 2

            /*
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToShortDateString());
            Console.WriteLine(myValue.ToLongDateString());
            Console.WriteLine(myValue.ToString("dd. MMMM yyyy HH:mm:ss"));
            Console.WriteLine(myValue.ToString("dd. dddd MMM y"));
            */

            //Opgave 3

            
        }
    }
}

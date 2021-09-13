using System;

namespace FornavnEfternavnS1.DateAndTime.Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 1

            DateTime rightNow = DateTime.Now;
            DateTime today = DateTime.Today;
            DateTime utcNow = DateTime.UtcNow;

            Console.WriteLine(rightNow.ToString());
            Console.WriteLine(today.ToString());
            Console.WriteLine(utcNow.ToString());

            Console.WriteLine("");

            //Opgave 2

            DateTime addedOneYear = rightNow.AddYears(1);
            DateTime removedTwoYears = rightNow.AddYears(-2);
            DateTime added30Days = rightNow.AddDays(30);
            DateTime removed17Days = rightNow.AddDays(-17);
            DateTime addedThreeMonths = rightNow.AddMonths(3);
            DateTime removedSevenMonths = rightNow.AddMonths(-7);
            DateTime added23Hours = rightNow.AddHours(23);
            DateTime removed11Hours = rightNow.AddHours(-11);
            DateTime added23HoursAnd17Minutes = rightNow.AddMinutes(1397);

            Console.WriteLine(addedOneYear.ToString());
            Console.WriteLine(removedTwoYears.ToString());
            Console.WriteLine(added30Days.ToString());
            Console.WriteLine(removed17Days.ToString());
            Console.WriteLine(addedThreeMonths.ToString());
            Console.WriteLine(removedSevenMonths.ToString());
            Console.WriteLine(added23Hours.ToString());
            Console.WriteLine(removed11Hours.ToString());
            Console.WriteLine(added23HoursAnd17Minutes.ToString());

            Console.WriteLine("");

            //Opgave 3

            DateTime i = DateTime.Now;
            DateTime x = i.Date;
            Console.WriteLine(i.ToString());
            Console.WriteLine(x.ToString());

            Console.WriteLine("");

            //Opgave 4

            int year = 2021;
            Console.WriteLine("År = " + year);
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("Skudår!");
            }
            else
            {
                Console.WriteLine("Ikke skudår!");
            }

            Console.ReadKey();
        }
    }
}

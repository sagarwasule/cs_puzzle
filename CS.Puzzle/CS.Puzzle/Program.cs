using System;

namespace CS.Puzzle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("There are {0} sundays on the first of a month", calculateNumberOfSundays());
            Console.ReadLine();
        }

        private static int calculateNumberOfSundays()
        {
            int sundays = 0;

            for (int year = 1901; year <= 2000; year++)
            {
                for (int month = 1; month <= 12; month++)
                {
                    if ((new DateTime(year, month, 1)).DayOfWeek == DayOfWeek.Sunday)
                    {
                        sundays++;
                    }
                }
            }

            return sundays;
        }
    }
}

using System;

namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());

            mins = hours * 60 + mins + 15;
            hours = mins / 60;
            mins = mins % 60;

            if (hours == 24)
            {
                hours = 0;
            }

            Console.WriteLine("{0}:{1:D2}", hours, mins);

        }
    }
}

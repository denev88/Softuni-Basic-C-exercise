using System;

namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Име на сериал – текст
            //
            //2.Продължителност на епизод – цяло число в диапазона[10… 90]
            //
            //3.Продължителност на почивката – цяло число в диапазона[10… 120]

            string serialName = Console.ReadLine();
            double episodeDuration = int.Parse(Console.ReadLine());
            double breakDuration = int.Parse(Console.ReadLine());

            double timeForLunch = breakDuration * 0.125;
            double timeForBreak = breakDuration * 0.25;
            double othersTime = breakDuration - timeForLunch - timeForBreak;
            
            if (othersTime >= episodeDuration)
            {
                //double timeOne = Math.Ceiling(othersTime - episodeDuration);


                Console.WriteLine($"You have enough time to watch {serialName}" +
                    $" and left with {Math.Ceiling(othersTime - episodeDuration)} minutes free time.");
            }
            else 
            {
                //double timeTwo = Math.Ceiling(episodeDuration - othersTime);

                Console.WriteLine($"You don't have enough time to watch {serialName}, " +
                    $"you need {Math.Ceiling(episodeDuration - othersTime )} more minutes.");
            }

        }
    }
}

using System;

namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //1.Рекордът в секунди – реално число в интервала[0.00 … 100000.00]
         //
         //2.Разстоянието в метри – реално число в интервала[0.00 … 100000.00]
         //
         //3.Времето в секунди, за което плува разстояние от 1 м. - реално число в интервала[0.00 … 1000.00]


            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine()); 
            double timeInSeconds = double.Parse(Console.ReadLine());  
            
            double distance = distanceInMeters * timeInSeconds;
            double timeincludes = Math.Floor (distanceInMeters / 15) * 12.5;
            double totalTime = distance + timeincludes;
           //double time = totalTime - recordInSeconds;

            if(recordInSeconds > totalTime)
            {
               //double needTime = totalTime - recordInSeconds;
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }
            else 
            {
                double needTime = totalTime - recordInSeconds;
                Console.WriteLine($"No, he failed! He was {needTime:f2} seconds slower.");
            }
        }  
    }
}

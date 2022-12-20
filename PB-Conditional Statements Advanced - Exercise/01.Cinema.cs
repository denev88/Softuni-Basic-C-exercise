using System;

namespace _01._Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // тип прожекция(стринг), брой редове и брой колони в залата

           string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());    
            int columns = int.Parse(Console.ReadLine());
            double income = 0.0;



            //. Premiere – премиерна прожекция, на цена 12.00 лева.
            //
            //· Normal – стандартна прожекция, на цена 7.50 лева.
            //
            //· Discount – прожекция за деца, ученици и студенти на намалена цена от 5.00 лева.


            if(projection == "Premiere")
            {
                 income = row * columns * 12.0;
            }
            else if(projection == "Normal")
            {
                income = row * columns * 7.50;
            }
            else if (projection == "Discount")
            {
                income = row * columns * 5.00;
            }
            Console.WriteLine($"{income:f2} leva.");
        }
    }
}

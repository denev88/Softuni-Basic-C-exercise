using System;

namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //1.Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
           //2.Брой пъзели - цяло число в интервала[0… 1000]
           //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
           //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
           //5.Брой миньони - цяло число в интервала[0 … 1000]
           //6.Брой камиончета - цяло число в интервала[0 … 1000]

            double priceForTrip = double.Parse(Console.ReadLine());
            double puzzles = double.Parse(Console.ReadLine());
            double dolls = double.Parse(Console.ReadLine());
            double bears = double.Parse(Console.ReadLine());  
            double minions = double.Parse(Console.ReadLine());    
            double trucks = double.Parse(Console.ReadLine());

            //· Пъзел - 2.60лв
            //· Говореща кукла - 3лв.
            //· Плюшено мече - 4.10лв.
            //· Миньон - 8.20лв.
            //· Камионче - 2лв.

            double pricePuzzles = 2.60;
            double priceDolls = 3;
            double priceBears = 4.10;
            double priceMinions = 8.20;
            double priceTrucks = 2;

            double discount = 0.25;
            double rent = 0.10;
            double finalPrice = 0;
            double priceForRent = 0;
            double profit = 0;

            double totalPriceForToys = pricePuzzles * puzzles + priceDolls * dolls
                + priceBears * bears + priceMinions * minions + priceTrucks * trucks;

          double numberOfToys = puzzles + dolls + bears + 
                minions + trucks;

            if (numberOfToys > 50)
            {
                 double discountN = totalPriceForToys * discount;
                finalPrice = totalPriceForToys - discountN;
                priceForRent = finalPrice * rent;
                profit =  finalPrice - priceForRent   ;
            }
            else
            {
                priceForRent = totalPriceForToys * rent;
                profit = totalPriceForToys - priceForRent;
            }
       
            double result = 0;
            if(profit > priceForTrip)
            {
                result =  profit - priceForTrip;
                Console.WriteLine($"Yes! {result:f2}lv left.");
            }
            else
            {
               result = priceForTrip - profit;
                Console.WriteLine($"Not enough money! {result:f2}lv needed.");
            }

        }
    }
}

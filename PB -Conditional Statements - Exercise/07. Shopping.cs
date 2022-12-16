using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Бюджетът на Петър -реално число в интервала[0.0…100000.0]
            //
            //2.Броят видеокарти - цяло число в интервала[0…100]
            //
            //3.Броят процесори - цяло число в интервала[0…100]
            //
            //4.Броят рам памет -цяло число в интервала[0…100]

            double budgetPeter = double.Parse(Console.ReadLine());
            int numberOfVideocards = int.Parse(Console.ReadLine());
            int numberOfProcesors = int.Parse(Console.ReadLine());
            int numberOfRam = int.Parse(Console.ReadLine());

            //· Видеокарта – 250 лв./ бр.
            //
            //· Процесор – 35 % от цената на закупените видеокарти/ бр.
            //
            //· Рам памет – 10 % от цената на закупените видеокарти/ бр

            int videocardPrice = 250;
            double discountProcesors = 0.35;
            double discountRam = 0.10;
            double totalDiscount = 0.15;

            int totalPriceVideocard = numberOfVideocards * videocardPrice;

           double priceofProcesors = totalPriceVideocard * discountProcesors;
            double totalProcesorsPrice = priceofProcesors * numberOfProcesors;

           double priceOfRam = totalPriceVideocard * discountRam;
            double totalRamPrice = priceOfRam * numberOfRam;

            double totalSum = totalPriceVideocard + totalProcesorsPrice + totalRamPrice;
           
              double Sum = totalSum - (totalSum * totalDiscount);
           


            if ( budgetPeter  >= Sum)
            {

                double finalSum = budgetPeter - Sum;
                Console.WriteLine($"You have {Math.Abs(finalSum):f2} leva left!");

            }
            else
            {
                double sumFinal = budgetPeter - Sum;

                Console.WriteLine($"Not enough money! You need {Math.Abs(sumFinal):f2} leva more!");
            }
                 



        }
    }
}

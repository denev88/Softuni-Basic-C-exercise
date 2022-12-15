using System;

namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ред 1.Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            //Ред 2.Брой на статистите – цяло число в интервала[1 … 500]
            //Ред 3.Цена за облекло на един статист – реално число в интервала[1.00 … 1000.0

            double budgetMovie = double.Parse(Console.ReadLine());
            int numberOfPeople = int.Parse(Console.ReadLine());
            double priceForDressForOnePerson = double.Parse(Console.ReadLine());

            //· Декорът за филма е на стойност 10 % от бюджета.
            //· При повече от 150 статиста, има отстъпка за облеклото на стойност 10 %.

            double decorationForMovie = 0.10;
            double discount = 0.10;

            double priceForDecor = budgetMovie * decorationForMovie;
            double priceForDress = numberOfPeople * priceForDressForOnePerson;
            
            
            if(numberOfPeople > 150)
            {
                priceForDress = priceForDress - (0.10 * priceForDress);

            }
            double totalMoney = priceForDress + priceForDecor;
            double moneyLeft = budgetMovie - totalMoney;
            
            if(totalMoney > budgetMovie) 
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(moneyLeft):f2} leva more.");
            }
            else if (totalMoney <= budgetMovie) 
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:f2} leva left.");
            }

        }
    }
}

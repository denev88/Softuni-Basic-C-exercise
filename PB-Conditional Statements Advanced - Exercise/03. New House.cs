using System;

namespace _03._New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //· Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //
            //· Брой цветя -цяло число в интервала[10…1000]
            //
            //· Бюджет - цяло число в интервала[50…2500]

            string typeFlowers = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            
            double price = 0;

            if (typeFlowers == "Roses")
            {
                if (numberFlowers > 80)
                {
                    price = numberFlowers * 5;
                    price = price - (price * 0.1);
                }
                else
                {
                    price = numberFlowers * 5;
                }

            }
             if (typeFlowers == "Dahlias")
            {
                if (numberFlowers > 90)
                {
                    price = numberFlowers * 3.80;
                    price = price - (price * 0.15);
                }
                else
                {
                    price = numberFlowers * 3.80;
                }

            }
             if (typeFlowers == "Tulips")
            {
                if (numberFlowers > 80)
                {
                    price = numberFlowers * 2.80;
                    price = price - (price * 0.15);
                }
                else
                {
                    price = numberFlowers * 2.80;
                }

            }
            if (typeFlowers == "Narcissus")
            {
                if (numberFlowers < 120)
                {
                    price = numberFlowers * 3;
                    price = price + (price * 0.15);
                }
                else
                {
                    price = numberFlowers * 3;
                }

            }
             if (typeFlowers == "Gladiolus")
            {
                if (numberFlowers < 80)
                {
                    price = numberFlowers * 5;
                    price = price + (price * 0.2);
                }
                else
                {
                    price = numberFlowers * 5;
                }
                 
                

            }
            if (budget >= price)
            {
                double totalPrice = budget - price;
                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {typeFlowers} " +
                    $"and {totalPrice:f2} leva left.");
            }
            else if (budget <= price)
            {
                double total = price - budget;
                Console.WriteLine($"Not enough money, you need {total:f2} leva more.");

            }
        }
        
    }
}

using System;

namespace _02._Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degree = double.Parse(Console.ReadLine());
            string timeFromDay = Console.ReadLine();
            string outfit = "";
            string shoes = "";


            if (degree >= 10 && degree <= 18)
            {
                if (timeFromDay == "Morning")
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (timeFromDay == "Afternoon" || timeFromDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            if (degree > 18 && degree <= 24)
            {
                if (timeFromDay == "Morning" || timeFromDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (timeFromDay == "Afternoon")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }

            if (degree >= 25)
            {
                if (timeFromDay == "Morning")
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (timeFromDay == "Afternoon")
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (timeFromDay == "Evening")
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");

        }

    }
}

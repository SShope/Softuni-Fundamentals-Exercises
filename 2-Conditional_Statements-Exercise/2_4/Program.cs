using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_4
{
    class Program
    {
        static void Main(string[] args)
        {

            //Input
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            decimal priceStudio, priceDouble, priceSuite;

            //Calculations
            switch (month)
            {
                case "May":
                case "October":
                    priceStudio = 50.0m;
                    priceDouble = 65.0m;
                    priceSuite = 75.0m; ;
                    break;
                case "June":
                case "September":
                    priceStudio = 60.0m;
                    priceDouble = 72.0m;
                    priceSuite = 82.0m; ;
                    break;
                default:
                    priceStudio = 68.0m;
                    priceDouble = 77.0m;
                    priceSuite = 89.0m; ;
                    break;
            }

            if (nights > 14)
            {
                if (month == "June" || month == "September")
                {
                    priceDouble = priceDouble * 0.90m;
                }
                if (month == "July" || month == "August" || month == "December")
                {
                    priceSuite = priceSuite * 0.85m;
                }
            }
            else if (nights > 7)
            {
                if (month == "May" || month == "October")
                {
                    priceStudio = priceStudio * 0.95m;
                }
                if (month == "September" || month == "October")
                {
                    priceStudio = (priceStudio * (nights - 1)) / nights;
                }
            }

            //Output
            Console.WriteLine($"Studio: {nights * priceStudio:F2} lv.");
            Console.WriteLine($"Double: {nights * priceDouble:F2} lv.");
            Console.WriteLine($"Suite: {nights * priceSuite:F2} lv.");

        }
    }
}

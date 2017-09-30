using System;

namespace _2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input
            int peopleCount = int.Parse(Console.ReadLine());
            string discountType = Console.ReadLine();
            string hallName = null;
            decimal price = 0;
            decimal pricePerPerson = 0;

            //Calculate
            if (peopleCount <= 50)
            {
                price = 2500m;
                hallName = "Small Hall";
            }
            else if (peopleCount <= 100)
            {
                price = 5000m;
                hallName = "Terrace";
            }
            else if (peopleCount <= 120)
            {
                price = 7500m;
                hallName = "Great Hall";
            }
            
            switch (discountType)
            {
                case "Normal": price = (price + 500m) * 0.95m; break;
                case "Gold": price = (price + 750m) * 0.90m; break;
                case "Platinum": price = (price + 1000m) * 0.85m; break;
            }
            
            //Output
            if (peopleCount > 120) {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                pricePerPerson = price / (decimal)peopleCount;
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {pricePerPerson:F2}$");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1
{
    class Program
    {
        static void Main(string[] args)
        {

            string prof = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            decimal price = 0;
            decimal totalPrice = 0;
            string drink = "";

            switch (prof)
            {
                case "Athlete":
                    drink = "Water";
                    price = 0.7m;
                    break;
                case "Businessman":
                case "Businesswoman":
                    drink = "Coffee";
                    price = 1.0m;
                    break;
                case "SoftUni Student":
                    drink = "Beer";
                    price = 1.7m;
                    break;
                default:
                    drink = "Tea";
                    price = 1.2m;
                    break;
            }
            totalPrice = quantity * price;
            Console.WriteLine($"The {prof} has to pay {totalPrice:F2}.");
        }
    }
}

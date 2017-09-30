using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {

            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double price = 0.00;

            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
            }
            else
            {

                switch (day)
                {
                    case "Weekday":
                        if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                        {
                            price = 12.00;
                        }
                        else
                        {
                            price = 18.00;
                        }
                        ;
                        break;
                    case "Weekend":
                        if ((age >= 0 && age <= 18) || (age > 64 && age <= 122))
                        {
                            price = 15.00;
                        }
                        else
                        {
                            price = 20.00;
                        }
                        break;
                    case "Holiday":
                        if (age >= 0 && age <= 18)
                        {
                            price = 5.00;
                        }
                        else if (age > 18 && age <= 64)
                        {
                            price = 12.00;
                        }
                        else
                        {
                            price = 10.00;
                        }
                        break;
                    default:; break;
                }
                Console.WriteLine($"{price}$");
            }
           
        }
    }
}

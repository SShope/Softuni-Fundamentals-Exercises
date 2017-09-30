using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;

            do
            {
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                }
            }
            while (number % 2 == 0);
        }
    }
}

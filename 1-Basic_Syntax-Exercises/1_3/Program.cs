using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_3
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal miles = decimal.Parse(Console.ReadLine());
            decimal km = miles * (decimal)1.60934;

            Console.WriteLine($"{km:F2}");

        }
    }
}

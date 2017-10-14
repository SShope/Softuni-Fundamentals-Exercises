using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(IsPrime(number));
        }

        static bool IsPrime(long number)
        {
            long i = 2;
            if (number == 0 || number == 1)
            {
                return false;
            }
            while (Math.Sqrt(number) + 1 > i)
            {
                if (number == 0 || number == 1 || number % i == 0)
                {
                    return false;
                }
                i++;
            }
            return true;
        }
    }
}

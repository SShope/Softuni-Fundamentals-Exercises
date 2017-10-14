using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int position = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Fib(position));
        }

        static long Fib(int position)
        {
            long fibNum1 = 1;
            long fibNum2 = 1;
            long fibNum3 = 2;

            if (position == 0 || position == 1)
            {
                return 1;
            }

            for (int i = 2; i <= position; i++)
            {
                fibNum3 = fibNum1 + fibNum2;
                fibNum1 = fibNum2;
                fibNum2 = fibNum3;
            }

            return fibNum3;

        }

    }
}

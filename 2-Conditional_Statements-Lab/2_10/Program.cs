using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_10
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int start = int.Parse(Console.ReadLine());
            int multi = 0;

            if (start > 10)
            {
                multi = num * start;
                Console.WriteLine($"{num} X {start} = {multi}");
            }

            for (int i = start; i <= 10; i++)
            {
                multi = num * i;
                Console.WriteLine($"{num} X {i} = {multi}");
            }

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_9
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());
            int multi = 0;
            for (int i = 1; i<=10; i++)
            {
                multi = num * i;
                Console.WriteLine($"{num} X {i} = {multi}");
            }

        }
    }
}

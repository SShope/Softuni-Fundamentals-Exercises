using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddCount = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i=1; i<=2*oddCount; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}

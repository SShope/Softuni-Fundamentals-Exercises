using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int temp;
            // Calculation

            if (num1 > num2)
            {
                temp = num2;
                num2 = num1;
                num1 = temp;
            }

            for (int i=num1; i<=num2; i++)
            {
                Console.WriteLine(i);
            }

            // Output
        }
    }
}

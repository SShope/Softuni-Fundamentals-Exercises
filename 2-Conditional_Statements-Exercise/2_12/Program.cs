using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int comboCount = 0;

            // Calculation

            for (int i = n; i >= 1; i--)
            {
                
                for (int j = 1; j <= m; j++)
                {
                    if (totalSum >= maxSum)
                    {
                        break;
                    }
                    else
                    {
                        totalSum = totalSum + 3 * (i * j);
                        comboCount += 1;
                    }
                }
            }

            // Output
            Console.WriteLine($"{comboCount} combinations");
            if (totalSum >= maxSum)
            {
                Console.WriteLine($"Sum: {totalSum} >= {maxSum}");
            }
            else
            {
                Console.WriteLine($"Sum: {totalSum}");
            }
        }
    }
}

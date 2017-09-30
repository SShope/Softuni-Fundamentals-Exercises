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
            // Input
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            // Calc
            if (b - a <= 3) {
                Console.WriteLine("No");
            }
            else
            {
                for (int i = a; i < b; i++)
                {
                    for (int j = i + 1; j < b; j++)
                    {
                        for (int k = j + 1; k < b; k++)
                        {
                            for (int l = k + 1; l < b; l++)
                            {
                                for (int m = l + 1; m <= b; m++)
                                {
                                    Console.WriteLine($"{i} {j} {k} {l} {m}");
                                }
                            }
                        }
                    }
                }
            }

            // Output


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_13
{
    class Program
    {
        static void Main(string[] args)
        {

            // input
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int ii=0, jj=0, count=0;

            // Calc
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    count += 1;
                    if (i+j == magic)
                    {
                        ii = i;
                        jj = j;
                    }
                }
            }

            // Output
            if (ii + jj == magic)
            {
                Console.WriteLine($"Number found! {ii} + {jj} = {magic}");
            }
            else
            {

                Console.WriteLine($"{count} combinations - neither equals {magic}");
            }
            
        }
    }
}

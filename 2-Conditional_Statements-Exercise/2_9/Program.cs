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
            int num = 0;
            int count = 0;

            for (int i = 0; i < 100; i++)
            {
                try
                {
                    num = int.Parse(Console.ReadLine());
                    count += 1;
                }
                catch
                {
                    Console.WriteLine(count);
                    break;
                }
            }
        }
    }
}

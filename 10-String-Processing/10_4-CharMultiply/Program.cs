using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_4_CharMultiply
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(' ').ToArray();
            string w1 = input[0];
            string w2 = input[1];

            int lenDiff = Math.Abs(w1.Length - w2.Length);
            if (w1.Length > w2.Length)
            {
                w2 = w2 + new String('\u0001', lenDiff);
            }
            else if (w1.Length < w2.Length)
            {
                w1 = w1 + new String('\u0001', lenDiff);
            }
           
            int result = 0;
            for (int i = 0; i < w1.Length; i++)
            {
                result += w1[i] * w2[i];
            }

            Console.WriteLine(result);
        }
    }
}

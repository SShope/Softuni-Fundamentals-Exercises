using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_6_SumReversedNums
{
    class Program
    {
        static void Main(string[] args)
        {

            var numSequence = Console.ReadLine().Split(' ').ToList();
            int sum = 0;

            for (int i = 0; i < numSequence.Count; i++)
            {
                numSequence[i] = string.Join("", numSequence[i].ToCharArray().Reverse());
                sum += int.Parse(numSequence[i]);
            }

            Console.WriteLine(sum);
        }
    }
}

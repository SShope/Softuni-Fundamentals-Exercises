using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_1_Max_Sequence_Equals
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var numList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int start = 0;
            int bestStart = 0;
            int length = 1;
            int bestLength = 1;
            int currentNumber = numList[0];

            for (int p = 1; p < numList.Count; p++)
            {
                if (currentNumber == numList[p])
                {
                    length++;
                }
                else
                {
                    currentNumber = numList[p];
                    length = 1;
                    start = p;
                }

                if (length > bestLength)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }

            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(numList[i] + " ");
            }

        }
    }
}

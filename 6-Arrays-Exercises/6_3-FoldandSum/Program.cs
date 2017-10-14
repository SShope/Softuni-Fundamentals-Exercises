using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_3_FoldandSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();




        }

        static int[] foldArray(int[] inputArr)
        {
            int[] leftArray = new int[inputArr.Length / 4];
            int[] rightArray = new int[inputArr.Length / 4];
            int[] innerArray = new int[inputArr.Length / 2];

            // leftArray elements + reverse
            for (int i = 0; i < (inputArr.Length / 4) - 1; i++)
            {
                leftArray[i] = innerArray[i];
            }
            Array.Reverse(leftArray);

            // rightArray elements + reverse
            for (int i = inputArr.Length; i >= (3 * inputArr.Length / 4) - 1; i--)
            {
                rightArray[];
            }
            Array.Reverse(rightArray);

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Arrays_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); ;
            int rotation = int.Parse(Console.ReadLine());

            int[] resultArray = RotateArray(inputArray, rotation);

            for (int i = 0; i < resultArray.Length; i++)
            {
                Console.Write($"{resultArray[i]} ");
            }
        }

        static int[] RotateArray(int[] array, int rotation)
        {

            int arrLenght = array.Length;
            int lastEl;

            int[] rotatedArray = array;
            int[] finalArray = new int[arrLenght];

            for (int i = 0; i < rotation; i++)
            {
                lastEl = rotatedArray[arrLenght - 1];
                for (int j = arrLenght - 1 ; j >= 1; j--)
                {
                    rotatedArray[j] = rotatedArray[j-1];
                }
                rotatedArray[0] = lastEl;
                finalArray = SumArrays(rotatedArray, finalArray);
            }

            return finalArray;
        }

        static int[] SumArrays(int[] firstArray, int[] secondArray)
        {
            int[] returnArray = new int[firstArray.Length];
            for (int i = 0; i < firstArray.Length; i++)
            {
                returnArray[i] = firstArray[i] + secondArray[i];
            }
            return returnArray;
        }

    }
}

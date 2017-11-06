using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _10_2_BaseNtoBaseTen
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            BigInteger baseN = BigInteger.Parse(input.Split(' ').First());
            BigInteger number = BigInteger.Parse(input.Split(' ').Last());

            Console.WriteLine(ConvertBaseNumber(number, baseN));

        }

        static BigInteger ConvertBaseNumber(BigInteger numToConvert, BigInteger newBase)
        {
            // Convert number to base 10
            BigInteger convertedNum = 0;
            string strNumber = numToConvert.ToString();
            double position = 0;

            if (newBase >= 2 && newBase <= 10)
            {
                for (int i = strNumber.Length - 1; i >= 0; i--)
                {
                    convertedNum += BigInteger.Parse(strNumber.Substring(i, 1)) *
                        (BigInteger)Math.Pow((double)newBase, (double)position);
                    position++;
                }
            }
            else
            {
                convertedNum = 0;
            }

            return convertedNum;
        }
    }
}

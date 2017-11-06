using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _10_1_Base10ToBaseN
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            BigInteger baseN = BigInteger.Parse(input.Split(' ').First());
            BigInteger baseTenNum = BigInteger.Parse(input.Split(' ').Last());

            Console.WriteLine(ConvertBaseNumber(baseTenNum, baseN));

        }

        static string ConvertBaseNumber(BigInteger numToConvert, BigInteger newBase)
        {
            // Convert number to base N
            string convertedNum = null;
            while (numToConvert > 0)
            {
                convertedNum = (numToConvert % newBase).ToString() + convertedNum;
                numToConvert /= newBase;
            }
            return convertedNum;
        }

    }
}

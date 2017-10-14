using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_4
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(number));
        }

        static double ReverseNumber(double num)
        {
            string strNum = num.ToString();

            char[] charArray = strNum.ToCharArray();
            Array.Reverse(charArray);
            strNum = new string(charArray);

            return double.Parse(strNum);
        }

    }
}

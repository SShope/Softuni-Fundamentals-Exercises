using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_6_SumBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {

            string num1 = Console.ReadLine();
            string num2 = Console.ReadLine();

            int lenDiff = Math.Abs(num1.Length - num2.Length);
            if (num1.Length > num2.Length)
            {
                num2 = new String('0', lenDiff) + num2;
            }
            else if (num1.Length < num2.Length)
            {
                num1 = new String('0', lenDiff) + num1;
            }


            for (int i = num1.Length; i >= 0; i--)
            {




            }
        }
    }
}

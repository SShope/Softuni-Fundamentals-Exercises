using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_14
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            string hexNumber = number.ToString("X");
            Console.WriteLine(hexNumber.ToUpper());
            string binaryNumber = Convert.ToString(number, 2);
            Console.WriteLine(binaryNumber);

        }
    }
}
